Imports System.Data.SqlClient
Public Class PersonelKayit
    Private kuaforSqlDA As SqlDataAdapter
    Private Sub PersonelKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Try
            SQLBaglanti.Open()
            Dim Sorgu As String = "SELECT * FROM PersonelTablosu"
            kuaforSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)

            Dim SqlKomutOlusturucu As New SqlCommandBuilder(kuaforSqlDA)
            kuaforSqlDA.InsertCommand = SqlKomutOlusturucu.GetInsertCommand
            kuaforSqlDA.UpdateCommand = SqlKomutOlusturucu.GetUpdateCommand
            kuaforSqlDA.DeleteCommand = SqlKomutOlusturucu.GetDeleteCommand
            kuaforSqlDA.Fill(KuaforDS, "PersonelTablosu")
            personelBS.DataSource = KuaforDS.Tables("PersonelTablosu")
            personelbilgilerinigetir()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub

    Private Sub personelbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM PersonelTablosu ORDER BY PersonelAdi"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not KuaforDS.Tables.Contains("PersonelTablosu") Then
            KuaforDS.Tables.Add("PersonelTablosu")
        Else
            KuaforDS.Tables("PersonelTablosu").Clear()
        End If
        SqlBaglanti.Open()
        KuaforDS.Tables("PersonelTablosu").Load(SqlKomut.ExecuteReader)
        personelBS.DataSource = KuaforDS.Tables("PersonelTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub kaydet_Click(sender As Object, e As EventArgs) Handles kaydet.Click
        VTyeKaydet()
    End Sub
    Private Sub VTyeKaydet()
        Me.Validate()
        personelBS.EndEdit()
        Try
            kuaforSqlDA.Update(KuaforDS, "PersonelTablosu")
            MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try

    End Sub
    Private Sub kapat_Click(sender As Object, e As EventArgs) Handles kapat.Click
        Me.Close()
    End Sub

    Private Sub liste_Click(sender As Object, e As EventArgs) Handles liste.Click
        PersonelListesi.ShowDialog()
    End Sub

    Private Sub giristb_Click(sender As Object, e As EventArgs) Handles giristb.Click
        If Me.Visible Then
            Me.Visible = False
        End If
        Me.ShowDialog()
        Form1.ShowDialog()
    End Sub
End Class