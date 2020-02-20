Public Class Form1
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        LstPizza.Items.Clear()

        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
        End If

        If CheckBox2.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        LstPizza.Items.Clear()

        If CheckBox1.Checked = True Then
            LstPizza.Items.Add(CheckBox1.Text)
        End If

        If CheckBox2.Checked = True Then
            LstPizza.Items.Add(CheckBox2.Text)
        End If

        If RadioButton1.Checked = True Then
            LstPizza.Items.Add(RadioButton1.Text)
        End If

        If RadioButton2.Checked = True Then
            LstPizza.Items.Add(RadioButton2.Text)
        End If
    End Sub
End Class
