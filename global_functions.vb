Imports MySql.Data.MySqlClient
Public Class global_functions

    Public Shared Function getCurrentDate()
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Connection.conn.Open()
        query = "SELECT NOW() as 'current_date'"
        cmd = New MySqlCommand(query, Connection.conn)
        reader = cmd.ExecuteReader()

        If reader.Read Then
            Dim date_time As Date = reader.GetMySqlDateTime("current_date")

            Connection.conn.Close()
            Return date_time
        Else
            Connection.conn.Close()
            Return Nothing
        End If
    End Function
End Class
