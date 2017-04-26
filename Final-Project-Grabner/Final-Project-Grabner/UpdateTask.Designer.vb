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
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.dtpAssigned = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radProject = New System.Windows.Forms.RadioButton()
        Me.radChore = New System.Windows.Forms.RadioButton()
        Me.radAppointment = New System.Windows.Forms.RadioButton()
        Me.radHomework = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtEstimateTime = New System.Windows.Forms.TextBox()
        Me.lblTimeToComplete = New System.Windows.Forms.Label()
        Me.grpType.SuspendLayout()
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
        Me.lblAssigned.Location = New System.Drawing.Point(31, 91)
        Me.lblAssigned.Name = "lblAssigned"
        Me.lblAssigned.Size = New System.Drawing.Size(76, 13)
        Me.lblAssigned.TabIndex = 1
        Me.lblAssigned.Text = "Date Assigned"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(31, 128)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(53, 13)
        Me.lblDueDate.TabIndex = 2
        Me.lblDueDate.Text = "Due Date"
        '
        'cboUser
        '
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(113, 12)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(121, 21)
        Me.cboUser.TabIndex = 4
        '
        'dtpDue
        '
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(131, 121)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(103, 20)
        Me.dtpDue.TabIndex = 6
        '
        'dtpAssigned
        '
        Me.dtpAssigned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAssigned.Location = New System.Drawing.Point(131, 84)
        Me.dtpAssigned.Name = "dtpAssigned"
        Me.dtpAssigned.Size = New System.Drawing.Size(103, 20)
        Me.dtpAssigned.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(37, 413)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(162, 413)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radProject)
        Me.grpType.Controls.Add(Me.radChore)
        Me.grpType.Controls.Add(Me.radAppointment)
        Me.grpType.Controls.Add(Me.radHomework)
        Me.grpType.Location = New System.Drawing.Point(34, 154)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(203, 75)
        Me.grpType.TabIndex = 10
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type of Task"
        '
        'radProject
        '
        Me.radProject.AutoSize = True
        Me.radProject.Location = New System.Drawing.Point(132, 44)
        Me.radProject.Name = "radProject"
        Me.radProject.Size = New System.Drawing.Size(58, 17)
        Me.radProject.TabIndex = 3
        Me.radProject.TabStop = True
        Me.radProject.Text = "Project"
        Me.radProject.UseVisualStyleBackColor = True
        '
        'radChore
        '
        Me.radChore.AutoSize = True
        Me.radChore.Location = New System.Drawing.Point(132, 19)
        Me.radChore.Name = "radChore"
        Me.radChore.Size = New System.Drawing.Size(53, 17)
        Me.radChore.TabIndex = 2
        Me.radChore.TabStop = True
        Me.radChore.Text = "Chore"
        Me.radChore.UseVisualStyleBackColor = True
        '
        'radAppointment
        '
        Me.radAppointment.AutoSize = True
        Me.radAppointment.Location = New System.Drawing.Point(7, 44)
        Me.radAppointment.Name = "radAppointment"
        Me.radAppointment.Size = New System.Drawing.Size(84, 17)
        Me.radAppointment.TabIndex = 1
        Me.radAppointment.TabStop = True
        Me.radAppointment.Text = "Appointment"
        Me.radAppointment.UseVisualStyleBackColor = True
        '
        'radHomework
        '
        Me.radHomework.AutoSize = True
        Me.radHomework.Location = New System.Drawing.Point(7, 20)
        Me.radHomework.Name = "radHomework"
        Me.radHomework.Size = New System.Drawing.Size(76, 17)
        Me.radHomework.TabIndex = 0
        Me.radHomework.TabStop = True
        Me.radHomework.Text = "Homework"
        Me.radHomework.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(31, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(77, 13)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Name for Task"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 20)
        Me.TextBox2.TabIndex = 12
        '
        'txtEstimateTime
        '
        Me.txtEstimateTime.Location = New System.Drawing.Point(49, 285)
        Me.txtEstimateTime.MaxLength = 3
        Me.txtEstimateTime.Name = "txtEstimateTime"
        Me.txtEstimateTime.Size = New System.Drawing.Size(196, 20)
        Me.txtEstimateTime.TabIndex = 29
        '
        'lblTimeToComplete
        '
        Me.lblTimeToComplete.AutoSize = True
        Me.lblTimeToComplete.Location = New System.Drawing.Point(31, 260)
        Me.lblTimeToComplete.Name = "lblTimeToComplete"
        Me.lblTimeToComplete.Size = New System.Drawing.Size(217, 13)
        Me.lblTimeToComplete.TabIndex = 28
        Me.lblTimeToComplete.Text = "Estimated minutes required to complete task "
        '
        'UpdateTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 453)
        Me.Controls.Add(Me.txtEstimateTime)
        Me.Controls.Add(Me.lblTimeToComplete)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpAssigned)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblAssigned)
        Me.Controls.Add(Me.lblOwner)
        Me.Name = "UpdateTask"
        Me.Text = "Update a Task"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOwner As Label
    Friend WithEvents lblAssigned As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents dtpAssigned As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radProject As RadioButton
    Friend WithEvents radChore As RadioButton
    Friend WithEvents radAppointment As RadioButton
    Friend WithEvents radHomework As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtEstimateTime As TextBox
    Friend WithEvents lblTimeToComplete As Label
End Class
