<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.listBoxBuku = New System.Windows.Forms.ListBox()
        Me.lblTambahBuku = New System.Windows.Forms.Label()
        Me.lblKurangiBuku = New System.Windows.Forms.Label()
        Me.dataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bahasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1203, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah koleksi"
        '
        'listBoxBuku
        '
        Me.listBoxBuku.FormattingEnabled = True
        Me.listBoxBuku.Location = New System.Drawing.Point(11, 68)
        Me.listBoxBuku.Name = "listBoxBuku"
        Me.listBoxBuku.Size = New System.Drawing.Size(200, 277)
        Me.listBoxBuku.TabIndex = 1
        '
        'lblTambahBuku
        '
        Me.lblTambahBuku.AutoSize = True
        Me.lblTambahBuku.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTambahBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTambahBuku.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTambahBuku.Location = New System.Drawing.Point(13, 35)
        Me.lblTambahBuku.Name = "lblTambahBuku"
        Me.lblTambahBuku.Size = New System.Drawing.Size(26, 18)
        Me.lblTambahBuku.TabIndex = 2
        Me.lblTambahBuku.Text = "➕"
        '
        'lblKurangiBuku
        '
        Me.lblKurangiBuku.AutoSize = True
        Me.lblKurangiBuku.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKurangiBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKurangiBuku.ForeColor = System.Drawing.SystemColors.Control
        Me.lblKurangiBuku.Location = New System.Drawing.Point(45, 35)
        Me.lblKurangiBuku.Name = "lblKurangiBuku"
        Me.lblKurangiBuku.Size = New System.Drawing.Size(26, 18)
        Me.lblKurangiBuku.TabIndex = 3
        Me.lblKurangiBuku.Text = "➖"
        '
        'dataGridKoleksi
        '
        Me.dataGridKoleksi.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridKoleksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.namaKoleksi, Me.jenisKoleksi, Me.penerbit, Me.deskripsi, Me.tahun, Me.lokasi, Me.tglMasuk, Me.stock, Me.bahasa, Me.kategori, Me.foto})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridKoleksi.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridKoleksi.EnableHeadersVisualStyles = False
        Me.dataGridKoleksi.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dataGridKoleksi.Location = New System.Drawing.Point(263, 68)
        Me.dataGridKoleksi.Margin = New System.Windows.Forms.Padding(2)
        Me.dataGridKoleksi.Name = "dataGridKoleksi"
        Me.dataGridKoleksi.RowHeadersWidth = 51
        Me.dataGridKoleksi.RowTemplate.Height = 24
        Me.dataGridKoleksi.Size = New System.Drawing.Size(885, 122)
        Me.dataGridKoleksi.TabIndex = 4
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'namaKoleksi
        '
        Me.namaKoleksi.HeaderText = "Nama Koleksi"
        Me.namaKoleksi.MinimumWidth = 6
        Me.namaKoleksi.Name = "namaKoleksi"
        Me.namaKoleksi.Width = 125
        '
        'jenisKoleksi
        '
        Me.jenisKoleksi.HeaderText = "Jenis Koleksi"
        Me.jenisKoleksi.MinimumWidth = 6
        Me.jenisKoleksi.Name = "jenisKoleksi"
        Me.jenisKoleksi.Width = 125
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit Koleksi"
        Me.penerbit.MinimumWidth = 6
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Width = 125
        '
        'deskripsi
        '
        Me.deskripsi.HeaderText = "Deskripsi Koleksi"
        Me.deskripsi.MinimumWidth = 6
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Width = 125
        '
        'tahun
        '
        Me.tahun.HeaderText = "Tahun Terbit"
        Me.tahun.MinimumWidth = 6
        Me.tahun.Name = "tahun"
        Me.tahun.Width = 125
        '
        'lokasi
        '
        Me.lokasi.HeaderText = "Lokasi Rak"
        Me.lokasi.MinimumWidth = 6
        Me.lokasi.Name = "lokasi"
        Me.lokasi.Width = 125
        '
        'tglMasuk
        '
        Me.tglMasuk.HeaderText = "Tanggal Masuk"
        Me.tglMasuk.MinimumWidth = 6
        Me.tglMasuk.Name = "tglMasuk"
        Me.tglMasuk.Width = 125
        '
        'stock
        '
        Me.stock.HeaderText = "Stock "
        Me.stock.MinimumWidth = 6
        Me.stock.Name = "stock"
        Me.stock.Width = 125
        '
        'bahasa
        '
        Me.bahasa.HeaderText = "Bahasa"
        Me.bahasa.MinimumWidth = 6
        Me.bahasa.Name = "bahasa"
        Me.bahasa.Width = 125
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.MinimumWidth = 6
        Me.kategori.Name = "kategori"
        Me.kategori.Width = 125
        '
        'foto
        '
        Me.foto.HeaderText = "Foto"
        Me.foto.MinimumWidth = 6
        Me.foto.Name = "foto"
        Me.foto.Width = 125
        '
        'btnShow
        '
        Me.btnShow.ForeColor = System.Drawing.Color.Black
        Me.btnShow.Location = New System.Drawing.Point(263, 195)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(344, 195)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.ForeColor = System.Drawing.Color.Black
        Me.btnHapus.Location = New System.Drawing.Point(425, 195)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Remove"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 355)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dataGridKoleksi)
        Me.Controls.Add(Me.lblKurangiBuku)
        Me.Controls.Add(Me.lblTambahBuku)
        Me.Controls.Add(Me.listBoxBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents listBoxBuku As ListBox
    Friend WithEvents lblTambahBuku As Label
    Friend WithEvents lblKurangiBuku As Label
    Friend WithEvents dataGridKoleksi As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnShow As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents namaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents jenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents deskripsi As DataGridViewTextBoxColumn
    Friend WithEvents tahun As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents tglMasuk As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents bahasa As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents foto As DataGridViewTextBoxColumn
End Class
