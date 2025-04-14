<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class randevuKayit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(randevuKayit))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.soyadtb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adtb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telefon = New System.Windows.Forms.TextBox()
        Me.personelcmb = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.kuadorDS = New System.Data.DataSet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.kaydet = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.kuaforBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.personelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.modelcmb = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.modelBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.kuadorDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kaydet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(491, 547)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Model Listesine Git"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(751, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Kaydet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(751, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 547)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Giriş Ekranına dön"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(551, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Randevu Tarihi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(557, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Müşteri Soyadı:"
        '
        'soyadtb
        '
        Me.soyadtb.Location = New System.Drawing.Point(692, 117)
        Me.soyadtb.Multiline = True
        Me.soyadtb.Name = "soyadtb"
        Me.soyadtb.Size = New System.Drawing.Size(198, 24)
        Me.soyadtb.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(563, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Müşteri Adı:"
        '
        'adtb
        '
        Me.adtb.Location = New System.Drawing.Point(692, 57)
        Me.adtb.Multiline = True
        Me.adtb.Name = "adtb"
        Me.adtb.Size = New System.Drawing.Size(198, 23)
        Me.adtb.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 547)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Randevu Saati:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(545, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Telefon Numarası:"
        '
        'telefon
        '
        Me.telefon.Location = New System.Drawing.Point(692, 172)
        Me.telefon.Multiline = True
        Me.telefon.Name = "telefon"
        Me.telefon.Size = New System.Drawing.Size(198, 24)
        Me.telefon.TabIndex = 88
        '
        'personelcmb
        '
        Me.personelcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.personelcmb.FormattingEnabled = True
        Me.personelcmb.Location = New System.Drawing.Point(692, 271)
        Me.personelcmb.Name = "personelcmb"
        Me.personelcmb.Size = New System.Drawing.Size(198, 24)
        Me.personelcmb.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(549, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 32)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "İşlemi Yapacak " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Personel:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'kuadorDS
        '
        Me.kuadorDS.DataSetName = "NewDataSet"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(549, 394)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Randevu Saati:"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.NazKuafor.My.Resources.Resources._2303204_done_options_todo_menu_check_icon
        Me.PictureBox8.Location = New System.Drawing.Point(409, 530)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(66, 67)
        Me.PictureBox8.TabIndex = 86
        Me.PictureBox8.TabStop = False
        '
        'kaydet
        '
        Me.kaydet.Image = Global.NazKuafor.My.Resources.Resources._8726195_save_floppy_icon
        Me.kaydet.Location = New System.Drawing.Point(677, 453)
        Me.kaydet.Name = "kaydet"
        Me.kaydet.Size = New System.Drawing.Size(59, 64)
        Me.kaydet.TabIndex = 78
        Me.kaydet.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.PictureBox3.Location = New System.Drawing.Point(871, 532)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 58)
        Me.PictureBox3.TabIndex = 75
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.PictureBox2.Location = New System.Drawing.Point(37, 532)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 65)
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NazKuafor.My.Resources.Resources._131
        Me.PictureBox1.Location = New System.Drawing.Point(37, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 481)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'modelcmb
        '
        Me.modelcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.modelcmb.FormattingEnabled = True
        Me.modelcmb.Location = New System.Drawing.Point(692, 213)
        Me.modelcmb.Name = "modelcmb"
        Me.modelcmb.Size = New System.Drawing.Size(198, 24)
        Me.modelcmb.TabIndex = 96
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(547, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Yapılacak Model:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(692, 386)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 24)
        Me.TextBox1.TabIndex = 98
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(692, 331)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 24)
        Me.TextBox2.TabIndex = 97
        '
        'randevuKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(952, 608)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.modelcmb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.personelcmb)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.telefon)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.kaydet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.soyadtb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.adtb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "randevuKayit"
        CType(Me.kuadorDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kaydet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personelBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modelBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents kaydet As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents soyadtb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents adtb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents telefon As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents personelcmb As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents kuaforBS As BindingSource
    Friend WithEvents kuadorDS As DataSet
    Friend WithEvents Label14 As Label
    Friend WithEvents personelBS As BindingSource
    Friend WithEvents modelcmb As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents modelBS As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
