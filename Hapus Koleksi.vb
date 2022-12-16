Public Class Hapus_Koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblKoleksiDihapus.Text = Form1.hapus_koleksi
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Form1.listBoxBuku.Items.RemoveAt(Form1.listBoxBuku.SelectedIndex)
        Me.Close()
    End Sub
End Class