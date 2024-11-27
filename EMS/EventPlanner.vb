Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EventPlanner
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim result As DialogResult = MessageBox.Show("Do You Really Want To Sign Out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Main.childform(studentlogin)
        End If
    End Sub

    Private Sub EventPlanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentUsernameCon()
        Try
            Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT eventName, eventDate, eventAddress, eventPax, eventDesc FROM eventinfo"
                Dim cmd As New MySqlCommand(query, conn)
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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Main.childform(eventregister)
    End Sub

    Private Sub btnMyEvent_Click(sender As Object, e As EventArgs) Handles btnMyEvent.Click
        Main.childform(myevent)
    End Sub

End Class
