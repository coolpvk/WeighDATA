<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReports
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblMastersTitle = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.LabelMaterial = New System.Windows.Forms.Label()
        Me.cmbParty = New System.Windows.Forms.ComboBox()
        Me.LabelParty = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.LabelTo = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelFrom = New System.Windows.Forms.Label()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.lblTotalSlips = New System.Windows.Forms.Label()
        Me.LabelSumTitle = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblMastersTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(920, 52)
        Me.pnlHeader.TabIndex = 1
        '
        'lblMastersTitle
        '
        Me.lblMastersTitle.AutoSize = True
        Me.lblMastersTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMastersTitle.ForeColor = System.Drawing.Color.White
        Me.lblMastersTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblMastersTitle.Name = "lblMastersTitle"
        Me.lblMastersTitle.Size = New System.Drawing.Size(197, 25)
        Me.lblMastersTitle.TabIndex = 0
        Me.lblMastersTitle.Text = "📊 Reports & Analytics"
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlFilter.Controls.Add(Me.btnExportExcel)
        Me.pnlFilter.Controls.Add(Me.btnGenerate)
        Me.pnlFilter.Controls.Add(Me.cmbMaterial)
        Me.pnlFilter.Controls.Add(Me.LabelMaterial)
        Me.pnlFilter.Controls.Add(Me.cmbParty)
        Me.pnlFilter.Controls.Add(Me.LabelParty)
        Me.pnlFilter.Controls.Add(Me.dtpTo)
        Me.pnlFilter.Controls.Add(Me.LabelTo)
        Me.pnlFilter.Controls.Add(Me.dtpFrom)
        Me.pnlFilter.Controls.Add(Me.LabelFrom)
        Me.pnlFilter.Controls.Add(Me.btnPrintReport)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 52)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(920, 100)
        Me.pnlFilter.TabIndex = 3
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnExportExcel.FlatAppearance.BorderSize = 0
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportExcel.Location = New System.Drawing.Point(660, 50)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(120, 35)
        Me.btnExportExcel.TabIndex = 0
        Me.btnExportExcel.Text = "📊 Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(660, 9)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(120, 35)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "🔍 Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'cmbMaterial
        '
        Me.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaterial.Location = New System.Drawing.Point(500, 40)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(150, 25)
        Me.cmbMaterial.TabIndex = 2
        '
        'LabelMaterial
        '
        Me.LabelMaterial.Location = New System.Drawing.Point(500, 20)
        Me.LabelMaterial.Name = "LabelMaterial"
        Me.LabelMaterial.Size = New System.Drawing.Size(100, 23)
        Me.LabelMaterial.TabIndex = 3
        Me.LabelMaterial.Text = "Material:"
        '
        'cmbParty
        '
        Me.cmbParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParty.Location = New System.Drawing.Point(340, 40)
        Me.cmbParty.Name = "cmbParty"
        Me.cmbParty.Size = New System.Drawing.Size(150, 25)
        Me.cmbParty.TabIndex = 4
        '
        'LabelParty
        '
        Me.LabelParty.Location = New System.Drawing.Point(340, 20)
        Me.LabelParty.Name = "LabelParty"
        Me.LabelParty.Size = New System.Drawing.Size(100, 23)
        Me.LabelParty.TabIndex = 5
        Me.LabelParty.Text = "Party:"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(180, 40)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(150, 25)
        Me.dtpTo.TabIndex = 6
        '
        'LabelTo
        '
        Me.LabelTo.Location = New System.Drawing.Point(180, 20)
        Me.LabelTo.Name = "LabelTo"
        Me.LabelTo.Size = New System.Drawing.Size(100, 23)
        Me.LabelTo.TabIndex = 7
        Me.LabelTo.Text = "To Date:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(20, 40)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(150, 25)
        Me.dtpFrom.TabIndex = 8
        '
        'LabelFrom
        '
        Me.LabelFrom.Location = New System.Drawing.Point(20, 20)
        Me.LabelFrom.Name = "LabelFrom"
        Me.LabelFrom.Size = New System.Drawing.Size(100, 23)
        Me.LabelFrom.TabIndex = 9
        Me.LabelFrom.Text = "From Date:"
        '
        'btnPrintReport
        '
        Me.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintReport.FlatAppearance.BorderSize = 0
        Me.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.ForeColor = System.Drawing.Color.White
        Me.btnPrintReport.Location = New System.Drawing.Point(786, 9)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(120, 35)
        Me.btnPrintReport.TabIndex = 10
        Me.btnPrintReport.Text = "🖨️ Print Report"
        Me.btnPrintReport.UseVisualStyleBackColor = False
        '
        'dgvReports
        '
        Me.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReports.Location = New System.Drawing.Point(0, 152)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.Size = New System.Drawing.Size(920, 220)
        Me.dgvReports.TabIndex = 0
        '
        'pnlSummary
        '
        Me.pnlSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pnlSummary.Controls.Add(Me.lblTotalAmount)
        Me.pnlSummary.Controls.Add(Me.lblTotalWeight)
        Me.pnlSummary.Controls.Add(Me.lblTotalSlips)
        Me.pnlSummary.Controls.Add(Me.LabelSumTitle)
        Me.pnlSummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSummary.Location = New System.Drawing.Point(0, 372)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Size = New System.Drawing.Size(920, 60)
        Me.pnlSummary.TabIndex = 2
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.Yellow
        Me.lblTotalAmount.Location = New System.Drawing.Point(450, 20)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(123, 17)
        Me.lblTotalAmount.TabIndex = 0
        Me.lblTotalAmount.Text = "Total Amount: ₹0.00"
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.AutoSize = True
        Me.lblTotalWeight.ForeColor = System.Drawing.Color.White
        Me.lblTotalWeight.Location = New System.Drawing.Point(250, 20)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(131, 17)
        Me.lblTotalWeight.TabIndex = 1
        Me.lblTotalWeight.Text = "Total Weight: 0.00 KG"
        '
        'lblTotalSlips
        '
        Me.lblTotalSlips.AutoSize = True
        Me.lblTotalSlips.ForeColor = System.Drawing.Color.White
        Me.lblTotalSlips.Location = New System.Drawing.Point(120, 20)
        Me.lblTotalSlips.Name = "lblTotalSlips"
        Me.lblTotalSlips.Size = New System.Drawing.Size(81, 17)
        Me.lblTotalSlips.TabIndex = 2
        Me.lblTotalSlips.Text = "Total Slips: 0"
        '
        'LabelSumTitle
        '
        Me.LabelSumTitle.AutoSize = True
        Me.LabelSumTitle.ForeColor = System.Drawing.Color.White
        Me.LabelSumTitle.Location = New System.Drawing.Point(20, 20)
        Me.LabelSumTitle.Name = "LabelSumTitle"
        Me.LabelSumTitle.Size = New System.Drawing.Size(65, 17)
        Me.LabelSumTitle.TabIndex = 3
        Me.LabelSumTitle.Text = "Summary:"
        '
        'FrmReports
        '
        Me.ClientSize = New System.Drawing.Size(920, 432)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSummary)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmReports"
        Me.Text = "Reports"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFilter.ResumeLayout(False)
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents LabelMaterial As Label
    Friend WithEvents cmbParty As ComboBox
    Friend WithEvents LabelParty As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents LabelTo As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents LabelFrom As Label
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTotalWeight As Label
    Friend WithEvents lblTotalSlips As Label
    Friend WithEvents LabelSumTitle As Label
    Friend WithEvents btnPrintReport As Button
    Friend WithEvents lblMastersTitle As Label
End Class
