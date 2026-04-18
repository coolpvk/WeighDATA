Public Class SessionManager

    ' Current logged in user info
    Public Shared Property UserId As Integer = 0
    Public Shared Property Username As String = ""
    Public Shared Property FullName As String = ""
    Public Shared Property Role As String = ""
    Public Shared Property CompanyId As Integer = 0
    Public Shared Property CompanyName As String = ""
    Public Shared Property CompanyCode As String = ""
    Public Shared Property BranchId As Integer = 0
    Public Shared Property BranchName As String = ""
    Public Shared Property BranchCode As String = ""
    Public Shared Property IsLoggedIn As Boolean = False

    Public Shared Sub SetSession(row As DataRow)
        UserId = Convert.ToInt32(row("id"))
        Username = row("username").ToString()
        Username = row("name").ToString()
        Role = row("role").ToString()
        CompanyId = If(IsDBNull(row("company_id")), 0, Convert.ToInt32(row("company_id")))
        BranchId = If(IsDBNull(row("branch_id")), 0, Convert.ToInt32(row("branch_id")))
        IsLoggedIn = True

        ' Load company + branch names
        LoadCompanyBranch()
    End Sub

    Private Shared Sub LoadCompanyBranch()
        If CompanyId > 0 Then
            Dim dt = DatabaseHelper.ExecuteQuery(
                "SELECT name, code FROM companies WHERE id = @id",
                New Dictionary(Of String, Object) From {{"@id", CompanyId}})
            If dt.Rows.Count > 0 Then
                CompanyName = dt.Rows(0)("name").ToString()
                CompanyCode = dt.Rows(0)("code").ToString()
            End If
        End If

        If BranchId > 0 Then
            Dim dt = DatabaseHelper.ExecuteQuery(
                "SELECT name, code FROM branches WHERE id = @id",
                New Dictionary(Of String, Object) From {{"@id", BranchId}})
            If dt.Rows.Count > 0 Then
                BranchName = dt.Rows(0)("name").ToString()
                BranchCode = dt.Rows(0)("code").ToString()
            End If
        End If
    End Sub

    Public Shared Sub ClearSession()
        UserId = 0
        Username = ""
        Username = ""
        Role = ""
        CompanyId = 0
        CompanyName = ""
        CompanyCode = ""
        BranchId = 0
        BranchName = ""
        BranchCode = ""
        IsLoggedIn = False
    End Sub

    Public Shared ReadOnly Property IsAdmin As Boolean
        Get
            Return Role = "admin"
        End Get
    End Property

    Public Shared ReadOnly Property IsOperator As Boolean
        Get
            Return Role = "operator"
        End Get
    End Property

    ' Slip number generate చేయడానికి
    ' Format: BranchCode + Date + Serial → GT01-20260321-001
    Public Shared Function GenerateSlipNumber() As String
        Dim today = DateTime.Now.ToString("yyyyMMdd")
        Dim prefix = $"{BranchCode}-{today}-"

        Dim lastSlip = DatabaseHelper.ExecuteScalar(
            "SELECT slip_number FROM weighments
             WHERE branch_id = @bid AND slip_number LIKE @prefix
             ORDER BY id DESC LIMIT 1",
            New Dictionary(Of String, Object) From {
                {"@bid", BranchId},
                {"@prefix", prefix & "%"}
            })

        Dim serial = 1
        If lastSlip IsNot Nothing AndAlso lastSlip IsNot DBNull.Value Then
            Dim parts = lastSlip.ToString().Split("-"c)
            If parts.Length >= 3 Then
                Integer.TryParse(parts(parts.Length - 1), serial)
                serial += 1
            End If
        End If

        Return $"{prefix}{serial:D3}"
    End Function

End Class