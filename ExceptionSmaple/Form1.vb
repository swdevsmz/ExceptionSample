﻿Imports MySql.Data.MySqlClient
Imports Dapper

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim logic As New TestLogic()

        Try

            'MessageBox.Show(StatusType.未申請)

            For Each value As StatusType In [Enum].GetValues(GetType(StatusType))
                Dim intValue As Integer = value
                Dim strValue As String = value.ToString()
                Console.WriteLine(strValue & ", " & intValue)
            Next


            logic.run()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' 1.接続文字列を作成する
        Dim Builder = New MySqlConnectionStringBuilder()
        ' データベースに接続するために必要な情報をBuilderに与える
        Builder.Server = "localhost"
        Builder.Port = 3306
        Builder.UserID = "root"
        Builder.Password = "password"
        Builder.Database = "test"

        Dim connection As New MySqlConnection
        connection.ConnectionString = Builder.ToString()
        connection.Open()


        Dim users = connection.Query(Of User)("SELECT id, name FROM user ", Nothing)

        Me.DataGridView1.DataSource = users


        'For Each user In users
        '    Console.WriteLine(user.name)
        'Next

        connection.Close()

    End Sub
End Class
