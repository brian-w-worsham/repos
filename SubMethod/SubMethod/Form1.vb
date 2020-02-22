Public Class Form1
    Private Sub ClearForm()
        TextBoxName.Text = ""
        TextBoxAddress.Text = ""
        TextBoxPhone.Text = ""
    End Sub

    Private Sub Customer(name As String, addr As String, phone As String)
        TextBoxName.Text = name
        TextBoxAddress.Text = addr
        TextBoxPhone.Text = phone
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Me.ClearForm()
    End Sub

    Private Sub ButtonCustomer_Click(sender As Object, e As EventArgs) Handles ButtonCustomer.Click
        Me.Customer("Brian Worsham", "1612 Aztec Trce", "254-781-6430")
    End Sub
End Class
