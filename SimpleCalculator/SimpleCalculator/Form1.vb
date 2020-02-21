Public Class Form1
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        LabelResult.Text = "Result: " & Str(Val(TextBoxFirstNum.Text) + Val(TextBoxSecondNum.Text))
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        LabelResult.Text = "Result: " & Str(Val(TextBoxFirstNum.Text) - Val(TextBoxSecondNum.Text))
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        LabelResult.Text = "Result: " & Str(Val(TextBoxFirstNum.Text) * Val(TextBoxSecondNum.Text))
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        LabelResult.Text = "Result: " & Str(Val(TextBoxFirstNum.Text) / Val(TextBoxSecondNum.Text))
    End Sub
End Class
