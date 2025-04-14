<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stoklistesi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stoklistesi))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.urunnumarasi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ara = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.guncelle = New System.Windows.Forms.PictureBox()
        Me.uruncmb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kuaforDS = New System.Data.DataSet()
        Me.kuaforBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.urunBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stok = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guncelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(31, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(712, 376)
        Me.DataGridView1.TabIndex = 41
        '
        'urunnumarasi
        '
        Me.urunnumarasi.Location = New System.Drawing.Point(167, 49)
        Me.urunnumarasi.Margin = New System.Windows.Forms.Padding(4)
        Me.urunnumarasi.Name = "urunnumarasi"
        Me.urunnumarasi.Size = New System.Drawing.Size(397, 22)
        Me.urunnumarasi.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(48, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Ürün Numarası:"
        '
        'ara
        '
        Me.ara.BackColor = System.Drawing.Color.AliceBlue
        Me.ara.Image = Global.NazKuafor.My.Resources.Resources._8726214_search_icon
        Me.ara.Location = New System.Drawing.Point(591, 26)
        Me.ara.Name = "ara"
        Me.ara.Size = New System.Drawing.Size(63, 64)
        Me.ara.TabIndex = 72
        Me.ara.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(914, 555)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(121, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "İşlem Ekranına dön"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox3.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.PictureBox3.Location = New System.Drawing.Point(1043, 535)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 61)
        Me.PictureBox3.TabIndex = 77
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox2.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.PictureBox2.Location = New System.Drawing.Point(30, 533)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 61)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'guncelle
        '
        Me.guncelle.Image = Global.NazKuafor.My.Resources.Resources._8726304_refresh_icon__1_
        Me.guncelle.Location = New System.Drawing.Point(917, 382)
        Me.guncelle.Name = "guncelle"
        Me.guncelle.Size = New System.Drawing.Size(59, 64)
        Me.guncelle.TabIndex = 102
        Me.guncelle.TabStop = False
        '
        'uruncmb
        '
        Me.uruncmb.FormattingEnabled = True
        Me.uruncmb.Location = New System.Drawing.Point(895, 320)
        Me.uruncmb.Name = "uruncmb"
        Me.uruncmb.Size = New System.Drawing.Size(230, 24)
        Me.uruncmb.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(776, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Adeti:"
        '
        'adet
        '
        Me.adet.Location = New System.Drawing.Point(895, 248)
        Me.adet.Multiline = True
        Me.adet.Name = "adet"
        Me.adet.Size = New System.Drawing.Size(230, 24)
        Me.adet.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(776, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Ürün Adı:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(982, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Güncelle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(878, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 23)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "STOK GÜNCELLEME"
        '
        'kuaforDS
        '
        Me.kuaforDS.DataSetName = "NewDataSet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(776, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Stok Numarası:"
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(895, 181)
        Me.stok.Multiline = True
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(230, 24)
        Me.stok.TabIndex = 110
        '
        'stoklistesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.NazKuafor.My.Resources.Resources.kare2
        Me.ClientSize = New System.Drawing.Size(1160, 612)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.uruncmb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.adet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.guncelle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.urunnumarasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ara)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stoklistesi"
        Me.Text = "Stok Listesi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guncelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents urunnumarasi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ara As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents guncelle As PictureBox
    Friend WithEvents uruncmb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kuaforDS As DataSet
    Friend WithEvents kuaforBS As BindingSource
    Friend WithEvents urunBS As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents stok As TextBox
End Class
