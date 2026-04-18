Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseHelper.InitializeDatabase()
        SetupDefaultData()
        LoadCompanies()
    End Sub

    Private Sub LoadCompanies()
        cmbCompany.Items.Clear()
        Dim dt = DatabaseHelper.ExecuteQuery(
        "SELECT id, name, code FROM companies WHERE status=1 ORDER BY name")
        For Each row As DataRow In dt.Rows
            cmbCompany.Items.Add(New ComboItem(
            Convert.ToInt32(row("id")),
            $"{row("name")} ({row("code")})"))
        Next
        If cmbCompany.Items.Count > 0 Then cmbCompany.SelectedIndex = 0
    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cmbCompany.SelectedIndexChanged
        cmbBranch.Items.Clear()
        If cmbCompany.SelectedItem Is Nothing Then Return
        Dim compId = DirectCast(cmbCompany.SelectedItem, ComboItem).Id
        Dim dt = DatabaseHelper.ExecuteQuery(
        "SELECT id, name, code FROM branches WHERE company_id=@cid AND status=1",
        New Dictionary(Of String, Object) From {{"@cid", compId}})
        For Each row As DataRow In dt.Rows
            cmbBranch.Items.Add(New ComboItem(
            Convert.ToInt32(row("id")),
            $"{row("name")} ({row("code")})"))
        Next
        If cmbBranch.Items.Count > 0 Then cmbBranch.SelectedIndex = 0
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DoLogin()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then DoLogin()
    End Sub

    Private Sub DoLogin()
        lblError.Visible = False

        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" Then
            ShowError("Username and password required")
            Return
        End If

        If cmbCompany.SelectedItem Is Nothing Then
            ShowError("Company select చేయండి")
            Return
        End If

        If cmbBranch.SelectedItem Is Nothing Then
            ShowError("Branch select చేయండి")
            Return
        End If

        Dim dt = DatabaseHelper.ExecuteQuery(
        "SELECT * FROM users WHERE username=@u AND password=@p AND status=1",
        New Dictionary(Of String, Object) From {
        {"@u", txtUsername.Text.Trim()},
        {"@p", txtPassword.Text}
        })

        If dt.Rows.Count = 0 Then
            ShowError("Invalid username or password")
            Return
        End If

        ' Set Session
        Dim row = dt.Rows(0)
        Dim compId = DirectCast(cmbCompany.SelectedItem, ComboItem).Id
        Dim branchId = DirectCast(cmbBranch.SelectedItem, ComboItem).Id

        SessionManager.UserId = Convert.ToInt32(row("id"))
        SessionManager.Username = row("username").ToString()
        SessionManager.FullName = row("name").ToString()
        SessionManager.Role = row("role").ToString()
        SessionManager.CompanyId = compId
        SessionManager.BranchId = branchId
        SessionManager.IsLoggedIn = True

        ' Load company/branch names
        Dim ct = DatabaseHelper.ExecuteQuery(
        "SELECT name, code FROM companies WHERE id=@id",
        New Dictionary(Of String, Object) From {{"@id", compId}})
        If ct.Rows.Count > 0 Then
            SessionManager.CompanyName = ct.Rows(0)("name").ToString()
            SessionManager.CompanyCode = ct.Rows(0)("code").ToString()
        End If

        Dim bt = DatabaseHelper.ExecuteQuery(
        "SELECT name, code FROM branches WHERE id=@id",
        New Dictionary(Of String, Object) From {{"@id", branchId}})
        If bt.Rows.Count > 0 Then
            SessionManager.BranchName = bt.Rows(0)("name").ToString()
            SessionManager.BranchCode = bt.Rows(0)("code").ToString()
        End If

        ' Open Main Form
        Dim frm As New FrmMain()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowError(msg As String)
        lblError.Text = msg
        lblError.Visible = True
    End Sub

    Private Sub SetupDefaultData()
        Dim count = Convert.ToInt32(
        DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM companies"))
        If count = 0 Then
            DatabaseHelper.ExecuteNonQuery(
            "INSERT INTO companies (name, code) VALUES ('My Company', 'MC')")
            DatabaseHelper.ExecuteNonQuery(
            "INSERT INTO branches (company_id, name, code) VALUES (1, 'Main Branch', 'MB01')")
        End If
    End Sub

End Class