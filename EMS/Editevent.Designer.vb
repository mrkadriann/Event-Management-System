<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editevent
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.rtxtdesc = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtwhere = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtwhat = New System.Windows.Forms.TextBox()
        Me.cbevent = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpwhen = New System.Windows.Forms.DateTimePicker()
        Me.nudpax = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        CType(Me.nudpax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(331, 376)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(166, 49)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'rtxtdesc
        '
        Me.rtxtdesc.Location = New System.Drawing.Point(453, 210)
        Me.rtxtdesc.Name = "rtxtdesc"
        Me.rtxtdesc.Size = New System.Drawing.Size(244, 133)
        Me.rtxtdesc.TabIndex = 27
        Me.rtxtdesc.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Description"
        '
        'txtwhere
        '
        Me.txtwhere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwhere.Location = New System.Drawing.Point(151, 275)
        Me.txtwhere.Name = "txtwhere"
        Me.txtwhere.Size = New System.Drawing.Size(267, 26)
        Me.txtwhere.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Where:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "When:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "What:"
        '
        'txtwhat
        '
        Me.txtwhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwhat.Location = New System.Drawing.Point(151, 191)
        Me.txtwhat.Name = "txtwhat"
        Me.txtwhat.Size = New System.Drawing.Size(268, 26)
        Me.txtwhat.TabIndex = 20
        '
        'cbevent
        '
        Me.cbevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbevent.FormattingEnabled = True
        Me.cbevent.Location = New System.Drawing.Point(198, 138)
        Me.cbevent.Name = "cbevent"
        Me.cbevent.Size = New System.Drawing.Size(455, 24)
        Me.cbevent.TabIndex = 19
        Me.cbevent.Text = "Select Event"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Edit Event"
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(648, 48)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(101, 36)
        Me.btnGoBack.TabIndex = 17
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Max:"
        '
        'dtpwhen
        '
        Me.dtpwhen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpwhen.Location = New System.Drawing.Point(150, 233)
        Me.dtpwhen.MaxDate = New Date(2026, 12, 31, 0, 0, 0, 0)
        Me.dtpwhen.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dtpwhen.Name = "dtpwhen"
        Me.dtpwhen.Size = New System.Drawing.Size(268, 26)
        Me.dtpwhen.TabIndex = 32
        '
        'nudpax
        '
        Me.nudpax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudpax.Location = New System.Drawing.Point(150, 317)
        Me.nudpax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudpax.Name = "nudpax"
        Me.nudpax.Size = New System.Drawing.Size(268, 26)
        Me.nudpax.TabIndex = 33
        Me.nudpax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Admin"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(55, 52)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(60, 23)
        Me.lblusername.TabIndex = 34
        Me.lblusername.Text = "USER"
        '
        'Editevent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.nudpax)
        Me.Controls.Add(Me.dtpwhen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpdate)
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
        Me.Name = "Editevent"
        Me.Text = "Event Planner"
        CType(Me.nudpax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents rtxtdesc As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtwhere As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtwhat As TextBox
    Friend WithEvents cbevent As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpwhen As DateTimePicker
    Friend WithEvents nudpax As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
End Class
