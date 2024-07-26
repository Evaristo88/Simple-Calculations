Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome Back!")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFnumber.Click

    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim fnumber, snumber, sum As Integer
        fnumber = txtFnumber.Text
        snumber = txtSnumber.Text
        sum = fnumber + snumber
        txtSum.Text = sum
    End Sub


End Class
