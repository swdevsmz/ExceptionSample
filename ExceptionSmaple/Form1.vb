Imports MySql.Data.MySqlClient
Imports Dapper
Imports log4net


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        For Each value As StatusType In [Enum].GetValues(GetType(StatusType))
            Dim intValue As Integer = value
            Dim strValue As String = value.ToString()
            Console.WriteLine(strValue & ", " & intValue)
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim logic As New TestLogic()
        Me.DataGridView1.DataSource = logic.FindUser()


        Dim logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

        logger.Debug("開発中のデバッグ／トレースに使用する")
        logger.Info("情報（操作履歴等）")
        logger.Warn("注意／警告（障害の一歩手前）")
        logger.Error("システムが停止するまではいかない障害が発生")
        logger.Fatal("システムが停止する致命的な障害が発生")


        MessageBox.Show(logger.Logger.Repository.Configured)
    End Sub
End Class
