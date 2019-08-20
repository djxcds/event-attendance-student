Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_sign_out_review
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public event_entry_id, event_date, g_event_status, penalty_full, penalty_half, session,
        event_session, student_first_name, attendance_id, message As String
    Dim isEventActive = False

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_sign_out.Click
        Dim star_value As Integer = cb_star_rating.Value
        Dim review As String = tb_review.Text
        Dim current_time As String = Format(global_functions.getCurrentDate, "HH:mm:ss")

        sessionChecker()
        If isEventActive Then
            If star_value <> 0 And review <> "" Then
                If isStudentSignedIn() Then
                    query = "Update tbl_attendance SET community_labor_minutes = '0', log_out_time = '" &
                        current_time & "' WHERE event_entry_id='" & event_entry_id & "' and attendance_entry = '" &
                        attendance_id & "'"

                    message = "Thanks " & student_first_name & " for the rating and review! You signed OUT successfully!"
                Else
                    query = "Update tbl_attendance SET community_labor_minutes = '" & penalty_half & "', log_out_time = '" &
                        current_time & "' WHERE event_entry_id='" & event_entry_id & "' and attendance_entry = '" &
                        attendance_id & "'"

                    message = "Thanks " & student_first_name & " for the rating and review! It appears that you didn't sign " &
                           "in earlier, a penalty is added to you. You signed OUT successfully!"
                End If
                connection.conn.Open()
                cmd = New MySqlCommand(query, connection.conn)
                cmd.ExecuteNonQuery()
                connection.conn.Close()

                connection.conn.Open()
                query = "Update tbl_event_assessment SET event_rating = '" & star_value & "', event_remarks = '" &
                    review & "' WHERE attendance_entry_id = '" & attendance_id & "'"
                cmd = New MySqlCommand(query, connection.conn)
                cmd.ExecuteNonQuery()
                connection.conn.Close()

                tb_user_query.Text = ""
                student_first_name = ""
                attendance_id = ""
                tb_student_name.Text = "Name of Student"
                cb_star_rating.Value = 1
                tb_review.Text = ""
                MsgBox(message, MsgBoxStyle.Information)

            ElseIf cb_star_rating.Value = 0 And tb_review.Text <> "" Then
                MsgBox("Please rate the event Not equal to zero. ")
            ElseIf cb_star_rating.Value <> 0 And tb_review.Text = "" Then
                MsgBox("Please write a review.")
            Else
                MsgBox("You did Not sign in earlier!", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Function isStudentSignedIn()
        connection.conn.Open()
        query = "SELECT log_in_time FROM tbl_attendance WHERE attendance_entry = '" + attendance_id + "'"
        cmd = New MySqlCommand(query, connection.conn)
        reader = cmd.ExecuteReader
        If reader.Read Then
            If Not reader.IsDBNull(0) Then
                connection.conn.Close()
                Return True
            Else
                connection.conn.Close()
                Return False
            End If
        Else
            connection.conn.Close()
            Return False
        End If
    End Function

    Private Sub tb_user_query_TextChanged(sender As Object, e As EventArgs) Handles tb_user_query.TextChanged
        Try
            Dim user_query As String = WebUtility.HtmlEncode(tb_user_query.Text)

            query = "SELECT CONCAT(student_first_name, ' ', student_last_name) as 'Student Name', " &
                "attendance_entry, student_first_name from tbl_attendance a, tbl_student_assigned_to_list b, " &
                "tbl_student c WHERE b.student_assigned_to_list_id = a.student_assigned_to_list_id And " &
                "c.student_entry = b.student_entry_id And event_entry_id = '" & event_entry_id &
                "' AND student_id = '" & user_query & "'"

            connection.conn.Open()
            cmd = New MySqlCommand(query, connection.conn)
            reader = cmd.ExecuteReader()
            If reader.Read Then
                tb_student_name.Text = WebUtility.HtmlDecode(reader.GetString("Student Name"))
                student_first_name = reader.GetString("student_first_name")
                attendance_id = reader.GetString("attendance_entry")
                btn_sign_out.Enabled = True
            Else
                tb_student_name.Text = "No student found in our records."
                student_first_name = ""
                attendance_id = ""
                btn_sign_out.Enabled = False
            End If
            connection.conn.Close()
        Catch ex As Exception
            tb_student_name.Text = "Something went wrong in connecting to server."
            attendance_id = ""
            student_first_name = ""
            btn_sign_out.Enabled = False
        End Try
    End Sub

    Sub sessionChecker()
        Dim event_status As String

        query = "SELECT event_status FROM tbl_event_entry WHERE event_entry_id = '" & event_entry_id & "'"

        connection.conn.Open()
        cmd = New MySqlCommand(query, connection.conn)
        reader = cmd.ExecuteReader

        If reader.Read Then
            event_status = reader.GetString("event_status")
        Else
            event_status = "FINISH"
        End If

        connection.conn.Close()

        If g_event_status <> event_status Then
            isEventActive = False
            MsgBox("Session expired. This form is now exiting.", MsgBoxStyle.Exclamation)
            Close()
        Else
            isEventActive = True
        End If

    End Sub
End Class
