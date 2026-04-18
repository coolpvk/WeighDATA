<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeighment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblStable = New System.Windows.Forms.Label()
        Me.pnlWeightDisplay = New System.Windows.Forms.Panel()
        Me.lblLiveWeight = New System.Windows.Forms.Label()
        Me.lblWTitle = New System.Windows.Forms.Label()
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.ckbPrintDuplicateTicket = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtNetWt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDeductionWt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbVehicleType = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ckbSecondWt = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlGrossSection = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFinalNetWt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl2ndWtDT = New System.Windows.Forms.Label()
        Me.lbl1stWtDT = New System.Windows.Forms.Label()
        Me.txt2ndWt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt1stWt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPayMode = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubParty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbVehicle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbWType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dgvPending = New System.Windows.Forms.DataGridView()
        Me.vView4 = New LibVLCSharp.WinForms.VideoView()
        Me.vView2 = New LibVLCSharp.WinForms.VideoView()
        Me.vView3 = New LibVLCSharp.WinForms.VideoView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tmrCameras = New System.Windows.Forms.Timer(Me.components)
        Me.vView1 = New LibVLCSharp.WinForms.VideoView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlWeightDisplay.SuspendLayout()
        Me.pnlEntry.SuspendLayout()
        Me.pnlGrossSection.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblStable)
        Me.pnlHeader.Controls.Add(Me.pnlWeightDisplay)
        Me.pnlHeader.Controls.Add(Me.lblWTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 56)
        Me.pnlHeader.TabIndex = 0
        '
        'lblStable
        '
        Me.lblStable.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStable.AutoSize = True
        Me.lblStable.ForeColor = System.Drawing.Color.White
        Me.lblStable.Location = New System.Drawing.Point(815, 18)
        Me.lblStable.Name = "lblStable"
        Me.lblStable.Size = New System.Drawing.Size(44, 17)
        Me.lblStable.TabIndex = 2
        Me.lblStable.Text = "Stable"
        '
        'pnlWeightDisplay
        '
        Me.pnlWeightDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWeightDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlWeightDisplay.Controls.Add(Me.lblLiveWeight)
        Me.pnlWeightDisplay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlWeightDisplay.Location = New System.Drawing.Point(891, 3)
        Me.pnlWeightDisplay.Name = "pnlWeightDisplay"
        Me.pnlWeightDisplay.Size = New System.Drawing.Size(220, 50)
        Me.pnlWeightDisplay.TabIndex = 1
        '
        'lblLiveWeight
        '
        Me.lblLiveWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLiveWeight.AutoSize = True
        Me.lblLiveWeight.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiveWeight.ForeColor = System.Drawing.Color.Lime
        Me.lblLiveWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLiveWeight.Location = New System.Drawing.Point(32, 0)
        Me.lblLiveWeight.Name = "lblLiveWeight"
        Me.lblLiveWeight.Size = New System.Drawing.Size(188, 51)
        Me.lblLiveWeight.TabIndex = 0
        Me.lblLiveWeight.Text = "0.000 MT"
        Me.lblLiveWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWTitle
        '
        Me.lblWTitle.AutoSize = True
        Me.lblWTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblWTitle.ForeColor = System.Drawing.Color.White
        Me.lblWTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblWTitle.Name = "lblWTitle"
        Me.lblWTitle.Size = New System.Drawing.Size(146, 25)
        Me.lblWTitle.TabIndex = 0
        Me.lblWTitle.Text = "⚖️  Weighment"
        '
        'pnlEntry
        '
        Me.pnlEntry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlEntry.Controls.Add(Me.ckbPrintDuplicateTicket)
        Me.pnlEntry.Controls.Add(Me.Panel4)
        Me.pnlEntry.Controls.Add(Me.Panel3)
        Me.pnlEntry.Controls.Add(Me.Label14)
        Me.pnlEntry.Controls.Add(Me.txtAmount)
        Me.pnlEntry.Controls.Add(Me.txtNetWt)
        Me.pnlEntry.Controls.Add(Me.Label19)
        Me.pnlEntry.Controls.Add(Me.txtRate)
        Me.pnlEntry.Controls.Add(Me.Label18)
        Me.pnlEntry.Controls.Add(Me.txtDeductionWt)
        Me.pnlEntry.Controls.Add(Me.Label16)
        Me.pnlEntry.Controls.Add(Me.cmbVehicleType)
        Me.pnlEntry.Controls.Add(Me.Label15)
        Me.pnlEntry.Controls.Add(Me.ckbSecondWt)
        Me.pnlEntry.Controls.Add(Me.btnClear)
        Me.pnlEntry.Controls.Add(Me.btnPrint)
        Me.pnlEntry.Controls.Add(Me.btnSave)
        Me.pnlEntry.Controls.Add(Me.pnlGrossSection)
        Me.pnlEntry.Controls.Add(Me.cmbPayMode)
        Me.pnlEntry.Controls.Add(Me.Label10)
        Me.pnlEntry.Controls.Add(Me.txtCharges)
        Me.pnlEntry.Controls.Add(Me.Label9)
        Me.pnlEntry.Controls.Add(Me.cmbMaterial)
        Me.pnlEntry.Controls.Add(Me.Label8)
        Me.pnlEntry.Controls.Add(Me.txtSubParty)
        Me.pnlEntry.Controls.Add(Me.Label7)
        Me.pnlEntry.Controls.Add(Me.txtMobile)
        Me.pnlEntry.Controls.Add(Me.Label6)
        Me.pnlEntry.Controls.Add(Me.cmbCustomer)
        Me.pnlEntry.Controls.Add(Me.Label5)
        Me.pnlEntry.Controls.Add(Me.cmbVehicle)
        Me.pnlEntry.Controls.Add(Me.Label4)
        Me.pnlEntry.Controls.Add(Me.cmbWType)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.txtSerialNo)
        Me.pnlEntry.Controls.Add(Me.Label2)
        Me.pnlEntry.Controls.Add(Me.Panel1)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.ForeColor = System.Drawing.Color.White
        Me.pnlEntry.Location = New System.Drawing.Point(12, 68)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(534, 580)
        Me.pnlEntry.TabIndex = 1
        '
        'ckbPrintDuplicateTicket
        '
        Me.ckbPrintDuplicateTicket.AutoSize = True
        Me.ckbPrintDuplicateTicket.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ckbPrintDuplicateTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ckbPrintDuplicateTicket.Location = New System.Drawing.Point(233, 7)
        Me.ckbPrintDuplicateTicket.Name = "ckbPrintDuplicateTicket"
        Me.ckbPrintDuplicateTicket.Size = New System.Drawing.Size(147, 19)
        Me.ckbPrintDuplicateTicket.TabIndex = 33
        Me.ckbPrintDuplicateTicket.Text = "Print Duplicate Ticket"
        Me.ckbPrintDuplicateTicket.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(13, 410)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(501, 2)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(16, 285)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(501, 2)
        Me.Panel3.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(214, 418)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 21)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Net WEIGHT (KG)"
        Me.Label14.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmount.Location = New System.Drawing.Point(372, 254)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(145, 25)
        Me.txtAmount.TabIndex = 17
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetWt
        '
        Me.txtNetWt.BackColor = System.Drawing.Color.Black
        Me.txtNetWt.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.txtNetWt.ForeColor = System.Drawing.Color.Yellow
        Me.txtNetWt.Location = New System.Drawing.Point(350, 418)
        Me.txtNetWt.Name = "txtNetWt"
        Me.txtNetWt.ReadOnly = True
        Me.txtNetWt.Size = New System.Drawing.Size(166, 54)
        Me.txtNetWt.TabIndex = 20
        Me.txtNetWt.Text = "0"
        Me.txtNetWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(376, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 15)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Amount"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRate.Location = New System.Drawing.Point(218, 254)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(145, 25)
        Me.txtRate.TabIndex = 9
        Me.txtRate.Text = "0.00"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(215, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Rate"
        '
        'txtDeductionWt
        '
        Me.txtDeductionWt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDeductionWt.Location = New System.Drawing.Point(16, 436)
        Me.txtDeductionWt.Name = "txtDeductionWt"
        Me.txtDeductionWt.Size = New System.Drawing.Size(157, 25)
        Me.txtDeductionWt.TabIndex = 10
        Me.txtDeductionWt.Text = "0"
        Me.txtDeductionWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(16, 418)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Deduction Weight"
        '
        'cmbVehicleType
        '
        Me.cmbVehicleType.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbVehicleType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbVehicleType.FormattingEnabled = True
        Me.cmbVehicleType.Location = New System.Drawing.Point(288, 113)
        Me.cmbVehicleType.Name = "cmbVehicleType"
        Me.cmbVehicleType.Size = New System.Drawing.Size(229, 25)
        Me.cmbVehicleType.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(291, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 15)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Vehicle Type"
        '
        'ckbSecondWt
        '
        Me.ckbSecondWt.AutoSize = True
        Me.ckbSecondWt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ckbSecondWt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ckbSecondWt.Location = New System.Drawing.Point(382, 7)
        Me.ckbSecondWt.Name = "ckbSecondWt"
        Me.ckbSecondWt.Size = New System.Drawing.Size(134, 19)
        Me.ckbSecondWt.TabIndex = 16
        Me.ckbSecondWt.Text = "Second weighment"
        Me.ckbSecondWt.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(155, 533)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 44)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "🔄  Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(394, 533)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 44)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "🖨️  Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(10, 533)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 44)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "💾  Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pnlGrossSection
        '
        Me.pnlGrossSection.Controls.Add(Me.Panel2)
        Me.pnlGrossSection.Controls.Add(Me.lbl2ndWtDT)
        Me.pnlGrossSection.Controls.Add(Me.lbl1stWtDT)
        Me.pnlGrossSection.Controls.Add(Me.txt2ndWt)
        Me.pnlGrossSection.Controls.Add(Me.Label13)
        Me.pnlGrossSection.Controls.Add(Me.txt1stWt)
        Me.pnlGrossSection.Controls.Add(Me.Label11)
        Me.pnlGrossSection.Location = New System.Drawing.Point(10, 295)
        Me.pnlGrossSection.Name = "pnlGrossSection"
        Me.pnlGrossSection.Size = New System.Drawing.Size(514, 112)
        Me.pnlGrossSection.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtFinalNetWt)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(319, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 100)
        Me.Panel2.TabIndex = 28
        '
        'txtFinalNetWt
        '
        Me.txtFinalNetWt.BackColor = System.Drawing.Color.Black
        Me.txtFinalNetWt.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.txtFinalNetWt.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtFinalNetWt.Location = New System.Drawing.Point(11, 37)
        Me.txtFinalNetWt.Name = "txtFinalNetWt"
        Me.txtFinalNetWt.ReadOnly = True
        Me.txtFinalNetWt.Size = New System.Drawing.Size(166, 54)
        Me.txtFinalNetWt.TabIndex = 21
        Me.txtFinalNetWt.Text = "0"
        Me.txtFinalNetWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(182, 21)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Final Net WEIGHT (KG)"
        '
        'lbl2ndWtDT
        '
        Me.lbl2ndWtDT.AutoSize = True
        Me.lbl2ndWtDT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl2ndWtDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lbl2ndWtDT.Location = New System.Drawing.Point(169, 86)
        Me.lbl2ndWtDT.Name = "lbl2ndWtDT"
        Me.lbl2ndWtDT.Size = New System.Drawing.Size(144, 15)
        Me.lbl2ndWtDT.TabIndex = 27
        Me.lbl2ndWtDT.Text = "11.01.2025  03:15:24 PM"
        '
        'lbl1stWtDT
        '
        Me.lbl1stWtDT.AutoSize = True
        Me.lbl1stWtDT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl1stWtDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lbl1stWtDT.Location = New System.Drawing.Point(169, 34)
        Me.lbl1stWtDT.Name = "lbl1stWtDT"
        Me.lbl1stWtDT.Size = New System.Drawing.Size(144, 15)
        Me.lbl1stWtDT.TabIndex = 26
        Me.lbl1stWtDT.Text = "11.01.2025  03:15:24 PM"
        '
        'txt2ndWt
        '
        Me.txt2ndWt.BackColor = System.Drawing.Color.White
        Me.txt2ndWt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txt2ndWt.Location = New System.Drawing.Point(10, 75)
        Me.txt2ndWt.Name = "txt2ndWt"
        Me.txt2ndWt.ReadOnly = True
        Me.txt2ndWt.Size = New System.Drawing.Size(153, 31)
        Me.txt2ndWt.TabIndex = 19
        Me.txt2ndWt.Text = "0"
        Me.txt2ndWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "2nd WEIGHT (KG)"
        '
        'txt1stWt
        '
        Me.txt1stWt.BackColor = System.Drawing.Color.White
        Me.txt1stWt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txt1stWt.Location = New System.Drawing.Point(10, 23)
        Me.txt1stWt.Name = "txt1stWt"
        Me.txt1stWt.ReadOnly = True
        Me.txt1stWt.Size = New System.Drawing.Size(153, 31)
        Me.txt1stWt.TabIndex = 18
        Me.txt1stWt.Text = "0"
        Me.txt1stWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "1st WEIGHT (KG)"
        '
        'cmbPayMode
        '
        Me.cmbPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPayMode.FormattingEnabled = True
        Me.cmbPayMode.Location = New System.Drawing.Point(16, 490)
        Me.cmbPayMode.Name = "cmbPayMode"
        Me.cmbPayMode.Size = New System.Drawing.Size(157, 25)
        Me.cmbPayMode.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Payment Mode"
        '
        'txtCharges
        '
        Me.txtCharges.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCharges.Location = New System.Drawing.Point(186, 490)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(141, 25)
        Me.txtCharges.TabIndex = 12
        Me.txtCharges.Text = "0"
        Me.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(186, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Charges"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMaterial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.ItemHeight = 17
        Me.cmbMaterial.Location = New System.Drawing.Point(16, 254)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(192, 25)
        Me.cmbMaterial.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Material"
        '
        'txtSubParty
        '
        Me.txtSubParty.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSubParty.Location = New System.Drawing.Point(17, 207)
        Me.txtSubParty.Name = "txtSubParty"
        Me.txtSubParty.Size = New System.Drawing.Size(500, 25)
        Me.txtSubParty.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(17, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sub Party"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMobile.Location = New System.Drawing.Point(288, 161)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(229, 25)
        Me.txtMobile.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(291, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mobile"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCustomer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(16, 161)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(229, 25)
        Me.cmbCustomer.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Customer / Party"
        '
        'cmbVehicle
        '
        Me.cmbVehicle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbVehicle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbVehicle.FormattingEnabled = True
        Me.cmbVehicle.Location = New System.Drawing.Point(16, 114)
        Me.cmbVehicle.Name = "cmbVehicle"
        Me.cmbVehicle.Size = New System.Drawing.Size(229, 25)
        Me.cmbVehicle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vehicle Number"
        '
        'cmbWType
        '
        Me.cmbWType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbWType.FormattingEnabled = True
        Me.cmbWType.Location = New System.Drawing.Point(288, 66)
        Me.cmbWType.Name = "cmbWType"
        Me.cmbWType.Size = New System.Drawing.Size(228, 25)
        Me.cmbWType.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(291, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Weighment Type"
        '
        'txtSerialNo
        '
        Me.txtSerialNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtSerialNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSerialNo.Location = New System.Drawing.Point(16, 66)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.ReadOnly = True
        Me.txtSerialNo.Size = New System.Drawing.Size(229, 25)
        Me.txtSerialNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serial No"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(16, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 2)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entry Details"
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.vView1)
        Me.pnlRight.Controls.Add(Me.Label20)
        Me.pnlRight.Controls.Add(Me.dgvPending)
        Me.pnlRight.Controls.Add(Me.vView4)
        Me.pnlRight.Controls.Add(Me.vView2)
        Me.pnlRight.Controls.Add(Me.vView3)
        Me.pnlRight.Controls.Add(Me.Label12)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(571, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(613, 605)
        Me.pnlRight.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(8, 428)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 19)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Pending Vehicles"
        '
        'dgvPending
        '
        Me.dgvPending.AllowUserToAddRows = False
        Me.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPending.BackgroundColor = System.Drawing.Color.White
        Me.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPending.Location = New System.Drawing.Point(12, 451)
        Me.dgvPending.Name = "dgvPending"
        Me.dgvPending.ReadOnly = True
        Me.dgvPending.RowHeadersVisible = False
        Me.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPending.Size = New System.Drawing.Size(582, 138)
        Me.dgvPending.TabIndex = 5
        '
        'picCam4
        '
        Me.vView4.BackColor = System.Drawing.Color.Black
        Me.vView4.Location = New System.Drawing.Point(306, 234)
        Me.vView4.MediaPlayer = Nothing
        Me.vView4.Name = "vView4"
        Me.vView4.Size = New System.Drawing.Size(288, 190)
        Me.vView4.TabIndex = 7
        Me.vView4.Text = "VideoView4"
        '
        'picCam2
        '
        Me.vView2.BackColor = System.Drawing.Color.Black
        Me.vView2.Location = New System.Drawing.Point(306, 39)
        Me.vView2.MediaPlayer = Nothing
        Me.vView2.Name = "vView2"
        Me.vView2.Size = New System.Drawing.Size(288, 190)
        Me.vView2.TabIndex = 7
        Me.vView2.Text = "VideoView2"
        '
        'picCam3
        '
        Me.vView3.BackColor = System.Drawing.Color.Black
        Me.vView3.Location = New System.Drawing.Point(12, 234)
        Me.vView3.MediaPlayer = Nothing
        Me.vView3.Name = "vView3"
        Me.vView3.Size = New System.Drawing.Size(288, 190)
        Me.vView3.TabIndex = 7
        Me.vView3.Text = "VideoView3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Live Camera"
        '
        'tmrCameras
        '
        Me.tmrCameras.Interval = 1000
        '
        'vView1
        '
        Me.vView1.BackColor = System.Drawing.Color.Black
        Me.vView1.Location = New System.Drawing.Point(12, 38)
        Me.vView1.MediaPlayer = Nothing
        Me.vView1.Name = "vView1"
        Me.vView1.Size = New System.Drawing.Size(288, 190)
        Me.vView1.TabIndex = 7
        Me.vView1.Text = "VideoView1"
        '
        'FrmWeighment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlEntry)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmWeighment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WeighDATA — First Weighment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlWeightDisplay.ResumeLayout(False)
        Me.pnlWeightDisplay.PerformLayout()
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        Me.pnlGrossSection.ResumeLayout(False)
        Me.pnlGrossSection.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlWeightDisplay As Panel
    Friend WithEvents lblLiveWeight As Label
    Friend WithEvents lblWTitle As Label
    Friend WithEvents pnlEntry As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlGrossSection As Panel
    Friend WithEvents txt1stWt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbPayMode As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCharges As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubParty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbVehicle As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbWType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSerialNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents vView3 As LibVLCSharp.WinForms.VideoView
    Friend WithEvents Label12 As Label
    Friend WithEvents ckbSecondWt As CheckBox
    Friend WithEvents txt2ndWt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl2ndWtDT As Label
    Friend WithEvents lbl1stWtDT As Label
    Friend WithEvents vView4 As LibVLCSharp.WinForms.VideoView
    Friend WithEvents vView2 As LibVLCSharp.WinForms.VideoView
    Friend WithEvents lblStable As Label
    Friend WithEvents cmbVehicleType As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDeductionWt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtFinalNetWt As TextBox
    Friend WithEvents dgvPending As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNetWt As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents ckbPrintDuplicateTicket As CheckBox
    Friend WithEvents tmrCameras As Timer
    Friend WithEvents vView1 As LibVLCSharp.WinForms.VideoView
End Class
