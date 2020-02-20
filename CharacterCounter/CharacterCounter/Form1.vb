Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        MsgBox("You typed: " & Str(Len(TextBoxInput.Text)) & " characters")
    End Sub
End Class
