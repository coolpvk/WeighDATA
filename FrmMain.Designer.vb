<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMenuSettings = New System.Windows.Forms.Button()
        Me.btnMenuAttendance = New System.Windows.Forms.Button()
        Me.btnMenuMaster = New System.Windows.Forms.Button()
        Me.btnMenuReports = New System.Windows.Forms.Button()
        Me.btnMenuWeighment = New System.Windows.Forms.Button()
        Me.btnMenuDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyInfo = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnMenuSettings)
        Me.pnlSidebar.Controls.Add(Me.btnMenuAttendance)
        Me.pnlSidebar.Controls.Add(Me.btnMenuMaster)
        Me.pnlSidebar.Controls.Add(Me.btnMenuReports)
        Me.pnlSidebar.Controls.Add(Me.btnMenuWeighment)
        Me.pnlSidebar.Controls.Add(Me.btnMenuDashboard)
        Me.pnlSidebar.Controls.Add(Me.Panel1)
        Me.pnlSidebar.Controls.Add(Me.lblCompanyInfo)
        Me.pnlSidebar.Controls.Add(Me.lblAppName)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 561)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 517)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(220, 44)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "🚪  Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMenuSettings
        '
        Me.btnMenuSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnMenuSettings.FlatAppearance.BorderSize = 0
        Me.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMenuSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMenuSettings.Location = New System.Drawing.Point(0, 316)
        Me.btnMenuSettings.Name = "btnMenuSettings"
        Me.btnMenuSettings.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnMenuSettings.Size = New System.Drawing.Size(220, 44)
        Me.btnMenuSettings.TabIndex = 8
        Me.btnMenuSettings.Text = "⚙️  Settings"
        Me.btnMenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuSettings.UseVisualStyleBackColor = False
        '
        'btnMenuAttendance
        '
        Me.btnMenuAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnMenuAttendance.FlatAppearance.BorderSize = 0
        Me.btnMenuAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuAttendance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMenuAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMenuAttendance.Location = New System.Drawing.Point(0, 272)
        Me.btnMenuAttendance.Name = "btnMenuAttendance"
        Me.btnMenuAttendance.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnMenuAttendance.Size = New System.Drawing.Size(220, 44)
        Me.btnMenuAttendance.TabIndex = 7
        Me.btnMenuAttendance.Text = "👥  Attendance"
        Me.btnMenuAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuAttendance.UseVisualStyleBackColor = False
        '
        'btnMenuMaster
        '
        Me.btnMenuMaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnMenuMaster.FlatAppearance.BorderSize = 0
        Me.btnMenuMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuMaster.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMenuMaster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMenuMaster.Location = New System.Drawing.Point(0, 228)
        Me.btnMenuMaster.Name = "btnMenuMaster"
        Me.btnMenuMaster.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnMenuMaster.Size = New System.Drawing.Size(220, 44)
        Me.btnMenuMaster.TabIndex = 6
        Me.btnMenuMaster.Text = "🚛  Master Management"
        Me.btnMenuMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuMaster.UseVisualStyleBackColor = False
        '
        'btnMenuReports
        '
        Me.btnMenuReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnMenuReports.FlatAppearance.BorderSize = 0
        Me.btnMenuReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuReports.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMenuReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMenuReports.Location = New System.Drawing.Point(0, 184)
        Me.btnMenuReports.Name = "btnMenuReports"
        Me.btnMenuReports.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnMenuReports.Size = New System.Drawing.Size(220, 44)
        Me.btnMenuReports.TabIndex = 5
        Me.btnMenuReports.Text = "📈  Reports"
        Me.btnMenuReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuReports.UseVisualStyleBackColor = False
        '
        'btnMenuWeighment
        '
        Me.btnMenuWeighment.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnMenuWeighment.FlatAppearance.BorderSize = 0
        Me.btnMenuWeighment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuWeighment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMenuWeighment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMenuWeighment.Location = New System.Drawing.Point(0, 140)
        Me.btnMenuWeighment.Name = "btnMenuWeighment"
        Me.btnMenuWeighment.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnMenuWeighment.Size = New System.Drawing.Size(220, 44)
        Me.btnMenuWeighment.TabIndex = 4
        Me.btnMenuWeighment.Text = "⚖️  Weighment"
        Me.btnMenuWeighment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuWeighment.UseVisualStyleBackColor = False
        '
        'btnMenuDashboard
        '
        Me.btnMenuDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnMenuDashboard.FlatAppearance.BorderSize = 0
        Me.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMenuDashboard.ForeColor = System.Drawing.Color.White
        Me.btnMenuDashboard.Location = New System.Drawing.Point(0, 96)
        Me.btnMenuDashboard.Name = "btnMenuDashboard"
        Me.btnMenuDashboard.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.btnMenuDashboard.Size = New System.Drawing.Size(220, 44)
        Me.btnMenuDashboard.TabIndex = 3
        Me.btnMenuDashboard.Text = "📊  Dashboard"
        Me.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuDashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(16, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 1)
        Me.Panel1.TabIndex = 2
        '
        'lblCompanyInfo
        '
        Me.lblCompanyInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblCompanyInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblCompanyInfo.Location = New System.Drawing.Point(16, 46)
        Me.lblCompanyInfo.Name = "lblCompanyInfo"
        Me.lblCompanyInfo.Size = New System.Drawing.Size(188, 32)
        Me.lblCompanyInfo.TabIndex = 1
        Me.lblCompanyInfo.Text = "Company · Branch"
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppName.ForeColor = System.Drawing.Color.White
        Me.lblAppName.Location = New System.Drawing.Point(16, 16)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(134, 30)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "WeighDATA"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.White
        Me.pnlTopBar.Controls.Add(Me.lblUserInfo)
        Me.pnlTopBar.Controls.Add(Me.lblPageTitle)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(220, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(788, 52)
        Me.pnlTopBar.TabIndex = 1
        '
        'lblUserInfo
        '
        Me.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUserInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblUserInfo.Location = New System.Drawing.Point(588, 0)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Padding = New System.Windows.Forms.Padding(0, 0, 16, 0)
        Me.lblUserInfo.Size = New System.Drawing.Size(200, 52)
        Me.lblUserInfo.TabIndex = 1
        Me.lblUserInfo.Text = "Admin · Branch"
        Me.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(109, 25)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Dashboard"
        '
        'pnlContent
        '
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(220, 52)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(788, 509)
        Me.pnlContent.TabIndex = 2
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMain"
        Me.Text = "WeighDATA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMenuSettings As Button
    Friend WithEvents btnMenuAttendance As Button
    Friend WithEvents btnMenuMaster As Button
    Friend WithEvents btnMenuReports As Button
    Friend WithEvents btnMenuWeighment As Button
    Friend WithEvents btnMenuDashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCompanyInfo As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents pnlContent As Panel
End Class
