Public Class frm_insertstaff_a161124

    Private Sub frm_insertstaff_a161124_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT*FROM TBL_STAFF_A161124"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_insertstaff.DataSource = mydatatable
    End Sub


    Private Sub clear_fields()

        txt_staffid.Text = ""
        txt_staffname.Text = ""

    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A161124 VALUES ('" & txt_staffid.Text & "','" & txt_staffname.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try


    End Sub

End Class