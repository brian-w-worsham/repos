Public Class Form1
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        LstPizza.Items.Clear()

        If CheckBox1.Checked = True Then
            LstPizza.Items.Add(CheckBox1.Text)
        End If

        If CheckBox2.Checked = True Then
            LstPizza.Items.Add(CheckBox2.Text)
        End If
    End Sub
End Class
