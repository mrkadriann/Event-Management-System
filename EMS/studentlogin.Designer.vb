<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.linkregister = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT LOGIN"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(282, 191)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(243, 20)
        Me.txtusername.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(282, 241)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(243, 20)
        Me.txtpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(426, 292)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(99, 34)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(351, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No Account Yet?"
        '
        'linkregister
        '
        Me.linkregister.AutoSize = True
        Me.linkregister.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkregister.Location = New System.Drawing.Point(357, 353)
        Me.linkregister.Name = "linkregister"
        Me.linkregister.Size = New System.Drawing.Size(87, 15)
        Me.linkregister.TabIndex = 9
        Me.linkregister.TabStop = True
        Me.linkregister.Text = "Sign Up Here!"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnGoBack)
        Me.Panel2.Controls.Add(Me.linkregister)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 449)
        Me.Panel2.TabIndex = 10
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(282, 292)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(99, 34)
        Me.btnGoBack.TabIndex = 11
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'studentlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.HelpButton = True
        Me.Name = "studentlogin"
        Me.Text = "Event Planner"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents linkregister As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGoBack As Button
    Friend WithEvents txtusername As TextBox
End Class
