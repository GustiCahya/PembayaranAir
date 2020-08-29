Imports System.Configuration
Imports System.Data.OleDb
Public Class Transaksi

    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)

    Public currentId As String

    Public nopel As String
    Public nama As String
    Public alamat As String
    Public golongan As String
    Public sekarang As String = Date.Now.ToString("dd/MM/yyyy")
    Public indexBulan As Integer
    Public currentTahun As Integer
    Public bulanTbl As String

    Private Sub handleTanggal()
        'Handle dtp_tanggal
        Dim daftarBulan As String() = {"JAN", "FEB", "MAR", "APR", "MEI", "JUN", "JUL", "AGU", "SEP", "OKT", "NOV", "DES"}
        indexBulan = dtp_tgl.Value.Month - 2
        currentTahun = dtp_tgl.Value.Year
        If indexBulan < 0 Then
            currentTahun -= 1
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
                alamat = dt.Rows(0).Item(2).ToString()
                golongan = dt.Rows(0).Item(3).ToString()

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
            If DataGridView1.RowCount > 0 Then
                With DataGridView1
                    .Rows.Add()
                    .Rows(index).Cells("no_pel").Value = nopel
                    .Rows(index).Cells("nama_pelanggan").Value = nama
                    .Rows(index).Cells("bulan").Value = bulanTbl
                    .Rows(index).Cells("alamat_pel").Value = tb_alamat.Text
                    .Rows(index).Cells("gol_pel").Value = tb_golongan.Text
                    .Rows(index).Cells("stand_meter").Value = "-"
                    .Rows(index).Cells("idx").Value = index + 1
                    .Rows(index).Cells("tahun").Value = currentTahun
                End With
                Dim tanggal As Date = Date.Parse(dtp_tgl.Value)
                dtp_tgl.Value = tanggal.AddMonths(-1)
                DataGridView1.Sort(DataGridView1.Columns("idx"),
                                System.ComponentModel.ListSortDirection.Descending)
            End If
        ElseIf String.IsNullOrEmpty(tb_nopel.Text) Then
            MsgBox("Harap isi Nomor Pelanggannya!", vbCritical)
        Else
            MsgBox("Data tidak ada, silahkan isi di menu pelanggan atau kalau sudah diisi di menu pelanggan silakan hapus lalu ketik ulang nomornya!", vbInformation)
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If DataGridView1.RowCount > 1 Then
            Select Case MsgBox("Yakin mau dilanjutkan?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes

                    If chk_hanya_add.Checked <> True Then

                        Dim tTxtPrint As String
                        For i = 0 To DataGridView1.RowCount - 2
                            With DataGridView1.Rows(i)

                                Dim nopel As String = .Cells("no_pel").Value
                                Dim nama As String = .Cells("nama_pelanggan").Value
                                Dim alamat As String = .Cells("alamat_pel").Value
                                Dim golongan As String = .Cells("gol_pel").Value
                                Dim bulan As String = .Cells("bulan").Value
                                Dim tahun As String = .Cells("tahun").Value
                                Dim stand_meter As String = .Cells("stand_meter").Value
                                Dim tagihan As Integer = .Cells("tagihan").Value
                                Dim admin As Integer = 2500
                                Dim tagihanWithAdmin As Integer = tagihan + admin

                                Dim f_tagihan As String = String.Format("{0:#,#}", tagihan).Replace(",", ".")
                                Dim f_admin As String = String.Format("{0:#,#}", admin).Replace(",", ".")
                                Dim f_total As String = String.Format("{0:#,#}", tagihanWithAdmin).Replace(",", ".")
                                tTxtPrint = RawPrinterHelper.AwalBrs
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "TANDA TERIMA PEMBAYARAN REKENING PDAM MATARAM" & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "_______________________________________________________________" & vbCrLf
                                tTxtPrint &= vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "BLN. REK     : " & bulan & " " & tahun & "               " & "TGL. BAYAR  : " & sekarang & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "NO. SAMB     : " & nopel & "              " & "STND MTR    : " & stand_meter & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "NAMA         : " & nama & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "Gol.         : " & golongan & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "ALAMAT       : " & alamat & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "TAGIHAN PDAM : Rp.          " & f_tagihan & vbCrLf
                                If tagihan >= 100000 Then
                                    tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "ADMIN FEE    : Rp.            " & f_admin & vbCrLf
                                Else
                                    tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "ADMIN FEE    : Rp.           " & f_admin & vbCrLf
                                End If
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "TOTAL BAYAR  : Rp.          " & f_total & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "Loket CAHYA UTAMA Menyatakan Struk ini Sebagai Bukti Yang Sah" & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "MOHON UNTUK DISIMPAN." & vbCrLf
                                tTxtPrint &= " " & vbCrLf
                                tTxtPrint &= vbTab & vbTab & vbTab & vbTab & vbTab & "RINCIAN TAGIHAN DAPAT DIAKSES DI KANTOR PDAM GIRI MENANG - MATARAM. TELP. 0370-632510" & vbCrLf
                                tTxtPrint &= vbCrLf
                            End With
                            'RawPrinterHelper.fnPrintRaw("Epson LQ-2180 ESC/P 2", tTxtPrint)
                            RawPrinterHelper.fnPrintRaw("Epson LX-310", tTxtPrint)
                        Next

                        If chk_hanya_print.Checked = True Then
                            DataGridView1.Rows.Clear()
                            DataGridView1.Refresh()
                        End If
                        clear()
                        tb_nopel.Text = ""
                    End If

                    If chk_hanya_print.Checked <> True Then
                        Try
                            cn.Open()

                            Dim pelanggan As ArrayList = New ArrayList()
                            Dim current_pelanggan As String = DataGridView1.Rows(0).Cells("no_pel").Value
                            Dim tagihan As Integer
                            Dim jumlah_bulan As Integer

                            For i = 0 To DataGridView1.RowCount - 2
                                With DataGridView1.Rows(i)
                                    If current_pelanggan = .Cells("no_pel").Value Then
                                        tagihan += Integer.Parse(.Cells("tagihan").Value)
                                        jumlah_bulan += 1
                                    ElseIf current_pelanggan <> .Cells("no_pel").Value Then
                                        pelanggan.Add({current_pelanggan, jumlah_bulan, tagihan})
                                        current_pelanggan = .Cells("no_pel").Value
                                        tagihan = 0
                                        jumlah_bulan = 0
                                        tagihan += Integer.Parse(.Cells("tagihan").Value)
                                        jumlah_bulan += 1
                                    End If
                                End With
                            Next
                            pelanggan.Add({current_pelanggan, jumlah_bulan, tagihan})

                            For i = 0 To pelanggan.Count - 1
                                Dim cm = New OleDbCommand("INSERT INTO Tagihan (no_pel, jumlah_bulan, tagihan, created_at, is_paid)
                                               VALUES (@no_pel, @jumlah_bulan, @tagihan, @created_at, @is_paid)", cn)
                                cm.Parameters.AddWithValue("@no_pel", pelanggan(i)(0))
                                cm.Parameters.AddWithValue("@jumlah_bulan", pelanggan(i)(1))
                                cm.Parameters.AddWithValue("@tagihan", pelanggan(i)(2))
                                cm.Parameters.AddWithValue("@created_at", Date.Now.ToString("dd/MM/yyyy H:m:ss"))
                                cm.Parameters.AddWithValue("@is_paid", False)
                                cm.ExecuteNonQuery()
                            Next

                            DataGridView1.Rows.Clear()
                            DataGridView1.Refresh()
                            clear()
                            MsgBox("Success", vbInformation)
                            cn.Close()
                            PageAdmin.FormPanel(Riwayat)
                            Riwayat.DataGridView1.Rows.Clear()
                            Riwayat.LoadTable()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message.ToString(), vbCritical)
                        End Try
                        tb_nopel.Text = ""
                    End If
            End Select
        Else
            MsgBox("Tidak ada transaksi yang akan dieksekusi", vbInformation)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_delete_all.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        clear()
        tb_nopel.Text = ""
    End Sub

    Private Sub chk_hanya_add_CheckedChanged(sender As Object, e As EventArgs) Handles chk_hanya_add.CheckedChanged
        If chk_hanya_add.Checked = True Then
            btn_print.Text = "Add"
        Else
            btn_print.Text = "Print"
        End If
    End Sub

    Private Sub btn_taruh_antrian_Click(sender As Object, e As EventArgs) Handles btn_taruh_antrian.Click
        Try
            cn.Open()
            For i = 0 To DataGridView1.RowCount - 2
                With DataGridView1.Rows(i)
                    Dim cm = New OleDbCommand("INSERT INTO Antrian (no_pel, bulan, stand_meter, tagihan, tahun, created_at) VALUES (@no_pel, @bulan, @stand_meter, @tagihan, @tahun, @created_at)", cn)
                    cm.Parameters.AddWithValue("@no_pel", .Cells("no_pel").Value)
                    cm.Parameters.AddWithValue("@bulan", .Cells("bulan").Value)
                    cm.Parameters.AddWithValue("@stand_meter", .Cells("stand_meter").Value)
                    cm.Parameters.AddWithValue("@tagihan", .Cells("tagihan").Value)
                    cm.Parameters.AddWithValue("@tahun", .Cells("tahun").Value)
                    cm.Parameters.AddWithValue("@created_at", Date.Now.ToString())
                    cm.ExecuteNonQuery()
                End With
            Next
            MsgBox("Transaksi BERHASIL Dimasukkan ke Antrian")
            DataGridView1.Rows.Clear()
            clear()
            cn.Close()
            tb_nopel.Text = ""
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

End Class