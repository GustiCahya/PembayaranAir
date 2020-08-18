<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Riwayat))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_dibuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_trx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_filter = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_dibayar = New System.Windows.Forms.Button()
        Me.chk_terbayar = New System.Windows.Forms.CheckBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.no_pel, Me.nama_pel, Me.jumlah_bulan, Me.tagihan, Me.tgl_dibuat, Me.no_trx})
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(527, 245)
        Me.DataGridView1.TabIndex = 16
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 50
        '
        'no_pel
        '
        Me.no_pel.HeaderText = "No. Pelanggan"
        Me.no_pel.Name = "no_pel"
        Me.no_pel.ReadOnly = True
        Me.no_pel.Width = 90
        '
        'nama_pel
        '
        Me.nama_pel.HeaderText = "Nama Pelanggan"
        Me.nama_pel.Name = "nama_pel"
        Me.nama_pel.ReadOnly = True
        '
        'jumlah_bulan
        '
        Me.jumlah_bulan.HeaderText = "Jumlah Bulan"
        Me.jumlah_bulan.Name = "jumlah_bulan"
        Me.jumlah_bulan.ReadOnly = True
        Me.jumlah_bulan.Width = 50
        '
        'tagihan
        '
        Me.tagihan.HeaderText = "Tagihan"
        Me.tagihan.Name = "tagihan"
        Me.tagihan.ReadOnly = True
        '
        'tgl_dibuat
        '
        Me.tgl_dibuat.HeaderText = "Tanggal Dibuat"
        Me.tgl_dibuat.Name = "tgl_dibuat"
        Me.tgl_dibuat.ReadOnly = True
        Me.tgl_dibuat.Width = 120
        '
        'no_trx
        '
        Me.no_trx.HeaderText = "No Trx"
        Me.no_trx.Name = "no_trx"
        Me.no_trx.ReadOnly = True
        Me.no_trx.Visible = False
        '
        'dtp_filter
        '
        Me.dtp_filter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_filter.Location = New System.Drawing.Point(12, 30)
        Me.dtp_filter.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_filter.Name = "dtp_filter"
        Me.dtp_filter.Size = New System.Drawing.Size(200, 29)
        Me.dtp_filter.TabIndex = 17
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 18
        Me.MetroLabel1.Text = "Tanggal"
        '
        'btn_laporan
        '
        Me.btn_laporan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_laporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_laporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_laporan.ForeColor = System.Drawing.Color.Snow
        Me.btn_laporan.Location = New System.Drawing.Point(342, 18)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(172, 45)
        Me.btn_laporan.TabIndex = 20
        Me.btn_laporan.Text = "BUAT LAPORAN"
        Me.btn_laporan.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.Snow
        Me.btn_delete.Location = New System.Drawing.Point(273, 9)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(63, 26)
        Me.btn_delete.TabIndex = 22
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        Me.btn_delete.Visible = False
        '
        'btn_dibayar
        '
        Me.btn_dibayar.BackColor = System.Drawing.Color.Teal
        Me.btn_dibayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dibayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dibayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_dibayar.ForeColor = System.Drawing.Color.Snow
        Me.btn_dibayar.Location = New System.Drawing.Point(218, 37)
        Me.btn_dibayar.Name = "btn_dibayar"
        Me.btn_dibayar.Size = New System.Drawing.Size(118, 26)
        Me.btn_dibayar.TabIndex = 23
        Me.btn_dibayar.Text = "✓ Sudah Dibayar"
        Me.btn_dibayar.UseVisualStyleBackColor = False
        '
        'chk_terbayar
        '
        Me.chk_terbayar.AutoSize = True
        Me.chk_terbayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_terbayar.Location = New System.Drawing.Point(82, 11)
        Me.chk_terbayar.Name = "chk_terbayar"
        Me.chk_terbayar.Size = New System.Drawing.Size(185, 17)
        Me.chk_terbayar.TabIndex = 24
        Me.chk_terbayar.Text = "Tampilkan dengan yg sdh dibayar"
        Me.chk_terbayar.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Riwayat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 314)
        Me.Controls.Add(Me.chk_terbayar)
        Me.Controls.Add(Me.btn_dibayar)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_laporan)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtp_filter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Riwayat"
        Me.Text = "Riwayat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp_filter As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_laporan As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents no_pel As DataGridViewTextBoxColumn
    Friend WithEvents nama_pel As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_bulan As DataGridViewTextBoxColumn
    Friend WithEvents tagihan As DataGridViewTextBoxColumn
    Friend WithEvents tgl_dibuat As DataGridViewTextBoxColumn
    Friend WithEvents no_trx As DataGridViewTextBoxColumn
    Friend WithEvents btn_dibayar As Button
    Friend WithEvents chk_terbayar As CheckBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
