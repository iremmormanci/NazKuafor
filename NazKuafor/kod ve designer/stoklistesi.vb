Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class stoklistesi
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.Visible Then
            ' Formu gizle
            Me.Visible = False
        End If

        ' Formu modal olarak göster
        Me.ShowDialog()
        Form1.ShowDialog()
    End Sub

    Private Sub stoklistesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SQLBaglanti.Open()
            Dim Sorgu As String = "SELECT * FROM StokTablosu"
            kuaforSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)

            Dim SqlKomutOlusturucu As New SqlCommandBuilder(kuaforSqlDA)
            kuaforSqlDA.InsertCommand = SqlKomutOlusturucu.GetInsertCommand
            kuaforSqlDA.UpdateCommand = SqlKomutOlusturucu.GetUpdateCommand
            kuaforSqlDA.DeleteCommand = SqlKomutOlusturucu.GetDeleteCommand
            kuaforSqlDA.Fill(kuaforDS, "StokTablosu")
            kuaforBS.DataSource = kuaforDS.Tables("StokTablosu")
            urunbilgilerinigetir()
            NesneleriBagla()
            stokbilgilerinigetir()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub urunbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM UrunTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuaforDS.Tables.Contains("UrunTablosu") Then
            kuaforDS.Tables.Add("UrunTablosu")
        Else
            kuaforDS.Tables("UrunTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuaforDS.Tables("UrunTablosu").Load(SqlKomut.ExecuteReader)
        urunBS.DataSource = kuaforDS.Tables("UrunTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub NesneleriBagla()

        'DataGridView1.AutoGenerateColumns = False
        uruncmb.DataBindings.Add("SelectedValue", kuaforBS, "UrunNumarasi")
        adet.DataBindings.Add("Text", kuaforBS, "StokAdeti")

        uruncmb.DataSource = urunBS
        uruncmb.DisplayMember = "UrunAdi"
        uruncmb.ValueMember = "UrunNumarasi"
        DataGridView1.DataSource = kuaforBS
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
        kuaforBS.DataSource = kuaforDS.Tables("StokTablosu")
        SqlBaglanti.Close()
    End Sub

    'Private Sub VTyeKaydet()
    '    Me.Validate()
    '    kuaforBS.EndEdit()
    '    Try
    '        kuaforSqlDA.Update(kuaforDS, "stokTablosu")
    '        MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
    '    Catch ex As Exception
    '        MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
    '    End Try

    'End Sub
    'Private Sub sil_Click(sender As Object, e As EventArgs) Handles sil.Click
    '    Dim Satir As DataRowView = kuaforBS.Current
    '    Dim Mesaj As String = String.Format("{0} isimli modeli silmek istediğinize emin misiniz?", Satir("modelAdi"))
    '    If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
    '        kuaforBS.RemoveCurrent()
    '        VTyeKaydet()
    '    End If
    'End Sub

    Private Sub StokTablosuGuncelle()
        'Dim connectionString As String = "Server=localhost;Database=kuaforveritabani;User Id=sa;Password=mmyo;"

        '' SQL sorgusunu oluşturun
        'Dim sorgu As String = "UPDATE StokTablosu SET StokAdeti = @StokAdeti WHERE StokNumarasi = @StokNumarasi"

        '' SqlConnection nesnesi ile bağlantıyı açın
        'Using baglanti As New SqlConnection(connectionString)
        '    ' SqlCommand nesnesini oluşturun
        '    Dim komut As New SqlCommand(sorgu, baglanti)

        '    ' Parametreleri ekleyin
        '    komut.Parameters.AddWithValue("@StokAdeti", adet)
        '    komut.Parameters.AddWithValue("@AlisFiyati", fiyat)
        '    komut.Parameters.AddWithValue("@UrunNumarasi", uruncmb)

        '    ' Bağlantıyı açın
        '    baglanti.Open()

        '    ' Komutu çalıştırın
        '    komut.ExecuteNonQuery()

        '    ' Bağlantıyı kapatın
        '    baglanti.Close()
        'End Using
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=kuaforveritaban;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        SQLcommand.CommandText = "UPDATE StokTablosu SET StokNumarasi = '" + stok.Text + "', StokAdeti = '" + adet.Text + "', UrunNumarasi = '" + uruncmb.SelectedItem + "' WHERE StokNumarasi = '" + stok.Text + "'"
        If Not String.IsNullOrEmpty(stok.Text) AndAlso
  Not String.IsNullOrEmpty(adet.Text) Then
            MessageBox.Show("Boşluklar dolu!")
        Else
            MessageBox.Show("Lütfen tüm boşlukları doldurun!")
        End If

        SqlCommand.Connection = Connection
        SqlCommand.ExecuteNonQuery()
        Dim sorgu = "Select * from StokTablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "StokTablosu")
        DataGridView1.DataSource = dsv.Tables("StokTablosu")
    End Sub

    Private Sub guncelle_Click(sender As Object, e As EventArgs) Handles guncelle.Click
        StokTablosuGuncelle()
    End Sub

    Private Sub ara_Click(sender As Object, e As EventArgs) Handles ara.Click
        kuaforBS.Filter = String.Format("UrunNumarasi LIKE '%{0}%'", urunnumarasi.Text)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

End Class