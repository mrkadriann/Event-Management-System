<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accountregister
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
        Me.txtregusername = New System.Windows.Forms.TextBox()
        Me.txtregpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtregconfpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btngoback = New System.Windows.Forms.Button()
        Me.txtregcontact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtregfname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtreglname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtregmname = New System.Windows.Forms.TextBox()
        Me.cbregcourse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbregyear = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REGISTER"
        '
        'txtregusername
        '
        Me.txtregusername.Location = New System.Drawing.Point(432, 165)
        Me.txtregusername.Name = "txtregusername"
        Me.txtregusername.Size = New System.Drawing.Size(234, 20)
        Me.txtregusername.TabIndex = 3
        '
        'txtregpassword
        '
        Me.txtregpassword.Location = New System.Drawing.Point(432, 211)
        Me.txtregpassword.Name = "txtregpassword"
        Me.txtregpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregpassword.Size = New System.Drawing.Size(234, 20)
        Me.txtregpassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Your Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirm Password"
        '
        'txtregconfpass
        '
        Me.txtregconfpass.Location = New System.Drawing.Point(432, 253)
        Me.txtregconfpass.Name = "txtregconfpass"
        Me.txtregconfpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregconfpass.Size = New System.Drawing.Size(234, 20)
        Me.txtregconfpass.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Contact no."
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(428, 347)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(102, 32)
        Me.btnsubmit.TabIndex = 11
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btngoback
        '
        Me.btngoback.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngoback.Location = New System.Drawing.Point(286, 347)
        Me.btngoback.Name = "btngoback"
        Me.btngoback.Size = New System.Drawing.Size(102, 32)
        Me.btngoback.TabIndex = 12
        Me.btngoback.Text = "Go Back"
        Me.btngoback.UseVisualStyleBackColor = True
        '
        'txtregcontact
        '
        Me.txtregcontact.Location = New System.Drawing.Point(432, 298)
        Me.txtregcontact.Name = "txtregcontact"
        Me.txtregcontact.Size = New System.Drawing.Size(234, 20)
        Me.txtregcontact.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(132, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Enter Your First Name:"
        '
        'txtregfname
        '
        Me.txtregfname.Location = New System.Drawing.Point(135, 165)
        Me.txtregfname.Name = "txtregfname"
        Me.txtregfname.Size = New System.Drawing.Size(247, 20)
        Me.txtregfname.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(132, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Enter Your Last Name:"
        '
        'txtreglname
        '
        Me.txtreglname.Location = New System.Drawing.Point(135, 211)
        Me.txtreglname.Name = "txtreglname"
        Me.txtreglname.Size = New System.Drawing.Size(247, 20)
        Me.txtreglname.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Enter Your Middle Name:"
        '
        'txtregmname
        '
        Me.txtregmname.Location = New System.Drawing.Point(135, 255)
        Me.txtregmname.Name = "txtregmname"
        Me.txtregmname.Size = New System.Drawing.Size(247, 20)
        Me.txtregmname.TabIndex = 18
        '
        'cbregcourse
        '
        Me.cbregcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbregcourse.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbregcourse.FormattingEnabled = True
        Me.cbregcourse.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbregcourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSIE"})
        Me.cbregcourse.Location = New System.Drawing.Point(135, 297)
        Me.cbregcourse.Name = "cbregcourse"
        Me.cbregcourse.Size = New System.Drawing.Size(115, 24)
        Me.cbregcourse.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(132, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Select Your Course:"
        '
        'cbregyear
        '
        Me.cbregyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbregyear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbregyear.FormattingEnabled = True
        Me.cbregyear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbregyear.Location = New System.Drawing.Point(267, 298)
        Me.cbregyear.Name = "cbregyear"
        Me.cbregyear.Size = New System.Drawing.Size(115, 24)
        Me.cbregyear.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(264, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Select Your Year:"
        '
        'accountregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbregyear)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbregcourse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtregmname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtreglname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtregfname)
        Me.Controls.Add(Me.txtregcontact)
        Me.Controls.Add(Me.btngoback)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtregconfpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtregpassword)
        Me.Controls.Add(Me.txtregusername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "accountregister"
        Me.Text = "Event Planner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtregusername As TextBox
    Friend WithEvents txtregpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtregconfpass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btngoback As Button
    Friend WithEvents txtregcontact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtregfname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtreglname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtregmname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbregyear As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbregcourse As ComboBox
End Class
