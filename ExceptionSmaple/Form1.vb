﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim logic As New TestLogic()

        Try
            logic.run()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
