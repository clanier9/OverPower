Public Class ConnectionStringBuilder
    Public Shared Function BuildMyConnectionString() As String
        Dim path = Application.StartupPath + "\op_card.sqlite"
        ' Let's build our connection string.
        Dim sqlConnString As New System.Data.SqlClient.SqlConnectionStringBuilder() With {
          .DataSource = path
        }
        Return sqlConnString.ConnectionString
    End Function
End Class