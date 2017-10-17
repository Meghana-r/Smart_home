Imports System.Data.SqlClient

Module Module1
    Public Sub writeDb(ByVal newTime As Double, ByVal elemName As String)
        ' takes a number and the element and adds them to the SQL database 
        ' it takes the previously stored value and addes the new value to the old value
        Dim previousTime As Long

        Dim connection As New SqlConnection(My.Settings.connString)
        Const retrieveQuery As String = "select TIME from billTable where NAME = @name"
        Const updateQuery As String = "update billTable set TIME = @time where NAME = @name"

        Dim sqlCommand As New SqlCommand(retrieveQuery, connection)

        Try
            connection.Open()
            sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = elemName
            Dim dataReader As SqlDataReader = sqlCommand.ExecuteReader
            While (dataReader.Read())
                previousTime = Integer.Parse(dataReader.Item("TIME"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            connection.Close()
        End Try

        Dim sqlCommand2 As New SqlCommand(updateQuery, connection)
        Try
            connection.Open()
            sqlCommand2.Parameters.Add("@time", SqlDbType.Float).Value = previousTime + newTime / 1000 ' convert milliseconds to seconds
            sqlCommand2.Parameters.Add("@name", SqlDbType.VarChar).Value = elemName
            sqlCommand2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            connection.Close()
        End Try
    End Sub
End Module
