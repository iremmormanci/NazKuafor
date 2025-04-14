<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonelKayit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonelKayit))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telefontb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.psoyaditb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paditb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tctb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.adrestb = New System.Windows.Forms.TextBox()
        Me.kapat = New System.Windows.Forms.PictureBox()
        Me.giristb = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.liste = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kaydet = New System.Windows.Forms.PictureBox()
        Me.KuaforDS = New System.Data.DataSet()
        Me.personelBS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.kapat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.giristb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.liste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kaydet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KuaforDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(743, 566)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 566)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Giriş Ekranına dön"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(584, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Telefon Numarası:"
        '
        'telefontb
        '
        Me.telefontb.Location = New System.Drawing.Point(746, 322)
        Me.telefontb.Multiline = True
        Me.telefontb.Name = "telefontb"
        Me.telefontb.Size = New System.Drawing.Size(190, 24)
        Me.telefontb.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(584, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Personel Soyadı:"
        '
        'psoyaditb
        '
        Me.psoyaditb.Location = New System.Drawing.Point(746, 208)
        Me.psoyaditb.Multiline = True
        Me.psoyaditb.Name = "psoyaditb"
        Me.psoyaditb.Size = New System.Drawing.Size(190, 24)
        Me.psoyaditb.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(584, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Personel Adı:"
        '
        'paditb
        '
        Me.paditb.Location = New System.Drawing.Point(746, 148)
        Me.paditb.Multiline = True
        Me.paditb.Name = "paditb"
        Me.paditb.Size = New System.Drawing.Size(190, 23)
        Me.paditb.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(579, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Tc Kimlik Numarası:"
        '
        'tctb
        '
        Me.tctb.Location = New System.Drawing.Point(746, 103)
        Me.tctb.Multiline = True
        Me.tctb.Name = "tctb"
        Me.tctb.Size = New System.Drawing.Size(190, 24)
        Me.tctb.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(587, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Adresi:"
        '
        'adrestb
        '
        Me.adrestb.Location = New System.Drawing.Point(746, 267)
        Me.adrestb.Multiline = True
        Me.adrestb.Name = "adrestb"
        Me.adrestb.Size = New System.Drawing.Size(190, 23)
        Me.adrestb.TabIndex = 63
        '
        'kapat
        '
        Me.kapat.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.kapat.Location = New System.Drawing.Point(863, 542)
        Me.kapat.Name = "kapat"
        Me.kapat.Size = New System.Drawing.Size(65, 57)
        Me.kapat.TabIndex = 52
        Me.kapat.TabStop = False
        '
        'giristb
        '
        Me.giristb.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.giristb.Location = New System.Drawing.Point(41, 542)
        Me.giristb.Name = "giristb"
        Me.giristb.Size = New System.Drawing.Size(65, 57)
        Me.giristb.TabIndex = 51
        Me.giristb.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(504, 566)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Personel Listesine Git"
        '
        'liste
        '
        Me.liste.Image = Global.NazKuafor.My.Resources.Resources._2303204_done_options_todo_menu_check_icon
        Me.liste.Location = New System.Drawing.Point(410, 542)
        Me.liste.Name = "liste"
        Me.liste.Size = New System.Drawing.Size(63, 57)
        Me.liste.TabIndex = 67
        Me.liste.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NazKuafor.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(42, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(497, 470)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(793, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Kaydet"
        '
        'kaydet
        '
        Me.kaydet.Image = Global.NazKuafor.My.Resources.Resources._8726195_save_floppy_icon
        Me.kaydet.Location = New System.Drawing.Point(722, 403)
        Me.kaydet.Name = "kaydet"
        Me.kaydet.Size = New System.Drawing.Size(59, 64)
        Me.kaydet.TabIndex = 84
        Me.kaydet.TabStop = False
        '
        'KuaforDS
        '
        Me.KuaforDS.DataSetName = "NewDataSet"
        '
        'PersonelKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(963, 623)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.kaydet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.liste)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.adrestb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.kapat)
        Me.Controls.Add(Me.giristb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.telefontb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.psoyaditb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.paditb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tctb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PersonelKayit"
        Me.Text = "Personel Kayıt Ekranına Hoşgeldiniz"
        CType(Me.kapat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.giristb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.liste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kaydet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KuaforDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personelBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents kapat As PictureBox
    Friend WithEvents giristb As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents telefontb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents psoyaditb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents paditb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tctb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents adrestb As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents liste As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents kaydet As PictureBox
    Friend WithEvents KuaforDS As DataSet
    Friend WithEvents personelBS As BindingSource
End Class
