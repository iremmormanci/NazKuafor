Imports System.Data.SqlClient

Public Class UrunKayit
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub UrunKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SQLBaglanti.Open()
            Dim Sorgu As String = "SELECT * FROM UrunTablosu"
            kuaforSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)

            Dim SqlKomutOlusturucu As New SqlCommandBuilder(kuaforSqlDA)
            kuaforSqlDA.InsertCommand = SqlKomutOlusturucu.GetInsertCommand
            kuaforSqlDA.UpdateCommand = SqlKomutOlusturucu.GetUpdateCommand
            kuaforSqlDA.DeleteCommand = SqlKomutOlusturucu.GetDeleteCommand
            kuaforSqlDA.Fill(kuadorDS, "UrunTablosu")
            urunBS.DataSource = kuadorDS.Tables("UrunTablosu")
            stokbilgilerinigetir()
            islembilgilerinigetir()
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        'adtb.DataBindings.Add("Text", urunBS, "UrunAdi")
        'fiyati.DataBindings.Add("Text", islemBS, "Tutari")
        'adet.DataBindings.Add("Text", stokBS, "StokAdeti")
        islemcmb.DataBindings.Add("SelectedValue", urunBS, "UrununKullanildigiModel")
        islemcmb.DataSource = islemBS
        islemcmb.DisplayMember = "ModelAdi"
        islemcmb.ValueMember = "ModelNumarasi"
        'adet.DataBindings.Add("Text", stokBS, "StokAdeti")

    End Sub
    Private Sub stokbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM StokTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuadorDS.Tables.Contains("StokTablosu") Then
            kuadorDS.Tables.Add("StokTablosu")
        Else
            kuadorDS.Tables("StokTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuadorDS.Tables("StokTablosu").Load(SqlKomut.ExecuteReader)
        stokBS.DataSource = kuadorDS.Tables("StokTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub islembilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM modelTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuadorDS.Tables.Contains("modelTablosu") Then
            kuadorDS.Tables.Add("modelTablosu")
        Else
            kuadorDS.Tables("modelTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuadorDS.Tables("modelTablosu").Load(SqlKomut.ExecuteReader)
        islemBS.DataSource = kuadorDS.Tables("modelTablosu")
        SqlBaglanti.Close()
    End Sub

    Private Sub kaydet_Click(sender As Object, e As EventArgs) Handles kaydet.Click
        urunBS.EndEdit()
        VTyeKaydet()
    End Sub
    Private Sub VTyeKaydet()
        'Me.Validate()
        'urunBS.EndEdit()
        Try
            kuaforSqlDA.Update(kuadorDS, "UrunTablosu")
            MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try

    End Sub

    Private Sub sil_Click(sender As Object, e As EventArgs)
        Dim Satir As DataRowView = urunBS.Current
        Dim Mesaj As String = String.Format("{0} isimli ürünü silmek istediğinize emin misiniz?", Satir("UrunAdi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            urunBS.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub

    Private Sub liste_Click(sender As Object, e As EventArgs) Handles liste.Click
        UrunListesi.ShowDialog()
    End Sub

    Private Sub giristb_Click(sender As Object, e As EventArgs) Handles giristb.Click
        Form1.ShowDialog()
    End Sub

    Private Sub kapat_Click(sender As Object, e As EventArgs) Handles kapat.Click
        Me.Close()
    End Sub
End Class