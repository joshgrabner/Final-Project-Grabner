<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTask
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
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblAssigned = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.dtpAssigned = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(31, 20)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(66, 13)
        Me.lblOwner.TabIndex = 0
        Me.lblOwner.Text = "Assigned To"
        '
        'lblAssigned
        '
        Me.lblAssigned.AutoSize = True
        Me.lblAssigned.Location = New System.Drawing.Point(31, 67)
        Me.lblAssigned.Name = "lblAssigned"
        Me.lblAssigned.Size = New System.Drawing.Size(76, 13)
        Me.lblAssigned.TabIndex = 1
        Me.lblAssigned.Text = "Date Assigned"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(31, 104)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(53, 13)
        Me.lblDueDate.TabIndex = 2
        Me.lblDueDate.Text = "Due Date"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(81, 149)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(99, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description of Task"
        '
        'cboUser
        '
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(113, 12)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(121, 21)
        Me.cboUser.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 165)
        Me.TextBox1.MaximumSize = New System.Drawing.Size(200, 150)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 150)
        Me.TextBox1.TabIndex = 5
        '
        'dtpDue
        '
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(131, 97)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(103, 20)
        Me.dtpDue.TabIndex = 6
        '
        'dtpAssigned
        '
        Me.dtpAssigned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAssigned.Location = New System.Drawing.Point(131, 60)
        Me.dtpAssigned.Name = "dtpAssigned"
        Me.dtpAssigned.Size = New System.Drawing.Size(103, 20)
        Me.dtpAssigned.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(34, 330)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(159, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'UpdateTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 377)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpAssigned)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblAssigned)
        Me.Controls.Add(Me.lblOwner)
        Me.Name = "UpdateTask"
        Me.Text = "UpdateTask"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOwner As Label
    Friend WithEvents lblAssigned As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents dtpAssigned As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
