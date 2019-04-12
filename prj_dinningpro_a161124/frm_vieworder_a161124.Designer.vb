<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a161124))
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.cmb_orderid = New System.Windows.Forms.ComboBox()
        Me.txt_customerid = New System.Windows.Forms.TextBox()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.grd_vieworder = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_thank = New System.Windows.Forms.Label()
        CType(Me.grd_vieworder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(272, 81)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(102, 20)
        Me.lbl_orderid.TabIndex = 0
        Me.lbl_orderid.Text = "ORDER ID"
        '
        'lbl_customerid
        '
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerid.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.Location = New System.Drawing.Point(272, 120)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(138, 20)
        Me.lbl_customerid.TabIndex = 1
        Me.lbl_customerid.Text = "CUSTOMER ID"
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(272, 162)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(93, 20)
        Me.lbl_staffid.TabIndex = 2
        Me.lbl_staffid.Text = "STAFF ID"
        '
        'cmb_orderid
        '
        Me.cmb_orderid.FormattingEnabled = True
        Me.cmb_orderid.Location = New System.Drawing.Point(467, 80)
        Me.cmb_orderid.Name = "cmb_orderid"
        Me.cmb_orderid.Size = New System.Drawing.Size(121, 21)
        Me.cmb_orderid.TabIndex = 3
        '
        'txt_customerid
        '
        Me.txt_customerid.Location = New System.Drawing.Point(467, 120)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.Size = New System.Drawing.Size(121, 20)
        Me.txt_customerid.TabIndex = 4
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(467, 164)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(121, 20)
        Me.txt_staffid.TabIndex = 5
        '
        'grd_vieworder
        '
        Me.grd_vieworder.AllowUserToAddRows = False
        Me.grd_vieworder.AllowUserToDeleteRows = False
        Me.grd_vieworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_vieworder.Location = New System.Drawing.Point(73, 215)
        Me.grd_vieworder.Name = "grd_vieworder"
        Me.grd_vieworder.Size = New System.Drawing.Size(551, 218)
        Me.grd_vieworder.TabIndex = 6
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(324, 455)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(71, 20)
        Me.lbl_total.TabIndex = 7
        Me.lbl_total.Text = "TOTAL"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(445, 455)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(73, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 75)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 24.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 38)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "INVOICE"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(12, 140)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(243, 14)
        Me.lbl_address.TabIndex = 11
        Me.lbl_address.Text = "28, JALAN MALURI, 43600 BANGI, SELANGOR"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(58, 154)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(150, 15)
        Me.lbl_email.TabIndex = 12
        Me.lbl_email.Text = "dinningpro2017@gmail.com"
        '
        'lbl_thank
        '
        Me.lbl_thank.AutoSize = True
        Me.lbl_thank.BackColor = System.Drawing.Color.Transparent
        Me.lbl_thank.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_thank.Location = New System.Drawing.Point(216, 496)
        Me.lbl_thank.Name = "lbl_thank"
        Me.lbl_thank.Size = New System.Drawing.Size(242, 15)
        Me.lbl_thank.TabIndex = 13
        Me.lbl_thank.Text = "Thank you for your support. Please come again!"
        '
        'frm_vieworder_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(761, 518)
        Me.Controls.Add(Me.lbl_thank)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_vieworder)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.cmb_orderid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_vieworder_a161124"
        Me.Text = "frm_vieworder_a161124"
        CType(Me.grd_vieworder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_orderid As System.Windows.Forms.Label
    Friend WithEvents lbl_customerid As System.Windows.Forms.Label
    Friend WithEvents lbl_staffid As System.Windows.Forms.Label
    Friend WithEvents cmb_orderid As System.Windows.Forms.ComboBox
    Friend WithEvents txt_customerid As System.Windows.Forms.TextBox
    Friend WithEvents txt_staffid As System.Windows.Forms.TextBox
    Friend WithEvents grd_vieworder As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_thank As System.Windows.Forms.Label
End Class
