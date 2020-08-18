<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.tb_nopel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtp_tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_golongan = New System.Windows.Forms.TextBox()
        Me.lbl_bulan = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.no_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stand_meter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idx_bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_nopel
        '
        Me.tb_nopel.Location = New System.Drawing.Point(13, 27)
        Me.tb_nopel.Name = "tb_nopel"
        Me.tb_nopel.Size = New System.Drawing.Size(177, 20)
        Me.tb_nopel.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "No. Pelanggan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_pel, Me.nama_pelanggan, Me.bulan, Me.stand_meter, Me.tagihan, Me.idx_bulan})
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(527, 207)
        Me.DataGridView1.TabIndex = 15
        '
        'dtp_tgl
        '
        Me.dtp_tgl.Location = New System.Drawing.Point(197, 26)
        Me.dtp_tgl.Name = "dtp_tgl"
        Me.dtp_tgl.Size = New System.Drawing.Size(183, 20)
        Me.dtp_tgl.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tanggal"
        '
        'tb_nama
        '
        Me.tb_nama.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_nama.Location = New System.Drawing.Point(13, 66)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.ReadOnly = True
        Me.tb_nama.Size = New System.Drawing.Size(126, 20)
        Me.tb_nama.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Alamat"
        '
        'tb_alamat
        '
        Me.tb_alamat.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_alamat.Location = New System.Drawing.Point(145, 66)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.ReadOnly = True
        Me.tb_alamat.Size = New System.Drawing.Size(126, 20)
        Me.tb_alamat.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Golongan"
        '
        'tb_golongan
        '
        Me.tb_golongan.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_golongan.Location = New System.Drawing.Point(277, 66)
        Me.tb_golongan.Name = "tb_golongan"
        Me.tb_golongan.ReadOnly = True
        Me.tb_golongan.Size = New System.Drawing.Size(103, 20)
        Me.tb_golongan.TabIndex = 31
        '
        'lbl_bulan
        '
        Me.lbl_bulan.Font = New System.Drawing.Font("Open Sans", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_bulan.Location = New System.Drawing.Point(383, 9)
        Me.lbl_bulan.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_bulan.Name = "lbl_bulan"
        Me.lbl_bulan.Size = New System.Drawing.Size(142, 39)
        Me.lbl_bulan.TabIndex = 33
        Me.lbl_bulan.Text = "bulan"
        Me.lbl_bulan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_print.ForeColor = System.Drawing.Color.Snow
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(400, 51)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(110, 35)
        Me.btn_print.TabIndex = 34
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'no_pel
        '
        Me.no_pel.HeaderText = "No. Pelanggan"
        Me.no_pel.Name = "no_pel"
        Me.no_pel.ReadOnly = True
        Me.no_pel.Width = 90
        '
        'nama_pelanggan
        '
        Me.nama_pelanggan.HeaderText = "Nama Pelanggan"
        Me.nama_pelanggan.Name = "nama_pelanggan"
        Me.nama_pelanggan.ReadOnly = True
        Me.nama_pelanggan.Width = 140
        '
        'bulan
        '
        Me.bulan.HeaderText = "Bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.ReadOnly = True
        Me.bulan.Width = 50
        '
        'stand_meter
        '
        Me.stand_meter.HeaderText = "Stand Meter"
        Me.stand_meter.Name = "stand_meter"
        '
        'tagihan
        '
        Me.tagihan.HeaderText = "Tagihan"
        Me.tagihan.Name = "tagihan"
        Me.tagihan.Width = 120
        '
        'idx_bulan
        '
        Me.idx_bulan.HeaderText = "idx_bulan"
        Me.idx_bulan.Name = "idx_bulan"
        Me.idx_bulan.Visible = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 314)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_bulan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_golongan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_tgl)
        Me.Controls.Add(Me.tb_nopel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_nopel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp_tgl As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_golongan As TextBox
    Friend WithEvents lbl_bulan As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents no_pel As DataGridViewTextBoxColumn
    Friend WithEvents nama_pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents bulan As DataGridViewTextBoxColumn
    Friend WithEvents stand_meter As DataGridViewTextBoxColumn
    Friend WithEvents tagihan As DataGridViewTextBoxColumn
    Friend WithEvents idx_bulan As DataGridViewTextBoxColumn
End Class
