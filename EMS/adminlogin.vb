Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Public Class adminlogin
#Region "Declares"
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        txtpassword.Clear()
        txtusername.Clear()
        Main.childform(roles)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query As String = "SELECT * FROM admininfo WHERE adminUsername = @Username AND adminPassword = @Password"
        Dim datatable As New DataTable

        Try
            Using connection As New MySqlConnection("server=localhost;port=3307;database=ooptestdb;username=root;password=")
                connection.Open()

                Using adapter As New MySqlDataAdapter(query, connection)
                    'Using Parameters to avoid SQL Injections
                    adapter.SelectCommand.Parameters.AddWithValue("@Username", txtusername.Text)
                    adapter.SelectCommand.Parameters.AddWithValue("@Password", txtpassword.Text)

                    adapter.Fill(datatable)
                End Using
            End Using


            If datatable.Rows.Count <= 0 Then
                MessageBox.Show("Username or Password is Invalid", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Successful Login!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'User Main 
                ProjRef.loggedusername = txtusername.Text
                txtpassword.Clear()
                txtusername.Clear()
                Main.childform(Adminevent)
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

#End Region
End Class