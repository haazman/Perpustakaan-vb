<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Koleksivb
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
        Me.txtLokasiRak = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBudaya = New System.Windows.Forms.CheckBox()
        Me.chkTeknologi = New System.Windows.Forms.CheckBox()
        Me.chkSosial = New System.Windows.Forms.CheckBox()
        Me.chkSains = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rBtnInggris = New System.Windows.Forms.RadioButton()
        Me.rBtnIndonesia = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datePickTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RTxtDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambahGambar = New System.Windows.Forms.Button()
        Me.pictBoxKoleksi = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictBoxKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLokasiRak
        '
        Me.txtLokasiRak.Location = New System.Drawing.Point(574, 500)
        Me.txtLokasiRak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLokasiRak.Name = "txtLokasiRak"
        Me.txtLokasiRak.Size = New System.Drawing.Size(265, 22)
        Me.txtLokasiRak.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(359, 500)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Lokasi Rak"
        '
        'btnUpdateKoleksi
        '
        Me.btnUpdateKoleksi.Location = New System.Drawing.Point(477, 844)
        Me.btnUpdateKoleksi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateKoleksi.Name = "btnUpdateKoleksi"
        Me.btnUpdateKoleksi.Size = New System.Drawing.Size(148, 28)
        Me.btnUpdateKoleksi.TabIndex = 44
        Me.btnUpdateKoleksi.Text = "Update Koleksi"
        Me.btnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBudaya)
        Me.GroupBox2.Controls.Add(Me.chkTeknologi)
        Me.GroupBox2.Controls.Add(Me.chkSosial)
        Me.GroupBox2.Controls.Add(Me.chkSains)
        Me.GroupBox2.Location = New System.Drawing.Point(574, 684)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 137)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'chkBudaya
        '
        Me.chkBudaya.AutoSize = True
        Me.chkBudaya.Location = New System.Drawing.Point(9, 110)
        Me.chkBudaya.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBudaya.Name = "chkBudaya"
        Me.chkBudaya.Size = New System.Drawing.Size(76, 20)
        Me.chkBudaya.TabIndex = 3
        Me.chkBudaya.Text = "Budaya"
        Me.chkBudaya.UseVisualStyleBackColor = True
        '
        'chkTeknologi
        '
        Me.chkTeknologi.AutoSize = True
        Me.chkTeknologi.Location = New System.Drawing.Point(9, 81)
        Me.chkTeknologi.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTeknologi.Name = "chkTeknologi"
        Me.chkTeknologi.Size = New System.Drawing.Size(90, 20)
        Me.chkTeknologi.TabIndex = 2
        Me.chkTeknologi.Text = "Teknologi"
        Me.chkTeknologi.UseVisualStyleBackColor = True
        '
        'chkSosial
        '
        Me.chkSosial.AutoSize = True
        Me.chkSosial.Location = New System.Drawing.Point(9, 53)
        Me.chkSosial.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSosial.Name = "chkSosial"
        Me.chkSosial.Size = New System.Drawing.Size(70, 20)
        Me.chkSosial.TabIndex = 1
        Me.chkSosial.Text = " Sosial"
        Me.chkSosial.UseVisualStyleBackColor = True
        '
        'chkSains
        '
        Me.chkSains.AutoSize = True
        Me.chkSains.Location = New System.Drawing.Point(9, 25)
        Me.chkSains.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSains.Name = "chkSains"
        Me.chkSains.Size = New System.Drawing.Size(63, 20)
        Me.chkSains.TabIndex = 0
        Me.chkSains.Text = "Sains"
        Me.chkSains.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(359, 684)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Kategori"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnInggris)
        Me.GroupBox1.Controls.Add(Me.rBtnIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(574, 535)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'rBtnInggris
        '
        Me.rBtnInggris.AutoSize = True
        Me.rBtnInggris.Location = New System.Drawing.Point(9, 53)
        Me.rBtnInggris.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtnInggris.Name = "rBtnInggris"
        Me.rBtnInggris.Size = New System.Drawing.Size(118, 20)
        Me.rBtnInggris.TabIndex = 1
        Me.rBtnInggris.TabStop = True
        Me.rBtnInggris.Text = "Bahasa Inggris"
        Me.rBtnInggris.UseVisualStyleBackColor = True
        '
        'rBtnIndonesia
        '
        Me.rBtnIndonesia.AutoSize = True
        Me.rBtnIndonesia.Location = New System.Drawing.Point(9, 25)
        Me.rBtnIndonesia.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtnIndonesia.Name = "rBtnIndonesia"
        Me.rBtnIndonesia.Size = New System.Drawing.Size(140, 20)
        Me.rBtnIndonesia.TabIndex = 0
        Me.rBtnIndonesia.TabStop = True
        Me.rBtnIndonesia.Text = " Bahasa Indonesia"
        Me.rBtnIndonesia.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(359, 535)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Bahasa"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(574, 463)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(265, 22)
        Me.txtStock.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(359, 463)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Stock"
        '
        'datePickTanggalMasuk
        '
        Me.datePickTanggalMasuk.Location = New System.Drawing.Point(574, 422)
        Me.datePickTanggalMasuk.Margin = New System.Windows.Forms.Padding(4)
        Me.datePickTanggalMasuk.Name = "datePickTanggalMasuk"
        Me.datePickTanggalMasuk.Size = New System.Drawing.Size(265, 22)
        Me.datePickTanggalMasuk.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 422)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'txtTahunTerbit
        '
        Me.txtTahunTerbit.Location = New System.Drawing.Point(574, 361)
        Me.txtTahunTerbit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTahunTerbit.Name = "txtTahunTerbit"
        Me.txtTahunTerbit.Size = New System.Drawing.Size(265, 22)
        Me.txtTahunTerbit.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 361)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Tahun Terbit"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(574, 307)
        Me.txtPenerbit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(265, 22)
        Me.txtPenerbit.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 307)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Penerbit"
        '
        'RTxtDeskripsi
        '
        Me.RTxtDeskripsi.Location = New System.Drawing.Point(574, 159)
        Me.RTxtDeskripsi.Margin = New System.Windows.Forms.Padding(4)
        Me.RTxtDeskripsi.Name = "RTxtDeskripsi"
        Me.RTxtDeskripsi.Size = New System.Drawing.Size(265, 117)
        Me.RTxtDeskripsi.TabIndex = 31
        Me.RTxtDeskripsi.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Deskripsi"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Buku"})
        Me.cmbJenis.Location = New System.Drawing.Point(574, 105)
        Me.cmbJenis.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(265, 24)
        Me.cmbJenis.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Jenis Koleksi"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(574, 49)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(265, 22)
        Me.txtNama.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nama Koleksi"
        '
        'btnTambahGambar
        '
        Me.btnTambahGambar.Location = New System.Drawing.Point(26, 222)
        Me.btnTambahGambar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTambahGambar.Name = "btnTambahGambar"
        Me.btnTambahGambar.Size = New System.Drawing.Size(148, 28)
        Me.btnTambahGambar.TabIndex = 25
        Me.btnTambahGambar.Text = "Tambah Gambar"
        Me.btnTambahGambar.UseVisualStyleBackColor = True
        '
        'pictBoxKoleksi
        '
        Me.pictBoxKoleksi.Location = New System.Drawing.Point(26, 49)
        Me.pictBoxKoleksi.Margin = New System.Windows.Forms.Padding(4)
        Me.pictBoxKoleksi.Name = "pictBoxKoleksi"
        Me.pictBoxKoleksi.Size = New System.Drawing.Size(148, 165)
        Me.pictBoxKoleksi.TabIndex = 24
        Me.pictBoxKoleksi.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 31)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tambah Koleksi"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Update_Koleksivb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 891)
        Me.Controls.Add(Me.txtLokasiRak)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnUpdateKoleksi)
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
        Me.Name = "Update_Koleksivb"
        Me.Text = "Update_Koleksivb"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictBoxKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLokasiRak As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnUpdateKoleksi As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkBudaya As CheckBox
    Friend WithEvents chkTeknologi As CheckBox
    Friend WithEvents chkSosial As CheckBox
    Friend WithEvents chkSains As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rBtnInggris As RadioButton
    Friend WithEvents rBtnIndonesia As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents datePickTanggalMasuk As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTahunTerbit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RTxtDeskripsi As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambahGambar As Button
    Friend WithEvents pictBoxKoleksi As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
