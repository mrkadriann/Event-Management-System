Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Editevent
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoComboBox()
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

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Main.childform(manageevent)
    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="

        Dim query As String = "SELECT eventName, eventDate, eventAddress, eventPax, eventDesc FROM eventinfo WHERE ID = @EventID"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EventID", cbevent.SelectedIndex + 1)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            txtwhat.Text = reader("eventName").ToString()
                            dtpwhen.Value = reader("eventDate").ToString()
                            txtwhere.Text = reader("eventAddress").ToString()
                            nudpax.Value = reader("eventPax").ToString()
                            rtxtdesc.Text = reader("eventDesc").ToString()

                        Else
                            MessageBox.Show("No record found with the specified ID.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="

        Dim query As String = "UPDATE eventinfo SET eventName = @EventName, eventDate = @EventDate, eventAddress = @EventAddress, eventPax = @EventPax, eventDesc = @EventDesc WHERE ID = @EventID"

        Dim eventPax As Integer

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@EventID", cbevent.SelectedIndex + 1)

                    cmd.Parameters.AddWithValue("@EventName", txtwhat.Text)
                    cmd.Parameters.AddWithValue("@EventDate", dtpwhen.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@EventAddress", txtwhere.Text)  ' Replace txtValue2 with the source of your new data
                    cmd.Parameters.AddWithValue("@EventPax", Integer.TryParse(nudpax.Value, eventPax))
                    cmd.Parameters.AddWithValue("@EventDesc", rtxtdesc)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"{rowsAffected} record(s) updated successfully.")
                    Else
                        MessageBox.Show("No records were updated. Please check your criteria.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class