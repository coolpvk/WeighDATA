<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMasterManagement
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabMaster = New System.Windows.Forms.TabControl()
        Me.tpVehicles = New System.Windows.Forms.TabPage()
        Me.pnlVehInput = New System.Windows.Forms.Panel()
        Me.btnDelVeh = New System.Windows.Forms.Button()
        Me.btnSaveVeh = New System.Windows.Forms.Button()
        Me.txtVehCap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVehOwner = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbVehType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVehNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVehTitle = New System.Windows.Forms.Label()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.tpParties = New System.Windows.Forms.TabPage()
        Me.pnlPartyInput = New System.Windows.Forms.Panel()
        Me.btnDelParty = New System.Windows.Forms.Button()
        Me.btnSaveParty = New System.Windows.Forms.Button()
        Me.txtPartyGST = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPartyAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPartyPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPartyType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPartyName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPartyTitle = New System.Windows.Forms.Label()
        Me.dgvParties = New System.Windows.Forms.DataGridView()
        Me.tpMaterials = New System.Windows.Forms.TabPage()
        Me.pnlMatInput = New System.Windows.Forms.Panel()
        Me.btnDelMat = New System.Windows.Forms.Button()
        Me.btnSaveMat = New System.Windows.Forms.Button()
        Me.cmbMatUnit = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMatName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMatTitle = New System.Windows.Forms.Label()
        Me.dgvMaterials = New System.Windows.Forms.DataGridView()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblMastersTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabMaster.SuspendLayout()
        Me.tpVehicles.SuspendLayout()
        Me.pnlVehInput.SuspendLayout()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpParties.SuspendLayout()
        Me.pnlPartyInput.SuspendLayout()
        CType(Me.dgvParties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMaterials.SuspendLayout()
        Me.pnlMatInput.SuspendLayout()
        CType(Me.dgvMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMaster
        '
        Me.tabMaster.Controls.Add(Me.tpVehicles)
        Me.tabMaster.Controls.Add(Me.tpParties)
        Me.tabMaster.Controls.Add(Me.tpMaterials)
        Me.tabMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMaster.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMaster.Location = New System.Drawing.Point(0, 0)
        Me.tabMaster.Name = "tabMaster"
        Me.tabMaster.SelectedIndex = 0
        Me.tabMaster.Size = New System.Drawing.Size(823, 447)
        Me.tabMaster.TabIndex = 0
        '
        'tpVehicles
        '
        Me.tpVehicles.Controls.Add(Me.pnlVehInput)
        Me.tpVehicles.Controls.Add(Me.dgvVehicles)
        Me.tpVehicles.Location = New System.Drawing.Point(4, 26)
        Me.tpVehicles.Name = "tpVehicles"
        Me.tpVehicles.Size = New System.Drawing.Size(815, 417)
        Me.tpVehicles.TabIndex = 0
        Me.tpVehicles.Text = "🚛 Vehicles"
        '
        'pnlVehInput
        '
        Me.pnlVehInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlVehInput.Controls.Add(Me.btnDelVeh)
        Me.pnlVehInput.Controls.Add(Me.btnSaveVeh)
        Me.pnlVehInput.Controls.Add(Me.txtVehCap)
        Me.pnlVehInput.Controls.Add(Me.Label4)
        Me.pnlVehInput.Controls.Add(Me.txtVehOwner)
        Me.pnlVehInput.Controls.Add(Me.Label3)
        Me.pnlVehInput.Controls.Add(Me.cmbVehType)
        Me.pnlVehInput.Controls.Add(Me.Label2)
        Me.pnlVehInput.Controls.Add(Me.txtVehNo)
        Me.pnlVehInput.Controls.Add(Me.Label1)
        Me.pnlVehInput.Controls.Add(Me.lblVehTitle)
        Me.pnlVehInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlVehInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlVehInput.Name = "pnlVehInput"
        Me.pnlVehInput.Size = New System.Drawing.Size(280, 417)
        Me.pnlVehInput.TabIndex = 0
        '
        'btnDelVeh
        '
        Me.btnDelVeh.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDelVeh.FlatAppearance.BorderSize = 0
        Me.btnDelVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelVeh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelVeh.ForeColor = System.Drawing.Color.White
        Me.btnDelVeh.Location = New System.Drawing.Point(140, 280)
        Me.btnDelVeh.Name = "btnDelVeh"
        Me.btnDelVeh.Size = New System.Drawing.Size(110, 35)
        Me.btnDelVeh.TabIndex = 0
        Me.btnDelVeh.Text = "🗑️ Delete"
        Me.btnDelVeh.UseVisualStyleBackColor = False
        '
        'btnSaveVeh
        '
        Me.btnSaveVeh.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSaveVeh.FlatAppearance.BorderSize = 0
        Me.btnSaveVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveVeh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveVeh.ForeColor = System.Drawing.Color.White
        Me.btnSaveVeh.Location = New System.Drawing.Point(20, 280)
        Me.btnSaveVeh.Name = "btnSaveVeh"
        Me.btnSaveVeh.Size = New System.Drawing.Size(110, 35)
        Me.btnSaveVeh.TabIndex = 1
        Me.btnSaveVeh.Text = "💾 Save"
        Me.btnSaveVeh.UseVisualStyleBackColor = False
        '
        'txtVehCap
        '
        Me.txtVehCap.Location = New System.Drawing.Point(20, 245)
        Me.txtVehCap.Name = "txtVehCap"
        Me.txtVehCap.Size = New System.Drawing.Size(240, 25)
        Me.txtVehCap.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capacity:"
        '
        'txtVehOwner
        '
        Me.txtVehOwner.Location = New System.Drawing.Point(20, 190)
        Me.txtVehOwner.Name = "txtVehOwner"
        Me.txtVehOwner.Size = New System.Drawing.Size(240, 25)
        Me.txtVehOwner.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Owner Name:"
        '
        'cmbVehType
        '
        Me.cmbVehType.Location = New System.Drawing.Point(20, 135)
        Me.cmbVehType.Name = "cmbVehType"
        Me.cmbVehType.Size = New System.Drawing.Size(240, 25)
        Me.cmbVehType.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vehicle Type:"
        '
        'txtVehNo
        '
        Me.txtVehNo.Location = New System.Drawing.Point(20, 80)
        Me.txtVehNo.Name = "txtVehNo"
        Me.txtVehNo.Size = New System.Drawing.Size(240, 25)
        Me.txtVehNo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Vehicle No:"
        '
        'lblVehTitle
        '
        Me.lblVehTitle.AutoSize = True
        Me.lblVehTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblVehTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblVehTitle.Name = "lblVehTitle"
        Me.lblVehTitle.Size = New System.Drawing.Size(111, 21)
        Me.lblVehTitle.TabIndex = 10
        Me.lblVehTitle.Text = "Vehicle Entry"
        '
        'dgvVehicles
        '
        Me.dgvVehicles.Location = New System.Drawing.Point(280, 0)
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.Size = New System.Drawing.Size(520, 450)
        Me.dgvVehicles.TabIndex = 1
        '
        'tpParties
        '
        Me.tpParties.Controls.Add(Me.pnlPartyInput)
        Me.tpParties.Controls.Add(Me.dgvParties)
        Me.tpParties.Location = New System.Drawing.Point(4, 26)
        Me.tpParties.Name = "tpParties"
        Me.tpParties.Size = New System.Drawing.Size(815, 417)
        Me.tpParties.TabIndex = 1
        Me.tpParties.Text = "👥 Parties"
        '
        'pnlPartyInput
        '
        Me.pnlPartyInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlPartyInput.Controls.Add(Me.btnDelParty)
        Me.pnlPartyInput.Controls.Add(Me.btnSaveParty)
        Me.pnlPartyInput.Controls.Add(Me.txtPartyGST)
        Me.pnlPartyInput.Controls.Add(Me.Label9)
        Me.pnlPartyInput.Controls.Add(Me.txtPartyAddress)
        Me.pnlPartyInput.Controls.Add(Me.Label8)
        Me.pnlPartyInput.Controls.Add(Me.txtPartyPhone)
        Me.pnlPartyInput.Controls.Add(Me.Label7)
        Me.pnlPartyInput.Controls.Add(Me.cmbPartyType)
        Me.pnlPartyInput.Controls.Add(Me.Label6)
        Me.pnlPartyInput.Controls.Add(Me.txtPartyName)
        Me.pnlPartyInput.Controls.Add(Me.Label5)
        Me.pnlPartyInput.Controls.Add(Me.lblPartyTitle)
        Me.pnlPartyInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlPartyInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlPartyInput.Name = "pnlPartyInput"
        Me.pnlPartyInput.Size = New System.Drawing.Size(280, 417)
        Me.pnlPartyInput.TabIndex = 0
        '
        'btnDelParty
        '
        Me.btnDelParty.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDelParty.FlatAppearance.BorderSize = 0
        Me.btnDelParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelParty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelParty.ForeColor = System.Drawing.Color.White
        Me.btnDelParty.Location = New System.Drawing.Point(140, 340)
        Me.btnDelParty.Name = "btnDelParty"
        Me.btnDelParty.Size = New System.Drawing.Size(110, 35)
        Me.btnDelParty.TabIndex = 0
        Me.btnDelParty.Text = "🗑️ Delete"
        Me.btnDelParty.UseVisualStyleBackColor = False
        '
        'btnSaveParty
        '
        Me.btnSaveParty.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSaveParty.FlatAppearance.BorderSize = 0
        Me.btnSaveParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveParty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveParty.ForeColor = System.Drawing.Color.White
        Me.btnSaveParty.Location = New System.Drawing.Point(20, 340)
        Me.btnSaveParty.Name = "btnSaveParty"
        Me.btnSaveParty.Size = New System.Drawing.Size(110, 35)
        Me.btnSaveParty.TabIndex = 1
        Me.btnSaveParty.Text = "💾 Save"
        Me.btnSaveParty.UseVisualStyleBackColor = False
        '
        'txtPartyGST
        '
        Me.txtPartyGST.Location = New System.Drawing.Point(20, 300)
        Me.txtPartyGST.Name = "txtPartyGST"
        Me.txtPartyGST.Size = New System.Drawing.Size(240, 25)
        Me.txtPartyGST.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(20, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "GST No:"
        '
        'txtPartyAddress
        '
        Me.txtPartyAddress.Location = New System.Drawing.Point(20, 245)
        Me.txtPartyAddress.Name = "txtPartyAddress"
        Me.txtPartyAddress.Size = New System.Drawing.Size(240, 25)
        Me.txtPartyAddress.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Address:"
        '
        'txtPartyPhone
        '
        Me.txtPartyPhone.Location = New System.Drawing.Point(20, 190)
        Me.txtPartyPhone.Name = "txtPartyPhone"
        Me.txtPartyPhone.Size = New System.Drawing.Size(240, 25)
        Me.txtPartyPhone.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone:"
        '
        'cmbPartyType
        '
        Me.cmbPartyType.Location = New System.Drawing.Point(20, 135)
        Me.cmbPartyType.Name = "cmbPartyType"
        Me.cmbPartyType.Size = New System.Drawing.Size(240, 25)
        Me.cmbPartyType.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Party Type:"
        '
        'txtPartyName
        '
        Me.txtPartyName.Location = New System.Drawing.Point(20, 80)
        Me.txtPartyName.Name = "txtPartyName"
        Me.txtPartyName.Size = New System.Drawing.Size(240, 25)
        Me.txtPartyName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Party Name:"
        '
        'lblPartyTitle
        '
        Me.lblPartyTitle.AutoSize = True
        Me.lblPartyTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPartyTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblPartyTitle.Name = "lblPartyTitle"
        Me.lblPartyTitle.Size = New System.Drawing.Size(95, 21)
        Me.lblPartyTitle.TabIndex = 12
        Me.lblPartyTitle.Text = "Party Entry"
        '
        'dgvParties
        '
        Me.dgvParties.Location = New System.Drawing.Point(280, 0)
        Me.dgvParties.Name = "dgvParties"
        Me.dgvParties.Size = New System.Drawing.Size(520, 450)
        Me.dgvParties.TabIndex = 1
        '
        'tpMaterials
        '
        Me.tpMaterials.Controls.Add(Me.pnlMatInput)
        Me.tpMaterials.Controls.Add(Me.dgvMaterials)
        Me.tpMaterials.Location = New System.Drawing.Point(4, 26)
        Me.tpMaterials.Name = "tpMaterials"
        Me.tpMaterials.Size = New System.Drawing.Size(815, 417)
        Me.tpMaterials.TabIndex = 2
        Me.tpMaterials.Text = "📦 Materials"
        '
        'pnlMatInput
        '
        Me.pnlMatInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlMatInput.Controls.Add(Me.btnDelMat)
        Me.pnlMatInput.Controls.Add(Me.btnSaveMat)
        Me.pnlMatInput.Controls.Add(Me.cmbMatUnit)
        Me.pnlMatInput.Controls.Add(Me.Label11)
        Me.pnlMatInput.Controls.Add(Me.txtMatName)
        Me.pnlMatInput.Controls.Add(Me.Label10)
        Me.pnlMatInput.Controls.Add(Me.lblMatTitle)
        Me.pnlMatInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMatInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlMatInput.Name = "pnlMatInput"
        Me.pnlMatInput.Size = New System.Drawing.Size(280, 417)
        Me.pnlMatInput.TabIndex = 0
        '
        'btnDelMat
        '
        Me.btnDelMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDelMat.FlatAppearance.BorderSize = 0
        Me.btnDelMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelMat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelMat.ForeColor = System.Drawing.Color.White
        Me.btnDelMat.Location = New System.Drawing.Point(140, 170)
        Me.btnDelMat.Name = "btnDelMat"
        Me.btnDelMat.Size = New System.Drawing.Size(110, 35)
        Me.btnDelMat.TabIndex = 0
        Me.btnDelMat.Text = "🗑️ Delete"
        Me.btnDelMat.UseVisualStyleBackColor = False
        '
        'btnSaveMat
        '
        Me.btnSaveMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSaveMat.FlatAppearance.BorderSize = 0
        Me.btnSaveMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveMat.ForeColor = System.Drawing.Color.White
        Me.btnSaveMat.Location = New System.Drawing.Point(20, 170)
        Me.btnSaveMat.Name = "btnSaveMat"
        Me.btnSaveMat.Size = New System.Drawing.Size(110, 35)
        Me.btnSaveMat.TabIndex = 1
        Me.btnSaveMat.Text = "💾 Save"
        Me.btnSaveMat.UseVisualStyleBackColor = False
        '
        'cmbMatUnit
        '
        Me.cmbMatUnit.Location = New System.Drawing.Point(20, 135)
        Me.cmbMatUnit.Name = "cmbMatUnit"
        Me.cmbMatUnit.Size = New System.Drawing.Size(240, 25)
        Me.cmbMatUnit.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(20, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Unit (MT/KG):"
        '
        'txtMatName
        '
        Me.txtMatName.Location = New System.Drawing.Point(20, 80)
        Me.txtMatName.Name = "txtMatName"
        Me.txtMatName.Size = New System.Drawing.Size(240, 25)
        Me.txtMatName.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(20, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Material Name:"
        '
        'lblMatTitle
        '
        Me.lblMatTitle.AutoSize = True
        Me.lblMatTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMatTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblMatTitle.Name = "lblMatTitle"
        Me.lblMatTitle.Size = New System.Drawing.Size(119, 21)
        Me.lblMatTitle.TabIndex = 6
        Me.lblMatTitle.Text = "Material Entry"
        '
        'dgvMaterials
        '
        Me.dgvMaterials.Location = New System.Drawing.Point(280, 0)
        Me.dgvMaterials.Name = "dgvMaterials"
        Me.dgvMaterials.Size = New System.Drawing.Size(520, 450)
        Me.dgvMaterials.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblMastersTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(823, 52)
        Me.pnlHeader.TabIndex = 1
        '
        'lblMastersTitle
        '
        Me.lblMastersTitle.AutoSize = True
        Me.lblMastersTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMastersTitle.ForeColor = System.Drawing.Color.White
        Me.lblMastersTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblMastersTitle.Name = "lblMastersTitle"
        Me.lblMastersTitle.Size = New System.Drawing.Size(236, 25)
        Me.lblMastersTitle.TabIndex = 0
        Me.lblMastersTitle.Text = "⚙️  Master Managements"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tabMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 447)
        Me.Panel1.TabIndex = 2
        '
        'FrmMasterManagement
        '
        Me.ClientSize = New System.Drawing.Size(823, 499)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "FrmMasterManagement"
        Me.Text = "Master Management"
        Me.tabMaster.ResumeLayout(False)
        Me.tpVehicles.ResumeLayout(False)
        Me.pnlVehInput.ResumeLayout(False)
        Me.pnlVehInput.PerformLayout()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpParties.ResumeLayout(False)
        Me.pnlPartyInput.ResumeLayout(False)
        Me.pnlPartyInput.PerformLayout()
        CType(Me.dgvParties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMaterials.ResumeLayout(False)
        Me.pnlMatInput.ResumeLayout(False)
        Me.pnlMatInput.PerformLayout()
        CType(Me.dgvMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMaster As TabControl
    Friend WithEvents tpVehicles As TabPage
    Friend WithEvents pnlVehInput As Panel
    Friend WithEvents lblVehTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVehNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbVehType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVehOwner As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVehCap As TextBox
    Friend WithEvents btnSaveVeh As Button
    Friend WithEvents btnDelVeh As Button
    Friend WithEvents dgvVehicles As DataGridView
    Friend WithEvents tpParties As TabPage
    Friend WithEvents pnlPartyInput As Panel
    Friend WithEvents lblPartyTitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPartyName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPartyType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPartyPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPartyAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPartyGST As TextBox
    Friend WithEvents btnSaveParty As Button
    Friend WithEvents btnDelParty As Button
    Friend WithEvents dgvParties As DataGridView
    Friend WithEvents tpMaterials As TabPage
    Friend WithEvents pnlMatInput As Panel
    Friend WithEvents lblMatTitle As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMatName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbMatUnit As ComboBox
    Friend WithEvents btnSaveMat As Button
    Friend WithEvents btnDelMat As Button
    Friend WithEvents dgvMaterials As DataGridView
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblMastersTitle As Label
    Friend WithEvents Panel1 As Panel
End Class
