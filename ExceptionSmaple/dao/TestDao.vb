﻿Imports MySql.Data.MySqlClient
Imports Dapper


Public Class TestDao
    Inherits BaseDao

    Public Function FindUser() As List(Of User)

        Return manager.Query(Of User)("SELECT id, name FROM user ")

    End Function

End Class
