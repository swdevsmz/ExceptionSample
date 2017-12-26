Public Class TestLogic

    Public Function FindUser() As List(Of User)

        Dim dao As New TestDao

        Return dao.FindUser()

    End Function

End Class
