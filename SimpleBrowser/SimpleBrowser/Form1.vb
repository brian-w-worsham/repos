Public Class Form1
    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
