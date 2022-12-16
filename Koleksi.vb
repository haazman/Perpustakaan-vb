Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient


Public Class Koleksi
    Private nama, jenis, deskripsi, penerbit, tahun, lokasi, tanggalMasuk, stock, Bahasa, Foto
    Private kategori As New List(Of String)
    Private koleksiDataTable As New ArrayList()
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private server = "localhost"
    Private username = "root"
    Private password = ""
    Private database = "perpustakaan"
    Private connectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database = " + database


    Public Function addKoleksiDatabase(dirGambar As String,
                                        namaKoleksi As String,
                                        jenisKoleksi As String,
                                        penerbitKoleksi As String,
                                        deskripsi As String,
                                        tahun As String,
                                        lokasi As String,
                                        tgl_masuk As Date,
                                        stock As String,
                                        bahasa As String,
                                        kategori As String)

        dbConn.ConnectionString = connectionString
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI (nama_koleksi, dir_gambar, deskripsi, penerbit, jenis_koleksi,tahun terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori) VALUE('" _
                        & namaKoleksi & "','" _
                        & dirGambar & "','" _
                        & deskripsi & "','" _
                        & penerbitKoleksi & "','" _
                        & jenisKoleksi & "','" _
                        & tahun & "','" _
                        & lokasi & "','" _
                        & tgl_masuk.ToString("yyyy/MM/dd") & "','" _
                        & stock & "','" _
                        & bahasa & "','" _
                        & kategori & "')'"
            MessageBox.Show(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Sub addKategori(kategoriTemp As String)
        kategori.Add(kategoriTemp)
    End Sub


    Public Function getDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database = " + database
        dbConn.Open()


        sqlCommand.Connection = dbConn
        'sqlCommand.CommandText = "SELECT nama_koleksi AS 'Nama Koleksi', jenis_koleksi AS 'Jenis Koleksi',penerbit AS 'Penerbit', deskripsi as 'Deskripsi',tahun_terbit AS 'Tahun Terbit',DATE_FORMAT(tanggal_masuk_koleksi, '%Y/%m/%d') AS 'Tanggal Masuk',lokasi AS 'lokasi rak',stock AS 'Stock',bahasa AS 'Bahasa',bahasa as 'Bahasa',kategori as 'Kategori', dir_gambar as 'Foto' FROM koleksi;"
        sqlCommand.CommandText = "SELECT id_koleksi as 'ID', nama_koleksi AS 'Nama Koleksi', jenis_koleksi AS 'Jenis Koleksi',penerbit AS 'Penerbit', deskripsi as 'Deskripsi',tahun_terbit AS 'Tahun Terbit',DATE_FORMAT(tanggal_masuk_koleksi, '%Y/%m/%d') AS 'Tanggal Masuk',lokasi AS 'lokasi rak',stock AS 'Stock',bahasa AS 'Bahasa',bahasa as 'Bahasa',kategori as 'Kategori', dir_gambar as 'Foto' FROM koleksi;"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function getDataKoleksiByIDDatabase(ID As Integer)
        Dim result As New List(Of String)

        dbConn.ConnectionString = connectionString
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT * FROM koleksi WHERE id_kolekis = '" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function updateDataKoleksiByIDDatabase(ID As Integer,
                                                  dirGambar As String,
                                                    namaKoleksi As String,
                                                    jenisKoleksi As String,
                                                    penerbitKoleksi As String,
                                                    deskripsi As String,
                                                    tahun As String,
                                                    lokasi As String,
                                                    tgl_masuk As Date,
                                                    stock As String,
                                                    bahasa As String,
                                                    kategori As String)
        dbConn.ConnectionString = connectionString
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " UPDATE koleksi SET " & "nama_koleksi = '" & namaKoleksi & "'," &
                    "dir_gambar = '" & dirGambar & "'," &
                    "deskripsi = '" & deskripsi & "'," &
                    "penerbit = '" & penerbitKoleksi & "'," &
                    "jenis_koleksi = '" & jenisKoleksi & "'," &
                    "tahun_terbit = '" & tahun & "'," &
                    "lokasi = '" & lokasi & "'," &
                    "tanggal_masuk_koleksi = '" & tgl_masuk.ToString("yyyy/MM/dd") & "'," &
                    "stock = '" & stock & "'," &
                    "bahasa = '" & bahasa & "'," &
                    "kategori = '" & kategori & "'," &
                    "WHERE id_koleksi = '" & ID & "'"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Sub addKoleksiDataTable(
                                        namaKoleksi As String,
                                        jenisKoleksi As String,
                                        penerbitKoleksi As String,
                                        deskripsi As String,
                                        tahun As String,
                                        lokasi As String,
                                        tgl_masuk As String,
                                        stock As String,
                                        bahasa As String,
                                        kategori As String,
                                        dirGambar As String)

        koleksiDataTable.Add({
                             namaKoleksi,
                             jenisKoleksi,
                             penerbitKoleksi,
                             deskripsi,
                             tahun,
                             lokasi,
                             tgl_masuk,
                             stock,
                             bahasa,
                             kategori,
                             dirGambar})

    End Sub

    Public Sub removeKoleksiTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Sub

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function convertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function convertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Property GSNama() As String
        Set(value As String)
            nama = value
        End Set
        Get
            Return nama
        End Get
    End Property

    Public Property GSjenis()
        Set(value)
            jenis = value
        End Set
        Get
            Return jenis
        End Get
    End Property

    Public Property GSdeskripsi()
        Set(value)
            deskripsi = value
        End Set
        Get
            Return deskripsi
        End Get
    End Property

    Public Property GSpenerbit()
        Set(value)
            penerbit = value
        End Set
        Get
            Return penerbit
        End Get
    End Property

    Public Property GStahun()
        Set(value)
            tahun = value
        End Set
        Get
            Return tahun
        End Get
    End Property

    Public Property GSLokasi()
        Set(value)
            lokasi = value
        End Set
        Get
            Return lokasi
        End Get
    End Property

    Public Property GStanggalMasuk()
        Set(value)
            tanggalMasuk = value
        End Set
        Get
            Return tanggalMasuk
        End Get
    End Property

    Public Property GSstock()
        Set(value)
            stock = value
        End Set
        Get
            Return stock
        End Get
    End Property

    Public Property GSbahasa()
        Set(value)
            Bahasa = value
        End Set
        Get
            Return Bahasa
        End Get
    End Property

    Public Property GSkategori()
        Set(value)
            kategori = value
        End Set
        Get
            Return kategori
        End Get
    End Property

    Public Property GSFoto()
        Set(value)
            Foto = value
        End Set
        Get
            Return Foto
        End Get
    End Property

End Class
