Public Class LoginForm
    Public Shared users As User
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        users = New User()
        users.runArrayList()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim data_user As List(Of String) = users.checkAuthDatabase(txtUsername.Text, txtPassword.Text)

        If data_user.Count > 0 Then
            users.GSUsername = data_user(1)
            Dim perpus = New Form1()
            perpus.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim daftar = New RegisterForm()
        daftar.Show()
    End Sub
End Class