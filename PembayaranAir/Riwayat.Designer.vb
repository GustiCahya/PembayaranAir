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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_dibuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_trx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_dibayar = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.btn_row_tidak = New System.Windows.Forms.Button()
        Me.btn_row_terbayar = New System.Windows.Forms.Button()
        Me.btn_tidak = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(527, 148)
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
        'btn_laporan
        '
        Me.btn_laporan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_laporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_laporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_laporan.ForeColor = System.Drawing.Color.Snow
        Me.btn_laporan.Location = New System.Drawing.Point(256, 5)
        Me.btn_laporan.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(185, 37)
        Me.btn_laporan.TabIndex = 20
        Me.btn_laporan.Text = "Generate Laporan"
        Me.btn_laporan.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.Snow
        Me.btn_delete.Location = New System.Drawing.Point(444, 16)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(63, 26)
        Me.btn_delete.TabIndex = 22
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_dibayar
        '
        Me.btn_dibayar.BackColor = System.Drawing.Color.Teal
        Me.btn_dibayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dibayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dibayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_dibayar.ForeColor = System.Drawing.Color.Snow
        Me.btn_dibayar.Location = New System.Drawing.Point(256, 45)
        Me.btn_dibayar.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btn_dibayar.Name = "btn_dibayar"
        Me.btn_dibayar.Size = New System.Drawing.Size(251, 26)
        Me.btn_dibayar.TabIndex = 23
        Me.btn_dibayar.Text = "✓ Tandai Terbayar Berdasarkan Tanggal"
        Me.btn_dibayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dibayar.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(14, 2)
        Me.MonthCalendar1.MaxSelectionCount = 31
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_no)
        Me.GroupBox1.Controls.Add(Me.btn_row_tidak)
        Me.GroupBox1.Controls.Add(Me.btn_row_terbayar)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 60)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eksekusi Berdasarkan Baris"
        '
        'lbl_no
        '
        Me.lbl_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(18, 20)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(57, 25)
        Me.lbl_no.TabIndex = 31
        Me.lbl_no.Text = "NO."
        Me.lbl_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_row_tidak
        '
        Me.btn_row_tidak.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_row_tidak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_row_tidak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_row_tidak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_row_tidak.ForeColor = System.Drawing.Color.Snow
        Me.btn_row_tidak.Location = New System.Drawing.Point(167, 21)
        Me.btn_row_tidak.Name = "btn_row_tidak"
        Me.btn_row_tidak.Size = New System.Drawing.Size(72, 26)
        Me.btn_row_tidak.TabIndex = 29
        Me.btn_row_tidak.Text = "✘ Tidak"
        Me.btn_row_tidak.UseVisualStyleBackColor = False
        '
        'btn_row_terbayar
        '
        Me.btn_row_terbayar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_row_terbayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_row_terbayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_row_terbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_row_terbayar.ForeColor = System.Drawing.Color.Snow
        Me.btn_row_terbayar.Location = New System.Drawing.Point(81, 21)
        Me.btn_row_terbayar.Name = "btn_row_terbayar"
        Me.btn_row_terbayar.Size = New System.Drawing.Size(82, 26)
        Me.btn_row_terbayar.TabIndex = 28
        Me.btn_row_terbayar.Text = "✓ Terbayar"
        Me.btn_row_terbayar.UseVisualStyleBackColor = False
        '
        'btn_tidak
        '
        Me.btn_tidak.BackColor = System.Drawing.Color.Brown
        Me.btn_tidak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tidak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tidak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_tidak.ForeColor = System.Drawing.Color.Snow
        Me.btn_tidak.Location = New System.Drawing.Point(256, 74)
        Me.btn_tidak.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_tidak.Name = "btn_tidak"
        Me.btn_tidak.Size = New System.Drawing.Size(251, 26)
        Me.btn_tidak.TabIndex = 28
        Me.btn_tidak.Text = "✘ Tandai Tidak Berdasarkan Tanggal"
        Me.btn_tidak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tidak.UseVisualStyleBackColor = False
        '
        'Riwayat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 314)
        Me.Controls.Add(Me.btn_tidak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btn_dibayar)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_laporan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Riwayat"
        Me.Text = "Riwayat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_no As Label
    Friend WithEvents btn_row_tidak As Button
    Friend WithEvents btn_row_terbayar As Button
    Friend WithEvents btn_tidak As Button
End Class
