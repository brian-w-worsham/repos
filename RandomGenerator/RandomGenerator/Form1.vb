Public Class Form1
    Dim num As Integer

    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 20)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.GetNumber()
    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        Select Case (Val(TextBoxInput.Text))
            Case Is > num
                Label1.Text = TextBoxInput.Text & " is too high"
            Case Is < num
                Label1.Text = TextBoxInput.Text & " is too low"
            Case Is = num
                Label1.Text = TextBoxInput.Text & " is correct. I have thought of another number - Try again!"
                Me.GetNumber()
        End Select
        TextBoxInput.Text = ""
    End Sub
End Class
