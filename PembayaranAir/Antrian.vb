Imports System.Configuration
Imports System.Data.OleDb
Public Class Antrian

    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)
    Public current_no_pel As String
    Public current_bulan As String
    Public current_tagihan As String

    Public sekarang As String = Date.Now.ToString("dd/MM/yyyy")

    Private Sub Antrian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Sub LoadTable()
        DataGridView1.Rows.Clear()
        Try
            cn.Open()
            Dim cm = New OleDbCommand("SELECT Antrian.No_Pel, Pelanggan.Nama_Pel, Antrian.Bulan, Antrian.Stand_Meter, Antrian.Tagihan, 
                                       Antrian.No, Antrian.Tahun, Pelanggan.Alamat, Pelanggan.Golongan, Antrian.Created_At FROM Antrian 
                                       INNER JOIN Pelanggan ON Antrian.No_Pel = Pelanggan.No_Pel", cn)
            Dim dt As New DataTable()
            dt.Load(cm.ExecuteReader())
            For i = 0 To dt.Rows.Count - 1
                With DataGridView1
                    .Rows.Add()
                    .Rows(i).Cells("no_pel").Value = dt.Rows(i).Item(0)
                    .Rows(i).Cells("nama_pelanggan").Value = dt.Rows(i).Item(1)
                    .Rows(i).Cells("bulan").Value = dt.Rows(i).Item(2)
                    .Rows(i).Cells("stand_meter").Value = dt.Rows(i).Item(3)
                    .Rows(i).Cells("tagihan").Value = dt.Rows(i).Item(4)
                    .Rows(i).Cells("idx").Value = dt.Rows(i).Item(5)
                    .Rows(i).Cells("tahun").Value = dt.Rows(i).Item(6)
                    .Rows(i).Cells("alamat_pel").Value = dt.Rows(i).Item(7)
                    .Rows(i).Cells("gol_pel").Value = dt.Rows(i).Item(8)
                    .Rows(i).Cells("created_at").Value = dt.Rows(i).Item(9)
                End With
                DataGridView1.Sort(DataGridView1.Columns("no_pel"),
                                System.ComponentModel.ListSortDirection.Ascending)
            Next
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Sub Clear()
        tb_nopel.Text = ""
        tb_nama.Text = ""
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        If DataGridView1.RowCount > 1 Then
            Select Case MsgBox("Yakin mau dilanjutkan?", MsgBoxStyle.YesNo + vbQuestion)
                Case MsgBoxResult.Yes

                    If chk_hanya_add.Checked <> True Then

                        Dim tTxtPrint As String
                        For i = 0 To DataGridView1.RowCount - 1
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
                            LoadTable()
                        End If
                        Clear()
                    End If

                    If chk_hanya_print.Checked <> True Then
                        Try
                            cn.Open()

                            Dim pelanggan As ArrayList = New ArrayList()
                            Dim current_pelanggan As String = DataGridView1.Rows(0).Cells("no_pel").Value
                            Dim tagihan As Integer
                            Dim jumlah_bulan As Integer

                            For i = 0 To DataGridView1.RowCount - 1
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
                                Dim cm2 = New OleDbCommand("DELETE FROM Antrian WHERE No_Pel=@no_pel", cn)
                                cm2.Parameters.AddWithValue("@no_pel", pelanggan(i)(0))
                                cm2.ExecuteNonQuery()
                            Next
                            Clear()
                            MsgBox("Success", vbInformation)
                            cn.Close()
                            LoadTable()
                            PageAdmin.title = "Riwayat"
                            PageAdmin.FormPanel(Riwayat)
                            Riwayat.LoadTableNow()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message.ToString(), vbCritical)
                        End Try
                    End If
            End Select
        Else
            MsgBox("Tidak ada antrian yang akan dieksekusi", vbInformation)
        End If
    End Sub

    Private Sub chk_hanya_add_CheckedChanged(sender As Object, e As EventArgs) Handles chk_hanya_add.CheckedChanged
        If chk_hanya_add.Checked = True Then
            btn_print.Text = "Add"
        Else
            btn_print.Text = "Print"
        End If
    End Sub

    Private Sub tb_nopel_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_nopel.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrEmpty(tb_nopel.Text) Then
                Try
                    cn.Open()
                    Dim cm = New OleDbCommand("SELECT Antrian.No_Pel, Pelanggan.Nama_Pel, Antrian.Bulan, Antrian.Stand_Meter, Antrian.Tagihan, 
                                       Antrian.No, Antrian.Tahun, Pelanggan.Alamat, Pelanggan.Golongan FROM Antrian 
                                       INNER JOIN Pelanggan ON Antrian.No_Pel = Pelanggan.No_Pel
                                       WHERE Antrian.No_Pel LIKE @no_pel", cn)
                    cm.Parameters.AddWithValue("@no_pel", "%" & tb_nopel.Text & "%")
                    Dim dt As New DataTable()
                    dt.Load(cm.ExecuteReader())
                    DataGridView1.Rows.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        With DataGridView1
                            .Rows.Add()
                            .Rows(i).Cells("no_pel").Value = dt.Rows(i).Item(0)
                            .Rows(i).Cells("nama_pelanggan").Value = dt.Rows(i).Item(1)
                            .Rows(i).Cells("bulan").Value = dt.Rows(i).Item(2)
                            .Rows(i).Cells("stand_meter").Value = dt.Rows(i).Item(3)
                            .Rows(i).Cells("tagihan").Value = dt.Rows(i).Item(4)
                            .Rows(i).Cells("idx").Value = dt.Rows(i).Item(5)
                            .Rows(i).Cells("tahun").Value = dt.Rows(i).Item(6)
                            .Rows(i).Cells("alamat_pel").Value = dt.Rows(i).Item(7)
                            .Rows(i).Cells("gol_pel").Value = dt.Rows(i).Item(8)
                        End With
                        DataGridView1.Sort(DataGridView1.Columns("no_pel"),
                                System.ComponentModel.ListSortDirection.Ascending)
                    Next
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
            Else
                LoadTable()
            End If
        End If
    End Sub
    Private Sub tb_nama_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrEmpty(tb_nama.Text) Then
                Try
                    cn.Open()
                    Dim cm = New OleDbCommand("SELECT Antrian.No_Pel, Pelanggan.Nama_Pel, Antrian.Bulan, Antrian.Stand_Meter, Antrian.Tagihan, 
                                       Antrian.No, Antrian.Tahun, Pelanggan.Alamat, Pelanggan.Golongan FROM Antrian 
                                       INNER JOIN Pelanggan ON Antrian.No_Pel = Pelanggan.No_Pel
                                       WHERE Pelanggan.Nama_Pel LIKE @nama_pel", cn)
                    cm.Parameters.AddWithValue("@nama_pel", "%" & tb_nama.Text & "%")
                    Dim dt As New DataTable()
                    dt.Load(cm.ExecuteReader())
                    DataGridView1.Rows.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        With DataGridView1
                            .Rows.Add()
                            .Rows(i).Cells("no_pel").Value = dt.Rows(i).Item(0)
                            .Rows(i).Cells("nama_pelanggan").Value = dt.Rows(i).Item(1)
                            .Rows(i).Cells("bulan").Value = dt.Rows(i).Item(2)
                            .Rows(i).Cells("stand_meter").Value = dt.Rows(i).Item(3)
                            .Rows(i).Cells("tagihan").Value = dt.Rows(i).Item(4)
                            .Rows(i).Cells("idx").Value = dt.Rows(i).Item(5)
                            .Rows(i).Cells("tahun").Value = dt.Rows(i).Item(6)
                            .Rows(i).Cells("alamat_pel").Value = dt.Rows(i).Item(7)
                            .Rows(i).Cells("gol_pel").Value = dt.Rows(i).Item(8)
                        End With
                        DataGridView1.Sort(DataGridView1.Columns("no_pel"),
                                System.ComponentModel.ListSortDirection.Ascending)
                    Next
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
            Else
                LoadTable()
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not String.IsNullOrEmpty(current_no_pel) Then
            Try
                cn.Open()
                Dim cm = New OleDbCommand("DELETE FROM Antrian WHERE No_Pel=@no_pel AND Bulan=@bulan AND Tagihan=@tagihan", cn)
                cm.Parameters.AddWithValue("@no_pel", current_no_pel)
                cm.Parameters.AddWithValue("@bulan", current_bulan)
                cm.Parameters.AddWithValue("@tagihan", current_tagihan)
                cm.ExecuteNonQuery()
                cn.Close()
                LoadTable()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        Else
            MsgBox("Harap pilih baris yang mau dihapus.", vbInformation)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            current_no_pel = DataGridView1.Rows(e.RowIndex).Cells("No_Pel").Value
            current_bulan = DataGridView1.Rows(e.RowIndex).Cells("Bulan").Value
            current_tagihan = DataGridView1.Rows(e.RowIndex).Cells("Tagihan").Value
        End If
    End Sub
End Class