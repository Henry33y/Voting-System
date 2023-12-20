Imports MySql.Data.MySqlClient
Public Class frmSubmit
    Dim connectionString As String = "Server=192.168.96.130;Database=voting_database;User ID=Henry;Password=1234567;"

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim presidential As Integer = VoteVariables.presidentialCand
        Dim secretary As Integer = VoteVariables.secretaryCand
        Dim organizer As Integer = VoteVariables.organizerCand
        Dim student_id As String = VoteVariables.student_id
        Dim updateQuery As String = "UPDATE voting_info SET president = @presidential, secretary = @secretary,organizer = @organizer WHERE student_id = @student_id;"

        Dim MySqlConnection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(updateQuery, MySqlConnection)
        command.Parameters.AddWithValue("@presidential", presidential)
        command.Parameters.AddWithValue("@secretary", secretary)
        command.Parameters.AddWithValue("@organizer", organizer)
        command.Parameters.AddWithValue("@student_id", student_id)
        Try
            MySqlConnection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully")
            Login.Show()
            Me.Hide()
            'MySqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            'MySqlConnection.Close()
        Finally
            If MySqlConnection.State = ConnectionState.Open Then
                MySqlConnection.Close()
            End If

        End Try



    End Sub


End Class