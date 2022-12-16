Public Class RegisterForm
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        'LoginForm.users.addUser(txtUsername.Text, txtPassword.Text)
        LoginForm.users.addUsersDatabase(txtUsername.Text, txtPassword.Text)
        Me.Close()
    End Sub
End Class