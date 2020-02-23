Public Class Form1
    Private Sub Clear()
        Label1.Text = "..."
        Label2.Text = "..."
        Label3.Text = "..."
        Label4.Text = "..."
        Label5.Text = "..."
        Label6.Text = "..."
        BtnPick.Enabled = True
        BtnReset.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Clear()
        Randomize()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.Clear()
    End Sub

    Private Sub BtnPick_Click(sender As Object, e As EventArgs) Handles BtnPick.Click
        Dim i, r, temp, nums(60) As Integer 'Declaring three variables In one statement
        For i = 1 To 59
            nums(i) = i
        Next

        'This loop will shuffle the values wihin nums elements 1-59
        For i = 1 To 59
            r = Int(59 * Rnd()) + 1
            temp = nums(i)
            nums(i) = nums(r)
            nums(r) = temp
        Next

        Label1.Text = nums(1)
        Label2.Text = nums(2)
        Label3.Text = nums(3)
        Label4.Text = nums(4)
        Label5.Text = nums(5)
        Label6.Text = nums(6)

        BtnPick.Enabled = False
        BtnReset.Enabled = True
    End Sub
End Class
