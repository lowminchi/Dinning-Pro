<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_a161124))
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_datetitle = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.grd_vieworder = New System.Windows.Forms.DataGridView()
        Me.num_quantity = New System.Windows.Forms.NumericUpDown()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_vieworder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Bauhaus 93", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.Location = New System.Drawing.Point(663, 9)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(156, 45)
        Me.lbl_order.TabIndex = 0
        Me.lbl_order.Text = "ORDER "
        '
        'grd_product
        '
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(2, 225)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.Size = New System.Drawing.Size(743, 150)
        Me.grd_product.TabIndex = 1
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(515, 85)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(67, 20)
        Me.lbl_staff.TabIndex = 2
        Me.lbl_staff.Text = "STAFF"
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(610, 82)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(121, 21)
        Me.cmb_staff.TabIndex = 3
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(792, 82)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(112, 20)
        Me.lbl_customer.TabIndex = 4
        Me.lbl_customer.Text = "CUSTOMER"
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(910, 81)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(121, 21)
        Me.cmb_customer.TabIndex = 5
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(498, 130)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(102, 20)
        Me.lbl_orderid.TabIndex = 6
        Me.lbl_orderid.Text = "ORDER ID"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(667, 131)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 19)
        Me.lbl_id.TabIndex = 7
        Me.lbl_id.Text = "ID"
        '
        'lbl_datetitle
        '
        Me.lbl_datetitle.AutoSize = True
        Me.lbl_datetitle.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datetitle.Location = New System.Drawing.Point(498, 182)
        Me.lbl_datetitle.Name = "lbl_datetitle"
        Me.lbl_datetitle.Size = New System.Drawing.Size(60, 20)
        Me.lbl_datetitle.TabIndex = 8
        Me.lbl_datetitle.Text = "DATE"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(667, 183)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(49, 19)
        Me.lbl_date.TabIndex = 9
        Me.lbl_date.Text = "DATE"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(783, 225)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(121, 128)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_product.TabIndex = 10
        Me.pic_product.TabStop = False
        '
        'grd_vieworder
        '
        Me.grd_vieworder.AllowUserToAddRows = False
        Me.grd_vieworder.AllowUserToDeleteRows = False
        Me.grd_vieworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_vieworder.Location = New System.Drawing.Point(936, 225)
        Me.grd_vieworder.Name = "grd_vieworder"
        Me.grd_vieworder.Size = New System.Drawing.Size(422, 150)
        Me.grd_vieworder.TabIndex = 11
        '
        'num_quantity
        '
        Me.num_quantity.Location = New System.Drawing.Point(223, 442)
        Me.num_quantity.Name = "num_quantity"
        Me.num_quantity.Size = New System.Drawing.Size(120, 20)
        Me.num_quantity.TabIndex = 12
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.Yellow
        Me.btn_addtocart.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.Location = New System.Drawing.Point(422, 431)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(136, 36)
        Me.btn_addtocart.TabIndex = 13
        Me.btn_addtocart.Text = "ADD TO CART"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Cyan
        Me.btn_confirm.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(1011, 442)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(101, 27)
        Me.btn_confirm.TabIndex = 15
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_vieworder
        '
        Me.btn_vieworder.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_vieworder.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.Location = New System.Drawing.Point(1127, 503)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(159, 33)
        Me.btn_vieworder.TabIndex = 16
        Me.btn_vieworder.Text = "VIEW INVOICE"
        Me.btn_vieworder.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(977, 386)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(71, 20)
        Me.lbl_total.TabIndex = 18
        Me.lbl_total.Text = "TOTAL"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(1098, 388)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 19
        '
        'grd_order
        '
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(16, 174)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.Size = New System.Drawing.Size(241, 150)
        Me.grd_order.TabIndex = 1
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Violet
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1144, 442)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(92, 27)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(102, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 70)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "QUANTITY"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(37, 136)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(243, 14)
        Me.lbl_address.TabIndex = 23
        Me.lbl_address.Text = "28, JALAN MALURI, 43600 BANGI, SELANGOR"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(73, 150)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(150, 15)
        Me.lbl_email.TabIndex = 24
        Me.lbl_email.Text = "dinningpro2017@gmail.com"
        '
        'frm_order_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 548)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_addtocart)
        Me.Controls.Add(Me.num_quantity)
        Me.Controls.Add(Me.grd_vieworder)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_datetitle)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_order)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_order_a161124"
        Me.Text = "frm_order_a161124"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_vieworder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_order As System.Windows.Forms.Label
    Friend WithEvents grd_product As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_staff As System.Windows.Forms.Label
    Friend WithEvents cmb_staff As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_customer As System.Windows.Forms.Label
    Friend WithEvents cmb_customer As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_orderid As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_datetitle As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents grd_vieworder As System.Windows.Forms.DataGridView
    Friend WithEvents num_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_addtocart As System.Windows.Forms.Button
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents btn_vieworder As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents grd_order As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
End Class
