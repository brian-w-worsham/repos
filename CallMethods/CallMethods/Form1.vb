Public Class Form1
    Private Sub ButtonSetBounds_Click(sender As Object, e As EventArgs) Handles ButtonSetBounds.Click
        LabelRed.SetBounds(45, 45, 45, 700)
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        LabelRed.Hide()
    End Sub

    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        LabelRed.Show()
    End Sub

    Private Sub ButtonSendBack_Click(sender As Object, e As EventArgs) Handles ButtonSendBack.Click
        LabelRed.SendToBack()
    End Sub

    Private Sub ButtonBringFront_Click(sender As Object, e As EventArgs) Handles ButtonBringFront.Click
        LabelRed.BringToFront()
    End Sub
End Class
