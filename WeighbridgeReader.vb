Imports System.IO.Ports

Public Class WeighbridgeReader
    ' --- Singleton Pattern Start ---
    ' Shared వేరియబుల్ ద్వారా ఒక్క ఇన్స్టాన్స్ మాత్రమే ఉండేలా చూస్తాము
    Private Shared _instance As WeighbridgeReader

    Public Shared ReadOnly Property Instance As WeighbridgeReader
        Get
            If _instance Is Nothing Then
                _instance = New WeighbridgeReader()
            End If
            Return _instance
        End Get
    End Property
    ' --- Singleton Pattern End ---

    Private WithEvents serialPort As SerialPort
    Private rawBuffer As String = ""
    Private settingsHelper As New FrmSettings()

    ' Events — FrmWeighment listen చేస్తుంది
    Public Event WeightReceived(weight As Double, isStable As Boolean)
    Public Event ConnectionChanged(isConnected As Boolean)
    Public Event RawDataReceived(raw As String)

    Public ReadOnly Property IsConnected As Boolean
        Get
            Return serialPort IsNot Nothing AndAlso serialPort.IsOpen
        End Get
    End Property

    ' ── Connect ───────────────────────────────────────────────

    Public Function Connect() As Boolean
        Try
            ' ఒకవేళ పోర్ట్ ఇప్పటికే ఓపెన్ లో ఉంటే, మళ్ళీ ఓపెన్ చేయాల్సిన అవసరం లేదు
            If IsConnected Then Return True

            Dim comPort = settingsHelper.GetSetting("Indicator", "COMPort", "COM1")
            Dim baudRate = CInt(settingsHelper.GetSetting("Indicator", "BaudRate", "9600"))
            Dim dataBits = CInt(settingsHelper.GetSetting("Indicator", "DataBits", "8"))
            Dim parityStr = settingsHelper.GetSetting("Indicator", "Parity", "None")
            Dim stopStr = settingsHelper.GetSetting("Indicator", "StopBits", "1")

            If comPort = "" OrElse comPort = "No COM Ports" Then Return False

            serialPort = New SerialPort()
            serialPort.PortName = comPort
            serialPort.BaudRate = baudRate
            serialPort.DataBits = dataBits
            serialPort.Parity = [Enum].Parse(GetType(Parity), parityStr)
            serialPort.StopBits = If(stopStr = "2", StopBits.Two,
                                   If(stopStr = "1.5", StopBits.OnePointFive,
                                      StopBits.One))
            serialPort.ReadTimeout = 2000
            serialPort.WriteTimeout = 2000
            serialPort.NewLine = vbCr  ' Most indicators use CR

            serialPort.Open()
            RaiseEvent ConnectionChanged(True)
            Return True

        Catch ex As Exception
            RaiseEvent ConnectionChanged(False)
            Return False
        End Try
    End Function

    ' ── Disconnect ────────────────────────────────────────────

    Public Sub Disconnect()
        Try
            If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
                serialPort.Close()
            End If
        Catch : End Try
        RaiseEvent ConnectionChanged(False)
    End Sub

    ' ── Data Received ─────────────────────────────────────────

    Private Sub serialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) _
        Handles serialPort.DataReceived
        Try
            Dim data = serialPort.ReadExisting()
            rawBuffer &= data

            ' Process complete lines
            Do While rawBuffer.Contains(vbCr) OrElse rawBuffer.Contains(vbLf)
                Dim lineEnd = rawBuffer.IndexOfAny({Chr(13), Chr(10)})
                If lineEnd < 0 Then Exit Do

                Dim line = rawBuffer.Substring(0, lineEnd).Trim()
                rawBuffer = rawBuffer.Substring(lineEnd + 1)

                If line.Length > 0 Then
                    ProcessWeightLine(line)
                End If
            Loop
        Catch : End Try
    End Sub

    ' ── Parse Weight ──────────────────────────────────────────

    Private Sub ProcessWeightLine(line As String)
        RaiseEvent RawDataReceived(line)

        Dim fmt = settingsHelper.GetSetting("Indicator", "Format", "W+000000")
        Dim weight As Double = 0
        Dim stable As Boolean = False

        Try
            ' ── Common formats ────────────────────────────────

            ' Format 1: "W+001234" or "W-001234" (most common)
            If line.Length >= 2 AndAlso line(0) = "W" Then
                Dim numStr = New String(line.Skip(1).Where(Function(c) Char.IsDigit(c) OrElse c = "."c).ToArray())
                Double.TryParse(numStr, weight)
                stable = Not line.Contains("U") AndAlso Not line.Contains("M")
                RaiseEvent WeightReceived(weight / 1000, stable)
                Return
            End If

            ' Format 2: "ST,GS,+001234KG" (OHAUS style)
            If line.Contains("ST") OrElse line.Contains("GS") Then
                stable = line.Contains("ST")
                Dim numStr = New String(line.Where(Function(c) Char.IsDigit(c) OrElse c = "."c).ToArray())
                Double.TryParse(numStr, weight)
                RaiseEvent WeightReceived(weight / 1000, stable)
                Return
            End If

            ' Format 3: Plain number "001234"
            Dim digits = New String(line.Where(Function(c) Char.IsDigit(c) OrElse c = "."c).ToArray())
            If digits.Length > 0 Then
                Double.TryParse(digits, weight)
                stable = True
                RaiseEvent WeightReceived(weight / 1000, stable)
            End If

        Catch : End Try
    End Sub

    ' ── Manual Read (polling mode) ────────────────────────────

    Public Function ReadOnce() As Tuple(Of Double, Boolean)
        If Not IsConnected Then Return New Tuple(Of Double, Boolean)(0, False)
        Try
            Dim line = serialPort.ReadLine().Trim()
            RaiseEvent RawDataReceived(line)
            Dim digits = New String(line.Where(Function(c) Char.IsDigit(c) OrElse c = "."c).ToArray())
            Dim weight As Double = 0
            Double.TryParse(digits, weight)
            Return New Tuple(Of Double, Boolean)(weight / 1000, True)
        Catch
            Return New Tuple(Of Double, Boolean)(0, False)
        End Try
    End Function

End Class
