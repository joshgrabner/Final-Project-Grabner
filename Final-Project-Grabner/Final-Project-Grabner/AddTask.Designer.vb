<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTask
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
        Me.components = New System.ComponentModel.Container()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radProject = New System.Windows.Forms.RadioButton()
        Me.radChore = New System.Windows.Forms.RadioButton()
        Me.radAppointment = New System.Windows.Forms.RadioButton()
        Me.radHomework = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpAssigned = New System.Windows.Forms.DateTimePicker()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.TaskProjectDataSet = New Final_Project_Grabner.TaskProjectDataSet()
        Me.UserTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblAssigned = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.User_TTableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.User_TTableAdapter()
        Me.Tasks_T__TableAdapter1 = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter()
        Me.lblTimeToComplete = New System.Windows.Forms.Label()
        Me.txtEstimateTime = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpType.SuspendLayout()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(122, 46)
        Me.txtTitle.MaxLength = 20
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(123, 20)
        Me.txtTitle.TabIndex = 25
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(39, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(77, 13)
        Me.lblTitle.TabIndex = 24
        Me.lblTitle.Text = "Name for Task"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radProject)
        Me.grpType.Controls.Add(Me.radChore)
        Me.grpType.Controls.Add(Me.radAppointment)
        Me.grpType.Controls.Add(Me.radHomework)
        Me.grpType.Location = New System.Drawing.Point(42, 152)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(203, 75)
        Me.grpType.TabIndex = 23
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
        Me.radHomework.Checked = True
        Me.radHomework.Location = New System.Drawing.Point(7, 20)
        Me.radHomework.Name = "radHomework"
        Me.radHomework.Size = New System.Drawing.Size(76, 17)
        Me.radHomework.TabIndex = 0
        Me.radHomework.TabStop = True
        Me.radHomework.Text = "Homework"
        Me.radHomework.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(174, 298)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(31, 298)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtpAssigned
        '
        Me.dtpAssigned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAssigned.Location = New System.Drawing.Point(139, 82)
        Me.dtpAssigned.Name = "dtpAssigned"
        Me.dtpAssigned.Size = New System.Drawing.Size(103, 20)
        Me.dtpAssigned.TabIndex = 20
        '
        'dtpDue
        '
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(139, 119)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(103, 20)
        Me.dtpDue.TabIndex = 19
        '
        'cboUser
        '
        Me.cboUser.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TaskProjectDataSet, "User_T.UserID", True))
        Me.cboUser.DataSource = Me.UserTBindingSource
        Me.cboUser.DisplayMember = "Name"
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(121, 10)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(124, 21)
        Me.cboUser.TabIndex = 17
        Me.cboUser.ValueMember = "UserID"
        '
        'TaskProjectDataSet
        '
        Me.TaskProjectDataSet.DataSetName = "TaskProjectDataSet"
        Me.TaskProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTBindingSource
        '
        Me.UserTBindingSource.DataMember = "User_T"
        Me.UserTBindingSource.DataSource = Me.TaskProjectDataSet
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(39, 126)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(53, 13)
        Me.lblDueDate.TabIndex = 15
        Me.lblDueDate.Text = "Due Date"
        '
        'lblAssigned
        '
        Me.lblAssigned.AutoSize = True
        Me.lblAssigned.Location = New System.Drawing.Point(39, 89)
        Me.lblAssigned.Name = "lblAssigned"
        Me.lblAssigned.Size = New System.Drawing.Size(76, 13)
        Me.lblAssigned.TabIndex = 14
        Me.lblAssigned.Text = "Date Assigned"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(39, 18)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(66, 13)
        Me.lblOwner.TabIndex = 13
        Me.lblOwner.Text = "Assigned To"
        '
        'User_TTableAdapter
        '
        Me.User_TTableAdapter.ClearBeforeFill = True
        '
        'Tasks_T__TableAdapter1
        '
        Me.Tasks_T__TableAdapter1.ClearBeforeFill = True
        '
        'lblTimeToComplete
        '
        Me.lblTimeToComplete.AutoSize = True
        Me.lblTimeToComplete.Location = New System.Drawing.Point(28, 247)
        Me.lblTimeToComplete.Name = "lblTimeToComplete"
        Me.lblTimeToComplete.Size = New System.Drawing.Size(217, 13)
        Me.lblTimeToComplete.TabIndex = 26
        Me.lblTimeToComplete.Text = "Estimated minutes required to complete task "
        '
        'txtEstimateTime
        '
        Me.txtEstimateTime.Location = New System.Drawing.Point(46, 272)
        Me.txtEstimateTime.MaxLength = 3
        Me.txtEstimateTime.Name = "txtEstimateTime"
        Me.txtEstimateTime.Size = New System.Drawing.Size(196, 20)
        Me.txtEstimateTime.TabIndex = 27
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 341)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(267, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'AddTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(267, 363)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtEstimateTime)
        Me.Controls.Add(Me.lblTimeToComplete)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpAssigned)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblAssigned)
        Me.Controls.Add(Me.lblOwner)
        Me.Name = "AddTask"
        Me.Text = "AddTask"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radProject As RadioButton
    Friend WithEvents radChore As RadioButton
    Friend WithEvents radAppointment As RadioButton
    Friend WithEvents radHomework As RadioButton
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtpAssigned As DateTimePicker
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblAssigned As Label
    Friend WithEvents lblOwner As Label
    Friend WithEvents TaskProjectDataSet As TaskProjectDataSet
    Friend WithEvents UserTBindingSource As BindingSource
    Friend WithEvents User_TTableAdapter As TaskProjectDataSetTableAdapters.User_TTableAdapter
    Friend WithEvents Tasks_T__TableAdapter1 As TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter
    Friend WithEvents lblTimeToComplete As Label
    Friend WithEvents txtEstimateTime As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
