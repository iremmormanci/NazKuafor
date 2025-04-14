Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module AyarlarModul
    Public Function SQLBaglantiCumlesi() As String
        Dim SqlBaglantiCumlesiOlusturucu As New SqlConnectionStringBuilder
        SqlBaglantiCumlesiOlusturucu.DataSource = "."
        SqlBaglantiCumlesiOlusturucu.InitialCatalog = "kuaforveritabani"
        SqlBaglantiCumlesiOlusturucu.PersistSecurityInfo = False
        SqlBaglantiCumlesiOlusturucu.IntegratedSecurity = False
        SqlBaglantiCumlesiOlusturucu.UserID = "sa"
        SqlBaglantiCumlesiOlusturucu.Password = "mmyo"
        Return SqlBaglantiCumlesiOlusturucu.ConnectionString
    End Function
    Public Function SifreKontrol(Sifre As String) As Boolean
        Dim Sonuc As Boolean = False
        Dim Duzenliifade As New Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{5,15}$")
        If Duzenliifade.IsMatch(Sifre) Then
            Sonuc = True
        End If
        Return Sonuc
    End Function

End Module


