<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventPlanner
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnMyEvent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvevent = New System.Windows.Forms.DataGridView()
        Me.eventnamecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdatecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventaddresscol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventpaxcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdesccol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(36, 26)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(60, 23)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "USER"
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(673, 26)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(101, 36)
        Me.btnSignOut.TabIndex = 1
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quezon City Events"
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(237, 402)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(153, 36)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnMyEvent
        '
        Me.btnMyEvent.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyEvent.Location = New System.Drawing.Point(416, 402)
        Me.btnMyEvent.Name = "btnMyEvent"
        Me.btnMyEvent.Size = New System.Drawing.Size(153, 36)
        Me.btnMyEvent.TabIndex = 5
        Me.btnMyEvent.Text = "My Event"
        Me.btnMyEvent.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Student"
        '
        'dgvevent
        '
        Me.dgvevent.AllowUserToAddRows = False
        Me.dgvevent.AllowUserToResizeColumns = False
        Me.dgvevent.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvevent.BackgroundColor = System.Drawing.Color.White
        Me.dgvevent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvevent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eventnamecol, Me.eventdatecol, Me.eventaddresscol, Me.eventpaxcol, Me.eventdesccol})
        Me.dgvevent.Location = New System.Drawing.Point(76, 129)
        Me.dgvevent.Name = "dgvevent"
        Me.dgvevent.RowHeadersVisible = False
        Me.dgvevent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvevent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvevent.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.RowTemplate.ReadOnly = True
        Me.dgvevent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvevent.Size = New System.Drawing.Size(649, 256)
        Me.dgvevent.TabIndex = 17
        '
        'eventnamecol
        '
        Me.eventnamecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.eventnamecol.HeaderText = "Event"
        Me.eventnamecol.Name = "eventnamecol"
        '
        'eventdatecol
        '
        Me.eventdatecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.eventdatecol.HeaderText = "Date"
        Me.eventdatecol.Name = "eventdatecol"
        '
        'eventaddresscol
        '
        Me.eventaddresscol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.eventaddresscol.HeaderText = "Address"
        Me.eventaddresscol.Name = "eventaddresscol"
        '
        'eventpaxcol
        '
        Me.eventpaxcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.eventpaxcol.HeaderText = "Max Participants"
        Me.eventpaxcol.Name = "eventpaxcol"
        '
        'eventdesccol
        '
        Me.eventdesccol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.eventdesccol.HeaderText = "Description"
        Me.eventdesccol.Name = "eventdesccol"
        '
        'EventPlanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvevent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMyEvent)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "EventPlanner"
        Me.Text = "Event Planner"
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblusername As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnMyEvent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvevent As DataGridView
    Friend WithEvents eventnamecol As DataGridViewTextBoxColumn
    Friend WithEvents eventdatecol As DataGridViewTextBoxColumn
    Friend WithEvents eventaddresscol As DataGridViewTextBoxColumn
    Friend WithEvents eventpaxcol As DataGridViewTextBoxColumn
    Friend WithEvents eventdesccol As DataGridViewTextBoxColumn
End Class
