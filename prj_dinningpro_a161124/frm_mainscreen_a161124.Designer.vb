<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainscreen_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainscreen_a161124))
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_mainmenu = New System.Windows.Forms.Label()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_orderdetails = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_insertupdate = New System.Windows.Forms.Button()
        Me.btn_productdetail = New System.Windows.Forms.Button()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_logo.Location = New System.Drawing.Point(217, 6)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(332, 147)
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'lbl_mainmenu
        '
        Me.lbl_mainmenu.AutoSize = True
        Me.lbl_mainmenu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mainmenu.Font = New System.Drawing.Font("Stencil Std", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mainmenu.ForeColor = System.Drawing.Color.Black
        Me.lbl_mainmenu.Location = New System.Drawing.Point(263, 156)
        Me.lbl_mainmenu.Name = "lbl_mainmenu"
        Me.lbl_mainmenu.Size = New System.Drawing.Size(236, 46)
        Me.lbl_mainmenu.TabIndex = 1
        Me.lbl_mainmenu.Text = "MAIN MENU"
        '
        'btn_product
        '
        Me.btn_product.BackColor = System.Drawing.Color.Olive
        Me.btn_product.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(126, 205)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(459, 38)
        Me.btn_product.TabIndex = 2
        Me.btn_product.Text = "PRODUCT"
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.Chartreuse
        Me.btn_order.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(126, 413)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(459, 35)
        Me.btn_order.TabIndex = 3
        Me.btn_order.Text = "ORDER"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_orderdetails
        '
        Me.btn_orderdetails.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_orderdetails.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdetails.Location = New System.Drawing.Point(126, 465)
        Me.btn_orderdetails.Name = "btn_orderdetails"
        Me.btn_orderdetails.Size = New System.Drawing.Size(459, 33)
        Me.btn_orderdetails.TabIndex = 4
        Me.btn_orderdetails.Text = "INVOICE"
        Me.btn_orderdetails.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.OliveDrab
        Me.btn_staff.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(126, 308)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(459, 32)
        Me.btn_staff.TabIndex = 5
        Me.btn_staff.Text = "STAFF"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_customer.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(126, 362)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(459, 36)
        Me.btn_customer.TabIndex = 6
        Me.btn_customer.Text = "CUSTOMER"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_insertupdate
        '
        Me.btn_insertupdate.BackColor = System.Drawing.Color.LightGreen
        Me.btn_insertupdate.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertupdate.Location = New System.Drawing.Point(126, 513)
        Me.btn_insertupdate.Name = "btn_insertupdate"
        Me.btn_insertupdate.Size = New System.Drawing.Size(459, 34)
        Me.btn_insertupdate.TabIndex = 7
        Me.btn_insertupdate.Text = "INSERT AND UPDATE OPTION"
        Me.btn_insertupdate.UseVisualStyleBackColor = False
        '
        'btn_productdetail
        '
        Me.btn_productdetail.BackColor = System.Drawing.Color.DarkKhaki
        Me.btn_productdetail.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productdetail.Location = New System.Drawing.Point(126, 258)
        Me.btn_productdetail.Name = "btn_productdetail"
        Me.btn_productdetail.Size = New System.Drawing.Size(459, 33)
        Me.btn_productdetail.TabIndex = 8
        Me.btn_productdetail.Text = "PRODUCT DETAIL"
        Me.btn_productdetail.UseVisualStyleBackColor = False
        '
        'frm_mainscreen_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(690, 556)
        Me.Controls.Add(Me.btn_productdetail)
        Me.Controls.Add(Me.btn_insertupdate)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_orderdetails)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.lbl_mainmenu)
        Me.Controls.Add(Me.pic_logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mainscreen_a161124"
        Me.Text = "Form1"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_mainmenu As System.Windows.Forms.Label
    Friend WithEvents btn_product As System.Windows.Forms.Button
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_orderdetails As System.Windows.Forms.Button
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents btn_insertupdate As System.Windows.Forms.Button
    Friend WithEvents btn_productdetail As System.Windows.Forms.Button

End Class
