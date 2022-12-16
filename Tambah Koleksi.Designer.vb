<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Koleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pictBoxKoleksi = New System.Windows.Forms.PictureBox()
        Me.btnTambahGambar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RTxtDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datePickTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBtnIndonesia = New System.Windows.Forms.RadioButton()
        Me.rBtnInggris = New System.Windows.Forms.RadioButton()
        Me.chkSains = New System.Windows.Forms.CheckBox()
        Me.chkSosial = New System.Windows.Forms.CheckBox()
        Me.chkTeknologi = New System.Windows.Forms.CheckBox()
        Me.chkBudaya = New System.Windows.Forms.CheckBox()
        Me.btnTambahKoleksi = New System.Windows.Forms.Button()
        Me.txtLokasiRak = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pictBoxKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Koleksi"
        '
        'pictBoxKoleksi
        '
        Me.pictBoxKoleksi.Location = New System.Drawing.Point(18, 42)
        Me.pictBoxKoleksi.Name = "pictBoxKoleksi"
        Me.pictBoxKoleksi.Size = New System.Drawing.Size(111, 134)
        Me.pictBoxKoleksi.TabIndex = 1
        Me.pictBoxKoleksi.TabStop = False
        '
        'btnTambahGambar
        '
        Me.btnTambahGambar.Location = New System.Drawing.Point(18, 183)
        Me.btnTambahGambar.Name = "btnTambahGambar"
        Me.btnTambahGambar.Size = New System.Drawing.Size(111, 23)
        Me.btnTambahGambar.TabIndex = 2
        Me.btnTambahGambar.Text = "Tambah Gambar"
        Me.btnTambahGambar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Koleksi"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(429, 42)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Koleksi"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Buku"})
        Me.cmbJenis.Location = New System.Drawing.Point(429, 88)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(200, 21)
        Me.cmbJenis.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Deskripsi"
        '
        'RTxtDeskripsi
        '
        Me.RTxtDeskripsi.Location = New System.Drawing.Point(429, 132)
        Me.RTxtDeskripsi.Name = "RTxtDeskripsi"
        Me.RTxtDeskripsi.Size = New System.Drawing.Size(200, 96)
        Me.RTxtDeskripsi.TabIndex = 8
        Me.RTxtDeskripsi.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Penerbit"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(429, 252)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(200, 20)
        Me.txtPenerbit.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tahun Terbit"
        '
        'txtTahunTerbit
        '
        Me.txtTahunTerbit.Location = New System.Drawing.Point(429, 296)
        Me.txtTahunTerbit.Name = "txtTahunTerbit"
        Me.txtTahunTerbit.Size = New System.Drawing.Size(200, 20)
        Me.txtTahunTerbit.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'datePickTanggalMasuk
        '
        Me.datePickTanggalMasuk.Location = New System.Drawing.Point(429, 345)
        Me.datePickTanggalMasuk.Name = "datePickTanggalMasuk"
        Me.datePickTanggalMasuk.Size = New System.Drawing.Size(200, 20)
        Me.datePickTanggalMasuk.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(429, 379)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(200, 20)
        Me.txtStock.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 437)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Bahasa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnInggris)
        Me.GroupBox1.Controls.Add(Me.rBtnIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(429, 437)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 558)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Kategori"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBudaya)
        Me.GroupBox2.Controls.Add(Me.chkTeknologi)
        Me.GroupBox2.Controls.Add(Me.chkSosial)
        Me.GroupBox2.Controls.Add(Me.chkSains)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 558)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'rBtnIndonesia
        '
        Me.rBtnIndonesia.AutoSize = True
        Me.rBtnIndonesia.Location = New System.Drawing.Point(7, 20)
        Me.rBtnIndonesia.Name = "rBtnIndonesia"
        Me.rBtnIndonesia.Size = New System.Drawing.Size(113, 17)
        Me.rBtnIndonesia.TabIndex = 0
        Me.rBtnIndonesia.TabStop = True
        Me.rBtnIndonesia.Text = " Bahasa Indonesia"
        Me.rBtnIndonesia.UseVisualStyleBackColor = True
        '
        'rBtnInggris
        '
        Me.rBtnInggris.AutoSize = True
        Me.rBtnInggris.Location = New System.Drawing.Point(7, 43)
        Me.rBtnInggris.Name = "rBtnInggris"
        Me.rBtnInggris.Size = New System.Drawing.Size(95, 17)
        Me.rBtnInggris.TabIndex = 1
        Me.rBtnInggris.TabStop = True
        Me.rBtnInggris.Text = "Bahasa Inggris"
        Me.rBtnInggris.UseVisualStyleBackColor = True
        '
        'chkSains
        '
        Me.chkSains.AutoSize = True
        Me.chkSains.Location = New System.Drawing.Point(7, 20)
        Me.chkSains.Name = "chkSains"
        Me.chkSains.Size = New System.Drawing.Size(52, 17)
        Me.chkSains.TabIndex = 0
        Me.chkSains.Text = "Sains"
        Me.chkSains.UseVisualStyleBackColor = True
        '
        'chkSosial
        '
        Me.chkSosial.AutoSize = True
        Me.chkSosial.Location = New System.Drawing.Point(7, 43)
        Me.chkSosial.Name = "chkSosial"
        Me.chkSosial.Size = New System.Drawing.Size(57, 17)
        Me.chkSosial.TabIndex = 1
        Me.chkSosial.Text = " Sosial"
        Me.chkSosial.UseVisualStyleBackColor = True
        '
        'chkTeknologi
        '
        Me.chkTeknologi.AutoSize = True
        Me.chkTeknologi.Location = New System.Drawing.Point(7, 66)
        Me.chkTeknologi.Name = "chkTeknologi"
        Me.chkTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.chkTeknologi.TabIndex = 2
        Me.chkTeknologi.Text = "Teknologi"
        Me.chkTeknologi.UseVisualStyleBackColor = True
        '
        'chkBudaya
        '
        Me.chkBudaya.AutoSize = True
        Me.chkBudaya.Location = New System.Drawing.Point(7, 89)
        Me.chkBudaya.Name = "chkBudaya"
        Me.chkBudaya.Size = New System.Drawing.Size(62, 17)
        Me.chkBudaya.TabIndex = 3
        Me.chkBudaya.Text = "Budaya"
        Me.chkBudaya.UseVisualStyleBackColor = True
        '
        'btnTambahKoleksi
        '
        Me.btnTambahKoleksi.Location = New System.Drawing.Point(356, 688)
        Me.btnTambahKoleksi.Name = "btnTambahKoleksi"
        Me.btnTambahKoleksi.Size = New System.Drawing.Size(111, 23)
        Me.btnTambahKoleksi.TabIndex = 20
        Me.btnTambahKoleksi.Text = "Tambah Koleksi"
        Me.btnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'txtLokasiRak
        '
        Me.txtLokasiRak.Location = New System.Drawing.Point(429, 409)
        Me.txtLokasiRak.Name = "txtLokasiRak"
        Me.txtLokasiRak.Size = New System.Drawing.Size(200, 20)
        Me.txtLokasiRak.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 409)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Lokasi Rak"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tambah_Koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 723)
        Me.Controls.Add(Me.txtLokasiRak)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnTambahKoleksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.datePickTanggalMasuk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTahunTerbit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RTxtDeskripsi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTambahGambar)
        Me.Controls.Add(Me.pictBoxKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah_Koleksi"
        Me.Text = "Tambah_Koleksi"
        CType(Me.pictBoxKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pictBoxKoleksi As PictureBox
    Friend WithEvents btnTambahGambar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RTxtDeskripsi As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTahunTerbit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents datePickTanggalMasuk As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rBtnInggris As RadioButton
    Friend WithEvents rBtnIndonesia As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkBudaya As CheckBox
    Friend WithEvents chkTeknologi As CheckBox
    Friend WithEvents chkSosial As CheckBox
    Friend WithEvents chkSains As CheckBox
    Friend WithEvents btnTambahKoleksi As Button
    Friend WithEvents txtLokasiRak As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
