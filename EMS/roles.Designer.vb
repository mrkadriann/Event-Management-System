<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class roles
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.roleadmin = New System.Windows.Forms.Button()
        Me.rolestudent = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 48)
        Me.Label1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.roleadmin)
        Me.Panel1.Controls.Add(Me.rolestudent)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 452)
        Me.Panel1.TabIndex = 9
        '
        'roleadmin
        '
        Me.roleadmin.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roleadmin.Location = New System.Drawing.Point(429, 261)
        Me.roleadmin.Name = "roleadmin"
        Me.roleadmin.Size = New System.Drawing.Size(140, 59)
        Me.roleadmin.TabIndex = 2
        Me.roleadmin.Text = "ADMIN"
        Me.roleadmin.UseVisualStyleBackColor = True
        '
        'rolestudent
        '
        Me.rolestudent.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rolestudent.Location = New System.Drawing.Point(231, 261)
        Me.rolestudent.Name = "rolestudent"
        Me.rolestudent.Size = New System.Drawing.Size(140, 59)
        Me.rolestudent.TabIndex = 2
        Me.rolestudent.Text = "STUDENT"
        Me.rolestudent.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 35)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Welcome!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 56)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Event Planner"
        '
        'roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "roles"
        Me.Text = "roles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents roleadmin As Button
    Friend WithEvents rolestudent As Button
End Class
