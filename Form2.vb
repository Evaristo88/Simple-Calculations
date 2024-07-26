Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = "Admin"
        Dim password As String = "1234"

        If txtUser.Text = username And txtPass.Text = password Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Error")
            txtUser.Clear()
            txtPass.Clear()

        End If
    End Sub


End Class