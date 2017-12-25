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
End Class
