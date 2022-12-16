Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form1
    Public Shared koleksi As Koleksi
    Public Shared hapus_koleksi
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        koleksi = New Koleksi()
        'updateDataTableArrayList()
        reloadDataTableDatabase()

    End Sub



    Private Sub reloadDataTableDatabase()
        dataGridKoleksi.DataSource = koleksi.getDataKoleksiDatabase
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah_kamar_form = New Tambah_Koleksi()
        tambah_kamar_form.Show()
    End Sub

    Private Sub lblTambahBuku_Click(sender As Object, e As EventArgs) Handles lblTambahBuku.Click
        Dim tambah_kamar_form = New Tambah_Koleksi()
        tambah_kamar_form.Show()

    End Sub

    Private Sub lblKurangiBuku_Click(sender As Object, e As EventArgs) Handles lblKurangiBuku.Click
        If listBoxBuku.SelectedItem = "" Then
            MessageBox.Show("Dilipih dulu kak")
        Else
            hapus_koleksi = listBoxBuku.SelectedItem

            Dim kurang_kamar_form = New Hapus_Koleksi()
            kurang_kamar_form.Show()

        End If

    End Sub

    Public Sub updateDataTableArrayList()
        dataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In koleksi.getKoleksiDataTable
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10),
                                         rowKoleksi(0)}
            dataGridKoleksi.Rows.Add(dataTable)
        Next

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'updateDataTableArrayList()
        reloadDataTableDatabase()
    End Sub

    Private Sub dataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridKoleksi.CellClick
        'selectedTableKoleksi = dataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim dataSelected = koleksi.getDataKoleksiByIDDatabase(selectedTableKoleksi)

        koleksi.GSNama = dataSelected(0)
        koleksi.GSjenis = dataSelected(1)
        koleksi.GSdeskripsi = dataSelected(2)
        koleksi.GSpenerbit = dataSelected(3)
        koleksi.GStahun = dataSelected(4)
        koleksi.GSLokasi = dataSelected(5)
        koleksi.GStanggalMasuk = dataSelected(6)
        koleksi.GSstock = dataSelected(7)
        koleksi.GSbahasa = dataSelected(8)

        Dim dataKoleksi As List(Of String) = koleksi.convertStringToKoleksi(dataSelected(9))
        koleksi.GSFoto = dataSelected(10)

        koleksi.GSkategori = dataKoleksi

        Dim infoTambah = New Info_Buku()
        infoTambah.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedKoleksi As List(Of String) = koleksi.getDataKoleksiByIDDatabase(selectedTableKoleksi)

        koleksi.GSNama = selectedKoleksi(0)
        koleksi.GSjenis = selectedKoleksi(1)
        koleksi.GSdeskripsi = selectedKoleksi(2)
        koleksi.GSpenerbit = selectedKoleksi(3)
        koleksi.GStahun = selectedKoleksi(4)
        koleksi.GSLokasi = selectedKoleksi(5)
        koleksi.GStanggalMasuk = selectedKoleksi(6)
        koleksi.GSstock = selectedKoleksi(7)
        koleksi.GSbahasa = selectedKoleksi(8)

        Dim dataKoleksi As List(Of String) = koleksi.convertStringToKoleksi(selectedKoleksi(9))
        koleksi.GSFoto = selectedKoleksi(10)

        koleksi.GSkategori = dataKoleksi

        Dim formUpdate = New Update_Koleksivb()
        formUpdate.Show()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koleksi.removeKoleksiTable(selectedTableKoleksi )
    End Sub
End Class
