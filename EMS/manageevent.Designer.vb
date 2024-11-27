<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageevent
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvevent = New System.Windows.Forms.DataGridView()
        Me.eventnamecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdatecol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventaddresscol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventpaxcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdesccol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(324, 345)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(153, 36)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(153, 345)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(153, 36)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvevent
        '
        Me.dgvevent.AllowUserToAddRows = False
        Me.dgvevent.AllowUserToResizeColumns = False
        Me.dgvevent.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvevent.BackgroundColor = System.Drawing.Color.White
        Me.dgvevent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvevent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eventnamecol, Me.eventdatecol, Me.eventaddresscol, Me.eventpaxcol, Me.eventdesccol})
        Me.dgvevent.Location = New System.Drawing.Point(134, 103)
        Me.dgvevent.Name = "dgvevent"
        Me.dgvevent.RowHeadersVisible = False
        Me.dgvevent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvevent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvevent.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.RowTemplate.ReadOnly = True
        Me.dgvevent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvevent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvevent.Size = New System.Drawing.Size(530, 218)
        Me.dgvevent.TabIndex = 15
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Quezon City Events"
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(668, 19)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(101, 36)
        Me.btnGoBack.TabIndex = 13
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(495, 345)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 36)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Admin"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(26, 23)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(60, 23)
        Me.lblusername.TabIndex = 19
        Me.lblusername.Text = "USER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Event Management"
        '
        'manageevent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvevent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGoBack)
        Me.Name = "manageevent"
        Me.Text = "Event Planner"
        CType(Me.dgvevent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvevent As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents eventnamecol As DataGridViewTextBoxColumn
    Friend WithEvents eventdatecol As DataGridViewTextBoxColumn
    Friend WithEvents eventaddresscol As DataGridViewTextBoxColumn
    Friend WithEvents eventpaxcol As DataGridViewTextBoxColumn
    Friend WithEvents eventdesccol As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents Label3 As Label
End Class
