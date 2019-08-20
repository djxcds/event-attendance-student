Imports MySql.Data.MySqlClient
Imports System.Net
Public Class frm_display_attend_list
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim current_date As Date = global_functions.getCurrentDate

    Sub displayUpcomingEvents()
        Dim current_day As Integer = Date.Parse(global_functions.getCurrentDate).Day

        dgv_upcoming_events.ColumnCount = 5
        dgv_upcoming_events.Columns(0).Name = "event_entry_id"
        dgv_upcoming_events.Columns(0).Visible = False
        dgv_upcoming_events.Columns(1).Name = "Event"
        dgv_upcoming_events.Columns(2).Name = "Day"
        dgv_upcoming_events.Columns(3).Name = "Session"
        dgv_upcoming_events.Columns(4).Name = "Attendance Status"
        dgv_upcoming_events.Rows.Clear()

        Connection.conn.Open()
        query = "SELECT event_entry_id, event_title AS 'Event', event_date AS 'Date', " &
            "session AS 'Session', event_status FROM tbl_event_entry a, tbl_event b " &
            "WHERE b.event_id = a.event_id AND event_status <> 'FINISH' ORDER BY a.event_date"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        While reader.Read
            Dim day As Integer = Date.Parse(reader.GetMySqlDateTime("Date")).Day
            Dim month As Integer = Date.Parse(reader.GetMySqlDateTime("Date")).Month
            Dim current_month_value As Integer = Date.Parse(current_date).Month

            If day >= current_day And month = current_month_value Then
                Dim event_entry_id As String = reader.GetString("event_entry_id")
                Dim event_title As String = WebUtility.HtmlDecode(reader.GetString("Event"))
                Dim event_day As String = Date.Parse(reader.GetMySqlDateTime("Date")).Day.ToString
                Dim session As String = reader.GetString("Session")
                Dim attendance_status As String = reader.GetString("event_status")

                Dim row As String() = New String() {event_entry_id, event_title, event_day, session, attendance_status}
                dgv_upcoming_events.Rows.Add(row)
            End If

        End While
        Connection.conn.Close()
    End Sub

    Function isReviewEnabledOnEvent(event_entry_id)
        connection.conn.Open()
        query = "SELECT event_rating_enabled FROM tbl_event_entry WHERE event_status <> 'FINISH' AND " &
            "event_status <> 'PAUSE' AND event_entry_id = '" & event_entry_id & "'"
        cmd = New MySqlCommand(query, connection.conn)
        reader = cmd.ExecuteReader()
        If reader.Read Then

            If reader.GetString("event_rating_enabled") = "Yes" Then
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

    Private Sub frm_attend_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayUpcomingEvents()
    End Sub

    Private Sub dgv_upcoming_events_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgv_upcoming_events.CellDoubleClick

        If e.RowIndex >= 0 Then

            Dim rowValue As DataGridViewRow = dgv_upcoming_events.Rows(e.RowIndex)
            Dim event_entry_id As String = rowValue.Cells("event_entry_id").Value.ToString
            Dim attendance_status As String = rowValue.Cells("Attendance Status").Value.ToString

            Select Case attendance_status
                Case "SIGN IN"
                    loadAttendance(event_entry_id)
                Case "SIGN OUT"
                    If Not isReviewEnabledOnEvent(event_entry_id) Then
                        loadAttendance(event_entry_id)
                    Else
                        loadAttendanceWithReview(event_entry_id)
                    End If
                Case Else
                    MsgBox("The attendance you selected is not yet active. Hit refresh to update list.")
            End Select
        End If
    End Sub

    Sub loadAttendanceWithReview(event_entry_id)
        query = "SELECT event_title, event_status, event_date AS 'Date', session, " &
            "penalty_full, penalty_half FROM tbl_event_entry a, tbl_event b WHERE " &
            "event_status <> 'FINISH' AND event_status <> 'PAUSE' and event_entry_id = '" &
            event_entry_id & "'"
        connection.conn.Open()
        cmd = New MySqlCommand(query, connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            frm_sign_out_review.tb_event_title.Text = reader.GetString("event_title")
            frm_sign_out_review.event_entry_id = event_entry_id
            frm_sign_out_review.penalty_full = reader.GetString("penalty_full")
            frm_sign_out_review.penalty_half = reader.GetString("penalty_half")
            frm_sign_out_review.event_date = reader.GetString("Date")
            frm_sign_out_review.g_event_status = reader.GetString("event_status")
            frm_sign_out_review.session = reader.GetString("session")
        End If
        connection.conn.Close()

        frm_sign_out_review.ShowDialog()
    End Sub

    Sub loadAttendance(event_entry_id)
        query = "SELECT event_title, event_status, event_date AS 'Date', session, " &
            "penalty_full, penalty_half FROM tbl_event_entry a, tbl_event b WHERE " &
            "event_status <> 'FINISH' AND event_status <> 'PAUSE' and event_entry_id = '" &
            event_entry_id & "'"
        connection.conn.Open()
        cmd = New MySqlCommand(query, connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            frm_sign_in_out.tb_event_title.Text = reader.GetString("event_title")
            frm_sign_in_out.event_entry_id = event_entry_id
            frm_sign_in_out.penalty_full = reader.GetString("penalty_full")
            frm_sign_in_out.penalty_half = reader.GetString("penalty_half")
            frm_sign_in_out.event_date = reader.GetString("Date")
            frm_sign_in_out.g_event_status = reader.GetString("event_status")
            frm_sign_in_out.session = reader.GetString("session")
        End If
        connection.conn.Close()

        frm_sign_in_out.ShowDialog()
    End Sub

    Private Sub frm_display_attend_list_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        displayUpcomingEvents()
    End Sub

    Private Sub lbl_clickable_Click(sender As Object, e As EventArgs) Handles lbl_clickable.Click
        frm_about_me.ShowDialog()
    End Sub
End Class