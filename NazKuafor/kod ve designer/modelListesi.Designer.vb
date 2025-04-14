<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modelListesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modelListesi))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.kullanilanuruncmb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fiyat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adtb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ara = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modeladitb = New System.Windows.Forms.TextBox()
        Me.sil = New System.Windows.Forms.PictureBox()
        Me.guncelle = New System.Windows.Forms.PictureBox()
        Me.kuadorDS = New System.Data.DataSet()
        Me.kuaforBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.urunBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.modelnumarasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tutari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kullanilanUrunNumarasiC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guncelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuadorDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label6.Location = New System.Drawing.Point(1021, 572)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label7.Location = New System.Drawing.Point(102, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "İşlem Ekranına dön"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LavenderBlush
        Me.PictureBox3.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.PictureBox3.Location = New System.Drawing.Point(1137, 540)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 69)
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        '
        'kullanilanuruncmb
        '
        Me.kullanilanuruncmb.FormattingEnabled = True
        Me.kullanilanuruncmb.Location = New System.Drawing.Point(1025, 390)
        Me.kullanilanuruncmb.Name = "kullanilanuruncmb"
        Me.kullanilanuruncmb.Size = New System.Drawing.Size(190, 24)
        Me.kullanilanuruncmb.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(891, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Kullanılan Ürün:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(905, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Fiyatı:"
        '
        'fiyat
        '
        Me.fiyat.Location = New System.Drawing.Point(1025, 322)
        Me.fiyat.Multiline = True
        Me.fiyat.Name = "fiyat"
        Me.fiyat.Size = New System.Drawing.Size(190, 24)
        Me.fiyat.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(905, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Model Adı:"
        '
        'adtb
        '
        Me.adtb.Location = New System.Drawing.Point(1025, 260)
        Me.adtb.Multiline = True
        Me.adtb.Name = "adtb"
        Me.adtb.Size = New System.Drawing.Size(190, 23)
        Me.adtb.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(946, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(229, 23)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "MODEL GÜNCELLEME"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.PictureBox2.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.PictureBox2.Location = New System.Drawing.Point(25, 540)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 69)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modelnumarasi, Me.modelAdi, Me.Tutari, Me.kullanilanUrunNumarasiC})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(25, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(823, 393)
        Me.DataGridView1.TabIndex = 41
        '
        'ara
        '
        Me.ara.BackColor = System.Drawing.Color.LavenderBlush
        Me.ara.Image = Global.NazKuafor.My.Resources.Resources._8726214_search_icon
        Me.ara.Location = New System.Drawing.Point(581, 42)
        Me.ara.Name = "ara"
        Me.ara.Size = New System.Drawing.Size(73, 64)
        Me.ara.TabIndex = 69
        Me.ara.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(22, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Model Adı:"
        '
        'modeladitb
        '
        Me.modeladitb.Location = New System.Drawing.Point(135, 61)
        Me.modeladitb.Margin = New System.Windows.Forms.Padding(4)
        Me.modeladitb.Name = "modeladitb"
        Me.modeladitb.Size = New System.Drawing.Size(400, 22)
        Me.modeladitb.TabIndex = 71
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.Color.LavenderBlush
        Me.sil.Image = Global.NazKuafor.My.Resources.Resources._8726424_trash_alt_icon__1_
        Me.sil.Location = New System.Drawing.Point(683, 42)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(59, 64)
        Me.sil.TabIndex = 83
        Me.sil.TabStop = False
        '
        'guncelle
        '
        Me.guncelle.BackColor = System.Drawing.Color.LavenderBlush
        Me.guncelle.Image = Global.NazKuafor.My.Resources.Resources._8726304_refresh_icon__1_
        Me.guncelle.Location = New System.Drawing.Point(781, 42)
        Me.guncelle.Name = "guncelle"
        Me.guncelle.Size = New System.Drawing.Size(59, 64)
        Me.guncelle.TabIndex = 84
        Me.guncelle.TabStop = False
        '
        'kuadorDS
        '
        Me.kuadorDS.DataSetName = "NewDataSet"
        '
        'modelnumarasi
        '
        Me.modelnumarasi.HeaderText = "modelnumarasi"
        Me.modelnumarasi.MinimumWidth = 6
        Me.modelnumarasi.Name = "modelnumarasi"
        Me.modelnumarasi.ReadOnly = True
        Me.modelnumarasi.Visible = False
        Me.modelnumarasi.Width = 125
        '
        'modelAdi
        '
        Me.modelAdi.HeaderText = "Model Adı"
        Me.modelAdi.MinimumWidth = 6
        Me.modelAdi.Name = "modelAdi"
        Me.modelAdi.ReadOnly = True
        Me.modelAdi.Width = 125
        '
        'Tutari
        '
        Me.Tutari.HeaderText = "Tutarı"
        Me.Tutari.MinimumWidth = 6
        Me.Tutari.Name = "Tutari"
        Me.Tutari.ReadOnly = True
        Me.Tutari.Width = 385
        '
        'kullanilanUrunNumarasiC
        '
        Me.kullanilanUrunNumarasiC.HeaderText = "Kullanılan Ürün"
        Me.kullanilanUrunNumarasiC.MinimumWidth = 6
        Me.kullanilanUrunNumarasiC.Name = "kullanilanUrunNumarasiC"
        Me.kullanilanUrunNumarasiC.ReadOnly = True
        Me.kullanilanUrunNumarasiC.Width = 385
        '
        'modelListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NazKuafor.My.Resources.Resources.pexels_moose_photos_170195_1029894__1_
        Me.ClientSize = New System.Drawing.Size(1232, 631)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kullanilanuruncmb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fiyat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.adtb)
        Me.Controls.Add(Me.guncelle)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.modeladitb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ara)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modelListesi"
        Me.Text = "Model Listesi"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guncelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuadorDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents kullanilanuruncmb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fiyat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents adtb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ara As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents modeladitb As TextBox
    Friend WithEvents sil As PictureBox
    Friend WithEvents guncelle As PictureBox
    Friend WithEvents kuadorDS As DataSet
    Friend WithEvents kuaforBS As BindingSource
    Friend WithEvents urunBS As BindingSource
    Friend WithEvents modelnumarasi As DataGridViewTextBoxColumn
    Friend WithEvents modelAdi As DataGridViewTextBoxColumn
    Friend WithEvents Tutari As DataGridViewTextBoxColumn
    Friend WithEvents kullanilanUrunNumarasiC As DataGridViewComboBoxColumn
End Class
