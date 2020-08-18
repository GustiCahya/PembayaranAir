Imports System.Configuration
Imports System.Data.OleDb
Public Class Transaksi

    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)

    Public nopel As String
    Public nama As String
    Public indexBulan As Integer
    Public bulanTbl As String

    Private Sub handleTanggal()
        'Handle dtp_tanggal
        Dim daftarBulan As String() = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
        indexBulan = dtp_tgl.Value.Month - 2
        If indexBulan < 0 Then
            indexBulan = 11
        End If
        bulanTbl = daftarBulan(indexBulan)
        lbl_bulan.Text = daftarBulan(indexBulan).ToUpper()
    End Sub

    Private Sub clear()
        tb_nama.Text = ""
        tb_alamat.Text = ""
        tb_golongan.Text = ""
        dtp_tgl.Value = Now
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        handleTanggal()
    End Sub

    Private Sub tb_nopel_TextChanged(sender As Object, e As EventArgs) Handles tb_nopel.TextChanged
        Try
            cn.Open()
            Dim dt As New DataTable()
            Dim cm = New OleDbCommand("SELECT * FROM pelanggan WHERE no_pel=@nopel", cn)
            cm.Parameters.AddWithValue("@nopel", tb_nopel.Text)
            dt.Load(cm.ExecuteReader())

            If dt.Rows.Count = 1 Then
                nopel = dt.Rows(0).Item(0).ToString()
                nama = dt.Rows(0).Item(1).ToString()

                tb_nama.Text = dt.Rows(0).Item(1).ToString()
                tb_alamat.Text = dt.Rows(0).Item(2).ToString()
                tb_golongan.Text = dt.Rows(0).Item(3).ToString()
            Else
                clear()
            End If

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub tb_nopel_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_nopel.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_detail()
        End If
    End Sub

    Private Sub dtp_tgl_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_tgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            add_detail()
        End If
    End Sub

    Private Sub dtp_tgl_ValueChanged(sender As Object, e As EventArgs) Handles dtp_tgl.ValueChanged
        handleTanggal()
    End Sub

    Private Sub add_detail()
        If Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(tb_alamat.Text) Then
            Dim index As Integer = DataGridView1.RowCount - 1
            If DataGridView1.RowCount > 1 Then
                If bulanTbl <> DataGridView1.Rows(index - 1).Cells(2).Value And nama = DataGridView1.Rows(index - 1).Cells(1).Value Then
                    With DataGridView1
                        .Rows.Add()
                        .Rows(index).Cells(0).Value = nopel
                        .Rows(index).Cells(1).Value = nama
                        .Rows(index).Cells(2).Value = bulanTbl
                        .Rows(index).Cells(3).Value = "-"
                        .Rows(index).Cells("idx_bulan").Value = indexBulan
                    End With
                    Dim tanggal As Date = Date.Parse(dtp_tgl.Value)
                    dtp_tgl.Value = tanggal.AddMonths(-1)
                    DataGridView1.Sort(DataGridView1.Columns("idx_bulan"),
                                            System.ComponentModel.ListSortDirection.Ascending)
                End If
            Else
                With DataGridView1
                    .Rows.Add()
                    .Rows(index).Cells(0).Value = nopel
                    .Rows(index).Cells(1).Value = nama
                    .Rows(index).Cells(2).Value = bulanTbl
                    .Rows(index).Cells(3).Value = "-"
                    .Rows(index).Cells("idx_bulan").Value = indexBulan
                End With
                Dim tanggal As Date = Date.Parse(dtp_tgl.Value)
                dtp_tgl.Value = tanggal.AddMonths(-1)
            End If
        ElseIf String.IsNullOrEmpty(tb_nopel.Text) Then
            MsgBox("Harap isi Nomor Pelanggannya!", vbCritical)
        Else
            MsgBox("Nama, Alamat dan Golongan Dengan Nomor Pelanggan Tersebut Tidak Ada!", vbCritical)
        End If
    End Sub

    Dim dtItem As DataTable

    Private Sub Data_Load()
        dtItem = New DataTable
        With dtItem.Columns
            .Add("leftSide", Type.GetType("System.String"))
            .Add("rightSide", Type.GetType("System.String"))
        End With

        Dim ItemRow As DataRow
        '=== New Row ===
        ItemRow = dtItem.NewRow()

        'Left Side
        ItemRow("leftSide") = vbCrLf
        ItemRow("leftSide") &= "     " & "UD. CAHYA UTAMA" & vbCrLf
        ItemRow("leftSide") &= "     " & "==========================" & vbCrLf
        ItemRow("leftSide") &= "     " & "TGL. BAYAR : 18/08/2020" & vbCrLf
        ItemRow("leftSide") &= "     " & "NO PEL     : 010200286" & vbCrLf
        ItemRow("leftSide") &= "     " & "NAMA       : SOETOMO" & vbCrLf
        ItemRow("leftSide") &= "     " & "ALT        : GG SDM IV/8" & vbCrLf
        ItemRow("leftSide") &= "     " & "BLN. REK   : JUL 2020" & vbCrLf
        ItemRow("leftSide") &= "     " & "GOL.       : 2B" & vbCrLf
        ItemRow("leftSide") &= "     " & "STND MTR   : 382-358=24" & vbCrLf
        ItemRow("leftSide") &= "     " & "TAG        : Rp.   90.600" & vbCrLf
        ItemRow("leftSide") &= "     " & "ADMIN      : Rp.   2.500" & vbCrLf
        ItemRow("leftSide") &= "     " & "TOTAL      : Rp.   93100" & vbCrLf


        'Right Side
        ItemRow("rightSide") = vbCrLf
        ItemRow("rightSide") &= "TANDA TERIMA PEMBAYARAN REKENING PDAM MATARAM" & vbCrLf
        ItemRow("rightSide") &= "=======================================================================" & vbCrLf
        ItemRow("rightSide") &= "BLN. REK     : JUL 2020" & "                     " & "TGL. BAYAR  : 18/08/2020" & vbCrLf
        ItemRow("rightSide") &= "NO. SAMB     : 010200286" & "      " & "Gol.: 2B" & "      " & "STND MTR  : 382 - 358 = 24" & vbCrLf
        ItemRow("rightSide") &= "NAMA         : SOETOMO" & vbCrLf
        ItemRow("rightSide") &= "ALAMAT       : GG SDN IV/8" & vbCrLf
        ItemRow("rightSide") &= "TAGIHAN PDAM : Rp.          90.600" & vbCrLf
        ItemRow("rightSide") &= "ADMIN FEE    : Rp.           2.500" & vbCrLf
        ItemRow("rightSide") &= "TOTAL BAYAR  : Rp.          93.100" & vbCrLf
        ItemRow("rightSide") &= "Loket CAHYA UTAMA Menyatakan Struk ini Sebagai Bukti Yang Sah" & vbCrLf
        ItemRow("rightSide") &= "MOHON UNTUK DISIMPAN." & vbCrLf
        ItemRow("rightSide") &= " " & vbCrLf
        ItemRow("rightSide") &= "RINCIAN TAGIHAN DAPAT DIAKSES DI KANTOR PDAM GIRI MENANG - MATARAM. TELP. 0370-632510" & vbCrLf
        dtItem.Rows.Add(ItemRow)

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If DataGridView1.RowCount > 1 Then
            Select Case MsgBox("Yakin mau diprint?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes

                    Data_Load()

                    Printer.NewPrint()

                    Dim c As New PrintingFormat
                    Dim arrWidth() As Integer = {265, 529}
                    Dim arrFormat() As StringFormat = {c.MidLeft, c.MidLeft}

                    'looping item sales | loop item penjualan
                    For r = 0 To dtItem.Rows.Count - 1
                        Printer.Print(dtItem.Rows(r).Item("leftSide") & ";" &
                      dtItem.Rows(r).Item("rightSide") & ";", arrWidth, arrFormat)
                    Next

                    Printer.DoPrint()

                    'Try
                    '    cn.Open()
                    '    Dim cm = New OleDbCommand("INSERT INTO tagihan (no_pel, jumlah_bulan, tagihan, created_at, is_paid) 
                    '                       VALUES (@no_pel, @jumlah_bulan, @tagihan, @created_at, @is_paid)", cn)

                    '    Dim tagihan As Integer
                    '    Dim jumlah_bulan As Integer = DataGridView1.RowCount - 1

                    '    For i = 0 To DataGridView1.RowCount - 2
                    '        tagihan += DataGridView1.Rows(i).Cells("tagihan").Value
                    '    Next

                    '    With DataGridView1.Rows(0)
                    '        cm.Parameters.AddWithValue("@no_pel", .Cells("no_pel").Value)
                    '        cm.Parameters.AddWithValue("@jumlah_bulan", jumlah_bulan)
                    '        cm.Parameters.AddWithValue("@tagihan", tagihan)
                    '        cm.Parameters.AddWithValue("@created_at", Date.Now.ToString("d/M/yyyy H:m:ss"))
                    '        cm.Parameters.AddWithValue("@is_paid", False)
                    '    End With

                    '    cm.ExecuteNonQuery()
                    '    DataGridView1.Rows.Clear()
                    '    DataGridView1.Refresh()
                    '    clear()
                    '    MsgBox("Success", vbInformation)
                    '    cn.Close()
                    'Catch ex As Exception
                    '    cn.Close()
                    '    MsgBox(ex.Message.ToString(), vbCritical)
                    'End Try
                    'tb_nopel.Text = ""
            End Select
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        With DataGridView1
            Dim tagihan As Integer
            Dim withAdmin As Integer
            For i = 0 To .RowCount - 2
                tagihan += .Rows(i).Cells(4).Value
                withAdmin += .Rows(i).Cells(4).Value + 2500
            Next
            .Rows(.RowCount - 1).Cells(3).Value = "Admin: " & FormatNumber(withAdmin, 0, , , TriState.True)
            .Rows(.RowCount - 1).Cells(3).Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
            .Rows(.RowCount - 1).Cells(4).Value = "Total: " & FormatNumber(tagihan, 0, , , TriState.True)
            .Rows(.RowCount - 1).Cells(4).Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
        End With
    End Sub
End Class