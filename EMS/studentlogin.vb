Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class studentlogin
#Region "Declares"
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        txtpassword.Clear()
        txtusername.Clear()
        Main.childform(roles)
    End Sub

    Private Sub linkregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkregister.LinkClicked
        txtpassword.Clear()
        txtusername.Clear()
        Main.childform(accountregister)
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query As String = "SELECT * FROM studentinfo WHERE studUsername = @Username AND studPassword = @Password"
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
                Main.childform(EventPlanner)
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    'Private Sub btnlogin_click(sender As Object, e As EventArgs) Handles btnLogin.Click
    '    conadapter = New MySqlDataAdapter("select * from studentinfo where studusername= '" & txtusername.Text & "' and studpassword= '" & txtpassword.Text & "'", myconnection.open)
    '    datatable = New DataTable
    '    datatable.Clear()
    '    conadapter.Fill(datatable)

    '    If datatable.Rows.Count <= 0 Then
    '        MessageBox.Show("username or password are invalid")
    '        myconnection.close()
    '    Else
    '        MessageBox.Show("successful login!")
    '        myconnection.close()
    '        Main.childform(EventPlanner)
    '    End If

    'End Sub

#End Region
End Class
