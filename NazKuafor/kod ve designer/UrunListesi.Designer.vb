<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UrunListesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UrunListesi))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.urunadi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ara = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.kuaforDS = New System.Data.DataSet()
        Me.urunBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.stokBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.islemBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.sil = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stokBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.islemBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(29, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(672, 365)
        Me.DataGridView1.TabIndex = 5
        '
        'urunadi
        '
        Me.urunadi.Location = New System.Drawing.Point(138, 39)
        Me.urunadi.Margin = New System.Windows.Forms.Padding(4)
        Me.urunadi.Name = "urunadi"
        Me.urunadi.Size = New System.Drawing.Size(397, 22)
        Me.urunadi.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(58, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Ürün Adı:"
        '
        'ara
        '
        Me.ara.BackColor = System.Drawing.Color.LavenderBlush
        Me.ara.Image = Global.NazKuafor.My.Resources.Resources._8726214_search_icon
        Me.ara.Location = New System.Drawing.Point(543, 22)
        Me.ara.Name = "ara"
        Me.ara.Size = New System.Drawing.Size(73, 64)
        Me.ara.TabIndex = 69
        Me.ara.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label6.Location = New System.Drawing.Point(515, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Programı kapat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label7.Location = New System.Drawing.Point(109, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "İşlem Ekranına dön"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LavenderBlush
        Me.PictureBox3.Image = Global.NazKuafor.My.Resources.Resources._9027292_cancel_icon__1_
        Me.PictureBox3.Location = New System.Drawing.Point(642, 512)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 61)
        Me.PictureBox3.TabIndex = 73
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.PictureBox2.Image = Global.NazKuafor.My.Resources.Resources._2303135_arrow_back_left_refresh_renew_icon__3_
        Me.PictureBox2.Location = New System.Drawing.Point(29, 512)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 61)
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'kuaforDS
        '
        Me.kuaforDS.DataSetName = "NewDataSet"
        '
        'sil
        '
        Me.sil.BackColor = System.Drawing.Color.LavenderBlush
        Me.sil.Image = Global.NazKuafor.My.Resources.Resources._8726424_trash_alt_icon__1_
        Me.sil.Location = New System.Drawing.Point(642, 22)
        Me.sil.Name = "sil"
        Me.sil.Size = New System.Drawing.Size(59, 64)
        Me.sil.TabIndex = 90
        Me.sil.TabStop = False
        '
        'UrunListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NazKuafor.My.Resources.Resources.kare
        Me.ClientSize = New System.Drawing.Size(765, 586)
        Me.Controls.Add(Me.sil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.urunadi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ara)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UrunListesi"
        Me.Text = "Ürün Listesi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuaforDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urunBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stokBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.islemBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents urunadi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ara As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents kuaforDS As DataSet
    Friend WithEvents urunBS As BindingSource
    Friend WithEvents stokBS As BindingSource
    Friend WithEvents islemBS As BindingSource
    Friend WithEvents sil As PictureBox
End Class
