Imports System.Configuration
Imports System.Data.OleDb
Public Class Riwayat

    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)
    Private filterDate As String
    Private currentTrx As Integer

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
        Try
            cn.Open()
            Dim cm As New OleDbCommand("SELECT tagihan.no_pel, pelanggan.nama_pel, tagihan.jumlah_bulan, tagihan.tagihan, 
                                        tagihan.created_at, tagihan.no_trx, tagihan.is_paid 
                                        FROM tagihan INNER JOIN pelanggan ON tagihan.no_pel=pelanggan.no_pel 
                                        WHERE tagihan.created_at LIKE @created_at
                                        AND tagihan.Is_Paid=False", cn)
            cm.Parameters.AddWithValue("@created_at", "%" & dtp_filter.Value.ToString("d/M/yyyy") & "%")
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
                End With
            Next
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Public Sub LoadTableWithoutIsPaid()
        Try
            cn.Open()
            Dim cm As New OleDbCommand("SELECT tagihan.no_pel, pelanggan.nama_pel, tagihan.jumlah_bulan, tagihan.tagihan, 
                                        tagihan.created_at, tagihan.no_trx, tagihan.is_paid 
                                        FROM tagihan INNER JOIN pelanggan ON tagihan.no_pel=pelanggan.no_pel 
                                        WHERE tagihan.created_at LIKE @created_at", cn)
            cm.Parameters.AddWithValue("@created_at", "%" & dtp_filter.Value.ToString("d/M/yyyy") & "%")
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

    Private Sub dtp_filter_ValueChanged(sender As Object, e As EventArgs) Handles dtp_filter.ValueChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        LoadTable()
    End Sub

    Private Sub dtp_filter_MouseDown(sender As Object, e As MouseEventArgs) Handles dtp_filter.MouseDown
        dtp_filter.Focus()
        SendKeys.Send("{F4}")
    End Sub

    Private Sub btn_dibayar_Click(sender As Object, e As EventArgs) Handles btn_dibayar.Click
        If DataGridView1.Rows.Count > 0 Then
            Select Case MsgBox("Yakin Sudah Dibayar di PDAM?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes
                    Dim tanggal As String = dtp_filter.Value.ToString("d/M/yyyy")
                    Try
                        cn.Open()
                        Dim cm = New OleDbCommand("UPDATE Tagihan SET Is_Paid=@is_paid WHERE Created_At LIKE @created_at", cn)
                        cm.Parameters.AddWithValue("@is_paid", True)
                        cm.Parameters.AddWithValue("@created_at", "%" & tanggal & "%")
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
        If e.RowIndex > 0 Then
            currentTrx = DataGridView1.Rows(e.RowIndex).Cells("no_trx").Value()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
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
    End Sub

    Private Sub chk_terbayar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_terbayar.CheckedChanged
        If chk_terbayar.Checked = True Then
            btn_dibayar.Visible = False
            DataGridView1.Rows.Clear()
            LoadTableWithoutIsPaid()
        Else
            btn_dibayar.Visible = True
            DataGridView1.Rows.Clear()
            LoadTable()
        End If
    End Sub

    'Dim mRow As Integer = 0
    'Dim newpage As Boolean = True
    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    With DataGridView1
    '        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
    '        fmt.LineAlignment = StringAlignment.Center
    '        fmt.Trimming = StringTrimming.EllipsisCharacter
    '        Dim y As Single = e.MarginBounds.Top
    '        Do While mRow < .RowCount
    '            Dim row As DataGridViewRow = .Rows(mRow)
    '            Dim x As Single = e.MarginBounds.Left
    '            Dim h As Single = 0
    '            For Each cell As DataGridViewCell In row.Cells
    '                Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
    '                e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
    '                If (newpage) Then
    '                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
    '                Else
    '                    e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
    '                End If
    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)
    '            Next
    '            newpage = False
    '            y += h
    '            mRow += 1
    '            If y + h > e.MarginBounds.Bottom Then
    '                e.HasMorePages = True
    '                mRow -= 1
    '                newpage = True
    '                Exit Sub
    '            End If
    '        Loop
    '        mRow = 0
    '    End With
    'End Sub

    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
        Laporan.ShowDialog()
    End Sub

    Private Sub Riwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class