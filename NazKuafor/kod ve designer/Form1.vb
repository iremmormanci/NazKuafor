Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Public Class Form1

    Private Sub KapatALtF4ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles KapatALtF4ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RandevuListesiToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RandevuListesiToolStripMenuItem.Click
        randevulistesivb.ShowDialog(Me)
    End Sub

    Private Sub İşlemKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İşlemKayıtToolStripMenuItem.Click
        modelKayit.ShowDialog(Me)
    End Sub

    Private Sub İşlemListesiToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles İşlemListesiToolStripMenuItem.Click
        modelListesi.ShowDialog(Me)
    End Sub

    Private Sub ÜrünKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünKayıtToolStripMenuItem.Click
        UrunKayit.ShowDialog(Me)
    End Sub

    Private Sub ÜrünListesiToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ÜrünListesiToolStripMenuItem.Click
        UrunListesi.ShowDialog(Me)
    End Sub

    Private Sub PersonelKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelKaydıToolStripMenuItem.Click
        PersonelKayit.ShowDialog(Me)
    End Sub

    Private Sub PersonelListesiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelListesiToolStripMenuItem.Click
        PersonelListesi.ShowDialog()
    End Sub

    Private Sub StokGirişToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokGirişToolStripMenuItem.Click
        stoklistesi.ShowDialog()
    End Sub

    Private Sub RandevuKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandevuKayıtToolStripMenuItem.Click
        randevuKayit.ShowDialog()
    End Sub
End Class
