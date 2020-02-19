Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTxt.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtValue.Text = MsgBox("Click any button", vbYesNoCancel + vbQuestion)
    End Sub
End Class
