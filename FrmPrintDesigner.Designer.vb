<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintDesigner
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
        Me.dgvSettings = New System.Windows.Forms.DataGridView()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        CType(Me.dgvSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSettings
        '
        Me.dgvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSettings.Location = New System.Drawing.Point(12, 41)
        Me.dgvSettings.Name = "dgvSettings"
        Me.dgvSettings.Size = New System.Drawing.Size(592, 521)
        Me.dgvSettings.TabIndex = 0
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveSettings.FlatAppearance.BorderSize = 0
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.White
        Me.btnSaveSettings.Location = New System.Drawing.Point(12, 568)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(196, 44)
        Me.btnSaveSettings.TabIndex = 14
        Me.btnSaveSettings.Text = "💾  Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(610, 41)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(566, 571)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPreview.TabIndex = 15
        Me.picPreview.TabStop = False
        '
        'FrmPrintDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 624)
        Me.Controls.Add(Me.picPreview)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.dgvSettings)
        Me.Name = "FrmPrintDesigner"
        Me.Text = "FrmPrintDesigner"
        CType(Me.dgvSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSettings As DataGridView
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents picPreview As PictureBox
End Class
