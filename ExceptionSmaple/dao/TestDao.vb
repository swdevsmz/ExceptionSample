Imports MySql.Data.MySqlClient
Imports Dapper


Public Class TestDao

    Public Sub excute()
        Try
            Dim i(1) As Integer
            'i(3) = 1

            Call OpenDB()



        Catch ex As Exception
            'Throw New Exception("Value1が9を超えました。")
        End Try

    End Sub




    Public Sub OpenDB()

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


        For Each user In users
            Console.WriteLine(user.name)
        Next

        connection.Close()


        'Dim command As MySqlCommand = New MySqlCommand("select * from user", connection)

    End Sub


    ' Dim reader As MySqlDataReader = Command.ExecuteReader()

    'If reader.HasRows Then
    '        Do While reader.Read()
    '            Console.WriteLine(reader.GetInt32(0) _
    '              & vbTab & reader.GetString(1))
    '        Loop
    '    Else
    '        Console.WriteLine("No rows found.")
    '    End If

    '    reader.Close()


    'End Sub

End Class
