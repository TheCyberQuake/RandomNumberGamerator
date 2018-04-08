Public Class GameText
    Private Sub GameText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.UserFont Is Nothing Then
            lblText.Font = My.Settings.UserFont
        End If
        If My.Settings.ForeColor <> Nothing Then
            lblText.ForeColor = My.Settings.ForeColor
        End If
        If My.Settings.BackColor <> Nothing Then
            lblText.BackColor = My.Settings.BackColor
        End If
    End Sub
End Class