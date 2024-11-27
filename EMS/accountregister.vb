Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls
Public Class accountregister
#Region "Declares"

    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btngoback.Click

        txtregfname.Clear()
        txtreglname.Clear()
        txtregmname.Clear()
        cbregcourse.SelectedIndex = -1
        cbregyear.SelectedIndex = -1
        txtregusername.Clear()
        txtregpassword.Clear()
        txtregconfpass.Clear()
        txtregcontact.Clear()

        Main.childform(studentlogin)
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim fname As String = txtregfname.Text
        Dim lname As String = txtreglname.Text
        Dim mname As String = txtregmname.Text
        Dim course As String = cbregcourse.Text
        Dim yearString As String = cbregyear.Text
        Dim username As String = txtregusername.Text
        Dim password As String = txtregpassword.Text
        Dim confpass As String = txtregconfpass.Text
        Dim contact As String = txtregcontact.Text

        If String.IsNullOrWhiteSpace(fname) OrElse
       String.IsNullOrWhiteSpace(lname) OrElse
       String.IsNullOrWhiteSpace(mname) OrElse
       String.IsNullOrWhiteSpace(course) OrElse
       String.IsNullOrWhiteSpace(yearString) OrElse
       String.IsNullOrWhiteSpace(username) OrElse
       String.IsNullOrWhiteSpace(password) OrElse
       String.IsNullOrWhiteSpace(confpass) OrElse
       String.IsNullOrWhiteSpace(contact) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim year As Integer
        If Not Integer.TryParse(yearString, year) Then
            MessageBox.Show("Please select a valid year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If password <> confpass Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO studentinfo (studFirstName, studLastName, studMiddleName, studCourse, studYear, studUsername, studPassword, studContact) " & "VALUES (@FirstName, @LastName, @MiddleName, @Course, @Year, @Username, @Password, @Contact)"

        Try
            Using connection As New MySqlConnection("server=localhost;port=3307;database=ooptestdb;username=root;password=")
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the query
                    command.Parameters.AddWithValue("@FirstName", fname)
                    command.Parameters.AddWithValue("@LastName", lname)
                    command.Parameters.AddWithValue("@MiddleName", mname)
                    command.Parameters.AddWithValue("@Course", course)
                    command.Parameters.AddWithValue("@Year", year) 'Using the converted int
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@Contact", contact)


                    connection.Open()
                    command.ExecuteNonQuery()

                    txtregfname.Clear()
                    txtreglname.Clear()
                    txtregmname.Clear()
                    cbregcourse.SelectedIndex = -1
                    cbregyear.SelectedIndex = -1
                    txtregusername.Clear()
                    txtregpassword.Clear()
                    txtregconfpass.Clear()
                    txtregcontact.Clear()

                    MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()

                    Main.childform(studentlogin)
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region
End Class