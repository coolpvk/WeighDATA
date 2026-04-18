<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCameraTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.vViewTest = New LibVLCSharp.WinForms.VideoView()
        Me.vViewTest.Dock = DockStyle.Fill
        Me.Controls.Add(Me.vViewTest)
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Text = "Camera Stream Test"
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Friend WithEvents vViewTest As LibVLCSharp.WinForms.VideoView
End Class
