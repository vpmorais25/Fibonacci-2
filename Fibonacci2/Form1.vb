Public Class Form1

    Dim a As Long
    Dim b As Long
    Dim c As Long
    Dim TXT As String


    Private Sub Bstart_Click(sender As Object, e As EventArgs) Handles Bstart.Click
        Fib()
    End Sub


    Private Sub Fib()

        If a = 0 Then
            Texto(a)
            b = a
            a = 1
        ElseIf a > 0 Then
            Texto(" - " & a.ToString("#,###"))
            c = a
            a = a + b
            b = c

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = 0
    End Sub

    Private Sub Texto(txt)
        Tb1.Text = Tb1.Text & txt
    End Sub
End Class
