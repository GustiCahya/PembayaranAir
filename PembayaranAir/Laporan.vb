Imports System.Configuration
Imports System.Data.OleDb
Public Class Laporan
    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cn.Open()

            Dim laporan_rpt As New LaporanReport
            Dim laporan_ds = New dbAirDataSet

            Dim cmPelanggan = New OleDbCommand("SELECT * FROM pelanggan", cn)
            laporan_ds.Pelanggan.Load(cmPelanggan.ExecuteReader())

            Dim cmTagihan = New OleDbCommand("SELECT * FROM tagihan WHERE is_paid=False", cn)
            laporan_ds.Tagihan.Load(cmTagihan.ExecuteReader())

            laporan_rpt.SetDataSource(laporan_ds)
            CrystalReportViewer1.ReportSource = laporan_rpt

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub
End Class