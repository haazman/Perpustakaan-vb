Public Class Info_Buku

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Form1.koleksi.GSFoto) Then
            pictBoxKoleksi.Load(Form1.koleksi.GSFoto)
            pictBoxKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        lblDeskripsi.Text = Form1.koleksi.GSdeskripsi
        lblNama.Text = Form1.koleksi.GSNama
        lblJenis.Text = Form1.koleksi.GSjenis
        lblPenerbit.Text = Form1.koleksi.GSpenerbit
        lblTahunTerbit.Text = Form1.koleksi.GStahun
        lblLokasiRak.Text = Form1.koleksi.GSLokasi
        lblTanggalMasuk.Text = Form1.koleksi.GStanggalMasuk
        lblStock.Text = Form1.koleksi.GSstock
        lblBahasa.Text = Form1.koleksi.GSbahasa

        For Each value In Form1.koleksi.GSkategori
            listBoxKategori.Items.Add(value)
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class