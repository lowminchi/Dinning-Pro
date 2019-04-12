Public Class frm_updateproduct_a161124

    Dim current_id As String

    Private Sub frm_updateproduct_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_id()

    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT*FROM TBL_PRODUCTS_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_updateproduct.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()

        txt_productid.Text = ""
        txt_productname.Text = ""
        txt_price.Text = ""
        txt_manufacture.Text = ""

        cmb_type.Items.Add("FLATWARE")
        cmb_type.Items.Add("CHOPSTICK")
        cmb_type.Items.Add("BABY")
        cmb_type.Items.Add("LADLE")
        cmb_type.Items.Add("OTHERS")
        txt_material.Text = ""
        txt_colour.Text = ""

    End Sub
    Private Sub get_current_id()
        Dim current_row As Integer = grd_updateproduct.CurrentRow.Index()
        current_id = grd_updateproduct(0, current_row).Value

        txt_productid.Text = current_id
        txt_productname.Text = grd_updateproduct(1, current_row).Value()
        txt_price.Text = grd_updateproduct(2, current_row).Value()
        txt_manufacture.Text = grd_updateproduct(3, current_row).Value()
        cmb_type.Text = grd_updateproduct(4, current_row).Value()

        txt_material.Text = grd_updateproduct(5, current_row).Value()
        txt_colour.Text = grd_updateproduct(6, current_row).Value()

        Try

            pic_product3.BackgroundImage = Image.FromFile("pictures/" & txt_productid.Text & ".jpg")

        Catch ex As Exception

            pic_product3.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try

    End Sub

    Private Sub grd_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_updateproduct.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A161124 SET FLD_PRODUCT_NAME='" & txt_productname.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A161124 SET FLD_PRICE='" & txt_price.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A161124 SET FLD_MANUFACTURE='" & txt_manufacture.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A161124 SET FLD_TYPE='" & cmb_type.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A161124 SET FLD_MATERIAL='" & txt_material.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A161124 SET FLD_COLOUR='" & txt_colour.Text & "'WHERE FLD_PRODUCT_ID='" & current_id & "'")

    

        Beep()
        MsgBox("You have successfully updated the product """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click


        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product""" & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A161124 WHERE FLD_PRODUCT_ID='" & current_id & "'")



            Beep()
            MsgBox("The product""" & current_id & """has been successfully delete.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If

    End Sub

End Class