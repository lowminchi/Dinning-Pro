Public Class frm_updatestaff_a161124

    Dim current_id As String

    Private Sub frm_updatestaff_a161124Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()

    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT*FROM TBL_STAFF_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_updatestaff.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()

        txt_staffid.Text = ""
        txt_staffname.Text = ""

    End Sub
    Private Sub get_current_id()
        Dim current_row As Integer = grd_updatestaff.CurrentRow.Index
        current_id = grd_updatestaff(0, current_row).Value

        txt_staffid.Text = current_id
        txt_staffname.Text = grd_updatestaff(1, current_row).Value()

    End Sub

    Private Sub grd_staff_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_updatestaff.CellClick
        get_current_id()
    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A161124 SET FLD_STAFF_NAME='" & txt_staffname.Text & "'WHERE FLD_STAFF_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_id & """.")

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course""" & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A161124 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("The staff""" & current_id & """has been successfully delete.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If

    End Sub
End Class