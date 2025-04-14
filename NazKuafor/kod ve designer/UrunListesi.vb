Imports System.Data.SqlClient
Public Class UrunListesi
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub UrunListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM UrunTablosu"
        Dim randevuSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            randevuSqlDA.Fill(kuaforDS, "UrunTablosu")
            urunBS.DataSource = kuaforDS.Tables("UrunTablosu")
            islemBilgileriniGetir()
            NesneleriBagla()
            stokbilgilerinigetir()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub islemBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT *,modelAdi FROM modelTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuaforDS.Tables.Contains("modelTablosu") Then
            kuaforDS.Tables.Add("modelTablosu")
        Else
            kuaforDS.Tables("modelTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuaforDS.Tables("modelTablosu").Load(SqlKomut.ExecuteReader)
        islemBS.DataSource = kuaforDS.Tables("modelTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub NesneleriBagla()
        'adtb.DataBindings.Add("Text", urunBS, "UrunAdi")
        'TextBox1.DataBindings.Add("Text", islemBS, "Tutari")
        ''adet.DataBindings.Add("Text", stokBS, "StokAdeti")
        'islemcmb.DataBindings.Add("SelectedValue", urunBS, "UrununKullanildigiModel")
        'islemcmb.DataSource = islemBS
        'islemcmb.DisplayMember = "ModelAdi"
        'islemcmb.ValueMember = "ModelNumarasi"
        'DataGridView1.AutoGenerateColumns = False
        'kullanildigiislem.DataSource = islemBS
        'kullanildigiislem.DisplayMember = "modelAdi"
        'kullanildigiislem.ValueMember = "modelNumarasi"
        DataGridView1.DataSource = urunBS
    End Sub
    Private Sub stokbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM StokTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuaforDS.Tables.Contains("StokTablosu") Then
            kuaforDS.Tables.Add("StokTablosu")
        Else
            kuaforDS.Tables("StokTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuaforDS.Tables("StokTablosu").Load(SqlKomut.ExecuteReader)
        stokBS.DataSource = kuaforDS.Tables("StokTablosu")
        SqlBaglanti.Close()
    End Sub

    Private Sub ara_Click(sender As Object, e As EventArgs) Handles ara.Click
        urunBS.Filter = String.Format("UrunAdi LIKE '%{0}%'", urunadi.Text)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
    Private Sub VTyeKaydet()
        Me.Validate()
        urunBS.EndEdit()
        Try
            kuaforSqlDA.Update(kuaforDS, "UrunTablosu")
            MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try

    End Sub
    Private Sub sil_Click(sender As Object, e As EventArgs) Handles sil.Click
        Dim Satir As DataRowView = urunBS.Current
        Dim Mesaj As String = String.Format("{0} isimli ürünü silmek istediğinize emin misiniz?", Satir("UrunAdi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            urunBS.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub
    'Private Sub UrunTablosuGuncelle()
    '    Dim connectionString As String = "your_connection_string_here"

    '    ' SqlConnection nesnesi ile bağlantıyı açın
    '    Using baglanti As New SqlConnection(connectionString)
    '        ' Bağlantıyı açın
    '        baglanti.Open()

    '        ' SqlCommand nesnesini oluşturun
    '        Dim komut As New SqlCommand()

    '        ' Model tablosundan tutar ve kullanılan ürün adeti bilgilerini almak için bir alt sorgu kullanıyoruz
    '        komut.CommandText = "UPDATE UrunTablosu SET UrunAdi = @UrunAdi, UrununKullanildigiModel = @UrununKullanildigiModel, Tutari = (SELECT Tutari FROM ModelTablosu WHERE modelNumarasi = @UrununKullanildigiModel), KullanilanUrunAdeti = (SELECT KullanilanUrunAdeti FROM ModelTablosu WHERE modelNumarasi = @UrununKullanildigiModel) WHERE UrunNumarasi = @UrunNumarasi"

    '        ' Parametreleri ekleyin
    '        komut.Parameters.AddWithValue("@UrunAdi", adtb)
    '        komut.Parameters.AddWithValue("@UrununKullanildigiModel", islemcmb)
    '        'komut.Parameters.AddWithValue("@UrunNumarasi", urunNumarasi)

    '        ' Komutun bağlantısını belirtin
    '        komut.Connection = baglanti

    '        ' Komutu çalıştırın
    '        komut.ExecuteNonQuery()

    '        ' Bağlantıyı kapatın
    '        baglanti.Close()
    '    End Using
    'End Sub

    'Private Sub guncelle_Click(sender As Object, e As EventArgs)
    '    UrunTablosuGuncelle()
    'End Sub
End Class