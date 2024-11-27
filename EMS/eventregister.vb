Imports MySql.Data.MySqlClient
Public Class eventregister
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Main.childform(EventPlanner)
    End Sub

    Private Sub eventregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoComboBox()
        StudentUsernameCon()

    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
        Dim queryEvent As String = "SELECT eventName, eventDate, eventAddress, eventPax, eventDesc FROM eventinfo WHERE TRIM(LOWER(eventName)) = TRIM(LOWER(@EventName))"
        Dim querySlots As String = "SELECT COUNT(*) FROM participantinfo WHERE eventID = (SELECT ID FROM eventinfo WHERE TRIM(LOWER(eventName)) = TRIM(LOWER(@EventName)))"

        Try
            If String.IsNullOrWhiteSpace(cbevent.Text) Then
                MessageBox.Show("Please select an event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query event details
                Using cmdEvent As New MySqlCommand(queryEvent, conn)
                    cmdEvent.Parameters.AddWithValue("@EventName", cbevent.Text.Trim())

                    Using reader As MySqlDataReader = cmdEvent.ExecuteReader()
                        If reader.Read() Then
                            txtwhat.Text = reader("eventName").ToString()
                            txtwhen.Text = Convert.ToDateTime(reader("eventDate")).ToString("MMMM dd, yyyy")
                            txtwhere.Text = reader("eventAddress").ToString()
                            rtxtdesc.Text = reader("eventDesc").ToString()
                            lblPax.Text = "" ' Clear available slots temporarily
                        End If
                    End Using
                End Using

                ' Query available slots
                Dim totalSlots As Integer = 0
                Dim registeredStudents As Integer = 0

                ' Get total slots (eventPax)
                Using cmdEventPax As New MySqlCommand(queryEvent, conn)
                    cmdEventPax.Parameters.AddWithValue("@EventName", cbevent.Text.Trim())

                    Using reader As MySqlDataReader = cmdEventPax.ExecuteReader()
                        If reader.Read() Then
                            totalSlots = Convert.ToInt32(reader("eventPax"))
                        End If
                    End Using
                End Using

                ' Get number of registered students
                Using cmdSlots As New MySqlCommand(querySlots, conn)
                    cmdSlots.Parameters.AddWithValue("@EventName", cbevent.Text.Trim())
                    registeredStudents = Convert.ToInt32(cmdSlots.ExecuteScalar())
                End Using

                ' Calculate and display available slots
                Dim availableSlots As Integer = totalSlots - registeredStudents
                lblPax.Text = $"Available Slots: {availableSlots}"

            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="
        Dim queryEvent As String = "SELECT ID, eventPax FROM eventinfo WHERE eventName = @EventName"
        Dim queryStudent As String = "SELECT ID FROM studentinfo WHERE studUsername = @Username"
        Dim queryParticipantCount As String = "SELECT COUNT(*) FROM participantinfo WHERE eventID = @eventID"
        Dim queryCheckRegistration As String = "SELECT COUNT(*) FROM participantinfo WHERE eventID = @eventID AND studID = @studID"
        Dim queryInsert As String = "INSERT INTO participantinfo (eventID, studID) VALUES (@eventID, @studID)"
        Dim username As String = ProjRef.loggedusername
        Dim eventName As String = cbevent.Text
        Dim eventID As Integer
        Dim studentID As Integer
        Dim eventPax As Integer
        Dim registeredCount As Integer
        Dim isAlreadyRegistered As Integer

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Get Student ID
                Using cmdStudent As New MySqlCommand(queryStudent, conn)
                    cmdStudent.Parameters.AddWithValue("@Username", username)
                    Dim result = cmdStudent.ExecuteScalar()
                    If result IsNot Nothing Then
                        studentID = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Get Event ID and eventPax
                Using cmdEvent As New MySqlCommand(queryEvent, conn)
                    cmdEvent.Parameters.AddWithValue("@EventName", eventName)
                    Using reader As MySqlDataReader = cmdEvent.ExecuteReader()
                        If reader.Read() Then
                            eventID = Convert.ToInt32(reader("ID"))
                            eventPax = Convert.ToInt32(reader("eventPax"))
                        Else
                            MessageBox.Show("Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Check if the user is already registered for the event
                Using cmdCheckRegistration As New MySqlCommand(queryCheckRegistration, conn)
                    cmdCheckRegistration.Parameters.AddWithValue("@eventID", eventID)
                    cmdCheckRegistration.Parameters.AddWithValue("@studID", studentID)

                    isAlreadyRegistered = Convert.ToInt32(cmdCheckRegistration.ExecuteScalar())
                    If isAlreadyRegistered > 0 Then
                        MessageBox.Show("You are already registered for this event.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Check number of registered users
                Using cmdCount As New MySqlCommand(queryParticipantCount, conn)
                    cmdCount.Parameters.AddWithValue("@eventID", eventID)
                    registeredCount = Convert.ToInt32(cmdCount.ExecuteScalar())
                End Using

                ' Check if slots are available
                If registeredCount >= eventPax Then
                    MessageBox.Show("This event is fully booked. No more slots are available.", "Registration Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Insert new registration
                Using cmdInsert As New MySqlCommand(queryInsert, conn)
                    cmdInsert.Parameters.AddWithValue("@eventID", eventID)
                    cmdInsert.Parameters.AddWithValue("@studID", studentID)
                    cmdInsert.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while accessing the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                cbevent.DisplayMember = "eventName" ' Column to display in ComboBox
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class