Imports System.Configuration
Imports System.Data.OleDb
Public Class pelanggan

    Private cnString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString()
    Private cn As New OleDbConnection(cnString)

    Public Sub LoadTable()
        Try
            Dim cm As New OleDbCommand("SELECT * FROM pelanggan", cn)
            cn.Open()
            Dim dtPelanggan As New DataTable()
            dtPelanggan.Load(cm.ExecuteReader())
            DataGridView1.DataSource = dtPelanggan
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub Clear()
        tb_nopel.Text = ""
        tb_nama.Text = ""
        tb_alamat.Text = ""
        tb_golongan.Text = ""
    End Sub

    Private Sub tb_nopel_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_nopel.KeyDown
        'Search Nomor Pelanggan
        If e.KeyCode = Keys.Enter Then
            If tb_nopel.Text.Count > 0 Then
                Try
                    Dim cm As New OleDbCommand("SELECT * FROM pelanggan WHERE No_Pel LIKE @nopel", cn)
                    cm.Parameters.AddWithValue("@nopel", "%" + tb_nopel.Text + "%")
                    cn.Open()
                    Dim dt As New DataTable
                    dt.Load(cm.ExecuteReader())
                    DataGridView1.DataSource = dt
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
        'Search Nama Pelanggan
        If e.KeyCode = Keys.Enter Then
            If tb_nama.Text.Count > 0 Then
                Try
                    Dim cm As New OleDbCommand("SELECT * FROM pelanggan WHERE nama_pel LIKE @nama_pel", cn)
                    cm.Parameters.AddWithValue("@nopel", "%" + tb_nama.Text + "%")
                    cn.Open()
                    Dim dt As New DataTable
                    dt.Load(cm.ExecuteReader())
                    DataGridView1.DataSource = dt
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

    Private Sub tb_alamat_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_alamat.KeyDown
        'Search Alamat Pelanggan
        If e.KeyCode = Keys.Enter Then
            If tb_alamat.Text.Count > 0 Then
                Try
                    Dim cm As New OleDbCommand("SELECT * FROM pelanggan WHERE alamat LIKE @alamat", cn)
                    cm.Parameters.AddWithValue("@alamat", "%" + tb_alamat.Text + "%")
                    cn.Open()
                    Dim dt As New DataTable
                    dt.Load(cm.ExecuteReader())
                    DataGridView1.DataSource = dt
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

    Private Sub tb_golongan_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_golongan.KeyDown
        'Search Golongan Pelanggan
        If e.KeyCode = Keys.Enter Then
            If tb_golongan.Text.Count > 0 Then
                Try
                    Dim cm As New OleDbCommand("SELECT * FROM pelanggan WHERE golongan LIKE @golongan", cn)
                    cm.Parameters.AddWithValue("@golongan", "%" + tb_golongan.Text + "%")
                    cn.Open()
                    Dim dt As New DataTable
                    dt.Load(cm.ExecuteReader())
                    DataGridView1.DataSource = dt
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

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        btn_back.Visible = False
        btn_update.Visible = False
        btn_delete.Visible = False
        tb_nopel.ReadOnly = False
        tb_nopel.Cursor = System.Windows.Forms.Cursors.IBeam
        Clear()
        LoadTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            With DataGridView1
                tb_nopel.Text = .Item(0, e.RowIndex).Value
                tb_nama.Text = .Item(1, e.RowIndex).Value
                tb_alamat.Text = .Item(2, e.RowIndex).Value
                tb_golongan.Text = .Item(3, e.RowIndex).Value
            End With
            tb_nopel.ReadOnly = True
            tb_nopel.Cursor = System.Windows.Forms.Cursors.No
            btn_back.Visible = True
            btn_update.Visible = True
            btn_delete.Visible = True
        End If
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            Dim cm As New OleDbCommand("INSERT INTO pelanggan VALUES (@nopel, @nama, @alamat, @golongan)", cn)
            cn.Open()
            cm.Parameters.AddWithValue("@nopel", tb_nopel.Text)
            cm.Parameters.AddWithValue("@nama", tb_nama.Text)
            cm.Parameters.AddWithValue("@alamat", tb_alamat.Text)
            cm.Parameters.AddWithValue("@golongan", tb_golongan.Text)
            cm.ExecuteNonQuery()
            cn.Close()
            LoadTable()
            Clear()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Dim cm As New OleDbCommand("DELETE FROM pelanggan WHERE no_pel=@nopel", cn)
            cn.Open()
            cm.Parameters.AddWithValue("@nopel", tb_nopel.Text)
            cm.ExecuteNonQuery()
            cn.Close()
            btn_back.PerformClick()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            Dim cm As New OleDbCommand("UPDATE pelanggan SET no_pel=@nopel, nama_pel=@nama, alamat=@alamat, golongan=@golongan WHERE no_pel=@nopel", cn)
            cn.Open()
            cm.Parameters.AddWithValue("@nopel", tb_nopel.Text)
            cm.Parameters.AddWithValue("@nama", tb_nama.Text)
            cm.Parameters.AddWithValue("@alamat", tb_alamat.Text)
            cm.Parameters.AddWithValue("@golongan", tb_golongan.Text)
            cm.ExecuteNonQuery()
            cn.Close()
            btn_back.PerformClick()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class