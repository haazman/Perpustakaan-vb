Imports System.Windows.Forms.VisualStyles

Public Class Update_Koleksivb
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pictBoxKoleksi.Load(Form1.koleksi.GSFoto)
        pictBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        datePickTanggalMasuk.Format = DateTimePickerFormat.Custom
        datePickTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        txtNama.Text = Form1.koleksi.GSNama
        cmbJenis.SelectedItem() = Form1.koleksi.GSjenis
        RTxtDeskripsi.Text = Form1.koleksi.GSdeskripsi
        txtPenerbit.Text = Form1.koleksi.GSpenerbit
        txtTahunTerbit.Text = Form1.koleksi.GStahun
        txtLokasiRak.Text = Form1.koleksi.GSLokasi
        datePickTanggalMasuk.Value = Form1.koleksi.GStanggalMasuk
        txtStock.Text = Form1.koleksi.GSstock

        If String.Compare(Form1.koleksi.GSbahasa, "Indonesia") = 0 Then
            rBtnIndonesia.Checked = True
        ElseIf String.Compare(Form1.koleksi.GSbahasa, "Inggris") = 0 Then
            rBtnInggris.Checked = True
        End If

        For Each item In Form1.koleksi.GSkategori
            If String.Compare(item, "Sains") = 0 Then
                chkSains.Checked = True
            ElseIf String.Compare(item, "Sosial") = 0 Then
                chkSosial.Checked = True
            ElseIf String.Compare(item, "Teknologi") = 0 Then
                chkTeknologi.Checked = True
            ElseIf String.Compare(item, "Budaya") = 0 Then
                chkBudaya.Checked = True
            End If
        Next
        Dim clear As List(Of String)
        Form1.koleksi.GSkategori = clear
    End Sub

    Private Sub btnTambahGambar_Click(sender As Object, e As EventArgs) Handles btnTambahGambar.Click
        OpenFileDialog1.Title = "Open gambar koleksi"
        OpenFileDialog1.Filter = "Image |*.bmp|Image JPG|*.jpg|Image JPEG|*jpeg|Image PNG|*png|Image GIF|*gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        pictBoxKoleksi.Load(picKoleksiDir)
        pictBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        Form1.koleksi.GSFoto = picKoleksiDir.ToString()
        Form1.koleksi.GSFoto = Form1.koleksi.GSFoto.Replace("\", "/")
    End Sub

    Private Sub btnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles btnUpdateKoleksi.Click
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
            Form1.koleksi.addKategori("Sains")
        End If
        If chkSosial.Checked = True Then
            Form1.koleksi.addKategori("Sosial")
        End If
        If chkTeknologi.Checked = True Then
            Form1.koleksi.addKategori("Teknologi")
        End If
        If chkBudaya.Checked = True Then
            Form1.koleksi.addKategori("Budaya")
        End If



        Form1.listBoxBuku.Items.Add(Form1.koleksi.GSNama)

        Dim convertedKoleksi = Form1.koleksi.convertKoleksiToString(Form1.koleksi.GSkategori)
        Form1.koleksi.addKoleksiDatabase(Form1.koleksi.GSFoto, Form1.koleksi.GSNama, Form1.koleksi.GSjenis, Form1.koleksi.GSpenerbit, Form1.koleksi.GSdeskripsi, Form1.koleksi.GStahun, Form1.koleksi.GSLokasi, Form1.koleksi.GStanggalMasuk, Form1.koleksi.GSstock, Form1.koleksi.GSbahasa, convertedKoleksi)

        Me.Close()



    End Sub
End Class