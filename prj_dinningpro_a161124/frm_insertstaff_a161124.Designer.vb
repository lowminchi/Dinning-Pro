<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a161124
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaff_a161124))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_insertstaff = New System.Windows.Forms.DataGridView()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_staffname = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_insertstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bauhaus 93", 30.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(302, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(248, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "INSERT STAFF"
        '
        'grd_insertstaff
        '
        Me.grd_insertstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertstaff.Location = New System.Drawing.Point(310, 103)
        Me.grd_insertstaff.Name = "grd_insertstaff"
        Me.grd_insertstaff.Size = New System.Drawing.Size(240, 150)
        Me.grd_insertstaff.TabIndex = 1
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(266, 269)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(110, 24)
        Me.lbl_staffid.TabIndex = 2
        Me.lbl_staffid.Text = "STAFF ID"
        '
        'lbl_staffname
        '
        Me.lbl_staffname.AutoSize = True
        Me.lbl_staffname.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffname.Location = New System.Drawing.Point(266, 313)
        Me.lbl_staffname.Name = "lbl_staffname"
        Me.lbl_staffname.Size = New System.Drawing.Size(149, 24)
        Me.lbl_staffname.TabIndex = 3
        Me.lbl_staffname.Text = "STAFF NAME"
        '
        'txt_staffid
        '
        Me.txt_staffid.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.Location = New System.Drawing.Point(450, 269)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(117, 27)
        Me.txt_staffid.TabIndex = 4
        '
        'txt_staffname
        '
        Me.txt_staffname.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffname.Location = New System.Drawing.Point(450, 313)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(117, 27)
        Me.txt_staffname.TabIndex = 5
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Cyan
        Me.btn_insert.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(384, 376)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(119, 42)
        Me.btn_insert.TabIndex = 6
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(695, 333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 116)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'frm_insertstaff_a161124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 451)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.lbl_staffname)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.grd_insertstaff)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertstaff_a161124"
        Me.Text = "frm_insertstaff_a161124"
        CType(Me.grd_insertstaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents grd_insertstaff As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_staffid As System.Windows.Forms.Label
    Friend WithEvents lbl_staffname As System.Windows.Forms.Label
    Friend WithEvents txt_staffid As System.Windows.Forms.TextBox
    Friend WithEvents txt_staffname As System.Windows.Forms.TextBox
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
