Imports MySql.Data.MySqlClient
Imports Dapper


Public Class ConnectionManager

    Private Shared _manager As New ConnectionManager()

    Private _connection As MySqlConnection
    Private _transaction As MySqlTransaction

    Private Sub New()
        ' 1.接続文字列を作成する
        Dim Builder = New MySqlConnectionStringBuilder()
        ' データベースに接続するために必要な情報をBuilderに与える
        Builder.Server = "localhost"
        Builder.Port = 3306
        Builder.UserID = "root"
        Builder.Password = "password"
        Builder.Database = "test"
        _connection = New MySqlConnection
        _connection.ConnectionString = Builder.ToString()
    End Sub

    Public Shared Function GetInstance() As ConnectionManager
        Return _manager
    End Function

    Public ReadOnly Property connection As MySqlConnection
        Get
            Return _connection
        End Get
    End Property

    Public Function Query(Of T)(ByVal sql As String) As List(Of T)
        Return _connection.Query(Of T)(sql, Nothing)
    End Function

    Public Sub Open()
        _connection.Open()
    End Sub

    Public Function Excute(ByVal sql As String) As Integer
        Return _connection.Execute(sql, Nothing)
    End Function

    Public Sub BeginTransaction()
        _transaction = _connection.BeginTransaction()
    End Sub

    Public Sub Commit()
        _transaction.Commit()
    End Sub

    Public Sub RollBack()
        _transaction.Rollback()
    End Sub

    Public Sub Close()
        _connection.Close()
    End Sub
End Class
