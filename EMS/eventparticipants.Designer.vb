<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventparticipants
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.cbevent = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvevent = New System.Windows.Forms.DataGridView()
        Me.firstnamecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastnamecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middlenamecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coursecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Admin"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(52, 37)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(60, 23)
        Me.lblusername.TabIndex = 21
        Me.lblusername.Text = "USER"
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(660, 33)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(101, 36)
        Me.btnGoBack.TabIndex = 23
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'cbevent
        '
        Me.cbevent.FormattingEnabled = True
        Me.cbevent.Location = New System.Drawing.Point(218, 115)
        Me.cbevent.Name = "cbevent"
        Me.cbevent.Size = New System.Drawing.Size(368, 21)
        Me.cbevent.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Quezon City Events"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Event Participants"
        '
        'dgvevent
        '
        Me.dgvevent.AllowUserToAddRows = False
        Me.dgvevent.AllowUserToResizeColumns = False
        Me.dgvevent.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvevent.BackgroundColor = System.Drawing.Color.White
        Me.dgvevent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvevent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.firstnamecol, Me.lastnamecol, Me.middlenamecol, Me.coursecol, Me.yearcol, Me.contactcol})
        Me.dgvevent.Location = New System.Drawing.Point(84, 163)
        Me.dgvevent.Name = "dgvevent"
        Me.dgvevent.RowHeadersVisible = False
        Me.dgvevent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvevent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvevent.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.RowTemplate.ReadOnly = True
        Me.dgvevent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvevent.Size = New System.Drawing.Size(656, 266)
        Me.dgvevent.TabIndex = 27
        '
        'firstnamecol
        '
        Me.firstnamecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.firstnamecol.HeaderText = "First Name"
        Me.firstnamecol.Name = "firstnamecol"
        '
        'lastnamecol
        '
        Me.lastnamecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lastnamecol.HeaderText = "Last Name"
        Me.lastnamecol.Name = "lastnamecol"
        '
        'middlenamecol
        '
        Me.middlenamecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.middlenamecol.HeaderText = "Middle Name"
        Me.middlenamecol.Name = "middlenamecol"
        '
        'coursecol
        '
        Me.coursecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coursecol.HeaderText = "Course"
        Me.coursecol.Name = "coursecol"
        '
        'yearcol
        '
        Me.yearcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.yearcol.HeaderText = "Year"
        Me.yearcol.Name = "yearcol"
        '
        'contactcol
        '
        Me.contactcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.contactcol.HeaderText = "Contact Number"
        Me.contactcol.Name = "contactcol"
        '
        'lblPax
        '
        Me.lblPax.AutoSize = True
        Me.lblPax.Location = New System.Drawing.Point(463, 142)
        Me.lblPax.Name = "lblPax"
        Me.lblPax.Size = New System.Drawing.Size(13, 13)
        Me.lblPax.TabIndex = 28
        Me.lblPax.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 11)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Current Participants:"
        '
        'eventparticipants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPax)
        Me.Controls.Add(Me.dgvevent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbevent)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "eventparticipants"
        Me.Text = "eventparticipants"
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents cbevent As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvevent As DataGridView
    Friend WithEvents firstnamecol As DataGridViewTextBoxColumn
    Friend WithEvents lastnamecol As DataGridViewTextBoxColumn
    Friend WithEvents middlenamecol As DataGridViewTextBoxColumn
    Friend WithEvents coursecol As DataGridViewTextBoxColumn
    Friend WithEvents yearcol As DataGridViewTextBoxColumn
    Friend WithEvents contactcol As DataGridViewTextBoxColumn
    Friend WithEvents lblPax As Label
    Friend WithEvents Label4 As Label
End Class
