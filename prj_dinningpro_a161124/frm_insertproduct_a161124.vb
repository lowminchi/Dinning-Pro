Public Class frm_insertproduct_a161124
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim mydestop As String
    Private Sub frm_insertproduct_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_type.Items.Add("FLATWARE")
        cmb_type.Items.Add("CHOPSTICK")
        cmb_type.Items.Add("BABY")
        cmb_type.Items.Add("LADLE")
        cmb_type.Items.Add("OTHERS")

        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        grd_insertproduct.DataSource = run_sql_query("SELECT*FROM TBL_PRODUCTS_A161124")

        txt_productid.Text = generate_id()
        txt_productname.Text = ""
        txt_price.Text = ""
        txt_manufacture.Text = ""
        cmb_type.Text = ""
        txt_material.Text = ""
        txt_colour.Text = ""
        

        txt_picture.Text = defaultpicture
        pic_product2.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub
    Private Sub clear_fields()

        txt_productid.Text = generate_id()
        txt_productname.Text = ""
        txt_price.Text = ""
        txt_manufacture.Text = ""
        cmb_type.Text = ""
        txt_material.Text = ""
        txt_colour.Text = ""

    End Sub
    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A161124").Rows(0).Item("LASTID")

        MsgBox(lastid)

        Dim newid As String = "0" & Mid(lastid, 2) + 1

        Return newid

    End Function



    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        If (txt_productid.Text <> "" And txt_productname.Text <> "" And txt_price.Text <> "" And txt_manufacture.Text <> "" And cmb_type.Text <> "" And txt_material.Text <> "" And txt_colour.Text <> "") Then

            Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A161124 VALUES ('" & txt_productid.Text & "','" & txt_productname.Text & "','" & txt_price.Text & "','" & txt_manufacture.Text & "','" & cmb_type.Text & "','" & txt_material.Text & "','" & txt_colour.Text & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_productid.Text & ".jpg")

                grd_insertproduct.DataSource = run_sql_query("SELECT*FROM TBL_PRODUCTS_A161124")

                txt_productid.Text = generate_id()
                txt_productname.Text = ""
                txt_price.Text = ""
                txt_manufacture.Text = ""
                cmb_type.Text = ""
                txt_material.Text = ""
                txt_colour.Text = ""
                txt_picture.Text = defaultpicture
                pic_product2.BackgroundImage = Image.FromFile(defaultpicture)

            Catch ex As Exception

                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

                mywriter.Connection.Close()
            End Try

        Else
            Beep()
            MsgBox("Please complete the field(s) before proceed on. Thank You")
        End If

    End Sub

    Private Sub btn_insertpicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insertpicture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydestop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product2.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub txt_productid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_productid.TextChanged

    End Sub

    Private Sub lbl_productname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_productname.Click

    End Sub

    Private Sub lbl_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_price.Click

    End Sub

    Private Sub txt_productname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_productname.TextChanged

    End Sub
End Class