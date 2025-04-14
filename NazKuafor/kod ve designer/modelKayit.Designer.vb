<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modelKayit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modelKayit))
        Me.islemcmb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adtb = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.liste = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kapat = New System.Windows.Forms.PictureBox()
        Me.giristb = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kaydet = New System.Windows.Forms.PictureBox()
        Me.fiyati = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.urunBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.kuadorDS = New System.Data.DataSet()
        Me.islemBS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kapat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.giristb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kaydet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuadorDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.islemBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'islemcmb
        '
        Me.islemcmb.FormattingEnabled = True
        Me.islemcmb.Location = New System.Drawing.Point(669, 274)
        Me.islemcmb.Name = "islemcmb"
        Me.islemcmb.Size = New System.Drawing.Size(190, 24)
        Me.islemcmb.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(535, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Kullanılan Ürün:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(549, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Model Adı:"
        '
        'adtb
        '
        Me.adtb.Location = New System.Drawing.Point(669, 144)
        Me.adtb.Multiline = True
        Me.adtb.Name = "adtb"
        Me.adtb.Size = New System.Drawing.Size(190, 23)
        Me.adtb.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NazKuafor.My.Resources.Resources._61
        Me.PictureBox1.Location = New System.Drawing.Point(24, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(425, 455)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(468, 532)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "İşlem Listesine Git"
        '
        'liste
        '
        Me.liste.Image = Global.NazKuafor.My.Resources.Resources._2303204_done_options_todo_menu_check_icon
        Me.liste.Location = New System.Drawing.Point(374, 508)
        Me.liste.Name = "liste"
        Me.liste.Size = New System.Drawing.Size(63, 57)
        Me.liste.TabIndex = 73
        Me.liste.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(707, 532)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 532)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Giriş Ekranına dön"
        '
        'kapat
        '
        Me.kapat.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.kapat.Location = New System.Drawing.Point(827, 508)
        Me.kapat.Name = "kapat"
        Me.kapat.Size = New System.Drawing.Size(65, 57)
        Me.kapat.TabIndex = 70
        Me.kapat.TabStop = False
        '
        'giristb
        '
        Me.giristb.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.giristb.Location = New System.Drawing.Point(5, 508)
        Me.giristb.Name = "giristb"
        Me.giristb.Size = New System.Drawing.Size(65, 57)
        Me.giristb.TabIndex = 69
        Me.giristb.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(707, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Kaydet"
        '
        'kaydet
        '
        Me.kaydet.Image = Global.NazKuafor.My.Resources.Resources._8726195_save_floppy_icon
        Me.kaydet.Location = New System.Drawing.Point(635, 371)
        Me.kaydet.Name = "kaydet"
        Me.kaydet.Size = New System.Drawing.Size(59, 64)
        Me.kaydet.TabIndex = 90
        Me.kaydet.TabStop = False
        '
        'fiyati
        '
        Me.fiyati.Location = New System.Drawing.Point(669, 206)
        Me.fiyati.Multiline = True
        Me.fiyati.Name = "fiyati"
        Me.fiyati.Size = New System.Drawing.Size(190, 24)
        Me.fiyati.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(549, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Fiyatı:"
        '
        'kuadorDS
        '
        Me.kuadorDS.DataSetName = "NewDataSet"
        '
        'modelKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(922, 587)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.kaydet)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.liste)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.kapat)
        Me.Controls.Add(Me.giristb)
        Me.Controls.Add(Me.islemcmb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fiyati)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.adtb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modelKayit"
        Me.Text = "İşlemler Ekranına Hoşgeldiniz"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kapat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.giristb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kaydet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuadorDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.islemBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents islemcmb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents adtb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents liste As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents kapat As PictureBox
    Friend WithEvents giristb As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents kaydet As PictureBox
    Friend WithEvents fiyati As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents urunBS As BindingSource
    Friend WithEvents kuadorDS As DataSet
    Friend WithEvents islemBS As BindingSource
End Class
