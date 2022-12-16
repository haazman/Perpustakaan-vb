Imports System.ComponentModel
Imports System.IO
Public Class Tambah_Koleksi

    Dim kategori As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datePickTanggalMasuk.Format = DateTimePickerFormat.Custom
        datePickTanggalMasuk.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub btnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles btnTambahKoleksi.Click
        Form1.koleksi.GSNama = txtNama.Text
        Form1.koleksi.GSdeskripsi = RTxtDeskripsi.Text
        Form1.koleksi.GSjenis = cmbJenis.SelectedItem
        Form1.koleksi.GSpenerbit = txtPenerbit.Text
        Form1.koleksi.GStahun = txtTahunTerbit.Text
        Form1.koleksi.GSLokasi = txtLokasiRak.Text
        Form1.koleksi.GStanggalMasuk = datePickTanggalMasuk.Value.ToString("dd-MM-yyyy")
        Form1.koleksi.GSstock = txtStock.Text
        If rBtnIndonesia.Checked = True Then
            Form1.koleksi.GSbahasa = "Bahasa Indonesia"
        ElseIf rBtnInggris.Checked = True Then
            Form1.koleksi.GSbahasa = "Bahasa Inggris"
        End If
        'kategori.Clear()
        If chkSains.Checked = True Then
            kategori.Add("Sains")
        End If
        If chkSosial.Checked = True Then
            kategori.Add("Sosial")
        End If
        If chkTeknologi.Checked = True Then
            kategori.Add("teknologi")
        End If
        If chkBudaya.Checked = True Then
            kategori.Add("budaya")
        End If

        Form1.koleksi.GSkategori = kategori

        Dim form_info = New Info_Buku()
        form_info.Show()
        Me.Close()

        'Form1.listBoxBuku.Items.Add(Form1.koleksi.GSNama)

        Dim convertedKoleksi = Form1.koleksi.convertKoleksiToString(Form1.koleksi.GSkategori)
        Form1.koleksi.addKoleksiDatabase(Form1.koleksi.GSFoto, Form1.koleksi.GSNama, Form1.koleksi.GSjenis, Form1.koleksi.GSpenerbit, Form1.koleksi.GSdeskripsi, Form1.koleksi.GStahun, Form1.koleksi.GSLokasi, Form1.koleksi.GStanggalMasuk, Form1.koleksi.GSstock, Form1.koleksi.GSbahasa, convertedKoleksi)

    End Sub

    Private Sub btnTambahGambar_Click(sender As Object, e As EventArgs) Handles btnTambahGambar.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog1.Title = "Pilih Foto Pasien"
        OpenFileDialog1.Filter = "Image |*.bmp|Image JPG|*.jpg|Image JPEG|*jpeg|Image PNG|*png|Image GIF|*gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        Form1.koleksi.GSFoto = OpenFileDialog1.FileName
        pictBoxKoleksi.Load(Form1.koleksi.GSFoto)
        pictBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        Form1.koleksi.GSFoto = OpenFileDialog1.FileName.ToString()
        Form1.koleksi.GSFoto = Form1.koleksi.GSFoto.Replace("\", "/")
    End Sub
End Class

