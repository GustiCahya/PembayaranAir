<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Antrian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Antrian))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_nopel = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_hanya_add = New System.Windows.Forms.CheckBox()
        Me.chk_hanya_print = New System.Windows.Forms.CheckBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.no_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stand_meter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gol_pel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_at = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_pel, Me.nama_pelanggan, Me.bulan, Me.stand_meter, Me.tagihan, Me.idx, Me.tahun, Me.alamat_pel, Me.gol_pel, Me.created_at})
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(529, 234)
        Me.DataGridView1.TabIndex = 16
        '
        'tb_nopel
        '
        Me.tb_nopel.Location = New System.Drawing.Point(12, 50)
        Me.tb_nopel.Name = "tb_nopel"
        Me.tb_nopel.Size = New System.Drawing.Size(105, 20)
        Me.tb_nopel.TabIndex = 17
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(123, 50)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(121, 20)
        Me.tb_nama.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "No. Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(11, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Cari Berdasarkan :"
        '
        'chk_hanya_add
        '
        Me.chk_hanya_add.AutoSize = True
        Me.chk_hanya_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_hanya_add.Location = New System.Drawing.Point(340, 54)
        Me.chk_hanya_add.Name = "chk_hanya_add"
        Me.chk_hanya_add.Size = New System.Drawing.Size(79, 17)
        Me.chk_hanya_add.TabIndex = 40
        Me.chk_hanya_add.Text = "Hanya Add"
        Me.chk_hanya_add.UseVisualStyleBackColor = True
        '
        'chk_hanya_print
        '
        Me.chk_hanya_print.AutoSize = True
        Me.chk_hanya_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_hanya_print.Location = New System.Drawing.Point(427, 54)
        Me.chk_hanya_print.Name = "chk_hanya_print"
        Me.chk_hanya_print.Size = New System.Drawing.Size(81, 17)
        Me.chk_hanya_print.TabIndex = 39
        Me.chk_hanya_print.Text = "Hanya Print"
        Me.chk_hanya_print.UseVisualStyleBackColor = True
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
        Me.btn_print.Location = New System.Drawing.Point(400, 12)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(110, 35)
        Me.btn_print.TabIndex = 38
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(262, 49)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(60, 22)
        Me.btn_delete.TabIndex = 41
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
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
        Me.stand_meter.ReadOnly = True
        '
        'tagihan
        '
        Me.tagihan.HeaderText = "Tagihan"
        Me.tagihan.Name = "tagihan"
        Me.tagihan.ReadOnly = True
        Me.tagihan.Width = 120
        '
        'idx
        '
        Me.idx.HeaderText = "idx"
        Me.idx.Name = "idx"
        Me.idx.ReadOnly = True
        Me.idx.Visible = False
        '
        'tahun
        '
        Me.tahun.HeaderText = "Tahun"
        Me.tahun.Name = "tahun"
        Me.tahun.ReadOnly = True
        Me.tahun.Visible = False
        '
        'alamat_pel
        '
        Me.alamat_pel.HeaderText = "alamat_pel"
        Me.alamat_pel.Name = "alamat_pel"
        Me.alamat_pel.ReadOnly = True
        Me.alamat_pel.Visible = False
        '
        'gol_pel
        '
        Me.gol_pel.HeaderText = "gol_pel"
        Me.gol_pel.Name = "gol_pel"
        Me.gol_pel.ReadOnly = True
        Me.gol_pel.Visible = False
        '
        'created_at
        '
        Me.created_at.HeaderText = "Tanggal Dibuat"
        Me.created_at.Name = "created_at"
        Me.created_at.ReadOnly = True
        '
        'Antrian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 314)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.chk_hanya_add)
        Me.Controls.Add(Me.chk_hanya_print)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.tb_nopel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Antrian"
        Me.Text = "Antrian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_nopel As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_hanya_add As CheckBox
    Friend WithEvents chk_hanya_print As CheckBox
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents no_pel As DataGridViewTextBoxColumn
    Friend WithEvents nama_pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents bulan As DataGridViewTextBoxColumn
    Friend WithEvents stand_meter As DataGridViewTextBoxColumn
    Friend WithEvents tagihan As DataGridViewTextBoxColumn
    Friend WithEvents idx As DataGridViewTextBoxColumn
    Friend WithEvents tahun As DataGridViewTextBoxColumn
    Friend WithEvents alamat_pel As DataGridViewTextBoxColumn
    Friend WithEvents gol_pel As DataGridViewTextBoxColumn
    Friend WithEvents created_at As DataGridViewTextBoxColumn
End Class
