Imports System.IO
Imports System.IO.Ports

Public Class FrmSettings

    ' Settings file path
    Private settingsFile As String = Path.Combine(Application.StartupPath, "settings.ini")

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllSettings()
        FillCOMPorts()
        FillBaudRates()
        FillDataBits()
        FillParity()
        FillStopBits()
        FillPrinters()
        FillPaperSizes()
        FillCameraTypes()
    End Sub

    ' ── Fill Dropdowns ────────────────────────────────────────

    Private Sub FillCOMPorts()
        cmbCOMPort.Items.Clear()
        For Each port In SerialPort.GetPortNames()
            cmbCOMPort.Items.Add(port)
        Next
        If cmbCOMPort.Items.Count = 0 Then cmbCOMPort.Items.Add("No COM Ports")
    End Sub

    Private Sub FillBaudRates()
        cmbBaudRate.Items.Clear()
        cmbBaudRate.Items.AddRange({"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        cmbBaudRate.Text = "9600"
    End Sub

    Private Sub FillDataBits()
        cmbDataBits.Items.Clear()
        cmbDataBits.Items.AddRange({"7", "8"})
        cmbDataBits.Text = "8"
    End Sub

    Private Sub FillParity()
        cmbParity.Items.Clear()
        cmbParity.Items.AddRange({"None", "Even", "Odd", "Mark", "Space"})
        cmbParity.Text = "None"
    End Sub

    Private Sub FillStopBits()
        cmbStopBits.Items.Clear()
        cmbStopBits.Items.AddRange({"1", "1.5", "2"})
        cmbStopBits.Text = "1"
    End Sub

    Private Sub FillPrinters()
        cmbPrinterName.Items.Clear()
        For Each p As String In Drawing.Printing.PrinterSettings.InstalledPrinters
            cmbPrinterName.Items.Add(p)
        Next
        If cmbPrinterName.Items.Count > 0 Then cmbPrinterName.SelectedIndex = 0
    End Sub

    Private Sub FillPaperSizes()
        cmbPaperSize.Items.Clear()
        cmbPaperSize.Items.AddRange({"A4", "A5", "Letter", "Thermal 80mm", "Thermal 58mm"})
        cmbPaperSize.Text = "A4"
    End Sub

    Private Sub FillCameraTypes()
        Dim types() = {"RTSP", "USB", "HTTP", "IP Camera"}
        For Each cmb In {cmbCam1Type, cmbCam2Type, cmbCam3Type, cmbCam4Type}
            cmb.Items.Clear()
            cmb.Items.AddRange(types)
            cmb.SelectedIndex = 0
        Next
    End Sub

    ' ── Save Settings (INI file) ──────────────────────────────

    Private Sub SaveSettings(section As String, key As String, value As String)
        Dim lines As New List(Of String)
        Dim found = False
        Dim inSection = False

        If File.Exists(settingsFile) Then
            lines.AddRange(File.ReadAllLines(settingsFile))
        End If

        For i = 0 To lines.Count - 1
            If lines(i).Trim() = $"[{section}]" Then
                inSection = True
            ElseIf lines(i).StartsWith("[") Then
                inSection = False
            End If

            If inSection AndAlso lines(i).StartsWith(key & "=") Then
                lines(i) = $"{key}={value}"
                found = True
            End If
        Next

        If Not found Then
            Dim sectionIdx = lines.FindIndex(Function(l) l.Trim() = $"[{section}]")
            If sectionIdx < 0 Then
                lines.Add($"[{section}]")
                lines.Add($"{key}={value}")
            Else
                lines.Insert(sectionIdx + 1, $"{key}={value}")
            End If
        End If

        File.WriteAllLines(settingsFile, lines)
    End Sub

    Public Function GetSetting(section As String, key As String,
                               Optional defaultVal As String = "") As String
        If Not File.Exists(settingsFile) Then Return defaultVal
        Dim lines = File.ReadAllLines(settingsFile)
        Dim inSection = False
        For Each line In lines
            If line.Trim() = $"[{section}]" Then
                inSection = True
            ElseIf line.StartsWith("[") Then
                inSection = False
            End If
            If inSection AndAlso line.StartsWith(key & "=") Then
                Return line.Substring(key.Length + 1)
            End If
        Next
        Return defaultVal
    End Function

    ' ── Load All Settings ─────────────────────────────────────

    Private Sub LoadAllSettings()
        ' Indicator
        Dim port = GetSetting("Indicator", "COMPort", "")
        If port <> "" AndAlso cmbCOMPort.Items.Contains(port) Then cmbCOMPort.Text = port
        SetCombo(cmbBaudRate, GetSetting("Indicator", "BaudRate", "9600"))
        SetCombo(cmbDataBits, GetSetting("Indicator", "DataBits", "8"))
        SetCombo(cmbParity, GetSetting("Indicator", "Parity", "None"))
        SetCombo(cmbStopBits, GetSetting("Indicator", "StopBits", "1"))
        txtWeightFormat.Text = GetSetting("Indicator", "Format", "W+000000")

        ' Printer
        Dim prn = GetSetting("Printer", "Name", "")
        If prn <> "" Then cmbPrinterName.Text = prn
        SetCombo(cmbPaperSize, GetSetting("Printer", "PaperSize", "A4"))
        nudCopies.Value = Math.Max(1, Val(GetSetting("Printer", "Copies", "1")))
        chkAutoPrint.Checked = GetSetting("Printer", "AutoPrint", "False") = "True"
        chkColorPrint.Checked = GetSetting("Printer", "ColorPrint", "False") = "True"

        ' Camera
        txtCam1URL.Text = GetSetting("Camera", "Cam1URL", "")
        txtCam2URL.Text = GetSetting("Camera", "Cam2URL", "")
        txtCam3URL.Text = GetSetting("Camera", "Cam3URL", "")
        txtCam4URL.Text = GetSetting("Camera", "Cam4URL", "")
        SetCombo(cmbCam1Type, GetSetting("Camera", "Cam1Type", "RTSP"))
        SetCombo(cmbCam2Type, GetSetting("Camera", "Cam2Type", "RTSP"))
        SetCombo(cmbCam3Type, GetSetting("Camera", "Cam3Type", "RTSP"))
        SetCombo(cmbCam4Type, GetSetting("Camera", "Cam4Type", "RTSP"))

        ' Company
        txtCompanyName.Text = GetSetting("Company", "Name", SessionManager.CompanyName)
        txtGST.Text = GetSetting("Company", "GST", "")
        txtAddress.Text = GetSetting("Company", "Address", "")
        txtPhone.Text = GetSetting("Company", "Phone", "")
        txtCloudURL.Text = GetSetting("Company", "CloudURL", "http://facedesk.geniustech.online/api/")
    End Sub

    Private Sub SetCombo(cmb As ComboBox, value As String)
        If cmb.Items.Contains(value) Then cmb.Text = value
    End Sub

    ' ── Save Buttons ──────────────────────────────────────────

    Private Sub btnSaveIndicator_Click(s As Object, e As EventArgs) Handles btnSaveIndicator.Click
        SaveSettings("Indicator", "COMPort", cmbCOMPort.Text)
        SaveSettings("Indicator", "BaudRate", cmbBaudRate.Text)
        SaveSettings("Indicator", "DataBits", cmbDataBits.Text)
        SaveSettings("Indicator", "Parity", cmbParity.Text)
        SaveSettings("Indicator", "StopBits", cmbStopBits.Text)
        SaveSettings("Indicator", "Format", txtWeightFormat.Text)
        MsgBox("Indicator settings saved! ✅", MsgBoxStyle.Information)
    End Sub

    Private Sub btnSavePrinter_Click(s As Object, e As EventArgs) Handles btnSavePrinter.Click
        SaveSettings("Printer", "Name", cmbPrinterName.Text)
        SaveSettings("Printer", "PaperSize", cmbPaperSize.Text)
        SaveSettings("Printer", "Copies", nudCopies.Value.ToString())
        SaveSettings("Printer", "AutoPrint", chkAutoPrint.Checked.ToString())
        SaveSettings("Printer", "ColorPrint", chkColorPrint.Checked.ToString())
        MsgBox("Printer settings saved! ✅", MsgBoxStyle.Information)
    End Sub

    Private Sub btnSaveCamera_Click(s As Object, e As EventArgs) Handles btnSaveCamera.Click
        DatabaseHelper.SaveSetting("Cam1URL", txtCam1URL.Text)
        DatabaseHelper.SaveSetting("Cam2URL", txtCam2URL.Text)
        DatabaseHelper.SaveSetting("Cam3URL", txtCam3URL.Text)
        DatabaseHelper.SaveSetting("Cam4URL", txtCam4URL.Text)
        MsgBox("Cameras saved to Database! ✅")
    End Sub

    Private Sub btnSaveCompany_Click(s As Object, e As EventArgs) Handles btnSaveCompany.Click
        SaveSettings("Company", "Name", txtCompanyName.Text)
        SaveSettings("Company", "GST", txtGST.Text)
        SaveSettings("Company", "Address", txtAddress.Text)
        SaveSettings("Company", "Phone", txtPhone.Text)
        SaveSettings("Company", "CloudURL", txtCloudURL.Text)
        MsgBox("Company settings saved! ✅", MsgBoxStyle.Information)
    End Sub

    ' ── Test Buttons ──────────────────────────────────────────

    Private Sub btnTestCOM_Click(s As Object, e As EventArgs) Handles btnTestCOM.Click
        If cmbCOMPort.Text = "" OrElse cmbCOMPort.Text = "No COM Ports" Then
            MsgBox("COM Port select చేయండి!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim port As New SerialPort(
                cmbCOMPort.Text,
                CInt(cmbBaudRate.Text),
                [Enum].Parse(GetType(Parity), cmbParity.Text),
                CInt(cmbDataBits.Text),
                If(cmbStopBits.Text = "1", StopBits.One,
                   If(cmbStopBits.Text = "2", StopBits.Two, StopBits.OnePointFive)))

            port.Open()
            Threading.Thread.Sleep(500)

            Dim raw = ""
            If port.BytesToRead > 0 Then raw = port.ReadExisting()
            port.Close()

            If raw <> "" Then
                lblRawData.Text = $"Raw Data: {raw.Trim()}"
                lblParsedWeight.Text = $"Parsed: {ParseWeight(raw)} KG"
                MsgBox($"Connection OK!{vbCrLf}Raw: {raw.Trim()}", MsgBoxStyle.Information)
            Else
                lblRawData.Text = "Raw Data: (No data received)"
                MsgBox("Connected but no data. Indicator on గా ఉందా?", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox($"Connection failed!{vbCrLf}{ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function ParseWeight(raw As String) As String
        Try
            ' Format: W+001234 → 1234
            Dim fmt = txtWeightFormat.Text
            Dim digits = New String(raw.Where(Function(c) Char.IsDigit(c)).ToArray())
            If digits.Length > 0 Then Return digits.TrimStart("0"c)
            Return "0"
        Catch
            Return "0"
        End Try
    End Function

    Private Sub btnTestPrint_Click(s As Object, e As EventArgs) Handles btnTestPrint.Click
        If cmbPrinterName.Text = "" Then
            MsgBox("Printer select చేయండి!", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            Dim pd As New Drawing.Printing.PrintDocument()
            pd.PrinterSettings.PrinterName = cmbPrinterName.Text
            AddHandler pd.PrintPage, Sub(ps, pe)
                                         Dim g = pe.Graphics
                                         g.DrawString("WeighDATA Test Print",
                                             New Font("Arial", 16, FontStyle.Bold),
                                             Brushes.Black, 50, 50)
                                         g.DrawString($"Printer: {cmbPrinterName.Text}",
                                             New Font("Arial", 10), Brushes.Black, 50, 90)
                                         g.DrawString($"Date: {DateTime.Now}",
                                             New Font("Arial", 10), Brushes.Black, 50, 110)
                                         g.DrawString("This is a test print from WeighDATA",
                                             New Font("Arial", 10), Brushes.Black, 50, 140)
                                     End Sub
            pd.Print()
            MsgBox("Test print sent! ✅", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox($"Print error: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTestCameras_Click(s As Object, e As EventArgs) Handles btnTestCameras.Click
        Dim msg = "Camera URLs saved. RTSP cameras are shown in Weighment form." & vbCrLf & vbCrLf
        msg &= $"Cam 1: {If(txtCam1URL.Text <> "", "✅ " & txtCam1URL.Text, "❌ Not set")}" & vbCrLf
        msg &= $"Cam 2: {If(txtCam2URL.Text <> "", "✅ " & txtCam2URL.Text, "❌ Not set")}" & vbCrLf
        msg &= $"Cam 3: {If(txtCam3URL.Text <> "", "✅ " & txtCam3URL.Text, "❌ Not set")}" & vbCrLf
        msg &= $"Cam 4: {If(txtCam4URL.Text <> "", "✅ " & txtCam4URL.Text, "❌ Not set")}"
        MsgBox(msg, MsgBoxStyle.Information, "Camera Status")
    End Sub

    Private Sub btnTestCloud_Click(s As Object, e As EventArgs) Handles btnTestCloud.Click
        Try
            Dim client As New Net.WebClient()
            Dim result = client.DownloadString(txtCloudURL.Text & "ping.php")
            MsgBox($"Cloud connected! ✅{vbCrLf}Response: {result}", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox($"Cloud connection failed!{vbCrLf}{ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmPrintDesigner.Show()
    End Sub

    ' కెమెరాను టెస్ట్ చేయడానికి కామన్ మెథడ్
    Private Sub TestCameraStream(url As String)
        If String.IsNullOrWhiteSpace(url) Then
            MsgBox("ముందుగా URL ని ఎంటర్ చేయండి!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim testForm As New FrmCameraTest()
        testForm.Show()
        ' ఫామ్ ఓపెన్ అయిన తర్వాత స్ట్రీమ్ స్టార్ట్ చేయాలి
        testForm.StartStream(url)
    End Sub

    ' బటన్ క్లిక్ ఈవెంట్స్
    Private Sub btnTestCam1_Click(sender As Object, e As EventArgs) Handles btnTestCam1.Click
        TestCameraStream(txtCam1URL.Text)
    End Sub

    Private Sub btnTestCam2_Click(sender As Object, e As EventArgs) Handles btnTestCam2.Click
        TestCameraStream(txtCam2URL.Text)
    End Sub

    Private Sub btnTestCam3_Click(sender As Object, e As EventArgs) Handles btnTestCam3.Click
        TestCameraStream(txtCam3URL.Text)
    End Sub

    Private Sub btnTestCam4_Click(sender As Object, e As EventArgs) Handles btnTestCam4.Click
        TestCameraStream(txtCam4URL.Text)
    End Sub



End Class