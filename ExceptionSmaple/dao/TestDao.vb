Public Class TestDao

    Public Sub excute()

        Try
            Dim i(1) As Integer
            i(3) = 1


        Catch ex As Exception
            Throw New Exception("Value1が9を超えました。")
        End Try

    End Sub

End Class
