Public Class roles
    Private Sub rolestudent_Click(sender As Object, e As EventArgs) Handles rolestudent.Click
        Main.childform(studentlogin)
    End Sub
    Private Sub roleadmin_Click(sender As Object, e As EventArgs) Handles roleadmin.Click
        Main.childform(adminlogin)
    End Sub
End Class