<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUser
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.TaskProjectDataSet = New Final_Project_Grabner.TaskProjectDataSet()
        Me.UserTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_TTableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.User_TTableAdapter()
        Me.CompletedTasksTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompletedTasks_TTableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.CompletedTasks_TTableAdapter()
        Me.TaskIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedTasksTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskIdDataGridViewTextBoxColumn, Me.UserIdDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CompletedTasksTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(397, 219)
        Me.DataGridView1.TabIndex = 0
        '
        'cboUsers
        '
        Me.cboUsers.DataSource = Me.UserTBindingSource
        Me.cboUsers.DisplayMember = "Name"
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(12, 29)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(121, 21)
        Me.cboUsers.TabIndex = 1
        Me.cboUsers.ValueMember = "UserID"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(13, 13)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(71, 13)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Select a User"
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
        'User_TTableAdapter
        '
        Me.User_TTableAdapter.ClearBeforeFill = True
        '
        'CompletedTasksTBindingSource
        '
        Me.CompletedTasksTBindingSource.DataMember = "CompletedTasks_T"
        Me.CompletedTasksTBindingSource.DataSource = Me.TaskProjectDataSet
        '
        'CompletedTasks_TTableAdapter
        '
        Me.CompletedTasks_TTableAdapter.ClearBeforeFill = True
        '
        'TaskIdDataGridViewTextBoxColumn
        '
        Me.TaskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId"
        Me.TaskIdDataGridViewTextBoxColumn.HeaderText = "TaskId"
        Me.TaskIdDataGridViewTextBoxColumn.Name = "TaskIdDataGridViewTextBoxColumn"
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'AboutUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 310)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.cboUsers)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AboutUser"
        Me.Text = "User Stats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedTasksTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cboUsers As ComboBox
    Friend WithEvents lblUser As Label
    Friend WithEvents TaskProjectDataSet As TaskProjectDataSet
    Friend WithEvents UserTBindingSource As BindingSource
    Friend WithEvents User_TTableAdapter As TaskProjectDataSetTableAdapters.User_TTableAdapter
    Friend WithEvents CompletedTasksTBindingSource As BindingSource
    Friend WithEvents CompletedTasks_TTableAdapter As TaskProjectDataSetTableAdapters.CompletedTasks_TTableAdapter
    Friend WithEvents TaskIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
