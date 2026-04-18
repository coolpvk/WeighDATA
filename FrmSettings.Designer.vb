<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSettingsTitle = New System.Windows.Forms.Label()
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.tabIndicator = New System.Windows.Forms.TabPage()
        Me.btnSaveIndicator = New System.Windows.Forms.Button()
        Me.pnlCOMTest = New System.Windows.Forms.Panel()
        Me.btnTestCOM = New System.Windows.Forms.Button()
        Me.lblParsedWeight = New System.Windows.Forms.Label()
        Me.lblRawData = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWeightFormat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbStopBits = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbParity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDataBits = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCOMPort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabPrinter = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSavePrinter = New System.Windows.Forms.Button()
        Me.btnTestPrint = New System.Windows.Forms.Button()
        Me.chkColorPrint = New System.Windows.Forms.CheckBox()
        Me.chkAutoPrint = New System.Windows.Forms.CheckBox()
        Me.nudCopies = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbPaperSize = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPrinterName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabCamera = New System.Windows.Forms.TabPage()
        Me.btnSaveCamera = New System.Windows.Forms.Button()
        Me.btnTestCameras = New System.Windows.Forms.Button()
        Me.txtCam4URL = New System.Windows.Forms.TextBox()
        Me.cmbCam4Type = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCam3URL = New System.Windows.Forms.TextBox()
        Me.cmbCam3Type = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCam2URL = New System.Windows.Forms.TextBox()
        Me.cmbCam2Type = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCam1URL = New System.Windows.Forms.TextBox()
        Me.cmbCam1Type = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabCompany = New System.Windows.Forms.TabPage()
        Me.btnSaveCompany = New System.Windows.Forms.Button()
        Me.btnTestCloud = New System.Windows.Forms.Button()
        Me.txtCloudURL = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnTestCam1 = New System.Windows.Forms.Button()
        Me.btnTestCam2 = New System.Windows.Forms.Button()
        Me.btnTestCam3 = New System.Windows.Forms.Button()
        Me.btnTestCam4 = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabIndicator.SuspendLayout()
        Me.pnlCOMTest.SuspendLayout()
        Me.tabPrinter.SuspendLayout()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCamera.SuspendLayout()
        Me.tabCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblSettingsTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(844, 52)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSettingsTitle
        '
        Me.lblSettingsTitle.AutoSize = True
        Me.lblSettingsTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSettingsTitle.ForeColor = System.Drawing.Color.White
        Me.lblSettingsTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblSettingsTitle.Name = "lblSettingsTitle"
        Me.lblSettingsTitle.Size = New System.Drawing.Size(116, 25)
        Me.lblSettingsTitle.TabIndex = 0
        Me.lblSettingsTitle.Text = "⚙️  Settings"
        '
        'tabSettings
        '
        Me.tabSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSettings.Controls.Add(Me.tabIndicator)
        Me.tabSettings.Controls.Add(Me.tabPrinter)
        Me.tabSettings.Controls.Add(Me.tabCamera)
        Me.tabSettings.Controls.Add(Me.tabCompany)
        Me.tabSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabSettings.Location = New System.Drawing.Point(12, 64)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(820, 480)
        Me.tabSettings.TabIndex = 1
        '
        'tabIndicator
        '
        Me.tabIndicator.BackColor = System.Drawing.Color.White
        Me.tabIndicator.Controls.Add(Me.btnSaveIndicator)
        Me.tabIndicator.Controls.Add(Me.pnlCOMTest)
        Me.tabIndicator.Controls.Add(Me.Label8)
        Me.tabIndicator.Controls.Add(Me.txtWeightFormat)
        Me.tabIndicator.Controls.Add(Me.Label7)
        Me.tabIndicator.Controls.Add(Me.cmbStopBits)
        Me.tabIndicator.Controls.Add(Me.Label6)
        Me.tabIndicator.Controls.Add(Me.cmbParity)
        Me.tabIndicator.Controls.Add(Me.Label4)
        Me.tabIndicator.Controls.Add(Me.cmbDataBits)
        Me.tabIndicator.Controls.Add(Me.Label5)
        Me.tabIndicator.Controls.Add(Me.cmbBaudRate)
        Me.tabIndicator.Controls.Add(Me.Label3)
        Me.tabIndicator.Controls.Add(Me.cmbCOMPort)
        Me.tabIndicator.Controls.Add(Me.Label2)
        Me.tabIndicator.Controls.Add(Me.Panel1)
        Me.tabIndicator.Controls.Add(Me.Label1)
        Me.tabIndicator.Location = New System.Drawing.Point(4, 26)
        Me.tabIndicator.Name = "tabIndicator"
        Me.tabIndicator.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIndicator.Size = New System.Drawing.Size(812, 450)
        Me.tabIndicator.TabIndex = 0
        Me.tabIndicator.Text = "⚙️ Indicator"
        '
        'btnSaveIndicator
        '
        Me.btnSaveIndicator.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveIndicator.FlatAppearance.BorderSize = 0
        Me.btnSaveIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveIndicator.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveIndicator.ForeColor = System.Drawing.Color.White
        Me.btnSaveIndicator.Location = New System.Drawing.Point(16, 280)
        Me.btnSaveIndicator.Name = "btnSaveIndicator"
        Me.btnSaveIndicator.Size = New System.Drawing.Size(140, 40)
        Me.btnSaveIndicator.TabIndex = 19
        Me.btnSaveIndicator.Text = "💾  Save"
        Me.btnSaveIndicator.UseVisualStyleBackColor = False
        '
        'pnlCOMTest
        '
        Me.pnlCOMTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlCOMTest.Controls.Add(Me.btnTestCOM)
        Me.pnlCOMTest.Controls.Add(Me.lblParsedWeight)
        Me.pnlCOMTest.Controls.Add(Me.lblRawData)
        Me.pnlCOMTest.Location = New System.Drawing.Point(16, 190)
        Me.pnlCOMTest.Name = "pnlCOMTest"
        Me.pnlCOMTest.Size = New System.Drawing.Size(740, 72)
        Me.pnlCOMTest.TabIndex = 15
        '
        'btnTestCOM
        '
        Me.btnTestCOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCOM.FlatAppearance.BorderSize = 0
        Me.btnTestCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCOM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCOM.ForeColor = System.Drawing.Color.White
        Me.btnTestCOM.Location = New System.Drawing.Point(560, 18)
        Me.btnTestCOM.Name = "btnTestCOM"
        Me.btnTestCOM.Size = New System.Drawing.Size(160, 36)
        Me.btnTestCOM.TabIndex = 18
        Me.btnTestCOM.Text = "🔌 Test Connection"
        Me.btnTestCOM.UseVisualStyleBackColor = False
        '
        'lblParsedWeight
        '
        Me.lblParsedWeight.AutoSize = True
        Me.lblParsedWeight.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblParsedWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblParsedWeight.Location = New System.Drawing.Point(10, 32)
        Me.lblParsedWeight.Name = "lblParsedWeight"
        Me.lblParsedWeight.Size = New System.Drawing.Size(110, 21)
        Me.lblParsedWeight.TabIndex = 17
        Me.lblParsedWeight.Text = "Parsed: — KG"
        '
        'lblRawData
        '
        Me.lblRawData.AutoSize = True
        Me.lblRawData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRawData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblRawData.Location = New System.Drawing.Point(10, 10)
        Me.lblRawData.Name = "lblRawData"
        Me.lblRawData.Size = New System.Drawing.Size(78, 15)
        Me.lblRawData.TabIndex = 16
        Me.lblRawData.Text = "Raw Data: —"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Example: W+001234 = 1234 KG"
        '
        'txtWeightFormat
        '
        Me.txtWeightFormat.Location = New System.Drawing.Point(16, 134)
        Me.txtWeightFormat.Name = "txtWeightFormat"
        Me.txtWeightFormat.Size = New System.Drawing.Size(280, 25)
        Me.txtWeightFormat.TabIndex = 13
        Me.txtWeightFormat.Text = "W+000000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Weight String Format"
        '
        'cmbStopBits
        '
        Me.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStopBits.FormattingEnabled = True
        Me.cmbStopBits.Location = New System.Drawing.Point(616, 74)
        Me.cmbStopBits.Name = "cmbStopBits"
        Me.cmbStopBits.Size = New System.Drawing.Size(100, 25)
        Me.cmbStopBits.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(616, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Stop Bits"
        '
        'cmbParity
        '
        Me.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParity.FormattingEnabled = True
        Me.cmbParity.Location = New System.Drawing.Point(476, 74)
        Me.cmbParity.Name = "cmbParity"
        Me.cmbParity.Size = New System.Drawing.Size(120, 25)
        Me.cmbParity.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(476, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Parity"
        '
        'cmbDataBits
        '
        Me.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDataBits.FormattingEnabled = True
        Me.cmbDataBits.Location = New System.Drawing.Point(356, 74)
        Me.cmbDataBits.Name = "cmbDataBits"
        Me.cmbDataBits.Size = New System.Drawing.Size(100, 25)
        Me.cmbDataBits.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(356, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Data Bits"
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Location = New System.Drawing.Point(196, 74)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(140, 25)
        Me.cmbBaudRate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(196, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Baud Rate"
        '
        'cmbCOMPort
        '
        Me.cmbCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCOMPort.FormattingEnabled = True
        Me.cmbCOMPort.Location = New System.Drawing.Point(16, 74)
        Me.cmbCOMPort.Name = "cmbCOMPort"
        Me.cmbCOMPort.Size = New System.Drawing.Size(160, 25)
        Me.cmbCOMPort.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "COM Port"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(16, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 2)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weighbridge Indicator Settings"
        '
        'tabPrinter
        '
        Me.tabPrinter.BackColor = System.Drawing.Color.White
        Me.tabPrinter.Controls.Add(Me.Button1)
        Me.tabPrinter.Controls.Add(Me.btnSavePrinter)
        Me.tabPrinter.Controls.Add(Me.btnTestPrint)
        Me.tabPrinter.Controls.Add(Me.chkColorPrint)
        Me.tabPrinter.Controls.Add(Me.chkAutoPrint)
        Me.tabPrinter.Controls.Add(Me.nudCopies)
        Me.tabPrinter.Controls.Add(Me.Label12)
        Me.tabPrinter.Controls.Add(Me.cmbPaperSize)
        Me.tabPrinter.Controls.Add(Me.Label11)
        Me.tabPrinter.Controls.Add(Me.cmbPrinterName)
        Me.tabPrinter.Controls.Add(Me.Label10)
        Me.tabPrinter.Controls.Add(Me.Panel2)
        Me.tabPrinter.Controls.Add(Me.Label9)
        Me.tabPrinter.Location = New System.Drawing.Point(4, 26)
        Me.tabPrinter.Name = "tabPrinter"
        Me.tabPrinter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrinter.Size = New System.Drawing.Size(812, 450)
        Me.tabPrinter.TabIndex = 1
        Me.tabPrinter.Text = "🖨️ Printer"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(589, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 40)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "🖨️ Print Slip Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSavePrinter
        '
        Me.btnSavePrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSavePrinter.FlatAppearance.BorderSize = 0
        Me.btnSavePrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrinter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSavePrinter.ForeColor = System.Drawing.Color.White
        Me.btnSavePrinter.Location = New System.Drawing.Point(160, 244)
        Me.btnSavePrinter.Name = "btnSavePrinter"
        Me.btnSavePrinter.Size = New System.Drawing.Size(140, 40)
        Me.btnSavePrinter.TabIndex = 20
        Me.btnSavePrinter.Text = "💾  Save"
        Me.btnSavePrinter.UseVisualStyleBackColor = False
        '
        'btnTestPrint
        '
        Me.btnTestPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestPrint.FlatAppearance.BorderSize = 0
        Me.btnTestPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestPrint.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestPrint.ForeColor = System.Drawing.Color.White
        Me.btnTestPrint.Location = New System.Drawing.Point(16, 244)
        Me.btnTestPrint.Name = "btnTestPrint"
        Me.btnTestPrint.Size = New System.Drawing.Size(130, 40)
        Me.btnTestPrint.TabIndex = 19
        Me.btnTestPrint.Text = "🖨️ Test Print"
        Me.btnTestPrint.UseVisualStyleBackColor = False
        '
        'chkColorPrint
        '
        Me.chkColorPrint.AutoSize = True
        Me.chkColorPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.chkColorPrint.Location = New System.Drawing.Point(16, 204)
        Me.chkColorPrint.Name = "chkColorPrint"
        Me.chkColorPrint.Size = New System.Drawing.Size(94, 23)
        Me.chkColorPrint.TabIndex = 11
        Me.chkColorPrint.Text = "Color print"
        Me.chkColorPrint.UseVisualStyleBackColor = True
        '
        'chkAutoPrint
        '
        Me.chkAutoPrint.AutoSize = True
        Me.chkAutoPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.chkAutoPrint.Location = New System.Drawing.Point(16, 176)
        Me.chkAutoPrint.Name = "chkAutoPrint"
        Me.chkAutoPrint.Size = New System.Drawing.Size(155, 23)
        Me.chkAutoPrint.TabIndex = 10
        Me.chkAutoPrint.Text = "Auto print after Save"
        Me.chkAutoPrint.UseVisualStyleBackColor = True
        '
        'nudCopies
        '
        Me.nudCopies.Location = New System.Drawing.Point(216, 134)
        Me.nudCopies.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCopies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopies.Name = "nudCopies"
        Me.nudCopies.Size = New System.Drawing.Size(80, 25)
        Me.nudCopies.TabIndex = 9
        Me.nudCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(216, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Copies"
        '
        'cmbPaperSize
        '
        Me.cmbPaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaperSize.FormattingEnabled = True
        Me.cmbPaperSize.Location = New System.Drawing.Point(16, 134)
        Me.cmbPaperSize.Name = "cmbPaperSize"
        Me.cmbPaperSize.Size = New System.Drawing.Size(180, 25)
        Me.cmbPaperSize.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Paper Size"
        '
        'cmbPrinterName
        '
        Me.cmbPrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrinterName.FormattingEnabled = True
        Me.cmbPrinterName.Location = New System.Drawing.Point(16, 74)
        Me.cmbPrinterName.Name = "cmbPrinterName"
        Me.cmbPrinterName.Size = New System.Drawing.Size(280, 25)
        Me.cmbPrinterName.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Select Printer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(16, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 2)
        Me.Panel2.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Printer Settings"
        '
        'tabCamera
        '
        Me.tabCamera.BackColor = System.Drawing.Color.White
        Me.tabCamera.Controls.Add(Me.btnTestCam4)
        Me.tabCamera.Controls.Add(Me.btnTestCam3)
        Me.tabCamera.Controls.Add(Me.btnTestCam2)
        Me.tabCamera.Controls.Add(Me.btnTestCam1)
        Me.tabCamera.Controls.Add(Me.btnSaveCamera)
        Me.tabCamera.Controls.Add(Me.btnTestCameras)
        Me.tabCamera.Controls.Add(Me.txtCam4URL)
        Me.tabCamera.Controls.Add(Me.cmbCam4Type)
        Me.tabCamera.Controls.Add(Me.Label16)
        Me.tabCamera.Controls.Add(Me.txtCam3URL)
        Me.tabCamera.Controls.Add(Me.cmbCam3Type)
        Me.tabCamera.Controls.Add(Me.Label17)
        Me.tabCamera.Controls.Add(Me.txtCam2URL)
        Me.tabCamera.Controls.Add(Me.cmbCam2Type)
        Me.tabCamera.Controls.Add(Me.Label15)
        Me.tabCamera.Controls.Add(Me.txtCam1URL)
        Me.tabCamera.Controls.Add(Me.cmbCam1Type)
        Me.tabCamera.Controls.Add(Me.Label13)
        Me.tabCamera.Controls.Add(Me.Panel3)
        Me.tabCamera.Controls.Add(Me.Label14)
        Me.tabCamera.Location = New System.Drawing.Point(4, 26)
        Me.tabCamera.Name = "tabCamera"
        Me.tabCamera.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCamera.Size = New System.Drawing.Size(812, 450)
        Me.tabCamera.TabIndex = 2
        Me.tabCamera.Text = "📷 Camera"
        '
        'btnSaveCamera
        '
        Me.btnSaveCamera.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveCamera.FlatAppearance.BorderSize = 0
        Me.btnSaveCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCamera.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveCamera.ForeColor = System.Drawing.Color.White
        Me.btnSaveCamera.Location = New System.Drawing.Point(160, 296)
        Me.btnSaveCamera.Name = "btnSaveCamera"
        Me.btnSaveCamera.Size = New System.Drawing.Size(140, 40)
        Me.btnSaveCamera.TabIndex = 21
        Me.btnSaveCamera.Text = "💾  Save"
        Me.btnSaveCamera.UseVisualStyleBackColor = False
        '
        'btnTestCameras
        '
        Me.btnTestCameras.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCameras.FlatAppearance.BorderSize = 0
        Me.btnTestCameras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCameras.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCameras.ForeColor = System.Drawing.Color.White
        Me.btnTestCameras.Location = New System.Drawing.Point(16, 296)
        Me.btnTestCameras.Name = "btnTestCameras"
        Me.btnTestCameras.Size = New System.Drawing.Size(130, 40)
        Me.btnTestCameras.TabIndex = 20
        Me.btnTestCameras.Text = "📷 Test All"
        Me.btnTestCameras.UseVisualStyleBackColor = False
        '
        'txtCam4URL
        '
        Me.txtCam4URL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCam4URL.Location = New System.Drawing.Point(16, 248)
        Me.txtCam4URL.Name = "txtCam4URL"
        Me.txtCam4URL.Size = New System.Drawing.Size(480, 23)
        Me.txtCam4URL.TabIndex = 19
        '
        'cmbCam4Type
        '
        Me.cmbCam4Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCam4Type.FormattingEnabled = True
        Me.cmbCam4Type.Location = New System.Drawing.Point(506, 248)
        Me.cmbCam4Type.Name = "cmbCam4Type"
        Me.cmbCam4Type.Size = New System.Drawing.Size(130, 25)
        Me.cmbCam4Type.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(16, 230)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 15)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Camera 4 URL / Device"
        '
        'txtCam3URL
        '
        Me.txtCam3URL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCam3URL.Location = New System.Drawing.Point(16, 190)
        Me.txtCam3URL.Name = "txtCam3URL"
        Me.txtCam3URL.Size = New System.Drawing.Size(480, 23)
        Me.txtCam3URL.TabIndex = 16
        '
        'cmbCam3Type
        '
        Me.cmbCam3Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCam3Type.FormattingEnabled = True
        Me.cmbCam3Type.Location = New System.Drawing.Point(506, 190)
        Me.cmbCam3Type.Name = "cmbCam3Type"
        Me.cmbCam3Type.Size = New System.Drawing.Size(130, 25)
        Me.cmbCam3Type.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(16, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Camera 3 URL / Device"
        '
        'txtCam2URL
        '
        Me.txtCam2URL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCam2URL.Location = New System.Drawing.Point(16, 132)
        Me.txtCam2URL.Name = "txtCam2URL"
        Me.txtCam2URL.Size = New System.Drawing.Size(480, 23)
        Me.txtCam2URL.TabIndex = 13
        '
        'cmbCam2Type
        '
        Me.cmbCam2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCam2Type.FormattingEnabled = True
        Me.cmbCam2Type.Location = New System.Drawing.Point(506, 132)
        Me.cmbCam2Type.Name = "cmbCam2Type"
        Me.cmbCam2Type.Size = New System.Drawing.Size(130, 25)
        Me.cmbCam2Type.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 15)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Camera 2 URL / Device"
        '
        'txtCam1URL
        '
        Me.txtCam1URL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCam1URL.Location = New System.Drawing.Point(16, 74)
        Me.txtCam1URL.Name = "txtCam1URL"
        Me.txtCam1URL.Size = New System.Drawing.Size(480, 23)
        Me.txtCam1URL.TabIndex = 10
        '
        'cmbCam1Type
        '
        Me.cmbCam1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCam1Type.FormattingEnabled = True
        Me.cmbCam1Type.Location = New System.Drawing.Point(506, 74)
        Me.cmbCam1Type.Name = "cmbCam1Type"
        Me.cmbCam1Type.Size = New System.Drawing.Size(130, 25)
        Me.cmbCam1Type.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Camera 1 URL / Device"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(16, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(760, 2)
        Me.Panel3.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(234, 21)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Camera Settings (RTSP / USB)"
        '
        'tabCompany
        '
        Me.tabCompany.BackColor = System.Drawing.Color.White
        Me.tabCompany.Controls.Add(Me.btnSaveCompany)
        Me.tabCompany.Controls.Add(Me.btnTestCloud)
        Me.tabCompany.Controls.Add(Me.txtCloudURL)
        Me.tabCompany.Controls.Add(Me.Label23)
        Me.tabCompany.Controls.Add(Me.txtPhone)
        Me.tabCompany.Controls.Add(Me.Label21)
        Me.tabCompany.Controls.Add(Me.txtAddress)
        Me.tabCompany.Controls.Add(Me.Label22)
        Me.tabCompany.Controls.Add(Me.txtGST)
        Me.tabCompany.Controls.Add(Me.Label20)
        Me.tabCompany.Controls.Add(Me.txtCompanyName)
        Me.tabCompany.Controls.Add(Me.Label18)
        Me.tabCompany.Controls.Add(Me.Panel4)
        Me.tabCompany.Controls.Add(Me.Label19)
        Me.tabCompany.Location = New System.Drawing.Point(4, 26)
        Me.tabCompany.Name = "tabCompany"
        Me.tabCompany.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompany.Size = New System.Drawing.Size(812, 450)
        Me.tabCompany.TabIndex = 3
        Me.tabCompany.Text = "🏢 Company"
        '
        'btnSaveCompany
        '
        Me.btnSaveCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveCompany.FlatAppearance.BorderSize = 0
        Me.btnSaveCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCompany.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveCompany.ForeColor = System.Drawing.Color.White
        Me.btnSaveCompany.Location = New System.Drawing.Point(16, 304)
        Me.btnSaveCompany.Name = "btnSaveCompany"
        Me.btnSaveCompany.Size = New System.Drawing.Size(180, 40)
        Me.btnSaveCompany.TabIndex = 24
        Me.btnSaveCompany.Text = "💾  Save All Settings"
        Me.btnSaveCompany.UseVisualStyleBackColor = False
        '
        'btnTestCloud
        '
        Me.btnTestCloud.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCloud.FlatAppearance.BorderSize = 0
        Me.btnTestCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCloud.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCloud.ForeColor = System.Drawing.Color.White
        Me.btnTestCloud.Location = New System.Drawing.Point(586, 254)
        Me.btnTestCloud.Name = "btnTestCloud"
        Me.btnTestCloud.Size = New System.Drawing.Size(80, 28)
        Me.btnTestCloud.TabIndex = 23
        Me.btnTestCloud.Text = "🌐 Test"
        Me.btnTestCloud.UseVisualStyleBackColor = False
        '
        'txtCloudURL
        '
        Me.txtCloudURL.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCloudURL.Location = New System.Drawing.Point(16, 254)
        Me.txtCloudURL.Name = "txtCloudURL"
        Me.txtCloudURL.Size = New System.Drawing.Size(560, 25)
        Me.txtCloudURL.TabIndex = 22
        Me.txtCloudURL.Text = "http://facedesk.geniustech.online/api/"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(16, 236)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 15)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Cloud Sync API URL"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPhone.Location = New System.Drawing.Point(16, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 25)
        Me.txtPhone.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(16, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 15)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Phone"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAddress.Location = New System.Drawing.Point(16, 134)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(660, 25)
        Me.txtAddress.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(16, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 15)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Address"
        '
        'txtGST
        '
        Me.txtGST.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGST.Location = New System.Drawing.Point(416, 74)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(260, 25)
        Me.txtGST.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(416, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 15)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "GST Number"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCompanyName.Location = New System.Drawing.Point(16, 74)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(380, 25)
        Me.txtCompanyName.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(16, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 15)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Company Name"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(16, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(760, 2)
        Me.Panel4.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(186, 21)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Company / Branch Info"
        '
        'btnTestCam1
        '
        Me.btnTestCam1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCam1.FlatAppearance.BorderSize = 0
        Me.btnTestCam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCam1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCam1.ForeColor = System.Drawing.Color.White
        Me.btnTestCam1.Location = New System.Drawing.Point(673, 63)
        Me.btnTestCam1.Name = "btnTestCam1"
        Me.btnTestCam1.Size = New System.Drawing.Size(103, 40)
        Me.btnTestCam1.TabIndex = 22
        Me.btnTestCam1.Text = "📷 Test"
        Me.btnTestCam1.UseVisualStyleBackColor = False
        '
        'btnTestCam2
        '
        Me.btnTestCam2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCam2.FlatAppearance.BorderSize = 0
        Me.btnTestCam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCam2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCam2.ForeColor = System.Drawing.Color.White
        Me.btnTestCam2.Location = New System.Drawing.Point(673, 123)
        Me.btnTestCam2.Name = "btnTestCam2"
        Me.btnTestCam2.Size = New System.Drawing.Size(103, 40)
        Me.btnTestCam2.TabIndex = 23
        Me.btnTestCam2.Text = "📷 Test"
        Me.btnTestCam2.UseVisualStyleBackColor = False
        '
        'btnTestCam3
        '
        Me.btnTestCam3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCam3.FlatAppearance.BorderSize = 0
        Me.btnTestCam3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCam3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCam3.ForeColor = System.Drawing.Color.White
        Me.btnTestCam3.Location = New System.Drawing.Point(673, 181)
        Me.btnTestCam3.Name = "btnTestCam3"
        Me.btnTestCam3.Size = New System.Drawing.Size(103, 40)
        Me.btnTestCam3.TabIndex = 24
        Me.btnTestCam3.Text = "📷 Test"
        Me.btnTestCam3.UseVisualStyleBackColor = False
        '
        'btnTestCam4
        '
        Me.btnTestCam4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTestCam4.FlatAppearance.BorderSize = 0
        Me.btnTestCam4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCam4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestCam4.ForeColor = System.Drawing.Color.White
        Me.btnTestCam4.Location = New System.Drawing.Point(673, 237)
        Me.btnTestCam4.Name = "btnTestCam4"
        Me.btnTestCam4.Size = New System.Drawing.Size(103, 40)
        Me.btnTestCam4.TabIndex = 25
        Me.btnTestCam4.Text = "📷 Test"
        Me.btnTestCam4.UseVisualStyleBackColor = False
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 541)
        Me.Controls.Add(Me.tabSettings)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "FrmSettings"
        Me.Text = "WeighDATA — Settings"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.tabIndicator.ResumeLayout(False)
        Me.tabIndicator.PerformLayout()
        Me.pnlCOMTest.ResumeLayout(False)
        Me.pnlCOMTest.PerformLayout()
        Me.tabPrinter.ResumeLayout(False)
        Me.tabPrinter.PerformLayout()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCamera.ResumeLayout(False)
        Me.tabCamera.PerformLayout()
        Me.tabCompany.ResumeLayout(False)
        Me.tabCompany.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSettingsTitle As Label
    Friend WithEvents tabSettings As TabControl
    Friend WithEvents tabIndicator As TabPage
    Friend WithEvents btnSaveIndicator As Button
    Friend WithEvents pnlCOMTest As Panel
    Friend WithEvents btnTestCOM As Button
    Friend WithEvents lblParsedWeight As Label
    Friend WithEvents lblRawData As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtWeightFormat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbStopBits As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbParity As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDataBits As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBaudRate As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCOMPort As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tabPrinter As TabPage
    Friend WithEvents btnSavePrinter As Button
    Friend WithEvents btnTestPrint As Button
    Friend WithEvents chkColorPrint As CheckBox
    Friend WithEvents chkAutoPrint As CheckBox
    Friend WithEvents nudCopies As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbPaperSize As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbPrinterName As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents tabCamera As TabPage
    Friend WithEvents btnSaveCamera As Button
    Friend WithEvents btnTestCameras As Button
    Friend WithEvents txtCam4URL As TextBox
    Friend WithEvents cmbCam4Type As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCam3URL As TextBox
    Friend WithEvents cmbCam3Type As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCam2URL As TextBox
    Friend WithEvents cmbCam2Type As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCam1URL As TextBox
    Friend WithEvents cmbCam1Type As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents tabCompany As TabPage
    Friend WithEvents btnSaveCompany As Button
    Friend WithEvents btnTestCloud As Button
    Friend WithEvents txtCloudURL As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtGST As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTestCam4 As Button
    Friend WithEvents btnTestCam3 As Button
    Friend WithEvents btnTestCam2 As Button
    Friend WithEvents btnTestCam1 As Button
End Class
