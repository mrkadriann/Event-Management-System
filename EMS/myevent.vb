Imports MySql.Data.MySqlClient

Public Class myevent
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Main.childform(EventPlanner)
    End Sub

    Private Sub myevent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentUsernameCon()
        Try
            Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to get events that the current logged user is registered for
                Dim query As String = "SELECT e.eventName, e.eventDate, e.eventAddress, e.eventPax, e.eventDesc " &
                                      "FROM eventinfo e " &
                                      "JOIN participantinfo p ON e.ID = p.eventID " &
                                      "JOIN studentinfo s ON p.studID = s.ID " &
                                      "WHERE s.studUsername = @Username"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", ProjRef.loggedusername) ' Use the logged-in username as a parameter

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                dgvevent.Rows.Clear()

                While reader.Read()
                    dgvevent.Rows.Add(reader("eventName").ToString(), reader("eventDate").ToString(), reader("eventAddress").ToString(), reader("eventPax").ToString(), reader("eventDesc").ToString())
                End While
                dgvevent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Public Sub StudentUsernameCon()
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
        Dim query As String = "SELECT studFirstName, studLastName FROM studentinfo WHERE studUsername = @Username"
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
                            Dim firstName As String = reader("studFirstName").ToString()
                            Dim lastName As String = reader("studLastName").ToString()

                            'Full Name in Label
                            lblusername.Text = firstName & " " & lastName
                        End If
                    End Using
                End Using
            Catch ex As Exception
                'Si taguro taga salo ng exceptions(2)
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class