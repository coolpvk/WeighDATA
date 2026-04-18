Imports System.Data
Imports System.IO
Imports System.Drawing.Printing

Public Class FrmReports

    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGrid()
        LoadFilters()
        GenerateReport() ' లోడ్ అవ్వగానే ఈరోజు డేటా చూపిస్తుంది
    End Sub

    Private Sub SetupGrid()
        dgvReports.ReadOnly = True
        dgvReports.AllowUserToAddRows = False
        dgvReports.RowHeadersVisible = False
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReports.BackgroundColor = Color.White
    End Sub

    Private Sub LoadFilters()
        ' పార్టీల జాబితా
        Dim dtParties = DatabaseHelper.ExecuteQuery("SELECT name FROM parties WHERE status=1 ORDER BY name")
        cmbParty.DataSource = dtParties
        cmbParty.DisplayMember = "name"
        cmbParty.ValueMember = "name"
        cmbParty.SelectedIndex = -1

        ' మెటీరియల్స్ జాబితా
        Dim dtMats = DatabaseHelper.ExecuteQuery("SELECT name FROM materials WHERE status=1 ORDER BY name")
        cmbMaterial.DataSource = dtMats
        cmbMaterial.DisplayMember = "name"
        cmbMaterial.ValueMember = "name"
        cmbMaterial.SelectedIndex = -1
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReport()
    End Sub

    Private Sub GenerateReport()
        ' తేదీలను SQLite ఫార్మాట్ (YYYY-MM-DD) లోకి మార్చాలి
        Dim dateFrom As String = dtpFrom.Value.ToString("yyyy-MM-dd")
        Dim dateTo As String = dtpTo.Value.ToString("yyyy-MM-dd")

        ' Dynamic SQL Query
        Dim sql As String = "SELECT slip_number, weigh_date, vehicle_number, party_name, material_name, net_weight, amount " &
                            "FROM weighments WHERE branch_id=@bid AND weigh_date BETWEEN @df AND @dt"

        Dim params As New Dictionary(Of String, Object) From {
            {"@bid", SessionManager.BranchId},
            {"@df", dateFrom},
            {"@dt", dateTo}
        }

        ' పార్టీ ఫిల్టర్ ఉంటే
        If cmbParty.Text <> "" Then
            sql &= " AND party_name = @party"
            params.Add("@party", cmbParty.Text)
        End If

        ' మెటీరియల్ ఫిల్టర్ ఉంటే
        If cmbMaterial.Text <> "" Then
            sql &= " AND material_name = @mat"
            params.Add("@mat", cmbMaterial.Text)
        End If

        sql &= " ORDER BY weigh_date DESC, id DESC"

        Dim dt = DatabaseHelper.ExecuteQuery(sql, params)
        dgvReports.DataSource = dt
        CalculateSummary(dt)
    End Sub

    Private Sub CalculateSummary(dt As DataTable)
        Dim totalSlips As Integer = dt.Rows.Count
        Dim totalWt As Double = 0
        Dim totalAmt As Double = 0

        For Each row As DataRow In dt.Rows
            totalWt += Convert.ToDouble(row("net_weight"))
            totalAmt += Convert.ToDouble(row("amount"))
        Next

        lblTotalSlips.Text = $"Total Slips: {totalSlips}"
        lblTotalWeight.Text = $"Total Weight: {totalWt:F2} KG"
        lblTotalAmount.Text = $"Total Amount: ₹{totalAmt:N2}"
    End Sub

    ' ── EXPORT TO EXCEL (Simple CSV approach for compatibility) ──────────────────
    ' ── EXPORT TO EXCEL (Fixed CSV Version) ──────────────────────────────────
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReports.Rows.Count = 0 Then
            MsgBox("ఎక్స్‌పోర్ట్ చేయడానికి డేటా లేదు!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV files (*.csv)|*.csv"
            saveDialog.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()

                ' --- 1. Headers (అన్ని హెడర్లను ఒకే లైన్‌లో పెట్టడం) ---
                Dim headerList As New List(Of String)
                For Each col As DataGridViewColumn In dgvReports.Columns
                    ' హెడర్ పేరులో కామా ఉంటే సమస్య వస్తుంది, అందుకే డబుల్ కోట్స్ పెడుతున్నాను
                    headerList.Add("""" & col.HeaderText & """")
                Next
                ' అన్ని హెడర్లను కామాలతో కలిపి ఒకే లైన్ గా యాడ్ చేయడం
                sb.AppendLine(String.Join(",", headerList))

                ' --- 2. Data Rows (డేటాను వరుసగా యాడ్ చేయడం) ---
                For Each row As DataGridViewRow In dgvReports.Rows
                    Dim lineValues As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        Dim cellValue As String = ""
                        If cell.Value IsNot Nothing Then
                            cellValue = cell.Value.ToString()
                        End If
                        ' ప్రతి విలువకు డబుల్ కోట్స్ పెట్టి లిస్ట్‌లో యాడ్ చేయడం
                        lineValues.Add("""" & cellValue & """")
                    Next
                    ' ఒక రో లోని అన్ని విలువలను కామాలతో కలిపి ఒకే లైన్ గా యాడ్ చేయడం
                    sb.AppendLine(String.Join(",", lineValues))
                Next

                ' ఫైల్‌ను సేవ్ చేయడం
                File.WriteAllText(saveDialog.FileName, sb.ToString())
                MsgBox("రిపోర్ట్ విజయవంతంగా ఎక్సెల్ (CSV) లో సేవ్ చేయబడింది!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error exporting: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private rowIdx As Integer = 0 ' ఏ రో దగ్గర ప్రింటింగ్ ఆగిందో ట్రాక్ చేయడానికి

    ' Print Button Click
    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        If dgvReports.Rows.Count = 0 Then
            MsgBox("ప్రింట్ చేయడానికి డేటా లేదు!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim pd As New PrintDocument()
            pd.DefaultPageSettings.PaperSize = New PaperSize("A4", 827, 1169)
            AddHandler pd.PrintPage, AddressOf PrintReportPage

            ' ప్రింట్ డైలాగ్ బాక్స్ చూపించడం
            Dim printDlg As New PrintDialog()
            printDlg.Document = pd

            If printDlg.ShowDialog() = DialogResult.OK Then
                rowIdx = 0 ' రో ఇండెక్స్‌ను రీసెట్ చేయాలి
                pd.Print()
            End If
        Catch ex As Exception
            MsgBox("Printing Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Printing Page Logic
    Private Sub PrintReportPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontBody As New Font("Segoe UI", 9, FontStyle.Regular)

        Dim curX As Integer = 50
        Dim pageWidth As Integer = 727
        Dim curY As Integer = 40

        ' --- 1. HEADER SECTION ---
        Dim sfCenter As New StringFormat() : sfCenter.Alignment = StringAlignment.Center
        g.DrawString(SessionManager.CompanyName, fontTitle, Brushes.Black, New RectangleF(curX, curY, pageWidth, 30), sfCenter)
        curY += 30

        Dim reportTitle As String = "Weighment Report (" & dtpFrom.Value.ToString("dd-MM-yyyy") & " to " & dtpTo.Value.ToString("dd-MM-yyyy") & ")"
        g.DrawString(reportTitle, fontHeader, Brushes.Black, New RectangleF(curX, curY, pageWidth, 20), sfCenter)
        curY += 40

        ' --- 2. TABLE DRAWING ---
        ' Table Headers
        Dim colWidths As Integer() = {80, 100, 110, 150, 100, 100, 100} ' కాలమ్ వెడల్పులు
        Dim colNames As String() = {"Slip No", "Date", "Vehicle", "Party", "Material", "Weight", "Amount"}

        ' Header Background
        g.FillRectangle(Brushes.LightGray, curX, curY, pageWidth, 25)
        g.DrawRectangle(Pens.Black, curX, curY, pageWidth, 25)

        Dim tempX As Integer = curX
        For i As Integer = 0 To colNames.Length - 1
            g.DrawString(colNames(i), fontHeader, Brushes.Black, tempX + 5, curY + 5)
            g.DrawLine(Pens.Black, tempX + colWidths(i), curY, tempX + colWidths(i), curY + 25)
            tempX += colWidths(i)
        Next
        curY += 25

        ' Data Rows
        While rowIdx < dgvReports.Rows.Count
            Dim row = dgvReports.Rows(rowIdx)

            ' Row Border
            g.DrawRectangle(Pens.Black, curX, curY, pageWidth, 20)

            tempX = curX
            For i As Integer = 0 To dgvReports.Columns.Count - 1
                Dim cellValue As String = ""
                If row.Cells(i).Value IsNot Nothing Then
                    Dim val As String = row.Cells(i).Value.ToString()
                    ' ఒకవేళ అది తేదీ కాలమ్ అయితే, సమయాన్ని తీసివేసి కేవలం డేట్ మాత్రమే ఉంచుతుంది
                    If i = 1 Then ' Date column index 1 అయితే
                        Dim dt As DateTime
                        If DateTime.TryParse(val, dt) Then
                            cellValue = dt.ToString("dd-MMM-yyyy")
                        Else
                            cellValue = val
                        End If
                    Else
                        cellValue = val
                    End If
                End If
                g.DrawString(cellValue, fontBody, Brushes.Black, tempX + 5, curY + 5)
                g.DrawLine(Pens.Black, tempX + colWidths(i), curY, tempX + colWidths(i), curY + 20)
                tempX += colWidths(i)
            Next

            curY += 20
            rowIdx += 1

            ' పేజీ కిందకు వచ్చిందో లేదో చెక్ చేయడం (A4 Height limit)
            If curY > 1000 Then
                e.HasMorePages = True ' ఇంకా డేటా ఉంది, రెండో పేజీ కావాలి
                Return
            End If
        End While

        ' --- 3. SUMMARY SECTION (Last Page Only) ---
        If rowIdx >= dgvReports.Rows.Count Then
            curY += 20
            g.DrawLine(Pens.Black, curX, curY, curX + pageWidth, curY)
            curY += 10
            g.DrawString(lblTotalSlips.Text, fontHeader, Brushes.Black, curX, curY)
            g.DrawString(lblTotalWeight.Text, fontHeader, Brushes.Black, curX + 200, curY)
            g.DrawString(lblTotalAmount.Text, fontHeader, Brushes.Black, curX + 400, curY)
        End If

        e.HasMorePages = False ' డేటా మొత్తం ప్రింట్ అయిపోయింది
    End Sub

End Class
