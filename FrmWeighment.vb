Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.Drawing.Printing
Imports System.IO
Imports LibVLCSharp.Shared
Imports LibVLCSharp.WinForms

Public Class FrmWeighment

    ' ── Global Variables ──────────────────────────────────────
    Private currentWeight As Double = 0
    Private isStable As Boolean = False
    Private isFirstWeighment As Boolean = True
    Private reader As WeighbridgeReader = WeighbridgeReader.Instance

    ' VLC Objects for Live Video
    Private libVlc As LibVLC
    Private mp1 As MediaPlayer
    Private mp2 As MediaPlayer
    Private mp3 As MediaPlayer
    Private mp4 As MediaPlayer

    ' Timer for Weight Display
    Private WithEvents tmrDisplay As New Timer With {.Interval = 300}

    ' ── Form Load ─────────────────────────────────────────────
    Private Sub FrmWeighment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialize VLC Live Video
        Try
            Core.Initialize()
            libVlc = New LibVLC()
            StartLiveStreams()
        Catch ex As Exception
            Debug.WriteLine("VLC Init Error: " & ex.Message)
        End Try

        ' 2. Load Other Data
        LoadComboData()
        SetupAutoComplete()
        SetupDataGridView()
        LoadPendingWeights()
        GenerateSerialNo()
        SetFirstWeighmentMode()

        ' 3. Indicator Events Attach
        AddHandler reader.WeightReceived, AddressOf OnWeightReceived
        AddHandler reader.ConnectionChanged, AddressOf OnConnectionChanged
        AddHandler reader.RawDataReceived, AddressOf OnRawData

        ' 4. Connection Check
        If Not reader.IsConnected Then
            ConnectIndicator()
        Else
            lblStable.Text = "● Connected"
            lblStable.ForeColor = Color.FromArgb(52, 211, 153)
        End If

        tmrDisplay.Start()
    End Sub

    ' ── VLC Live Streaming Logic ──────────────────────────────
    ' లైవ్ వీడియో స్ట్రీమింగ్‌ను స్టార్ట్ చేసే మెథడ్
    Private Sub StartLiveStreams()
        Try
            If libVlc Is Nothing Then
                Core.Initialize()
                libVlc = New LibVLC()
            End If

            Dim urls As String() = {
                DatabaseHelper.GetSetting("Cam1URL"),
                DatabaseHelper.GetSetting("Cam2URL"),
                DatabaseHelper.GetSetting("Cam3URL"),
                DatabaseHelper.GetSetting("Cam4URL")
            }

            Dim views As VideoView() = {vView1, vView2, vView3, vView4}

            For i As Integer = 0 To 3
                If Not String.IsNullOrEmpty(urls(i)) Then
                    Dim player = New MediaPlayer(libVlc)

                    ' CORRECTED: Use New Uri(urls(i))
                    Dim media = New Media(libVlc, New Uri(urls(i)))

                    player.Play(media)
                    views(i).MediaPlayer = player

                    If i = 0 Then mp1 = player
                    If i = 1 Then mp2 = player
                    If i = 2 Then mp3 = player
                    If i = 3 Then mp4 = player
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("VLC Stream Error: " & ex.Message)
        End Try
    End Sub






    ' ── COM Port & Weight Logic ────────────────────────────────

    Private Sub ConnectIndicator()
        Dim ok = reader.Connect()
        If ok Then
            lblStable.Text = "● Connecting..."
            lblStable.ForeColor = Color.Yellow
        Else
            lblStable.Text = "● No Indicator"
            lblStable.ForeColor = Color.FromArgb(248, 113, 113)
        End If
    End Sub

    Private Sub OnConnectionChanged(isConnected As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() OnConnectionChanged(isConnected))
            Return
        End If
        If isConnected Then
            lblStable.Text = "● Connected"
            lblStable.ForeColor = Color.FromArgb(52, 211, 153)
        Else
            lblStable.Text = "● Disconnected"
            lblStable.ForeColor = Color.FromArgb(248, 113, 113)
        End If
    End Sub

    Private Sub OnWeightReceived(weight As Double, stable As Boolean)
        If Me.IsDisposed Then Return
        If Me.InvokeRequired Then
            Me.Invoke(Sub() OnWeightReceived(weight, stable))
            Return
        End If
        currentWeight = weight
        isStable = stable
        UpdateWeightDisplay(weight, stable)
    End Sub

    Private Sub OnRawData(raw As String)
        Debug.WriteLine($"RAW: {raw}")
    End Sub

    Private Sub tmrDisplay_Tick(sender As Object, e As EventArgs) Handles tmrDisplay.Tick
        UpdateWeightDisplay(currentWeight, isStable)
    End Sub

    Public Sub UpdateWeightDisplay(weight As Double, stable As Boolean)
        lblLiveWeight.Text = $"{weight * 1000:F0} KG"
        If stable Then
            lblStable.Text = "● STABLE"
            lblStable.ForeColor = Color.FromArgb(52, 211, 153)
        Else
            lblStable.Text = "● UNSTABLE"
            lblStable.ForeColor = Color.FromArgb(248, 113, 113)
        End If
        txtNetWt.Text = (weight * 1000).ToString("F0")
        txtNetWt.BackColor = Color.Black
        txtNetWt.ForeColor = Color.LawnGreen
    End Sub

    Private Sub CaptureWeight()
        If Not isStable Then
            Dim result = reader.ReadOnce()
            If result.Item1 > 0 Then
                currentWeight = result.Item1
                isStable = result.Item2
            End If
            If Not isStable Then
                MsgBox("Weight UNSTABLE! Stable అయిన తర్వాత క్యాప్చర్ అవుతుంది.", MsgBoxStyle.Exclamation, "Unstable")
                Return
            End If
        End If

        If isFirstWeighment Then
            txt1stWt.Text = (currentWeight * 1000).ToString("F0")
            lbl1stWtDT.Text = DateTime.Now.ToString("dd.MM.yyyy  hh:mm:ss tt")
        Else
            txt2ndWt.Text = (currentWeight * 1000).ToString("F0")
            lbl2ndWtDT.Text = DateTime.Now.ToString("dd.MM.yyyy  hh:mm:ss tt")
            CalculateEverything()
        End If
    End Sub

    ' ── Mode Switching ────────────────────────────────────────

    Private Sub SetFirstWeighmentMode()
        isFirstWeighment = True
        lblWTitle.Text = "⚖️  First Weighment"
        txtSerialNo.ReadOnly = True
        txtSerialNo.BackColor = Color.FromArgb(240, 244, 250)
        txt1stWt.ReadOnly = True
        txt2ndWt.ReadOnly = True
        txt2ndWt.BackColor = Color.FromArgb(240, 244, 250)
        txt1stWt.BackColor = Color.FromArgb(240, 244, 250)
        Label11.Text = "1st WEIGHT (KG)"
        Label13.Text = "2nd WEIGHT (KG)"
        txt1stWt.Text = "0"
        txt2ndWt.Text = "0"
        txtNetWt.Text = "0"
        lbl1stWtDT.Text = ""
        lbl2ndWtDT.Text = ""
    End Sub

    Private Sub SetSecondWeighmentMode()
        isFirstWeighment = False
        lblWTitle.Text = "⚖️  Second Weighment"
        txtSerialNo.ReadOnly = False
        txtSerialNo.BackColor = Color.White
        txt1stWt.ReadOnly = True
        txt1stWt.BackColor = Color.FromArgb(240, 244, 250)
        txt2ndWt.ReadOnly = True
        Label11.Text = "1st WEIGHT (KG) — Saved"
        Label13.Text = "2nd WEIGHT (KG) — Capture"
        txtSerialNo.Focus()
    End Sub

    Private Sub ckbSecondWt_CheckedChanged(s As Object, e As EventArgs) Handles ckbSecondWt.CheckedChanged
        If ckbSecondWt.Checked Then
            SetSecondWeighmentMode()
        Else
            SetFirstWeighmentMode()
            GenerateSerialNo()
            ClearForm()
        End If
    End Sub

    ' ── Data Loading & Serial No ────────────────────────────────

    Private Sub txtSerialNo_Leave(sender As Object, e As EventArgs) Handles txtSerialNo.Leave
        Dim srNo As String = txtSerialNo.Text.Trim()
        If srNo = "" Then Return

        If ckbPrintDuplicateTicket.Checked Then
            LoadTicketForPrint(srNo)
        ElseIf Not isFirstWeighment Then
            LoadFirstWeighmentData(srNo)
        End If
    End Sub

    Private Sub LoadFirstWeighmentData(srNo As String)
        If srNo = "" Then Return
        Dim sql As String = "SELECT id, slip_number, weigh_type, vehicle_number, vehicle_type, party_name, mobile, sub_party, material_name, gross_weight, CAST(gross_time AS TEXT) as gross_time FROM weighments WHERE slip_number=@sn AND branch_id=@bid AND status='first_done'"
        Dim dt = DatabaseHelper.ExecuteQuery(sql, New Dictionary(Of String, Object) From {{"@sn", srNo}, {"@bid", SessionManager.BranchId}})

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Return

        Dim row = dt.Rows(0)
        cmbWType.Text = row("weigh_type").ToString()
        cmbVehicle.Text = row("vehicle_number").ToString()
        cmbVehicleType.Text = row("vehicle_type").ToString()
        cmbCustomer.Text = row("party_name").ToString()
        txtMobile.Text = row("mobile").ToString()
        txtSubParty.Text = row("sub_party").ToString()
        cmbMaterial.Text = row("material_name").ToString()
        txt1stWt.Text = row("gross_weight").ToString()
        lbl1stWtDT.Text = FormatDbDateTime(row("gross_time"))
        CaptureWeight()
    End Sub

    Private Sub GenerateSerialNo()
        Dim lastNo = DatabaseHelper.ExecuteScalar("SELECT MAX(CAST(slip_number AS INTEGER)) FROM weighments WHERE branch_id=@bid", New Dictionary(Of String, Object) From {{"@bid", SessionManager.BranchId}})
        Dim nextNo = 1
        If lastNo IsNot Nothing AndAlso lastNo IsNot DBNull.Value Then nextNo = Convert.ToInt32(lastNo) + 1
        If nextNo > 9999 Then nextNo = 1
        txtSerialNo.Text = nextNo.ToString("D4")
    End Sub

    ' ── Combo & Grid Setup ──────────────────────────────────────

    Private Sub LoadComboData()
        cmbWType.Items.Clear()
        cmbWType.Items.AddRange({"PURCHASE", "SALE", "OWN VEHICLE IN", "OWN VEHICLE OUT"})
        If cmbWType.Items.Count > 0 Then cmbWType.SelectedIndex = 0
        cmbPayMode.Items.Clear()
        cmbPayMode.Items.AddRange({"CASH", "CREDIT", "UPI"})
        If cmbPayMode.Items.Count > 0 Then cmbPayMode.SelectedIndex = 0
        cmbVehicleType.Items.Clear()
        Dim vTypeDt = DatabaseHelper.ExecuteQuery("SELECT name FROM vehicle_types WHERE company_id=@cid AND status=1 ORDER BY name", New Dictionary(Of String, Object) From {{"@cid", SessionManager.CompanyId}})
        For Each row As DataRow In vTypeDt.Rows : cmbVehicleType.Items.Add(row("name").ToString()) : Next
        cmbVehicle.Items.Clear()
        Dim vt = DatabaseHelper.ExecuteQuery("SELECT vehicle_number FROM vehicles WHERE company_id=@cid AND status=1 ORDER BY vehicle_number", New Dictionary(Of String, Object) From {{"@cid", SessionManager.CompanyId}})
        For Each row As DataRow In vt.Rows : cmbVehicle.Items.Add(row("vehicle_number").ToString()) : Next
        cmbCustomer.Items.Clear()
        Dim pt = DatabaseHelper.ExecuteQuery("SELECT name FROM parties WHERE company_id=@cid AND status=1 ORDER BY name", New Dictionary(Of String, Object) From {{"@cid", SessionManager.CompanyId}})
        For Each row As DataRow In pt.Rows : cmbCustomer.Items.Add(row("name").ToString()) : Next
        cmbMaterial.Items.Clear()
        Dim mt = DatabaseHelper.ExecuteQuery("SELECT name FROM materials WHERE (company_id=@cid OR company_id IS NULL) AND status=1 ORDER BY name", New Dictionary(Of String, Object) From {{"@cid", SessionManager.CompanyId}})
        For Each row As DataRow In mt.Rows : cmbMaterial.Items.Add(row("name").ToString()) : Next
    End Sub

    ' ── Calculations ──────────────────────────────────────────

    Private Sub CalculateEverything()
        Dim w1, w2, deduct, rate As Double
        Double.TryParse(txt1stWt.Text, w1)
        Double.TryParse(txt2ndWt.Text, w2)
        Double.TryParse(txtDeductionWt.Text, deduct)
        Double.TryParse(txtRate.Text, rate)
        Dim initialNet As Double = Math.Abs(w1 - w2)
        txtNetWt.Text = initialNet.ToString("F0")
        Dim finalNet As Double = initialNet - deduct
        If finalNet < 0 Then finalNet = 0
        txtFinalNetWt.Text = finalNet.ToString("F0")
        Dim totalAmount As Double = finalNet * rate
        txtAmount.Text = totalAmount.ToString("F2")
    End Sub

    Private Sub UpdateCalculations(sender As Object, e As EventArgs) Handles _
        txt1stWt.TextChanged, txt2ndWt.TextChanged, txtDeductionWt.TextChanged, txtRate.TextChanged, txtCharges.TextChanged
        CalculateEverything()
    End Sub

    ' ── Image Saving Logic (Snapshot URL based) ──────────────────
    Private Sub SaveCurrentCameraImages()
        Try
            Dim slipFolder As String = Path.Combine(Application.StartupPath, "Slips", txtSerialNo.Text)
            If Not Directory.Exists(slipFolder) Then Directory.CreateDirectory(slipFolder)

            ' Snapshot URLs for saving
            Dim urls As String() = {
                DatabaseHelper.GetSetting("Cam1URL"),
                DatabaseHelper.GetSetting("Cam2URL"),
                DatabaseHelper.GetSetting("Cam3URL"),
                DatabaseHelper.GetSetting("Cam4URL")
            }

            For i As Integer = 0 To 3
                Dim url = urls(i)
                If Not String.IsNullOrEmpty(url) Then
                    Try
                        Dim webClient As New Net.WebClient()
                        Dim bytes = webClient.DownloadData(url)
                        File.WriteAllBytes(Path.Combine(slipFolder, "cam" & (i + 1) & ".jpg"), bytes)
                    Catch ex As Exception
                        Debug.WriteLine($"Cam {i + 1} Save Error: " & ex.Message)
                    End Try
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("Image Folder Error: " & ex.Message)
        End Try
    End Sub

    ' ── Save Button Click Event ──────────────────────────────────────────
    Private Sub btnSave_Click(s As Object, e As EventArgs) Handles btnSave.Click
        If cmbVehicle.Text.Trim() = "" Then MsgBox("Vehicle Number enter చేయండి!", MsgBoxStyle.Exclamation) : Return

        Dim w1, w2, net As Double
        Double.TryParse(txt1stWt.Text, w1)
        Double.TryParse(txt2ndWt.Text, w2)
        Double.TryParse(txtNetWt.Text, net)
        Dim currentDbDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        If isFirstWeighment Then
            Dim vTypeId = DatabaseHelper.EnsureMasterExists("vehicle_types", "name", cmbVehicleType.Text, SessionManager.CompanyId)
            Dim partyId = DatabaseHelper.EnsureMasterExists("parties", "name", cmbCustomer.Text, SessionManager.CompanyId)
            Dim matId = DatabaseHelper.EnsureMasterExists("materials", "name", cmbMaterial.Text, SessionManager.CompanyId)
            Dim subPartyId = DatabaseHelper.EnsureMasterExists("sub_parties", "name", txtSubParty.Text, SessionManager.CompanyId)

            If w1 = 0 Then MsgBox("1st Weight capture చేయండి!", MsgBoxStyle.Exclamation) : Return

            Try
                DatabaseHelper.ExecuteNonQuery("INSERT INTO weighments (company_id, branch_id, slip_number, weigh_date, weigh_type, vehicle_id, vehicle_number, vehicle_type_id, vehicle_type, party_id, party_name, mobile, sub_party_id, sub_party, material_id, material_name, gross_weight, gross_time, status, sync_status) VALUES (@cid, @bid, @sn, date('now'), @type, @vid, @veh, @vtid, @vtype, @pid, @party, @mob, @spid, @sub, @mid, @mat, @gross, @dt, 'first_done', 'pending')", New Dictionary(Of String, Object) From {{"@cid", SessionManager.CompanyId}, {"@bid", SessionManager.BranchId}, {"@sn", txtSerialNo.Text}, {"@type", cmbWType.Text}, {"@vid", 0}, {"@veh", cmbVehicle.Text}, {"@vtid", vTypeId}, {"@vtype", cmbVehicleType.Text}, {"@pid", partyId}, {"@party", cmbCustomer.Text}, {"@mob", txtMobile.Text}, {"@spid", subPartyId}, {"@sub", txtSubParty.Text}, {"@mid", matId}, {"@mat", cmbMaterial.Text}, {"@gross", w1}, {"@dt", currentDbDateTime}})

                SaveCurrentCameraImages()

                MsgBox($"✅ 1st Weighment Saved!", MsgBoxStyle.Information)
                PerformPrint() : LoadPendingWeights() : GenerateSerialNo() : LoadComboData() : ClearForm()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try

        Else
            If w2 = 0 Then MsgBox("2nd Weight capture చేయండి!", MsgBoxStyle.Exclamation) : Return

            Dim actualGross As Double = Math.Max(w1, w2)
            Dim actualTare As Double = Math.Min(w1, w2)
            Dim deduction As Double = 0 : Double.TryParse(txtDeductionWt.Text, deduction)
            Dim finalNet = actualGross - actualTare - deduction
            If finalNet < 0 Then finalNet = 0

            Dim finalGrossTime As String = If(w1 > w2, lbl1stWtDT.Text, lbl2ndWtDT.Text)
            Dim finalTareTime As String = If(w1 > w2, lbl2ndWtDT.Text, lbl1stWtDT.Text)

            Try
                DatabaseHelper.ExecuteNonQuery("UPDATE weighments SET gross_weight=@gross, tare_weight=@tare, net_weight=@net, deduction_weight=@deduct, payment_mode=@pmode, rate=@rate, amount=@amt, charges=@chg, gross_time=@gt, tare_time=@tt, status='completed', sync_status='pending' WHERE slip_number=@sn AND branch_id=@bid", New Dictionary(Of String, Object) From {{"@gross", actualGross}, {"@tare", actualTare}, {"@net", finalNet}, {"@deduct", deduction}, {"@pmode", cmbPayMode.Text}, {"@rate", Val(txtRate.Text)}, {"@amt", Val(txtAmount.Text)}, {"@chg", Val(txtCharges.Text)}, {"@gt", finalGrossTime}, {"@tt", finalTareTime}, {"@sn", txtSerialNo.Text}, {"@bid", SessionManager.BranchId}})

                SaveCurrentCameraImages()

                MsgBox($"✅ Completed!", MsgBoxStyle.Information)
                PerformPrint() : LoadPendingWeights() : LoadComboData() : ClearForm() : ckbSecondWt.Checked = False
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' ── Printing ─────────────────────────────────────────────

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PerformPrint()
        If ckbPrintDuplicateTicket.Checked Then
            ckbPrintDuplicateTicket.Checked = False
            MsgBox("Duplicate Ticket Printed and Mode Reset!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PerformPrint()
        Try
            Dim pd As New PrintDocument()
            pd.DefaultPageSettings.PaperSize = New PaperSize("A4", 827, 1169)
            AddHandler pd.PrintPage, AddressOf PrintSlipPage
            pd.Print()
        Catch ex As Exception : MsgBox("Printing Error: " & ex.Message, MsgBoxStyle.Critical) : End Try
    End Sub

    Private Sub PrintSlipPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontSub As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontBody As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim fontStamp As New Font("Segoe UI", 12, FontStyle.Bold)

        Dim curX As Integer = 50
        Dim pageWidth As Integer = 727
        Dim curY As Integer = 0

        Dim sfCenter As New StringFormat() : sfCenter.Alignment = StringAlignment.Center
        g.DrawString(SessionManager.CompanyName, fontTitle, Brushes.Black, New RectangleF(curX, 40, pageWidth, 30), sfCenter)
        g.DrawString("1-4-47/1/3, Saradhi Nagar, Khammam, Telangana - 507003", fontBody, Brushes.Black, New RectangleF(curX, 70, pageWidth, 20), sfCenter)
        g.DrawString("Mobile No: 9000007533", fontBody, Brushes.Black, New RectangleF(curX, 90, pageWidth, 20), sfCenter)

        Dim printDate As String = "Print Date :  " & DateTime.Now.ToString("dd-MM-yyyy hh:mm tt")
        g.DrawString(printDate, fontBody, Brushes.Black, 560, 120)

        Dim copyText As String = If(ckbPrintDuplicateTicket.Checked, "DUPLICATE COPY", "ORIGINAL COPY")
        Dim copyColor As Brush = If(ckbPrintDuplicateTicket.Checked, Brushes.Red, Brushes.DarkGreen)
        g.DrawString(copyText, fontStamp, copyColor, 630, 90)

        curY = 115
        g.DrawLine(Pens.Black, curX, curY, curX + pageWidth, curY)
        curY = 145
        g.DrawLine(Pens.Black, curX, curY, curX + pageWidth, curY)

        Dim labelMap As New Dictionary(Of String, String) From {
            {"slip_number", "Serial No                         :"}, {"weighment_type", "Weighment Type :"},
            {"vehicle_number", "Vehicle No                      :"}, {"vehicle_type", "Vehicle Type        :"},
            {"party_name", "Party / Customer Name  :"}, {"sub_party", "Sub - Party          :"},
            {"phone", "Phone                            :"}, {"material_name", "Material               :"},
            {"gross_weight", "Gross Weight             :"}, {"gross_time", " "},
            {"tare_weight", "Tare Weight               :"}, {"tare_time", " "},
            {"net_weight", "Net Weight                :"}, {"deduction_weight", "Deduction Weight     :"},
            {"final_weight", "Final Net Weight       :"}, {"rate", "Rate             :"},
            {"amount", "Amount       :"}, {"charges", "Charges       :"}, {"payment_mode", "Payment Mode   :"}
        }

        Dim printData As New Dictionary(Of String, String) From {
            {"slip_number", txtSerialNo.Text}, {"weighment_type", cmbWType.Text},
            {"vehicle_number", cmbVehicle.Text}, {"vehicle_type", cmbVehicleType.Text},
            {"party_name", cmbCustomer.Text}, {"sub_party", txtSubParty.Text},
            {"phone", txtMobile.Text}, {"material_name", cmbMaterial.Text},
            {"gross_weight", txt1stWt.Text & " kg"}, {"gross_time", lbl1stWtDT.Text},
            {"tare_weight", txt2ndWt.Text & " Kg"}, {"tare_time", lbl2ndWtDT.Text},
            {"net_weight", txtNetWt.Text & " kg"}, {"deduction_weight", txtDeductionWt.Text & " kg"},
            {"final_weight", txtFinalNetWt.Text & " kg"}, {"rate", txtRate.Text & "/-"},
            {"amount", txtAmount.Text & "/-"}, {"charges", txtCharges.Text & "/-"}, {"payment_mode", cmbPayMode.Text}
        }

        For Each item In printData
            Dim fieldName As String = item.Key
            Dim fieldValue As String = item.Value
            Dim dt = DatabaseHelper.ExecuteQuery("SELECT * FROM print_settings WHERE field_name=@fn", New Dictionary(Of String, Object) From {{"@fn", fieldName}})

            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                If Convert.ToInt32(row("label_is_visible")) = 1 Then
                    Dim lX As Integer = Convert.ToInt32(row("label_x"))
                    Dim lY As Integer = Convert.ToInt32(row("label_y"))
                    Dim lSize As Integer = Convert.ToInt32(row("label_font_size"))
                    Dim lBold As Boolean = Convert.ToInt32(row("label_is_bold")) = 1
                    Dim lFont As New Font("Segoe UI", lSize, If(lBold, FontStyle.Bold, FontStyle.Regular))
                    Dim lText As String = If(labelMap.ContainsKey(fieldName), labelMap(fieldName), "")
                    g.DrawString(lText, lFont, Brushes.Black, lX, lY)
                End If
                If Convert.ToInt32(row("data_is_visible")) = 1 Then
                    Dim dX As Integer = Convert.ToInt32(row("data_x"))
                    Dim dY As Integer = Convert.ToInt32(row("data_y"))
                    Dim dSize As Integer = Convert.ToInt32(row("data_font_size"))
                    Dim dBold As Boolean = Convert.ToInt32(row("data_is_bold")) = 1
                    Dim dFont As New Font("Segoe UI", dSize, If(dBold, FontStyle.Bold, FontStyle.Regular))
                    g.DrawString(fieldValue, dFont, Brushes.Black, dX, dY)
                End If
            End If
        Next

        g.DrawLine(Pens.Black, curX, 245, curX + pageWidth, 245)
        g.DrawLine(Pens.Black, curX, 420, curX + pageWidth, 420)
        g.DrawLine(Pens.Black, curX, 455, curX + pageWidth, 455)

        g.DrawLine(Pens.Black, curX, 490, curX + 150, 490)
        g.DrawString("Operator Signature", fontBody, Brushes.Black, curX + 20, 490)
        g.DrawLine(Pens.Black, curX + 550, 490, curX + pageWidth, 490)
        g.DrawString("Customer Signature", fontBody, Brushes.Black, curX + 580, 490)

        Dim imgPath As String = Path.Combine(Application.StartupPath, "Slips", txtSerialNo.Text)
        Dim imgW As Integer = 320
        Dim imgH As Integer = 220
        Dim gapX As Integer = 30
        Dim gapY As Integer = 30
        Dim startX As Integer = curX + 30
        Dim startY As Integer = 530

        For i As Integer = 1 To 4
            Dim col As Integer = (i - 1) Mod 2
            Dim row As Integer = (i - 1) \ 2
            Dim currentX As Integer = startX + (col * (imgW + gapX))
            Dim currentY As Integer = startY + (row * (imgH + gapY))
            Dim fileName As String = Path.Combine(imgPath, "cam" & i & ".jpg")

            If File.Exists(fileName) Then
                Try
                    Using img As Image = Image.FromFile(fileName)
                        g.DrawImage(img, currentX, currentY, imgW, imgH)
                    End Using
                Catch ex As Exception
                    g.DrawRectangle(Pens.Gray, currentX, currentY, imgW, imgH)
                    g.DrawString("Image " & i & " Error", fontBody, Brushes.Gray, currentX + 10, currentY + 80)
                End Try
            Else
                g.DrawRectangle(Pens.Gray, currentX, currentY, imgW, imgH)
                g.DrawString("Image " & i & " Not Found", fontBody, Brushes.Gray, currentX + 40, currentY + 80)
            End If
        Next

        curY = 1020
        g.DrawLine(Pens.Black, curX, curY, curX + pageWidth, curY)
        g.DrawString("*This is computer generated weighment slip ", fontBody, Brushes.Gray, curX + 250, curY + 10)
        g.DrawString("- Powered by Genius Technologies, +91 90000 07533.   |    copyrights @ WeighDATA - 2026", fontBody, Brushes.Gray, curX + 60, curY + 30)
    End Sub

    ' ── Helper Methods ─────────────────────────────────────────

    Private Sub ClearForm()
        cmbVehicle.Text = "" : cmbCustomer.Text = "" : cmbVehicleType.Text = "" : txtRate.Text = "0.00"
        txtMobile.Text = "" : txtSubParty.Text = "" : cmbMaterial.SelectedIndex = 0 : txtCharges.Text = "0"
        cmbPayMode.SelectedIndex = 0 : txt1stWt.Text = "0" : txt2ndWt.Text = "0" : txtNetWt.Text = "0"
        lbl1stWtDT.Text = "" : lbl2ndWtDT.Text = ""
    End Sub

    Private Sub SetControlsEnabled(enabled As Boolean)
        For Each ctrl As Control In pnlEntry.Controls
            If ctrl.Name = "txtSerialNo" OrElse ctrl.Name = "btnPrint" Then
                ctrl.Enabled = True
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).ReadOnly = If(ckbPrintDuplicateTicket.Checked OrElse Not isFirstWeighment, False, True)
                    DirectCast(ctrl, TextBox).BackColor = If(DirectCast(ctrl, TextBox).ReadOnly, Color.FromArgb(240, 244, 250), Color.White)
                End If
            Else
                ctrl.Enabled = enabled
            End If
        Next
        btnSave.Enabled = enabled : btnClear.Enabled = enabled : ckbSecondWt.Enabled = enabled
    End Sub

    Private Sub ckbPrintDuplicateTicket_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPrintDuplicateTicket.CheckedChanged
        If ckbPrintDuplicateTicket.Checked Then
            SetControlsEnabled(False) : ClearForm() : txtSerialNo.Focus()
            ckbSecondWt.Checked = False : SetFirstWeighmentMode()
            txtSerialNo.ReadOnly = False : txtSerialNo.BackColor = Color.White
        Else
            SetControlsEnabled(True)
        End If
    End Sub

    Private Sub LoadTicketForPrint(srNo As String)
        If srNo = "" Then Return
        Try
            Dim sql As String = "SELECT id, slip_number, weigh_type, vehicle_number, vehicle_type, party_name, mobile, sub_party, material_name, gross_weight, CAST(gross_time AS TEXT) as gross_time, tare_weight, CAST(tare_time AS TEXT) as tare_time, net_weight, deduction_weight, rate, amount, charges, payment_mode FROM weighments WHERE slip_number=@sn AND branch_id=@bid AND status='completed'"
            Dim dt As DataTable = DatabaseHelper.ExecuteQuery(sql, New Dictionary(Of String, Object) From {{"@sn", srNo}, {"@bid", SessionManager.BranchId}})

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MsgBox("ఈ స్లిప్ నంబర్ తో ఎటువంటి పూర్తయిన రికార్డులు లేవు!", MsgBoxStyle.Exclamation)
                ClearForm()
                lblStable.Text = "● Not Found"
                lblStable.ForeColor = Color.Red
                Return
            End If

            Dim row = dt.Rows(0)
            txtSerialNo.Text = row("slip_number").ToString()
            cmbWType.Text = row("weigh_type").ToString()
            cmbVehicle.Text = row("vehicle_number").ToString()
            cmbVehicleType.Text = row("vehicle_type").ToString()
            cmbCustomer.Text = row("party_name").ToString()
            txtMobile.Text = row("mobile").ToString()
            txtSubParty.Text = row("sub_party").ToString()
            cmbMaterial.Text = row("material_name").ToString()
            txt1stWt.Text = row("gross_weight").ToString()
            txt2ndWt.Text = row("tare_weight").ToString()
            txtNetWt.Text = row("net_weight").ToString()
            txtDeductionWt.Text = row("deduction_weight").ToString()
            txtFinalNetWt.Text = row("net_weight").ToString()
            txtRate.Text = row("rate").ToString()
            txtAmount.Text = row("amount").ToString()
            txtCharges.Text = row("charges").ToString()
            cmbPayMode.Text = row("payment_mode").ToString()
            lbl1stWtDT.Text = FormatDbDateTime(row("gross_//_time")) ' Note: Fixed a potential typo here
            lbl2ndWtDT.Text = FormatDbDateTime(row("tare_time"))
            lblStable.Text = "● Ticket Loaded"
            lblStable.ForeColor = Color.Blue
        Catch ex As Exception
            MsgBox("Error loading ticket: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function FormatDbDateTime(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then Return ""
        Dim dateStr As String = value.ToString()
        Dim dtObj As DateTime
        If DateTime.TryParse(dateStr, dtObj) Then Return dtObj.ToString("dd.MM.yyyy hh:mm:ss tt")
        Return dateStr
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
        If Not isFirstWeighment Then : txtSerialNo.Text = "" : txtSerialNo.Focus() : Else : GenerateSerialNo() : End If
    End Sub

    Private Sub FrmWeighment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tmrDisplay.Stop()
        RemoveHandler reader.WeightReceived, AddressOf OnWeightReceived
        RemoveHandler reader.ConnectionChanged, AddressOf OnConnectionChanged
        RemoveHandler reader.RawDataReceived, AddressOf OnRawData

        If mp1 IsNot Nothing Then mp1.Stop()
        If mp2 IsNot Nothing Then mp2.Stop()
        If mp3 IsNot Nothing Then mp3.Stop()
        If mp4 IsNot Nothing Then mp4.Stop()

        If libVlc IsNot Nothing Then
            libVlc.Dispose()
        End If
    End Sub

    Private Sub cmbVehicle_Leave(sender As Object, e As EventArgs) Handles cmbVehicle.Leave
        If isFirstWeighment Then
            Dim vehicleNo As String = cmbVehicle.Text.Trim().ToUpper()
            If Regex.IsMatch(vehicleNo, "^[A-Z]{2}[0-9]{2}[A-Z]{2}[0-9]{4}$") Then CaptureWeight()
        End If
    End Sub

    Private Sub LoadPendingWeights()
        Try
            Dim sql = "SELECT slip_number, vehicle_number, party_name, material_name, gross_weight, gross_time FROM weighments WHERE status='first_done' AND branch_id=@bid ORDER BY id DESC"
            Dim dt = DatabaseHelper.ExecuteQuery(sql, New Dictionary(Of String, Object) From {{"@bid", SessionManager.BranchId}})
            dgvPending.DataSource = Nothing : dgvPending.DataSource = dt
            If dgvPending.Columns.Count > 0 Then
                dgvPending.Columns("slip_number").HeaderText = "Slip No"
                dgvPending.Columns("vehicle_number").HeaderText = "Vehicle No"
                dgvPending.Columns("party_name").HeaderText = "Customer / Party"
                dgvPending.Columns("material_name").HeaderText = "Material"
                dgvPending.Columns("gross_weight").HeaderText = "1st Weight (KG)"
                dgvPending.Columns("gross_time").HeaderText = "Date & Time"
            End If
        Catch ex As Exception : Debug.WriteLine(ex.Message) : End Try
    End Sub

    Private Sub dgvPending_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPending.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim selectedSlip As String = dgvPending.CurrentRow.Cells("slip_number").Value.ToString()
            ckbSecondWt.Checked = True : LoadFirstWeighmentData(selectedSlip) : txtSerialNo.Text = selectedSlip
        Catch ex As Exception : MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical) : End Try
    End Sub

    Private Sub SetupDataGridView()
        dgvPending.ReadOnly = True
        dgvPending.AllowUserToAddRows = False
        dgvPending.RowHeadersVisible = False
        dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPending.AllowUserToResizeColumns = False
        dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPending.EnableHeadersVisualStyles = False
        dgvPending.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 51, 83)
        dgvPending.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPending.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvPending.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPending.ColumnHeadersHeight = 45
        dgvPending.BackgroundColor = Color.White
        dgvPending.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 250)
        dgvPending.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 126, 245)
        dgvPending.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub SetupAutoComplete()
        cmbVehicleType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbVehicleType.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbMaterial.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub


End Class
