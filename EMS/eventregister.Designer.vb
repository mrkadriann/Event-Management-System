<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventregister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbevent = New System.Windows.Forms.ComboBox()
        Me.txtwhat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtwhere = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtxtdesc = New System.Windows.Forms.RichTextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtwhen = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(667, 51)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(101, 36)
        Me.btnGoBack.TabIndex = 3
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Register Now!"
        '
        'cbevent
        '
        Me.cbevent.FormattingEnabled = True
        Me.cbevent.Location = New System.Drawing.Point(242, 144)
        Me.cbevent.Name = "cbevent"
        Me.cbevent.Size = New System.Drawing.Size(336, 21)
        Me.cbevent.TabIndex = 5
        '
        'txtwhat
        '
        Me.txtwhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwhat.Location = New System.Drawing.Point(153, 211)
        Me.txtwhat.Name = "txtwhat"
        Me.txtwhat.ReadOnly = True
        Me.txtwhat.Size = New System.Drawing.Size(268, 26)
        Me.txtwhat.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "What:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "When:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Where:"
        '
        'txtwhere
        '
        Me.txtwhere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwhere.Location = New System.Drawing.Point(153, 295)
        Me.txtwhere.Name = "txtwhere"
        Me.txtwhere.ReadOnly = True
        Me.txtwhere.Size = New System.Drawing.Size(267, 26)
        Me.txtwhere.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Description"
        '
        'rtxtdesc
        '
        Me.rtxtdesc.Location = New System.Drawing.Point(455, 230)
        Me.rtxtdesc.Name = "rtxtdesc"
        Me.rtxtdesc.ReadOnly = True
        Me.rtxtdesc.Size = New System.Drawing.Size(244, 91)
        Me.rtxtdesc.TabIndex = 14
        Me.rtxtdesc.Text = ""
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(310, 356)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(166, 49)
        Me.btnRegister.TabIndex = 15
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Available Slots:"
        '
        'lblPax
        '
        Me.lblPax.AutoSize = True
        Me.lblPax.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPax.Location = New System.Drawing.Point(221, 182)
        Me.lblPax.Name = "lblPax"
        Me.lblPax.Size = New System.Drawing.Size(46, 14)
        Me.lblPax.TabIndex = 34
        Me.lblPax.Text = "Label8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Admin"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(60, 51)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(60, 23)
        Me.lblusername.TabIndex = 35
        Me.lblusername.Text = "USER"
        '
        'txtwhen
        '
        Me.txtwhen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwhen.Location = New System.Drawing.Point(154, 251)
        Me.txtwhen.Name = "txtwhen"
        Me.txtwhen.ReadOnly = True
        Me.txtwhen.Size = New System.Drawing.Size(267, 26)
        Me.txtwhen.TabIndex = 37
        '
        'eventregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtwhen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblPax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.rtxtdesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtwhere)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtwhat)
        Me.Controls.Add(Me.cbevent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGoBack)
        Me.Name = "eventregister"
        Me.Text = "Event Planner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGoBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbevent As ComboBox
    Friend WithEvents txtwhat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtwhere As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rtxtdesc As RichTextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPax As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents txtwhen As TextBox
End Class
