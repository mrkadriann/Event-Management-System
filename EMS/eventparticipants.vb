Imports MySql.Data.MySqlClient

Public Class eventparticipants
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Main.childform(Adminevent)
    End Sub

    Private Sub eventparticipants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoComboBox()
        AdminUsernameCon()

    End Sub

    Public Sub LoadDataIntoComboBox()
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
        Dim query As String = "SELECT eventName FROM eventinfo"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)

                cbevent.DataSource = table
                cbevent.DisplayMember = "eventName"
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        If String.IsNullOrWhiteSpace(cbevent.Text) Then
            MessageBox.Show("Please select an event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
        ' SQL query to get student details who are registered for the selected event
        Dim query As String = "SELECT s.studFirstName, s.studLastName, s.studMiddleName, s.studCourse, s.studYear, s.studContact " &
                          "FROM studentinfo s " &
                          "INNER JOIN participantinfo p ON s.ID = p.studID " &
                          "INNER JOIN eventinfo e ON p.eventID = e.ID " &
                          "WHERE e.eventName = @EventName"

        ' Query to count the number of registered users for the selected event
        Dim queryCount As String = "SELECT COUNT(*) FROM participantinfo p " &
                               "INNER JOIN eventinfo e ON p.eventID = e.ID " &
                               "WHERE e.eventName = @EventName"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Execute the count query to get the number of registered users
                Using cmdCount As New MySqlCommand(queryCount, conn)
                    cmdCount.Parameters.AddWithValue("@EventName", cbevent.Text.Trim())
                    Dim registeredCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())
                    lblPax.Text = registeredCount.ToString()
                End Using

                ' Execute the query to get the details of the registered users
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EventName", cbevent.Text.Trim())

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing rows before adding new data
                        dgvevent.Rows.Clear()

                        While reader.Read()
                            ' Add a new row to the DataGridView with the student details
                            dgvevent.Rows.Add(
                            reader("studFirstName").ToString(),
                            reader("studLastName").ToString(),
                            reader("studMiddleName").ToString(),
                            reader("studCourse").ToString(),
                            reader("studYear").ToString(),
                            reader("studContact").ToString()
                        )
                        End While

                        dgvevent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AdminUsernameCon()
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
                'Si taguro taga salo ng exceptions(MAX)
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class