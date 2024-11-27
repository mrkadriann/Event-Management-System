Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
Imports System.Data

Public Class manageevent
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Main.childform(Adminevent)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Main.childform(Addevent)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Main.childform(Editevent)
    End Sub

    Private Sub manageevent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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

    Public Sub LoadData()
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            If dgvevent.SelectedRows.Count > 0 Then

                Dim selectedRow As DataGridViewRow = dgvevent.SelectedRows(0)
                Dim eventname As String = Convert.ToString(selectedRow.Cells("eventnamecol").Value) ' Replace "eventnamecol" with your actual column name

                Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="

                Dim query As String = "DELETE FROM eventinfo WHERE eventName = @EventName"

                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()

                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@EventName", eventname)

                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Event deleted successfully.")
                            Else
                                MessageBox.Show("No record found to delete.")
                            End If
                        End Using
                    End Using

                    RefreshDataGridView()

                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Please select a row to delete.")
            End If
        Else
        End If
    End Sub

    Private Sub RefreshDataGridView()
        ' Assuming you have a method to load data into the DataGridView
        Dim query As String = "SELECT * FROM eventinfo"
        Dim connectionString As String = "server=localhost;port=3307;database=ooptestdb;username=root;password="

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Bind the data to the DataGridView
                    dgvevent.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class