Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls
Public Class Addevent
#Region "Declares"
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim whatevent As String = txtwhat.Text
        Dim whenevent As String = dtpwhen.Value.ToString("yyyy-MM-dd")
        Dim whereevent As String = txtwhere.Text
        Dim paxeventString As String = nudpax.Text
        Dim descevent As String = rtxtdescription.Text

        If String.IsNullOrWhiteSpace(whatevent) OrElse
       String.IsNullOrWhiteSpace(whenevent) OrElse
       String.IsNullOrWhiteSpace(whereevent) OrElse
       String.IsNullOrWhiteSpace(paxeventString) OrElse
       String.IsNullOrWhiteSpace(descevent) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim paxevent As Integer
        If Not Integer.TryParse(paxeventString, paxevent) Then
            MessageBox.Show("Please select a valid Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO eventinfo (eventName, eventDate, eventAddress, eventPax, eventDesc) " & "VALUES (@EventName, @EventDate, @EventAddress, @EventPax, @EventDesc)"

        Try
            Using connection As New MySqlConnection("server=localhost;port=3307;database=ooptestdb;username=root;password=")
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the query
                    command.Parameters.AddWithValue("@EventName", whatevent)
                    command.Parameters.AddWithValue("@EventDate", whenevent)
                    command.Parameters.AddWithValue("@EventAddress", whereevent)
                    command.Parameters.AddWithValue("@EventPax", paxevent)
                    command.Parameters.AddWithValue("@EventDesc", descevent)

                    connection.Open()
                    command.ExecuteNonQuery()

                    txtwhat.Clear()
                    txtwhere.Clear()
                    nudpax.Value = 1
                    rtxtdescription.Clear()

                    MessageBox.Show("Event Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()

                    Main.childform(Adminevent)
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        txtwhat.Clear()
        txtwhere.Clear()
        nudpax.Value = 1
        rtxtdescription.Clear()
        Main.childform(Adminevent)
    End Sub

    Private Sub Addevent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
        Dim query As String = "SELECT adminFirstName, adminLastName FROM admininfo WHERE adminUsername = @Username"
        Dim username As String = ProjRef.loggedusername

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    'Param to Avoid SQL Injections
                    command.Parameters.AddWithValue("@Username", username)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim firstName As String = reader("adminFirstName").ToString()
                            Dim lastName As String = reader("adminLastName").ToString()

                            'Full Name in Label
                            lblusername.Text = firstName & " " & lastName
                        End If
                    End Using
                End Using
            Catch ex As Exception
                'Si taguro taga salo ng exceptions
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

#End Region
End Class