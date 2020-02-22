Public Class Form1
    Private Function Inches(ByVal Cm As String) As Double
        Inches = Convert.ToDouble(Cm) / 2.54
        Inches = FormatNumber(Inches, 2) ' Formats the value to just two decimal places
        Return Inches
    End Function

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        LabelResult.Text = Inches(TextBox1.Text & " Inches")
    End Sub
End Class
