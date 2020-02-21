Public Class Form1

    Public globalVar As String = "Hello from the Project"
    Public formVar As String = "Hello from this Module"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = "Hello from the Button1 Sub"
        MsgBox(msg)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim msg As String = "Hello from the Button2 Sub"
        MsgBox(msg)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(globalVar & vbCrLf & formVar)
    End Sub
End Class
