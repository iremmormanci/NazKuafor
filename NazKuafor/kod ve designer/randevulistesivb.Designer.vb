<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class randevulistesivb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(randevulistesivb))
        Me.randevuDGV = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.kuaforDS = New System.Data.DataSet()
        Me.randevuBs = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ara = New System.Windows.Forms.PictureBox()
        Me.musteriadiTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sil = New System.Windows.Forms.PictureBox()
        Me.modelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.gecmisRandevuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.RandevuNumarasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusteriAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusteriSoyadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelNumarasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YapanPersonelTc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RandevuTarihi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RandevuSaati = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.randevuDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.randevuBs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gecmisRandevuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'randevuDGV
        '
        Me.randevuDGV.AllowUserToAddRows = False
        Me.randevuDGV.AllowUserToDeleteRows = False
        Me.randevuDGV.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.randevuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.randevuDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RandevuNumarasi, Me.MusteriAdi, Me.MusteriSoyadi, Me.TelefonNo, Me.modelNumarasi, Me.YapanPersonelTc, Me.RandevuTarihi, Me.RandevuSaati})
        Me.randevuDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.randevuDGV.Location = New System.Drawing.Point(35, 88)
        Me.randevuDGV.Name = "randevuDGV"
        Me.randevuDGV.ReadOnly = True
        Me.randevuDGV.RowHeadersWidth = 51
        Me.randevuDGV.RowTemplate.Height = 24
        Me.randevuDGV.Size = New System.Drawing.Size(774, 413)
        Me.randevuDGV.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(621, 544)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(114, 544)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "İşlem Ekranına dön"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox3.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.PictureBox3.Location = New System.Drawing.Point(740, 527)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 61)
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox2.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.PictureBox2.Location = New System.Drawing.Point(34, 527)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 61)
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'kuaforDS
        '
        Me.kuaforDS.DataSetName = "NewDataSet"
        '
        'ara
        '
        Me.ara.BackColor = System.Drawing.Color.AliceBlue
        Me.ara.Image = Global.NazKuafor.My.Resources.Resources._8726214_search_icon
        Me.ara.Location = New System.Drawing.Point(587, 12)
        Me.ara.Name = "ara"
        Me.ara.Size = New System.Drawing.Size(66, 64)
        Me.ara.TabIndex = 63
        Me.ara.TabStop = False
        '
        'musteriadiTBox
        '
        Me.musteriadiTBox.Location = New System.Drawing.Point(160, 38)
        Me.musteriadiTBox.Margin = New System.Windows.Forms.Padding(4)
        Me.musteriadiTBox.Name = "musteriadiTBox"
        Me.musteriadiTBox.Size = New System.Drawing.Size(409, 22)
        Me.musteriadiTBox.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(66, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Müşteri Adı:"
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.Color.AliceBlue
        Me.sil.Image = Global.NazKuafor.My.Resources.Resources._8726424_trash_alt_icon__1_
        Me.sil.Location = New System.Drawing.Point(690, 12)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(59, 64)
        Me.sil.TabIndex = 85
        Me.sil.TabStop = False
        '
        'RandevuNumarasi
        '
        Me.RandevuNumarasi.HeaderText = "RandevuNumarasi"
        Me.RandevuNumarasi.MinimumWidth = 6
        Me.RandevuNumarasi.Name = "RandevuNumarasi"
        Me.RandevuNumarasi.ReadOnly = True
        Me.RandevuNumarasi.Visible = False
        Me.RandevuNumarasi.Width = 125
        '
        'MusteriAdi
        '
        Me.MusteriAdi.HeaderText = "Ad"
        Me.MusteriAdi.MinimumWidth = 6
        Me.MusteriAdi.Name = "MusteriAdi"
        Me.MusteriAdi.ReadOnly = True
        Me.MusteriAdi.Width = 180
        '
        'MusteriSoyadi
        '
        Me.MusteriSoyadi.HeaderText = "Soyad"
        Me.MusteriSoyadi.MinimumWidth = 6
        Me.MusteriSoyadi.Name = "MusteriSoyadi"
        Me.MusteriSoyadi.ReadOnly = True
        Me.MusteriSoyadi.Width = 181
        '
        'TelefonNo
        '
        Me.TelefonNo.HeaderText = "Telefon Numarası"
        Me.TelefonNo.MinimumWidth = 6
        Me.TelefonNo.Name = "TelefonNo"
        Me.TelefonNo.ReadOnly = True
        Me.TelefonNo.Width = 180
        '
        'modelNumarasi
        '
        Me.modelNumarasi.HeaderText = "İşlem Türü"
        Me.modelNumarasi.MinimumWidth = 6
        Me.modelNumarasi.Name = "modelNumarasi"
        Me.modelNumarasi.ReadOnly = True
        Me.modelNumarasi.Width = 180
        '
        'YapanPersonelTc
        '
        Me.YapanPersonelTc.HeaderText = "YapanPersonelTc"
        Me.YapanPersonelTc.MinimumWidth = 6
        Me.YapanPersonelTc.Name = "YapanPersonelTc"
        Me.YapanPersonelTc.ReadOnly = True
        Me.YapanPersonelTc.Visible = False
        Me.YapanPersonelTc.Width = 125
        '
        'RandevuTarihi
        '
        Me.RandevuTarihi.HeaderText = "Randevu Tarihi"
        Me.RandevuTarihi.MinimumWidth = 6
        Me.RandevuTarihi.Name = "RandevuTarihi"
        Me.RandevuTarihi.ReadOnly = True
        Me.RandevuTarihi.Visible = False
        Me.RandevuTarihi.Width = 125
        '
        'RandevuSaati
        '
        Me.RandevuSaati.HeaderText = "Randevu Saati"
        Me.RandevuSaati.MinimumWidth = 6
        Me.RandevuSaati.Name = "RandevuSaati"
        Me.RandevuSaati.ReadOnly = True
        Me.RandevuSaati.Visible = False
        Me.RandevuSaati.Width = 125
        '
        'randevulistesivb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NazKuafor.My.Resources.Resources.images
        Me.ClientSize = New System.Drawing.Size(851, 601)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.musteriadiTBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ara)
        Me.Controls.Add(Me.randevuDGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "randevulistesivb"
        Me.Text = "Randevu Listesi"
        CType(Me.randevuDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.randevuBs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gecmisRandevuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents randevuDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents kuaforDS As DataSet
    Friend WithEvents randevuBs As BindingSource
    Friend WithEvents PersonelBS As BindingSource
    Friend WithEvents ara As PictureBox
    Friend WithEvents musteriadiTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sil As PictureBox
    Friend WithEvents modelBS As BindingSource
    Friend WithEvents gecmisRandevuBS As BindingSource
    Friend WithEvents RandevuNumarasi As DataGridViewTextBoxColumn
    Friend WithEvents MusteriAdi As DataGridViewTextBoxColumn
    Friend WithEvents MusteriSoyadi As DataGridViewTextBoxColumn
    Friend WithEvents TelefonNo As DataGridViewTextBoxColumn
    Friend WithEvents modelNumarasi As DataGridViewTextBoxColumn
    Friend WithEvents YapanPersonelTc As DataGridViewTextBoxColumn
    Friend WithEvents RandevuTarihi As DataGridViewTextBoxColumn
    Friend WithEvents RandevuSaati As DataGridViewTextBoxColumn
End Class
