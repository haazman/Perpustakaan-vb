<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Koleksi
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
        Me.lblKoleksiDihapus = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Ingin Menghapus Koleksi"
        '
        'lblKoleksiDihapus
        '
        Me.lblKoleksiDihapus.AutoSize = True
        Me.lblKoleksiDihapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKoleksiDihapus.ForeColor = System.Drawing.Color.Red
        Me.lblKoleksiDihapus.Location = New System.Drawing.Point(82, 112)
        Me.lblKoleksiDihapus.Name = "lblKoleksiDihapus"
        Me.lblKoleksiDihapus.Size = New System.Drawing.Size(104, 18)
        Me.lblKoleksiDihapus.TabIndex = 1
        Me.lblKoleksiDihapus.Text = "Koleksi Hapus"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(99, 179)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Hapus_Koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 252)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.lblKoleksiDihapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Koleksi"
        Me.Text = "Hapus_Koleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblKoleksiDihapus As Label
    Friend WithEvents btnHapus As Button
End Class
