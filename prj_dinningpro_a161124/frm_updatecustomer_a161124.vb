Public Class frm_updatecustomer_a161124

    Dim current_id As String

    Private Sub frm_updatecustomer_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()

    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT*FROM TBL_CUSTOMER_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_updatecustomer.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()

        txt_customerid.Text = ""
        txt_customername.Text = ""
        txt_phonenumber.Text = ""
        txt_email.Text = ""

    End Sub
    Private Sub get_current_id()
        Dim current_row As Integer = grd_updatecustomer.CurrentRow.Index()
        current_id = grd_updatecustomer(0, current_row).Value

        txt_customerid.Text = current_id
        txt_customername.Text = grd_updatecustomer(1, current_row).Value()
        txt_phonenumber.Text = grd_updatecustomer(2, current_row).Value()
        txt_email.Text = grd_updatecustomer(3, current_row).Value()
    End Sub

    Private Sub grd_customer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_updatecustomer.CellClick

        get_current_id()

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A161124 SET FLD_CUSTOMER_NAME='" & txt_customername.Text & "'WHERE FLD_CUSTOMER_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A161124 SET FLD_PHONENUMBER='" & txt_phonenumber.Text & "'WHERE FLD_CUSTOMER_ID='" & current_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A161124 SET FLD_EMAIL='" & txt_email.Text & "'WHERE FLD_CUSTOMER_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the customer  """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer""" & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A161124 WHERE FLD_CUSTOMER_ID='" & current_id & "'")

            Beep()
            MsgBox("The customer""" & current_id & """has been successfully delete.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If

    End Sub
End Class