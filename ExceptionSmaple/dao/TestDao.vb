﻿Imports MySql.Data.MySqlClient
Imports Dapper


Public Class TestDao
    Inherits BaseDao

    Public Function FindUser() As List(Of User)

        'Return Form1.manager.Query(Of User)("SELECT id, name FROM user ")
        '
        'Form1.manager.connection.Query(Of User, User, User)("select id , name FROM user",

    End Function

End Class
