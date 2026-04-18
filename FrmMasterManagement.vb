Public Class FrmMasterManagement

    ' ఎడిటింగ్ కోసం సెలెక్ట్ అయిన IDలను స్టోర్ చేయడానికి వేరియబుల్స్
    Private selectedVehId As Integer = 0
    Private selectedPartyId As Integer = 0
    Private selectedMatId As Integer = 0

    Private Sub FrmMasterManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGridStyles()
        FillCombos()
        LoadAllData()
    End Sub

    ' --- Grid Styles ---
    Private Sub SetupGridStyles()
        Dim grids() As DataGridView = {dgvVehicles, dgvParties, dgvMaterials}
        For Each dg In grids
            dg.ReadOnly = True
            dg.AllowUserToAddRows = False
            dg.RowHeadersVisible = False
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dg.BackgroundColor = Color.White
            dg.BorderStyle = BorderStyle.None
        Next
    End Sub

    ' --- Fill Dropdowns ---
    Private Sub FillCombos()
        cmbVehType.Items.Clear()
        cmbVehType.Items.AddRange({"Own", "Third Party", "Contract"})
        If cmbVehType.Items.Count > 0 Then cmbVehType.SelectedIndex = 0

        cmbPartyType.Items.Clear()
        cmbPartyType.Items.AddRange({"Supplier", "Customer", "Both"})
        If cmbPartyType.Items.Count > 0 Then cmbPartyType.SelectedIndex = 2

        cmbMatUnit.Items.Clear()
        cmbMatUnit.Items.AddRange({"MT", "KG", "Sacks", "Cubic Meter"})
        If cmbMatUnit.Items.Count > 0 Then cmbMatUnit.SelectedIndex = 0
    End Sub

    ' --- Load Data ---
    Private Sub LoadAllData()
        LoadVehicles()
        LoadParties()
        LoadMaterials()
    End Sub

    Private Sub LoadVehicles()
        dgvVehicles.DataSource = DatabaseHelper.ExecuteQuery("SELECT id, vehicle_number, type, owner_name, capacity FROM vehicles WHERE status=1 ORDER BY vehicle_number")
    End Sub

    Private Sub LoadParties()
        dgvParties.DataSource = DatabaseHelper.ExecuteQuery("SELECT id, name, type, phone, address, gst_number FROM parties WHERE status=1 ORDER BY name")
    End Sub

    Private Sub LoadMaterials()
        dgvMaterials.DataSource = DatabaseHelper.ExecuteQuery("SELECT id, name, unit FROM materials WHERE status=1 ORDER BY name")
    End Sub

    ' ── EDIT LOGIC (Grid Click) ──────────────────────────────────

    ' వాహనం ఎంచుకున్నప్పుడు వివరాలను లోడ్ చేయడం
    ' ── EDIT LOGIC (Grid Click) ──────────────────────────────────

    ' వాహనం ఎంచుకున్నప్పుడు వివరాలను లోడ్ చేయడం
    Private Sub dgvVehicles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVehicles.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvVehicles.Rows(e.RowIndex)

        ' CORRECTED: Using .Cells("column").Value
        selectedVehId = Convert.ToInt32(row.Cells("id").Value)
        txtVehNo.Text = row.Cells("vehicle_number").Value.ToString()
        cmbVehType.Text = row.Cells("type").Value.ToString()
        txtVehOwner.Text = row.Cells("owner_name").Value.ToString()
        txtVehCap.Text = row.Cells("capacity").Value.ToString()

        btnSaveVeh.Text = "🔄 Update"
        btnSaveVeh.BackColor = Color.FromArgb(34, 139, 34)
    End Sub

    ' పార్టీ ఎంచుకున్నప్పుడు వివరాలను లోడ్ చేయడం
    Private Sub dgvParties_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParties.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvParties.Rows(e.RowIndex)

        ' CORRECTED: Using .Cells("column").Value
        selectedPartyId = Convert.ToInt32(row.Cells("id").Value)
        txtPartyName.Text = row.Cells("name").Value.ToString()
        cmbPartyType.Text = row.Cells("type").Value.ToString()
        txtPartyPhone.Text = row.Cells("phone").Value.ToString()
        txtPartyAddress.Text = row.Cells("address").Value.ToString()
        txtPartyGST.Text = row.Cells("gst_number").Value.ToString()

        btnSaveParty.Text = "🔄 Update"
        btnSaveParty.BackColor = Color.FromArgb(34, 139, 34)
    End Sub

    ' మెటీరియల్ ఎంచుకున్నప్పుడు వివరాలను లోడ్ చేయడం
    Private Sub dgvMaterials_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterials.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvMaterials.Rows(e.RowIndex)

        ' CORRECTED: Using .Cells("column").Value
        selectedMatId = Convert.ToInt32(row.Cells("id").Value)
        txtMatName.Text = row.Cells("name").Value.ToString()
        cmbMatUnit.Text = row.Cells("unit").Value.ToString()

        btnSaveMat.Text = "🔄 Update"
        btnSaveMat.BackColor = Color.FromArgb(34, 139, 34)
    End Sub


    ' ── SAVE & UPDATE LOGIC ──────────────────────────────────────

    ' --- Save/Update Vehicle ---
    Private Sub btnSaveVeh_Click(sender As Object, e As EventArgs) Handles btnSaveVeh.Click
        If txtVehNo.Text.Trim() = "" Then
            MsgBox("Vehicle Number తప్పనిసరి!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If selectedVehId > 0 Then
            ' UPDATE Logic
            sql = "UPDATE vehicles SET vehicle_number=@vn, type=@type, owner_name=@owner, capacity=@cap WHERE id=@id"
            params.Add("@id", selectedVehId)
        Else
            ' INSERT Logic
            sql = "INSERT INTO vehicles (vehicle_number, type, owner_name, capacity, company_id) VALUES (@vn, @type, @owner, @cap, @cid)"
            params.Add("@cid", SessionManager.CompanyId)
        End If

        params.Add("@vn", txtVehNo.Text.ToUpper())
        params.Add("@type", cmbVehType.Text)
        params.Add("@owner", txtVehOwner.Text)
        params.Add("@cap", Val(txtVehCap.Text))

        DatabaseHelper.ExecuteNonQuery(sql, params)
        LoadVehicles()
        ClearVehFields()
    End Sub

    ' --- Save/Update Party ---
    Private Sub btnSaveParty_Click(sender As Object, e As EventArgs) Handles btnSaveParty.Click
        If txtPartyName.Text.Trim() = "" Then
            MsgBox("Party Name తప్పనిసరి!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If selectedPartyId > 0 Then
            sql = "UPDATE parties SET name=@name, type=@type, phone=@ph, address=@addr, gst_number=@gst WHERE id=@id"
            params.Add("@id", selectedPartyId)
        Else
            sql = "INSERT INTO parties (name, type, phone, address, gst_number, company_id) VALUES (@name, @type, @ph, @addr, @gst, @cid)"
            params.Add("@cid", SessionManager.CompanyId)
        End If

        params.Add("@name", txtPartyName.Text)
        params.Add("@type", cmbPartyType.Text)
        params.Add("@ph", txtPartyPhone.Text)
        params.Add("@addr", txtPartyAddress.Text)
        params.Add("@gst", txtPartyGST.Text)

        DatabaseHelper.ExecuteNonQuery(sql, params)
        LoadParties()
        ClearPartyFields()
    End Sub

    ' --- Save/Update Material ---
    Private Sub btnSaveMat_Click(sender As Object, e As EventArgs) Handles btnSaveMat.Click
        If txtMatName.Text.Trim() = "" Then
            MsgBox("Material Name తప్పనిసరి!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim sql As String
        Dim params As New Dictionary(Of String, Object)

        If selectedMatId > 0 Then
            sql = "UPDATE materials SET name=@name, unit=@unit WHERE id=@id"
            params.Add("@id", selectedMatId)
        Else
            sql = "INSERT INTO materials (name, unit, company_id) VALUES (@name, @unit, @cid)"
            params.Add("@cid", SessionManager.CompanyId)
        End If

        params.Add("@name", txtMatName.Text)
        params.Add("@unit", cmbMatUnit.Text)

        DatabaseHelper.ExecuteNonQuery(sql, params)
        LoadMaterials()
        ClearMatFields()
    End Sub

    ' ── DELETE LOGIC ─────────────────────────────────────────

    Private Sub btnDelVeh_Click(sender As Object, e As EventArgs) Handles btnDelVeh.Click
        If dgvVehicles.CurrentRow Is Nothing Then Return
        Dim id = dgvVehicles.CurrentRow.Cells("id").Value
        If MessageBox.Show("ఈ వాహనాన్ని తొలగించాలా?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DatabaseHelper.ExecuteNonQuery("DELETE FROM vehicles WHERE id=@id", New Dictionary(Of String, Object) From {{"@id", id}})
            LoadVehicles()
            ClearVehFields()
        End If
    End Sub

    Private Sub btnDelParty_Click(sender As Object, e As EventArgs) Handles btnDelParty.Click
        If dgvParties.CurrentRow Is Nothing Then Return
        Dim id = dgvParties.CurrentRow.Cells("id").Value
        If MessageBox.Show("ఈ పార్టీని తొలగించాలా?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DatabaseHelper.ExecuteNonQuery("DELETE FROM parties WHERE id=@id", New Dictionary(Of String, Object) From {{"@id", id}})
            LoadParties()
            ClearPartyFields()
        End If
    End Sub

    Private Sub btnDelMat_Click(sender As Object, e As EventArgs) Handles btnDelMat.Click
        If dgvMaterials.CurrentRow Is Nothing Then Return
        Dim id = dgvMaterials.CurrentRow.Cells("id").Value
        If MessageBox.Show("ఈ మెటీరియల్‌ను తొలగించాలా?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DatabaseHelper.ExecuteNonQuery("DELETE FROM materials WHERE id=@id", New Dictionary(Of String, Object) From {{"@id", id}})
            LoadMaterials()
            ClearMatFields()
        End If
    End Sub

    ' ── HELPERS ──────────────────────────────────────────────

    Private Sub ClearVehFields()
        selectedVehId = 0
        txtVehNo.Clear() : txtVehOwner.Clear() : txtVehCap.Clear()
        btnSaveVeh.Text = "💾 Save"
        btnSaveVeh.BackColor = Color.FromArgb(47, 126, 245)
    End Sub

    Private Sub ClearPartyFields()
        selectedPartyId = 0
        txtPartyName.Clear() : txtPartyPhone.Clear() : txtPartyAddress.Clear() : txtPartyGST.Clear()
        btnSaveParty.Text = "💾 Save"
        btnSaveParty.BackColor = Color.FromArgb(47, 126, 245)
    End Sub

    Private Sub ClearMatFields()
        selectedMatId = 0
        txtMatName.Clear()
        btnSaveMat.Text = "💾 Save"
        btnSaveMat.BackColor = Color.FromArgb(47, 126, 245)
    End Sub

End Class
