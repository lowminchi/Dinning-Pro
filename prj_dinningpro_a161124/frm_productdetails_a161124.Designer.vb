<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a161124))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_manufacture = New System.Windows.Forms.Label()
        Me.txt_manufacture = New System.Windows.Forms.TextBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.lbl_colour = New System.Windows.Forms.Label()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bauhaus 93", 24.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(275, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(287, 38)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "PRODUCT DETAILS"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(47, 172)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(161, 140)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.Location = New System.Drawing.Point(427, 91)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(148, 24)
        Me.lbl_productid.TabIndex = 3
        Me.lbl_productid.Text = "PRODUCT ID"
        '
        'txt_productid
        '
        Me.txt_productid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productid.Location = New System.Drawing.Point(651, 89)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.ReadOnly = True
        Me.txt_productid.Size = New System.Drawing.Size(347, 26)
        Me.txt_productid.TabIndex = 4
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(427, 145)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(187, 24)
        Me.lbl_productname.TabIndex = 5
        Me.lbl_productname.Text = "PRODUCT NAME"
        '
        'txt_productname
        '
        Me.txt_productname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productname.Location = New System.Drawing.Point(651, 146)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.ReadOnly = True
        Me.txt_productname.Size = New System.Drawing.Size(347, 26)
        Me.txt_productname.TabIndex = 6
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(427, 202)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(76, 24)
        Me.lbl_price.TabIndex = 7
        Me.lbl_price.Text = "PRICE"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(651, 203)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(347, 26)
        Me.txt_price.TabIndex = 8
        '
        'lbl_manufacture
        '
        Me.lbl_manufacture.AutoSize = True
        Me.lbl_manufacture.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manufacture.Location = New System.Drawing.Point(427, 250)
        Me.lbl_manufacture.Name = "lbl_manufacture"
        Me.lbl_manufacture.Size = New System.Drawing.Size(180, 24)
        Me.lbl_manufacture.TabIndex = 9
        Me.lbl_manufacture.Text = "MANUFACTURE"
        '
        'txt_manufacture
        '
        Me.txt_manufacture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_manufacture.Location = New System.Drawing.Point(651, 250)
        Me.txt_manufacture.Name = "txt_manufacture"
        Me.txt_manufacture.ReadOnly = True
        Me.txt_manufacture.Size = New System.Drawing.Size(347, 26)
        Me.txt_manufacture.TabIndex = 10
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(427, 303)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(68, 24)
        Me.lbl_type.TabIndex = 11
        Me.lbl_type.Text = "TYPE"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(427, 356)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(125, 24)
        Me.lbl_material.TabIndex = 13
        Me.lbl_material.Text = "MATERIAL"
        '
        'txt_material
        '
        Me.txt_material.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_material.Location = New System.Drawing.Point(651, 354)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.ReadOnly = True
        Me.txt_material.Size = New System.Drawing.Size(347, 26)
        Me.txt_material.TabIndex = 14
        '
        'lbl_colour
        '
        Me.lbl_colour.AutoSize = True
        Me.lbl_colour.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_colour.Location = New System.Drawing.Point(427, 412)
        Me.lbl_colour.Name = "lbl_colour"
        Me.lbl_colour.Size = New System.Drawing.Size(102, 24)
        Me.lbl_colour.TabIndex = 15
        Me.lbl_colour.Text = "COLOUR"
        '
        'txt_colour
        '
        Me.txt_colour.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colour.Location = New System.Drawing.Point(651, 413)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.ReadOnly = True
        Me.txt_colour.Size = New System.Drawing.Size(347, 26)
        Me.txt_colour.TabIndex = 16
        '
        'lst_id
        '
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.Location = New System.Drawing.Point(268, 91)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(120, 381)
        Me.lst_id.TabIndex = 17
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(651, 301)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(347, 26)
        Me.txt_type.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(884, 445)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 98)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'frm_productdetails_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 551)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.txt_colour)
        Me.Controls.Add(Me.lbl_colour)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_manufacture)
        Me.Controls.Add(Me.lbl_manufacture)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_productdetails_a161124"
        Me.Text = "frm_productdetails_a161124"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_productid As System.Windows.Forms.Label
    Friend WithEvents txt_productid As System.Windows.Forms.TextBox
    Friend WithEvents lbl_productname As System.Windows.Forms.Label
    Friend WithEvents txt_productname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_manufacture As System.Windows.Forms.Label
    Friend WithEvents txt_manufacture As System.Windows.Forms.TextBox
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents lbl_material As System.Windows.Forms.Label
    Friend WithEvents txt_material As System.Windows.Forms.TextBox
    Friend WithEvents lbl_colour As System.Windows.Forms.Label
    Friend WithEvents txt_colour As System.Windows.Forms.TextBox
    Friend WithEvents lst_id As System.Windows.Forms.ListBox
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
