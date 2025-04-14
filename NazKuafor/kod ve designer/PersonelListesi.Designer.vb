<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonelListesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonelListesi))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.personeladiTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ara = New System.Windows.Forms.PictureBox()
        Me.kuaforDS = New System.Data.DataSet()
        Me.PersonelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.sil = New System.Windows.Forms.PictureBox()
        Me.PersonelTcNumarasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonelAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonelSoyadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonNumarasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Thistle
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonelTcNumarasi, Me.PersonelAdi, Me.PersonelSoyadi, Me.Adresi, Me.TelefonNumarasi})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(45, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(744, 390)
        Me.DataGridView1.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Thistle
        Me.Label6.Location = New System.Drawing.Point(595, 549)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Thistle
        Me.Label7.Location = New System.Drawing.Point(125, 539)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "İşlem Ekranına dön"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Thistle
        Me.PictureBox3.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.PictureBox3.Location = New System.Drawing.Point(720, 531)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 61)
        Me.PictureBox3.TabIndex = 52
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Thistle
        Me.PictureBox2.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.PictureBox2.Location = New System.Drawing.Point(45, 522)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 61)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'personeladiTBox
        '
        Me.personeladiTBox.Location = New System.Drawing.Point(172, 34)
        Me.personeladiTBox.Margin = New System.Windows.Forms.Padding(4)
        Me.personeladiTBox.Name = "personeladiTBox"
        Me.personeladiTBox.Size = New System.Drawing.Size(427, 22)
        Me.personeladiTBox.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(59, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Personel Adı:"
        '
        'ara
        '
        Me.ara.BackColor = System.Drawing.Color.Thistle
        Me.ara.Image = Global.NazKuafor.My.Resources.Resources._8726214_search_icon
        Me.ara.Location = New System.Drawing.Point(621, 12)
        Me.ara.Name = "ara"
        Me.ara.Size = New System.Drawing.Size(73, 64)
        Me.ara.TabIndex = 66
        Me.ara.TabStop = False
        '
        'kuaforDS
        '
        Me.kuaforDS.DataSetName = "NewDataSet"
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.Color.Thistle
        Me.sil.Image = Global.NazKuafor.My.Resources.Resources._8726424_trash_alt_icon__1_
        Me.sil.Location = New System.Drawing.Point(730, 12)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(59, 64)
        Me.sil.TabIndex = 89
        Me.sil.TabStop = False
        '
        'PersonelTcNumarasi
        '
        Me.PersonelTcNumarasi.HeaderText = "Tc Kimlik Numarası"
        Me.PersonelTcNumarasi.MinimumWidth = 6
        Me.PersonelTcNumarasi.Name = "PersonelTcNumarasi"
        Me.PersonelTcNumarasi.ReadOnly = True
        Me.PersonelTcNumarasi.Width = 125
        '
        'PersonelAdi
        '
        Me.PersonelAdi.HeaderText = "Adı"
        Me.PersonelAdi.MinimumWidth = 6
        Me.PersonelAdi.Name = "PersonelAdi"
        Me.PersonelAdi.ReadOnly = True
        Me.PersonelAdi.Width = 125
        '
        'PersonelSoyadi
        '
        Me.PersonelSoyadi.HeaderText = "Soyadı"
        Me.PersonelSoyadi.MinimumWidth = 6
        Me.PersonelSoyadi.Name = "PersonelSoyadi"
        Me.PersonelSoyadi.ReadOnly = True
        Me.PersonelSoyadi.Width = 125
        '
        'Adresi
        '
        Me.Adresi.HeaderText = "Adresi"
        Me.Adresi.MinimumWidth = 6
        Me.Adresi.Name = "Adresi"
        Me.Adresi.ReadOnly = True
        Me.Adresi.Width = 125
        '
        'TelefonNumarasi
        '
        Me.TelefonNumarasi.HeaderText = "Telefon Numarası"
        Me.TelefonNumarasi.MinimumWidth = 6
        Me.TelefonNumarasi.Name = "TelefonNumarasi"
        Me.TelefonNumarasi.ReadOnly = True
        Me.TelefonNumarasi.Width = 125
        '
        'PersonelListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NazKuafor.My.Resources.Resources.arka61
        Me.ClientSize = New System.Drawing.Size(832, 604)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.personeladiTBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ara)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PersonelListesi"
        Me.Text = "Personel Listesi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents personeladiTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ara As PictureBox
    Friend WithEvents kuaforDS As DataSet
    Friend WithEvents PersonelBS As BindingSource
    Friend WithEvents sil As PictureBox
    Friend WithEvents PersonelTcNumarasi As DataGridViewTextBoxColumn
    Friend WithEvents PersonelAdi As DataGridViewTextBoxColumn
    Friend WithEvents PersonelSoyadi As DataGridViewTextBoxColumn
    Friend WithEvents Adresi As DataGridViewTextBoxColumn
    Friend WithEvents TelefonNumarasi As DataGridViewTextBoxColumn
End Class
