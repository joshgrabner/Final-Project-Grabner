﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTask
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radProject = New System.Windows.Forms.RadioButton()
        Me.radChore = New System.Windows.Forms.RadioButton()
        Me.radAppointment = New System.Windows.Forms.RadioButton()
        Me.radHomework = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dtpAssigned = New System.Windows.Forms.DateTimePicker()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.UserTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaskProjectDataSet = New Final_Project_Grabner.TaskProjectDataSet()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblAssigned = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.TasksTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKUSersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tasks_T__TableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter()
        Me.User_TTableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.User_TTableAdapter()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.grpType.SuspendLayout()
        CType(Me.UserTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKUSersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(122, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 20)
        Me.TextBox2.TabIndex = 38
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(39, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(77, 13)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "Name for Task"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radProject)
        Me.grpType.Controls.Add(Me.radChore)
        Me.grpType.Controls.Add(Me.radAppointment)
        Me.grpType.Controls.Add(Me.radHomework)
        Me.grpType.Enabled = False
        Me.grpType.Location = New System.Drawing.Point(42, 155)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(203, 75)
        Me.grpType.TabIndex = 36
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(170, 414)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(45, 414)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dtpAssigned
        '
        Me.dtpAssigned.Enabled = False
        Me.dtpAssigned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAssigned.Location = New System.Drawing.Point(139, 85)
        Me.dtpAssigned.Name = "dtpAssigned"
        Me.dtpAssigned.Size = New System.Drawing.Size(103, 20)
        Me.dtpAssigned.TabIndex = 33
        '
        'dtpDue
        '
        Me.dtpDue.Enabled = False
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(139, 122)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(103, 20)
        Me.dtpDue.TabIndex = 32
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(45, 249)
        Me.txtDescription.MaximumSize = New System.Drawing.Size(200, 150)
        Me.txtDescription.MinimumSize = New System.Drawing.Size(200, 150)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 20)
        Me.txtDescription.TabIndex = 31
        '
        'cboUser
        '
        Me.cboUser.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UserTBindingSource, "UserID", True))
        Me.cboUser.DataSource = Me.UserTBindingSource
        Me.cboUser.DisplayMember = "Name"
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(121, 13)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(121, 21)
        Me.cboUser.TabIndex = 30
        Me.cboUser.ValueMember = "UserID"
        '
        'UserTBindingSource
        '
        Me.UserTBindingSource.DataMember = "User_T"
        Me.UserTBindingSource.DataSource = Me.TaskProjectDataSet
        '
        'TaskProjectDataSet
        '
        Me.TaskProjectDataSet.DataSetName = "TaskProjectDataSet"
        Me.TaskProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(92, 233)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(99, 13)
        Me.lblDescription.TabIndex = 29
        Me.lblDescription.Text = "Description of Task"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(39, 129)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(53, 13)
        Me.lblDueDate.TabIndex = 28
        Me.lblDueDate.Text = "Due Date"
        '
        'lblAssigned
        '
        Me.lblAssigned.AutoSize = True
        Me.lblAssigned.Location = New System.Drawing.Point(39, 92)
        Me.lblAssigned.Name = "lblAssigned"
        Me.lblAssigned.Size = New System.Drawing.Size(76, 13)
        Me.lblAssigned.TabIndex = 27
        Me.lblAssigned.Text = "Date Assigned"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(39, 21)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(66, 13)
        Me.lblOwner.TabIndex = 26
        Me.lblOwner.Text = "Assigned To"
        '
        'lstTasks
        '
        Me.lstTasks.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TasksTBindingSource, "Title", True))
        Me.lstTasks.DataSource = Me.FKUSersBindingSource
        Me.lstTasks.DisplayMember = "Title"
        Me.lstTasks.FormattingEnabled = True
        Me.lstTasks.Location = New System.Drawing.Point(328, 21)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(333, 407)
        Me.lstTasks.TabIndex = 39
        Me.lstTasks.ValueMember = "TaskID"
        '
        'TasksTBindingSource
        '
        Me.TasksTBindingSource.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource.DataSource = Me.TaskProjectDataSet
        '
        'FKUSersBindingSource
        '
        Me.FKUSersBindingSource.DataMember = "FK_USers"
        Me.FKUSersBindingSource.DataSource = Me.UserTBindingSource
        '
        'Tasks_T__TableAdapter
        '
        Me.Tasks_T__TableAdapter.ClearBeforeFill = True
        '
        'User_TTableAdapter
        '
        Me.User_TTableAdapter.ClearBeforeFill = True
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(49, 366)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(183, 23)
        Me.btnComplete.TabIndex = 40
        Me.btnComplete.Text = "Mark Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'ViewTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 450)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.lstTasks)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dtpAssigned)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblAssigned)
        Me.Controls.Add(Me.lblOwner)
        Me.Name = "ViewTask"
        Me.Text = "ViewTask"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.UserTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKUSersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radProject As RadioButton
    Friend WithEvents radChore As RadioButton
    Friend WithEvents radAppointment As RadioButton
    Friend WithEvents radHomework As RadioButton
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents dtpAssigned As DateTimePicker
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblAssigned As Label
    Friend WithEvents lblOwner As Label
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents TaskProjectDataSet As TaskProjectDataSet
    Friend WithEvents TasksTBindingSource As BindingSource
    Friend WithEvents Tasks_T__TableAdapter As TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter
    Friend WithEvents UserTBindingSource As BindingSource
    Friend WithEvents User_TTableAdapter As TaskProjectDataSetTableAdapters.User_TTableAdapter
    Friend WithEvents FKUSersBindingSource As BindingSource
    Friend WithEvents btnComplete As Button
End Class
