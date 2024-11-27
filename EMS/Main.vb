Public Class Main
    Public Sub childform(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub ShowForm1IfPanelIsEmpty()
        ' Check if Panel1 has no controls (i.e., no form is displayed)
        If Panel1.Controls.Count = 0 Then
            ' If no controls, show Form1 inside the panel
            Dim form1 As New roles() ' Replace Form1 with the desired form
            childform(form1) ' Assuming you have a method like childform to show forms
        End If
    End Sub
    Private Sub btnCheckAndShowForm1_Click(sender As Object, e As EventArgs) Handles MyBase.Activated
        ShowForm1IfPanelIsEmpty()
    End Sub


End Class