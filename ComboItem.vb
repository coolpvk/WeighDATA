Public Class ComboItem
    Public Property Id As Integer
    Public Property DisplayText As String

    Public Sub New(id As Integer, text As String)
        Me.Id = id
        Me.DisplayText = text
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class