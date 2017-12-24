Public Class TestLogic

    Public Sub run()

        Dim dao As New TestDao

        Try

            dao.excute()
        Catch ex As Exception
            Throw
        End Try

    End Sub

End Class
