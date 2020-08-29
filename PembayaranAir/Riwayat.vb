Imports System.Configuration
Imports System.Data.OleDb
Public Class Riwayat

    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)

    Private start_date As Date
    Private end_date As Date
    Private currentTrx As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim chk As New DataGridViewCheckBoxColumn()
        DataGridView1.Columns.Add(chk)
        chk.HeaderText = "Terbayar"
        chk.Name = "terbayar"
        chk.Width = 60
        chk.DisplayIndex = 5
        chk.Visible = False

    End Sub

    Public Sub LoadTable()
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        lbl_no.Text = "No."
        currentTrx = ""
        Try
            cn.Open()
            Dim cm As New OleDbCommand("SELECT tagihan.no_pel, pelanggan.nama_pel, tagihan.jumlah_bulan, tagihan.tagihan, 
                                        tagihan.created_at, tagihan.no_trx, tagihan.is_paid 
                                        FROM tagihan INNER JOIN pelanggan ON tagihan.no_pel=pelanggan.no_pel 
                                        WHERE tagihan.created_at BETWEEN @start_date AND @end_date", cn)
            cm.Parameters.AddWithValue("@start_date", start_date)
            cm.Parameters.AddWithValue("@end_date", end_date)
            Dim dt As New DataTable()
            dt.Load(cm.ExecuteReader())

            'Handle DataGridView1 for Display Riwayat Transaksi
            For i = 0 To dt.Rows.Count - 1
                DataGridView1.Rows.Add()
                With DataGridView1.Rows(i)
                    .Cells(0).Value = i + 1
                    .Cells(1).Value = dt.Rows(i).Item("no_pel")
                    .Cells(2).Value = dt.Rows(i).Item("nama_pel")
                    .Cells(3).Value = dt.Rows(i).Item("jumlah_bulan")
                    .Cells(4).Value = dt.Rows(i).Item("tagihan")
                    .Cells(5).Value = dt.Rows(i).Item("created_at")
                    .Cells(6).Value = dt.Rows(i).Item("no_trx")
                    .Cells(7).Value = dt.Rows(i).Item("is_paid")
                    If .Cells(7).Value = True Then
                        .DefaultCellStyle.BackColor = Color.FromArgb(144, 238, 144)
                    End If
                End With
            Next
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub btn_dibayar_Click(sender As Object, e As EventArgs) Handles btn_dibayar.Click
        If DataGridView1.Rows.Count > 0 Then
            Select Case MsgBox("Yakin Sudah Dibayar di PDAM?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes
                    Try
                        cn.Open()
                        Dim cm = New OleDbCommand("UPDATE Tagihan SET Is_Paid=@is_paid 
                                                   WHERE Created_At BETWEEN @start_date AND @end_date", cn)
                        cm.Parameters.AddWithValue("@is_paid", True)
                        cm.Parameters.AddWithValue("@start_date", start_date)
                        cm.Parameters.AddWithValue("@end_date", end_date)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        DataGridView1.Rows.Clear()
                        LoadTable()
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message.ToString(), vbCritical)
                    End Try
            End Select
        End If
    End Sub

    Private Sub btn_tidak_Click(sender As Object, e As EventArgs) Handles btn_tidak.Click
        If DataGridView1.Rows.Count > 0 Then
            Select Case MsgBox("Yakin Tidak Terbayar?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes
                    Try
                        cn.Open()
                        Dim cm = New OleDbCommand("UPDATE Tagihan SET Is_Paid=@is_paid 
                                                   WHERE Created_At BETWEEN @start_date AND @end_date", cn)
                        cm.Parameters.AddWithValue("@is_paid", False)
                        cm.Parameters.AddWithValue("@start_date", start_date)
                        cm.Parameters.AddWithValue("@end_date", end_date)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        DataGridView1.Rows.Clear()
                        LoadTable()
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message.ToString(), vbCritical)
                    End Try
            End Select
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btn_delete.Visible = True
        If e.RowIndex > -1 Then
            currentTrx = DataGridView1.Rows(e.RowIndex).Cells("no_trx").Value()
            lbl_no.Text = DataGridView1.Rows(e.RowIndex).Cells("no").Value()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If Not String.IsNullOrEmpty(currentTrx) Then
            Select Case MsgBox("Yakin Mau Dihapus?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes
                    Try
                        cn.Open()
                        Dim cm = New OleDbCommand("DELETE FROM Tagihan WHERE No_Trx=@no_trx", cn)
                        cm.Parameters.AddWithValue("@no_trx", currentTrx)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        DataGridView1.Rows.Clear()
                        LoadTable()
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message.ToString(), vbCritical)
                    End Try
            End Select
        Else
            MsgBox("Harap pilih baris yang akan dihapus", vbInformation)
        End If

    End Sub

    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        Me.Cursor = Cursors.WaitCursor
        Laporan.ShowDialog()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        start_date = e.Start
        end_date = e.End
        LoadTable()
    End Sub

    Private Sub btn_row_terbayar_Click(sender As Object, e As EventArgs) Handles btn_row_terbayar.Click
        If Not String.IsNullOrEmpty(currentTrx) Then
            Try
                cn.Open()
                Dim cm = New OleDbCommand("UPDATE Tagihan SET Is_Paid=True WHERE No_Trx=@no_trx", cn)
                cm.Parameters.AddWithValue("@no_trx", currentTrx)
                cm.ExecuteNonQuery()
                cn.Close()
                LoadTable()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        Else
            MsgBox("Harap pilih barisnya terlebih dahulu", vbInformation)
        End If
    End Sub

    Private Sub btn_row_tidak_Click(sender As Object, e As EventArgs) Handles btn_row_tidak.Click
        If Not String.IsNullOrEmpty(currentTrx) Then
            Try
                cn.Open()
                Dim cm = New OleDbCommand("UPDATE Tagihan SET Is_Paid=False WHERE No_Trx=@no_trx", cn)
                cm.Parameters.AddWithValue("@no_trx", currentTrx)
                cm.ExecuteNonQuery()
                cn.Close()
                LoadTable()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        Else
            MsgBox("Harap pilih barisnya terlebih dahulu", vbInformation)
        End If
    End Sub

End Class