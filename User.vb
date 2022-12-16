Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class User
    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private usernamePerpustakaan As String

    Private server = "localhost"
    Private username = "root"
    Private password = ""
    Private database = "perpustakaan"
    Private connectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database = " + database

    Public Property GSUsername() As String
        Get
            Return usernamePerpustakaan
        End Get
        Set(value As String)
            usernamePerpustakaan = value
        End Set
    End Property

    Public Function encryptMD5(ByVal plaintext As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()

    End Function
    Dim users As New ArrayList()

    Public Sub runArrayList()
        users.Add({"haidar", encryptMD5("1234")})
        users.Add({"azmi", encryptMD5("4321")})
        users.Add({"rohman", encryptMD5("1234")})
    End Sub

    Public Function addUsersDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = connectionString

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USERS(username, password, registered_at) VALUE('" & username_regist & "','" & encryptMD5(password_regist) & "'" & today.ToString("yyyy/MM/dd") & "')"
            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function checkAuthDatabase(username As String, plainPassword As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = connectionString
            dbConn.Open()
            Dim queryAuth = "SELECT id_user, username FROM users"
            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try


    End Function

    Public Sub addUser(username As String, password As String)
        users.Add({username, encryptMD5(password)})
        MessageBox.Show("Daftar berhasil")
    End Sub


End Class
