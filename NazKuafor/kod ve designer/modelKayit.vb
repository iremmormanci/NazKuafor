Imports System.Data.SqlClient
Imports System.IO.Ports

Public Class modelKayit
    Private kuaforSqlDA As SqlDataAdapter

    Private Sub modelKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            islemBS.DataSource = kuadorDS.Tables("modelTablosu")
            modelbilgilerinigetir()
            urunbilgilerinigetir()
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Sistem yöneticinize başvurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        islemcmb.DataBindings.Add("SelectedValue", islemBS, "kullanilanUrunNumarasi")
        islemcmb.DataSource = urunBS
        islemcmb.DisplayMember = "UrunAdi"
        islemcmb.ValueMember = "UrunNumarasi"
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
        islemBS.DataSource = kuadorDS.Tables("modelTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub urunbilgilerinigetir()
        Dim SqlBaglanti As New SqlConnection(SQLBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM UrunTablosu"
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

    Private Sub kaydet_Click(sender As Object, e As EventArgs) Handles kaydet.Click
        islemBS.EndEdit()
        VTyeKaydet()
    End Sub
    Private Sub VTyeKaydet()
        'Me.Validate()
        'urunBS.EndEdit()
        Try
            kuaforSqlDA.Update(kuadorDS, "modelTablosu")
            MessageBox.Show("Kaydetme işlemi başarılı.", "Bilgi")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try

    End Sub
    Private Sub liste_Click(sender As Object, e As EventArgs) Handles liste.Click
        modelListesi.ShowDialog()
    End Sub

    Private Sub giristb_Click(sender As Object, e As EventArgs) Handles giristb.Click
        If Me.Visible Then
            Me.Visible = False
        End If
        Me.ShowDialog()
        Form1.ShowDialog()
    End Sub

    Private Sub kapat_Click(sender As Object, e As EventArgs) Handles kapat.Click
        Me.Close()
    End Sub
End Class