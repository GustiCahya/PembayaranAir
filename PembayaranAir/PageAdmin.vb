Public Class PageAdmin
    Public title As String
    Public Sub FormPanel(ByVal CurrentForm As Object)
        If Me.PanelShow.Controls.Count > 0 Then
            Me.PanelShow.Controls.RemoveAt(0)
        End If
        Dim cf As Form = TryCast(CurrentForm, Form)
        cf.TopLevel = False
        cf.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        cf.Dock = DockStyle.Fill
        cf.BackColor = Color.White
        Me.PanelShow.Controls.Add(cf)
        Me.PanelShow.Tag = cf
        cf.Show()
        lbl_title.Text = "Pembayaran Air | " & title
    End Sub
    Private Sub PageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        title = "Transaksi"
        FormPanel(Transaksi)
    End Sub
    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        title = "Transaksi"
        FormPanel(Transaksi)
    End Sub
    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        title = "Riwayat"
        FormPanel(Riwayat)
        Riwayat.DataGridView1.Rows.Clear()
        Riwayat.LoadTable()
    End Sub
    Private Sub btn_pelanggan_Click(sender As Object, e As EventArgs) Handles btn_pelanggan.Click
        title = "Pelanggan"
        FormPanel(pelanggan)
        pelanggan.DataGridView1.DataSource = vbNull
        pelanggan.LoadTable()
    End Sub
    Private Sub btn_antrian_Click(sender As Object, e As EventArgs) Handles btn_antrian.Click
        title = "Antrian"
        FormPanel(Antrian)
        Antrian.DataGridView1.Rows.Clear()
        Antrian.LoadTable()
    End Sub
End Class
