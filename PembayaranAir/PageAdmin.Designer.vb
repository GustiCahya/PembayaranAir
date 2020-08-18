<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageAdmin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageAdmin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_pelanggan = New System.Windows.Forms.Button()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.PanelShow = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_pelanggan)
        Me.PanelMenu.Controls.Add(Me.btn_history)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.btn_transaksi)
        Me.PanelMenu.Location = New System.Drawing.Point(-1, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(160, 414)
        Me.PanelMenu.TabIndex = 0
        '
        'btn_pelanggan
        '
        Me.btn_pelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_pelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pelanggan.FlatAppearance.BorderSize = 0
        Me.btn_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_pelanggan.ForeColor = System.Drawing.Color.White
        Me.btn_pelanggan.Location = New System.Drawing.Point(0, 205)
        Me.btn_pelanggan.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_pelanggan.Name = "btn_pelanggan"
        Me.btn_pelanggan.Size = New System.Drawing.Size(160, 50)
        Me.btn_pelanggan.TabIndex = 2
        Me.btn_pelanggan.Text = "Pelanggan"
        Me.btn_pelanggan.UseVisualStyleBackColor = False
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_history.FlatAppearance.BorderSize = 0
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_history.ForeColor = System.Drawing.Color.White
        Me.btn_history.Location = New System.Drawing.Point(0, 154)
        Me.btn_history.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(160, 51)
        Me.btn_history.TabIndex = 1
        Me.btn_history.Text = "Riwayat"
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_transaksi
        '
        Me.btn_transaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_transaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_transaksi.FlatAppearance.BorderSize = 0
        Me.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_transaksi.ForeColor = System.Drawing.Color.White
        Me.btn_transaksi.Location = New System.Drawing.Point(0, 103)
        Me.btn_transaksi.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(160, 51)
        Me.btn_transaksi.TabIndex = 0
        Me.btn_transaksi.Text = "Transaksi"
        Me.btn_transaksi.UseVisualStyleBackColor = False
        '
        'PanelShow
        '
        Me.PanelShow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelShow.Location = New System.Drawing.Point(160, 63)
        Me.PanelShow.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelShow.Name = "PanelShow"
        Me.PanelShow.Size = New System.Drawing.Size(533, 353)
        Me.PanelShow.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(165, 16)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(248, 37)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Pembayaran Air"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(171, 53)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(413, 3)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 414)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PanelShow)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "PageAdmin"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btn_pelanggan As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents PanelShow As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
