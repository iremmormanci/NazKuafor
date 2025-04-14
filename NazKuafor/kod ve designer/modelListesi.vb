Imports System.Configuration
Imports System.Data.SqlClient

Public Class modelListesi
    Private kuaforSqlDA As SqlDataAdapter
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
    Private Sub sil_Click(sender As Object, e As EventArgs) Handles sil.Click
        Dim Satir As DataRowView = kuaforBS.Current
        Dim Mesaj As String = String.Format("{0} isimli modeli silmek istediğinize emin misiniz?", Satir("modelAdi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            kuaforBS.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub

    Private Sub modelListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SQLBaglanti.Open()
            Dim Sorgu As String = "SELECT * FROM modelTablosu"
            kuaforSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)

            Dim SqlKomutOlusturucu As New SqlCommandBuilder(kuaforSqlDA)
            kuaforSqlDA.InsertCommand = SqlKomutOlusturucu.GetInsertCommand
            kuaforSqlDA.UpdateCommand = SqlKomutOlusturucu.GetUpdateCommand
            kuaforSqlDA.DeleteCommand = SqlKomutOlusturucu.GetDeleteCommand
            kuaforSqlDA.Fill(kuadorDS, "modelTablosu")
            kuaforBS.DataSource = kuadorDS.Tables("modelTablosu")
            urunbilgilerinigetir()
            modelbilgilerinigetir()
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub modelbilgilerinigetir()
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
        kuaforBS.DataSource = kuadorDS.Tables("modelTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub NesneleriBagla()
        DataGridView1.AutoGenerateColumns = False
        kullanilanUrunNumarasiC.DataSource = urunBS
        kullanilanUrunNumarasiC.DisplayMember = "UrunAdi"
        kullanilanUrunNumarasiC.ValueMember = "UrunNumarasi"

        DataGridView1.DataSource = kuaforBS
        kullanilanuruncmb.DataBindings.Add("SelectedValue", kuaforBS, "kullanilanUrunNumarasi")
        kullanilanuruncmb.DataSource = urunBS
        kullanilanuruncmb.DisplayMember = "UrunAdi"
        kullanilanuruncmb.ValueMember = "UrunNumarasi"

    End Sub
    Private Sub urunbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM UrunTablosu ORDER BY UrunAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuadorDS.Tables.Contains("UrunTablosu") Then
            kuadorDS.Tables.Add("UrunTablosu")
        Else
            kuadorDS.Tables("UrunTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuadorDS.Tables("UrunTablosu").Load(SqlKomut.ExecuteReader)
        urunBS.DataSource = kuadorDS.Tables("UrunTablosu")
        SqlBaglanti.Close()
    End Sub

    Private Sub guncelle_Click(sender As Object, e As EventArgs) Handles guncelle.Click
        ModelTablosuGuncelle()
    End Sub
    Public Sub ModelTablosuGuncelle()
        Dim baglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "UPDATE modelTablosu Set modelAdi = @modelAdi, Tutari = @Tutari, kullanilanUrunNumarasi = @kullanilanUrunNumarasi WHERE modelNumarasi = @modelNumarasi"
        Dim komut As New SqlCommand(Sorgu, baglanti)

        ' Parametreleri ekleyin
        komut.Parameters.AddWithValue("@modelAdi", adtb)
            komut.Parameters.AddWithValue("@Tutari", fiyat)
            komut.Parameters.AddWithValue("@kullanilanUrunNumarasi", kullanilanuruncmb)
        'komut.Parameters.AddWithValue("@KullanilanUrunAdeti", adet)
        komut.Parameters.AddWithValue("@modelNumarasi", kuaforBS.Current("modelNumarasi"))

        ' Bağlantıyı açın
        baglanti.Open()

            ' Komutu çalıştırın
            komut.ExecuteNonQuery()

            ' Bağlantıyı kapatın
            baglanti.Close()

    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        modelKayit.ShowDialog()
    End Sub

    Private Sub ara_Click(sender As Object, e As EventArgs) Handles ara.Click
        kuaforBS.Filter = String.Format("ModelAdi Like '%{0}%'", modeladitb.Text)
    End Sub
End Class