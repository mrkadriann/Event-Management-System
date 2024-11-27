<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myevent
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
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvevent = New System.Windows.Forms.DataGridView()
        Me.eventnamecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdatecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventaddresscol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventpaxcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdesccol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(668, 32)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(101, 36)
        Me.btnGoBack.TabIndex = 2
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Registered Events"
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
        Me.dgvevent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eventnamecol, Me.eventdatecol, Me.eventaddresscol, Me.eventpaxcol, Me.eventdesccol})
        Me.dgvevent.Location = New System.Drawing.Point(67, 133)
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
        Me.dgvevent.Size = New System.Drawing.Size(649, 267)
        Me.dgvevent.TabIndex = 18
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Student"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(63, 36)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(60, 23)
        Me.lblusername.TabIndex = 19
        Me.lblusername.Text = "USER"
        '
        'myevent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.dgvevent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGoBack)
        Me.Name = "myevent"
        Me.Text = "Event Planner"
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGoBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvevent As DataGridView
    Friend WithEvents eventnamecol As DataGridViewTextBoxColumn
    Friend WithEvents eventdatecol As DataGridViewTextBoxColumn
    Friend WithEvents eventaddresscol As DataGridViewTextBoxColumn
    Friend WithEvents eventpaxcol As DataGridViewTextBoxColumn
    Friend WithEvents eventdesccol As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents lblusername As Label
End Class
