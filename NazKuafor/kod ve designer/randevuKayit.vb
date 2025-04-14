Imports System.Data.SqlClient
Public Class randevuKayit
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub randevuKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SQLBaglanti.Open()
            Dim Sorgu As String = "SELECT * FROM RandevuTablosu"
            kuaforSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)

            Dim SqlKomutOlusturucu As New SqlCommandBuilder(kuaforSqlDA)
            kuaforSqlDA.InsertCommand = SqlKomutOlusturucu.GetInsertCommand
            kuaforSqlDA.UpdateCommand = SqlKomutOlusturucu.GetUpdateCommand
            kuaforSqlDA.DeleteCommand = SqlKomutOlusturucu.GetDeleteCommand
            kuaforSqlDA.Fill(kuadorDS, "RandevuTablosu")
            kuaforBS.DataSource = kuadorDS.Tables("RandevuTablosu")
            personelbilgilerinigetir()
            NesneleriBagla()
            modelbilgilerinigetir()
            randevubilgilerinigetir()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        '    'adtb.DataBindings.Add("Text", kuaforBS, "MusteriAdi")
        '    'soyadtb.DataBindings.Add("Text", kuaforBS, "MusteriSoyadi")
        '    'telefon.DataBindings.Add("Text", kuaforBS, "TelefonNo")
        '    modelcmb.DataBindings.Add("SelectedValue", kuaforBS, "modelNumarasi")
        '    personelcmb.DataBindings.Add("SelectedValue", kuaforBS, "YapanPersonelTc")

        '    modelcmb.DataSource = modelBS
        '    'modelcmb.DisplayMember = "modelAdi"
        '    'modelcmb.ValueMember = "modelnumarasi"
        '    modelcmb.DisplayMember = "modelAdi"
        '    modelcmb.ValueMember = "modelnumarasi"

        '    personelcmb.DataSource = personelBS
        '    personelcmb.DisplayMember = "PersonelAdi"
        '    personelcmb.ValueMember = "PersonelTcNumarasi"
        '    'DateTimePicker1.DataBindings.Add("Value", kuaforBS, "RandevuTarihi", True)
        '    'randevusaati.DataBindings.Add("SelectedItem", kuaforBS, "RandevuSaati")
        modelcmb.DataBindings.Add("SelectedValue", kuaforBS, "modelNumarasi")
        personelcmb.DataBindings.Add("SelectedValue", kuaforBS, "YapanPersonelTc")

        ' ComboBox'lara veri kaynağı atama
        modelcmb.DataSource = modelBS
        modelcmb.DisplayMember = "modelAdi"
        modelcmb.ValueMember = "modelnumarasi"

        personelcmb.DataSource = personelBS
        personelcmb.DisplayMember = "PersonelAdi"
        personelcmb.ValueMember = "PersonelTcNumarasi"
    End Sub
    Private Sub personelbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM PersonelTablosu ORDER BY PersonelAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuadorDS.Tables.Contains("PersonelTablosu") Then
            kuadorDS.Tables.Add("PersonelTablosu")
        Else
            kuadorDS.Tables("PersonelTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuadorDS.Tables("PersonelTablosu").Load(SqlKomut.ExecuteReader)
        personelBS.DataSource = kuadorDS.Tables("PersonelTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub modelbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM modelTablosu ORDER BY modelAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuadorDS.Tables.Contains("modelTablosu") Then
            kuadorDS.Tables.Add("modelTablosu")
        Else
            kuadorDS.Tables("modelTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuadorDS.Tables("modelTablosu").Load(SqlKomut.ExecuteReader)
        modelBS.DataSource = kuadorDS.Tables("modelTablosu")
        SqlBaglanti.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.Visible Then
            ' Formu gizle
            Me.Visible = False
        End If

        ' Formu modal olarak göster
        Me.ShowDialog()
        Form1.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        modelListesi.Show()
    End Sub

    Private Sub kaydet_Click(sender As Object, e As EventArgs) Handles kaydet.Click
        'Dim yeniSatir As DataRowView = kuaforBS.AddNew()
        'yeniSatir("modelAdi") = adtb.Text
        'yeniSatir("Tutari") = fiyati.Text
        'yeniSatir("kullanilanUrunNumarasi") = islemcmb.SelectedValue
        '' Diğer alanları da ekleyin
        'yeniSatir.EndEdit()
        'VTyeKaydet()
        kuaforBS.AddNew()
        VTyeKaydet()
    End Sub

    Private Sub VTyeKaydet()
        Me.Validate()
        kuaforBS.EndEdit()
        Try
            kuaforSqlDA.Update(kuadorDS, "modelTablosu")
            MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
    Private Sub randevubilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM RandevuTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuadorDS.Tables.Contains("RandevuTablosu") Then
            kuadorDS.Tables.Add("RandevuTablosu")
        Else
            kuadorDS.Tables("RandevuTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuadorDS.Tables("RandevuTablosu").Load(SqlKomut.ExecuteReader)
        kuaforBS.DataSource = kuadorDS.Tables("RandevuTablosu")
        SqlBaglanti.Close()
    End Sub

    Private Sub sil_Click(sender As Object, e As EventArgs)
        Dim Satir As DataRowView = kuaforBS.Current
        Dim Mesaj As String = String.Format("{0} isimli randevuyu silmek istediğinize emin misiniz?", Satir("MusteriAdi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            kuaforBS.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub
End Class