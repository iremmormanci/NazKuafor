Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class PersonelListesi
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PersonelKayit.ShowDialog()

    End Sub

    Private Sub PersonelListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM PersonelTablosu ORDER BY PersonelAdi"
        Dim randevuSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            randevuSqlDA.Fill(kuaforDS, "PersonelTablosu")
            PersonelBS.DataSource = kuaforDS.Tables("PersonelTablosu")
            PersonelBilgileriniGetir()
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub PersonelBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM PersonelTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuaforDS.Tables.Contains("PersonelTablosu") Then
            kuaforDS.Tables.Add("PersonelTablosu")
        Else
            kuaforDS.Tables("PersonelTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuaforDS.Tables("PersonelTablosu").Load(SqlKomut.ExecuteReader)
        PersonelBS.DataSource = kuaforDS.Tables("PersonelTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub NesneleriBagla()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = PersonelBS
    End Sub
    Private Sub ara_Click(sender As Object, e As EventArgs) Handles ara.Click
        PersonelBS.Filter = String.Format("PersonelAdi LIKE '%{0}%'", personeladiTBox.Text)
    End Sub

    Private Sub sil_Click(sender As Object, e As EventArgs) Handles sil.Click
        Dim Satir As DataRowView = PersonelBS.Current
        Dim Mesaj As String = String.Format("{0} isimli personeli silmek istediğinize emin misiniz?", Satir("PersonelAdi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            PersonelBS.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub
    Private Sub VTyeKaydet()
        Me.Validate()
        PersonelBS.EndEdit()
        Try
            If kuaforSqlDA IsNot Nothing Then
                kuaforSqlDA.Update(kuaforDS, "PersonelTablosu")
                MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
End Class