Public Class FrmMain

    Private activeBtn As Button = Nothing
    Private weighmentForm As FrmWeighment = Nothing


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"WeighDATA — {SessionManager.CompanyName} | {SessionManager.BranchName}"
        lblCompanyInfo.Text = $"{SessionManager.CompanyName} · {SessionManager.BranchName}"
        lblUserInfo.Text = $"{SessionManager.Username}  ·  {SessionManager.BranchName}"

        ' Engineer/Admin only → Settings visible
        btnMenuSettings.Visible = (SessionManager.Role = "engineer" OrElse SessionManager.Role = "admin")

        SetActiveMenu(btnMenuDashboard)
        ShowDashboard()
    End Sub

    ' ── Menu Clicks ───────────────────────────────────────────

    Private Sub btnMenuDashboard_Click(s As Object, e As EventArgs) Handles btnMenuDashboard.Click
        SetActiveMenu(btnMenuDashboard)
        lblPageTitle.Text = "Dashboard"
        HideWeighmentForm()
        ShowDashboard()
    End Sub

    Private Sub btnMenuWeighment_Click(s As Object, e As EventArgs) Handles btnMenuWeighment.Click
        SetActiveMenu(btnMenuWeighment)
        lblPageTitle.Text = "Weighment Entry"
        ShowWeighment()
    End Sub

    Private Sub btnMenuReports_Click(s As Object, e As EventArgs) Handles btnMenuReports.Click
        SetActiveMenu(btnMenuReports)
        lblPageTitle.Text = "Reports & Analytics"
        HideWeighmentForm()
        ShowReports()
    End Sub

    Private Sub btnMenuMaster_Click(s As Object, e As EventArgs) Handles btnMenuMaster.Click
        SetActiveMenu(btnMenuMaster)
        lblPageTitle.Text = "Master Management"
        HideWeighmentForm()
        ShowMasterManagement()
    End Sub


    Private Sub btnMenuAttendance_Click(s As Object, e As EventArgs) Handles btnMenuAttendance.Click
        SetActiveMenu(btnMenuAttendance)
        lblPageTitle.Text = "Attendance"
        HideWeighmentForm()
        ShowAttendance()
    End Sub

    Private Sub btnMenuSettings_Click(s As Object, e As EventArgs) Handles btnMenuSettings.Click
        SetActiveMenu(btnMenuSettings)
        lblPageTitle.Text = "Settings"
        HideWeighmentForm()
        ShowSettings()
    End Sub

    Private Sub btnLogout_Click(s As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Logout అవ్వాలా?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If weighmentForm IsNot Nothing Then weighmentForm.Close()
            SessionManager.ClearSession()
            Dim frm As New FrmLogin()
            frm.Show()
            Me.Close()
        End If
    End Sub

    ' ── Active Menu Highlight ─────────────────────────────────

    Private Sub SetActiveMenu(btn As Button)
        For Each ctrl As Control In pnlSidebar.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name <> "btnLogout" Then
                ctrl.BackColor = Color.FromArgb(26, 51, 83)
                ctrl.ForeColor = Color.FromArgb(148, 163, 184)
            End If
        Next
        btn.BackColor = Color.FromArgb(47, 126, 245)
        btn.ForeColor = Color.White
        activeBtn = btn
    End Sub

    ' ── Content Panel ─────────────────────────────────────────

    Private Sub ClearContent()
        For Each ctrl As Control In pnlContent.Controls
            ctrl.Dispose() ' కేవలం Clear చేయకుండా Dispose చేయండి
        Next
        pnlContent.Controls.Clear()
    End Sub

    Private Sub HideWeighmentForm()
        If weighmentForm IsNot Nothing AndAlso Not weighmentForm.IsDisposed Then
            weighmentForm.Hide()
        End If
        pnlContent.Visible = True
    End Sub

    ' ── Weighment (Separate Form — pnlContent hide) ───────────

    Private Sub ShowWeighment()
        ClearContent()
        pnlContent.Visible = True

        Dim frm1 As New FrmWeighment()
        frm1.TopLevel = False
        frm1.FormBorderStyle = FormBorderStyle.None
        frm1.Dock = DockStyle.Fill
        frm1.Parent = pnlContent
        pnlContent.Controls.Add(frm1)
        frm1.Show()



    End Sub

    ' ── Dashboard ─────────────────────────────────────────────

    Private Sub ShowDashboard()
        ClearContent()

        Dim today = DateTime.Now.ToString("yyyy-MM-dd")
        Dim params = New Dictionary(Of String, Object) From {
            {"@bid", SessionManager.BranchId},
            {"@date", today}
        }

        Dim totalW = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM weighments WHERE branch_id=@bid AND weigh_date=@date", params)
        Dim totalNet = DatabaseHelper.ExecuteScalar("SELECT IFNULL(SUM(net_weight),0) FROM weighments WHERE branch_id=@bid AND weigh_date=@date", params)
        Dim totalAmt = DatabaseHelper.ExecuteScalar("SELECT IFNULL(SUM(amount),0) FROM weighments WHERE branch_id=@bid AND weigh_date=@date", params)
        Dim pendSync = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM sync_queue", Nothing)

        ' ── Stat Cards ───────────────────────────────────────
        Dim cards() = {
            New With {.Title = "Today Weighments", .Value = totalW.ToString(), .Clr = Color.FromArgb(47, 126, 245)},
            New With {.Title = "Total Net Weight", .Value = $"{Convert.ToDouble(totalNet):F2} MT", .Clr = Color.FromArgb(52, 211, 153)},
            New With {.Title = "Today Amount", .Value = $"₹{Convert.ToDouble(totalAmt):N0}", .Clr = Color.FromArgb(251, 191, 36)},
            New With {.Title = "Pending Sync", .Value = If(pendSync Is Nothing, "0", pendSync.ToString()), .Clr = Color.FromArgb(248, 113, 113)}
        }

        Dim x = 20
        For Each c In cards
            Dim pnl As New Panel With {.Size = New Size(200, 100), .Location = New Point(x, 20), .BackColor = Color.FromArgb(26, 37, 53)}
            pnl.Controls.Add(New Label With {.Text = c.Value, .Font = New Font("Segoe UI", 20, FontStyle.Bold), .ForeColor = c.Clr, .AutoSize = True, .Location = New Point(14, 14)})
            pnl.Controls.Add(New Label With {.Text = c.Title, .Font = New Font("Segoe UI", 9), .ForeColor = Color.FromArgb(148, 163, 184), .AutoSize = True, .Location = New Point(14, 58)})
            pnlContent.Controls.Add(pnl)
            x += 220
        Next

        ' ── Table ────────────────────────────────────────────
        pnlContent.Controls.Add(New Label With {
            .Text = "Today's Weighments",
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.FromArgb(26, 38, 64),
            .AutoSize = True,
            .Location = New Point(20, 140)
        })

        Dim dgv As New DataGridView With {
            .Location = New Point(20, 168),
            .Size = New Size(pnlContent.Width - 40, pnlContent.Height - 200),
            .BackgroundColor = Color.White,
            .BorderStyle = BorderStyle.None,
            .RowHeadersVisible = False,
            .AllowUserToAddRows = False,
            .ReadOnly = True,
            .Font = New Font("Segoe UI", 9),
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        }
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 51, 83)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.EnableHeadersVisualStyles = False

        dgv.DataSource = DatabaseHelper.ExecuteQuery(
            "SELECT slip_number AS 'SR No', weigh_date AS 'Date',
                    weigh_type AS 'Type', vehicle_number AS 'Vehicle',
                    party_name AS 'Party', material_name AS 'Material',
                    gross_weight AS 'Gross KG', tare_weight AS 'Tare KG',
                    net_weight AS 'Net KG', status AS 'Status',
                    sync_status AS 'Sync'
             FROM weighments
             WHERE branch_id=@bid AND weigh_date=@date
             ORDER BY id DESC",
            New Dictionary(Of String, Object) From {
                {"@bid", SessionManager.BranchId},
                {"@date", today}
            })

        pnlContent.Controls.Add(dgv)
    End Sub

    ' ── Reports ───────────────────────────────────────────────

    Private Sub ShowReports()
        ClearContent()
        pnlContent.Visible = True

        Dim frm As New FrmReports()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Parent = pnlContent
        pnlContent.Controls.Add(frm)
        frm.Show()
    End Sub

    ' ── Vehicles ──────────────────────────────────────────────

    Private Sub ShowMasterManagement()
        ClearContent()
        pnlContent.Visible = True

        Dim frm As New FrmMasterManagement()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Parent = pnlContent
        pnlContent.Controls.Add(frm)
        frm.Show()
    End Sub

    ' ── Attendance ────────────────────────────────────────────

    Private Sub ShowAttendance()
        ClearContent()
        pnlContent.Controls.Add(New Label With {
            .Text = "👥 Attendance — Coming Next",
            .Font = New Font("Segoe UI", 14),
            .ForeColor = Color.FromArgb(122, 140, 170),
            .AutoSize = True,
            .Location = New Point(40, 40)
        })
    End Sub

    ' ── Settings ──────────────────────────────────────────────

    Private Sub ShowSettings()
        ClearContent()
        pnlContent.Visible = True

        Dim frm As New FrmSettings()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Parent = pnlContent
        pnlContent.Controls.Add(frm)
        frm.Show()
    End Sub

    ' ── Close ─────────────────────────────────────────────────

    Private Sub FrmMain_FormClosing(s As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class