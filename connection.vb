﻿Imports MySql.Data.MySqlClient
Public Class connection
    Public Shared conn As MySqlConnection = New MySqlConnection("data source=localhost;" &
        "database=db_eams;user id=root;password=;")
End Class
