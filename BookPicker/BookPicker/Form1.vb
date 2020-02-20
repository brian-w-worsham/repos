Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstBooks.Items.Add("Java in easy steps")
        LstBooks.Items.Add("Cracking the Coding Interview")
        LstBooks.Items.Add("The Principles of Object-Oriented Javascript")
        LstBooks.Sorted = True
        LstBooks.SelectedIndex = 0
        Me.Text = LstBooks.Items.Count & " More Books by Mike McGrath"
    End Sub

    Private Sub ButtonShowSelection_Click(sender As Object, e As EventArgs) Handles ButtonShowSelection.Click
        MsgBox(Me.LstBooks.SelectedItem.ToString)
    End Sub

End Class
