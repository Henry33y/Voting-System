
Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient
Public Class Login

    Dim connectionString As String = "Server=192.168.96.130;Database=voting_database;User ID=Henry;Password=1234567;"


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim studentId As String = txtStudentId.Text
        Dim password As String = txtPassword.Text
        Dim query As String = "SELECT student_id,password,president FROM voting_info WHERE student_id = @studentId;"
        Dim MySqlConnection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(query, MySqlConnection)

        command.Parameters.AddWithValue("@studentId", studentId)

        Dim studentIDcolumnValue As String
        Dim passwordcolumnValue As String
        Dim presidentcolumnValue As Integer
        If studentId = "" Or password = "" Then
            MessageBox.Show("Please complete the form to proceed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                MySqlConnection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    studentIDcolumnValue = reader.GetString(0)
                    passwordcolumnValue = reader.GetString(1)
                    presidentcolumnValue = reader.GetInt32(2)
                    'MessageBox.Show($"Column1: {studentIDcolumnValue}, Column2: {passwordcolumnValue}")
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If MySqlConnection.State = ConnectionState.Open Then
                    MySqlConnection.Close()
                End If
            End Try
            If password = passwordcolumnValue And studentId = studentIDcolumnValue Then
                If presidentcolumnValue = 0 Then
                    VoteVariables.student_id = studentId
                    Me.Hide()
                    frmPresidentials.Show()
                    txtPassword.Text = ""
                    txtStudentId.Text = ""
                    chkPassword.Checked = False

                Else
                    MessageBox.Show("User has already voted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else
                MessageBox.Show("Incorrect Credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim graphics As Graphics = e.Graphics
        Dim brush As New SolidBrush(Color.DarkMagenta)

        ' Get the current size of the form
        Dim formWidth As Integer = Me.ClientSize.Width
        Dim formHeight As Integer = Me.ClientSize.Height

        ' Calculate the position to center the rectangle
        Dim x As Integer = (formWidth - 400) \ 2
        Dim y As Integer = (formHeight - 600) \ 2

        ' Draw the centered rectangle
        graphics.FillRectangle(brush, x, y, 400, 600)
    End Sub

    Private Sub Form2_paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim ellipse As Graphics = e.Graphics
        Dim brush1 As New SolidBrush(Color.White)

        ' Get the current size of the form
        Dim formWidth As Integer = Me.ClientSize.Width
        Dim formHeight As Integer = Me.ClientSize.Height

        ' Calculate the position to center the ellipse
        Dim x As Integer = (formWidth - 140) \ 2
        Dim y As Integer = (formHeight - 600) \ 2  ' Adjust the circle position

        ' Ensure the circle is always at the top of the rectangle
        y = y - (140 \ 2) ' Subtract half of the ellipse height

        ' Draw the centered ellipse
        ellipse.FillEllipse(brush1, x, y, 140, 140)
    End Sub


    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            txtPassword.PasswordChar = ""

        Else
            txtPassword.PasswordChar = "."
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
