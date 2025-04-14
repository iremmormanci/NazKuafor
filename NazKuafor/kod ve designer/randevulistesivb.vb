Imports System.Data.SqlClient

Public Class randevulistesivb
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub randevulistesivb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM RandevuTablosu"
        Dim randevuSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            randevuSqlDA.Fill(kuaforDS, "RandevuTablosu")
            PersonelBS.DataSource = kuaforDS.Tables("RandevuTablosu")
            PersonelBilgileriniGetir()
            NesneleriBagla()
            randevubilgilerinigetir()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub


    Private Sub randevubilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM RandevuTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not kuaforDS.Tables.Contains("RandevuTablosu") Then
            kuaforDS.Tables.Add("RandevuTablosu")
        Else
            kuaforDS.Tables("RandevuTablosu").Clear()
        End If
        SqlBaglanti.Open()
        kuaforDS.Tables("RandevuTablosu").Load(SqlKomut.ExecuteReader)
        modelBS.DataSource = kuaforDS.Tables("RandevuTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub PersonelBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT *,PersonelAdi+' '+PersonelSoyadi AS AdiSoyadi FROM PersonelTablosu"
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
        randevuDGV.AutoGenerateColumns = False
        randevuDGV.DataSource = randevuBs
    End Sub

    Private Sub ara_Click(sender As Object, e As EventArgs) Handles ara.Click
        randevuBs.Filter = String.Format("MusteriAdi LIKE '%{0}%'", musteriadiTBox.Text)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        randevuKayit.ShowDialog()
    End Sub
    Private Sub VTyeKaydet()
        Me.Validate()
        randevuBs.EndEdit()
        Try
            kuaforSqlDA.Update(kuaforDS, "RandevuTablosu")
            MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
    Private Sub sil_Click(sender As Object, e As EventArgs) Handles sil.Click
        Dim Satir As DataRowView = randevuBs.Current
        Dim Mesaj As String = String.Format("{0} isimli randevuyu silmek istediğinize emin misiniz?", Satir("MusteriAdi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            randevuBs.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub
End Class