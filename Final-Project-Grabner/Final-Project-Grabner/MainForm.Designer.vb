<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mnuTaskCalendar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTaskUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWindow = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTaskAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTaskView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileAddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dgvTaskLook = New System.Windows.Forms.DataGridView()
        Me.TasksTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaskProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaskProjectDataSet = New Final_Project_Grabner.TaskProjectDataSet()
        Me.Tasks_T__TableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter()
        Me.TypesTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Types_TTableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.Types_TTableAdapter()
        Me.TypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainPageFillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MainPageFillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvTaskLook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypesTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPageFillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 413)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(539, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mnuTaskCalendar
        '
        Me.mnuTaskCalendar.Name = "mnuTaskCalendar"
        Me.mnuTaskCalendar.Size = New System.Drawing.Size(138, 22)
        Me.mnuTaskCalendar.Text = "Calendar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(135, 6)
        '
        'mnuTaskUpdate
        '
        Me.mnuTaskUpdate.Name = "mnuTaskUpdate"
        Me.mnuTaskUpdate.Size = New System.Drawing.Size(138, 22)
        Me.mnuTaskUpdate.Text = "Update Task"
        '
        'lblWindow
        '
        Me.lblWindow.AutoSize = True
        Me.lblWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindow.Location = New System.Drawing.Point(143, 82)
        Me.lblWindow.Name = "lblWindow"
        Me.lblWindow.Size = New System.Drawing.Size(160, 20)
        Me.lblWindow.TabIndex = 11
        Me.lblWindow.Text = "What's Due Today!"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'mnuTaskAdd
        '
        Me.mnuTaskAdd.Name = "mnuTaskAdd"
        Me.mnuTaskAdd.Size = New System.Drawing.Size(138, 22)
        Me.mnuTaskAdd.Text = "Add Task"
        '
        'mnuTask
        '
        Me.mnuTask.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTaskAdd, Me.mnuTaskView, Me.ToolStripSeparator2, Me.mnuTaskUpdate, Me.ToolStripSeparator3, Me.mnuTaskCalendar})
        Me.mnuTask.Name = "mnuTask"
        Me.mnuTask.Size = New System.Drawing.Size(47, 20)
        Me.mnuTask.Text = "Tasks"
        '
        'mnuTaskView
        '
        Me.mnuTaskView.Name = "mnuTaskView"
        Me.mnuTaskView.Size = New System.Drawing.Size(138, 22)
        Me.mnuTaskView.Text = "View Task"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(122, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(119, 6)
        '
        'mnuFileAbout
        '
        Me.mnuFileAbout.Name = "mnuFileAbout"
        Me.mnuFileAbout.Size = New System.Drawing.Size(122, 22)
        Me.mnuFileAbout.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(119, 6)
        '
        'mnuFileAddUser
        '
        Me.mnuFileAddUser.Name = "mnuFileAddUser"
        Me.mnuFileAddUser.Size = New System.Drawing.Size(122, 22)
        Me.mnuFileAddUser.Text = "Add User"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAddUser, Me.ToolStripSeparator1, Me.mnuFileAbout, Me.ToolStripSeparator4, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTask})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(539, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'dgvTaskLook
        '
        Me.dgvTaskLook.AllowUserToAddRows = False
        Me.dgvTaskLook.AllowUserToDeleteRows = False
        Me.dgvTaskLook.AutoGenerateColumns = False
        Me.dgvTaskLook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskLook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeIDDataGridViewTextBoxColumn, Me.TaskTypeDataGridViewTextBoxColumn})
        Me.dgvTaskLook.DataSource = Me.TypesTBindingSource
        Me.dgvTaskLook.Location = New System.Drawing.Point(0, 153)
        Me.dgvTaskLook.Name = "dgvTaskLook"
        Me.dgvTaskLook.ReadOnly = True
        Me.dgvTaskLook.Size = New System.Drawing.Size(508, 240)
        Me.dgvTaskLook.TabIndex = 13
        '
        'TasksTBindingSource
        '
        Me.TasksTBindingSource.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource.DataSource = Me.TaskProjectDataSetBindingSource
        '
        'TasksTBindingSource1
        '
        Me.TasksTBindingSource1.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource1.DataSource = Me.TaskProjectDataSetBindingSource
        '
        'TasksTBindingSource2
        '
        Me.TasksTBindingSource2.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource2.DataSource = Me.TaskProjectDataSetBindingSource
        '
        'TaskProjectDataSetBindingSource
        '
        Me.TaskProjectDataSetBindingSource.DataSource = Me.TaskProjectDataSet
        Me.TaskProjectDataSetBindingSource.Position = 0
        '
        'TaskProjectDataSet
        '
        Me.TaskProjectDataSet.DataSetName = "TaskProjectDataSet"
        Me.TaskProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tasks_T__TableAdapter
        '
        Me.Tasks_T__TableAdapter.ClearBeforeFill = True
        '
        'TypesTBindingSource
        '
        Me.TypesTBindingSource.DataMember = "Types_T"
        Me.TypesTBindingSource.DataSource = Me.TaskProjectDataSetBindingSource
        '
        'Types_TTableAdapter
        '
        Me.Types_TTableAdapter.ClearBeforeFill = True
        '
        'TypeIDDataGridViewTextBoxColumn
        '
        Me.TypeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.HeaderText = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.Name = "TypeIDDataGridViewTextBoxColumn"
        Me.TypeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaskTypeDataGridViewTextBoxColumn
        '
        Me.TaskTypeDataGridViewTextBoxColumn.DataPropertyName = "TaskType"
        Me.TaskTypeDataGridViewTextBoxColumn.HeaderText = "TaskType"
        Me.TaskTypeDataGridViewTextBoxColumn.Name = "TaskTypeDataGridViewTextBoxColumn"
        Me.TaskTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MainPageFillToolStripButton
        '
        Me.MainPageFillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MainPageFillToolStripButton.Name = "MainPageFillToolStripButton"
        Me.MainPageFillToolStripButton.Size = New System.Drawing.Size(79, 22)
        Me.MainPageFillToolStripButton.Text = "MainPageFill"
        '
        'MainPageFillToolStrip
        '
        Me.MainPageFillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainPageFillToolStripButton})
        Me.MainPageFillToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.MainPageFillToolStrip.Name = "MainPageFillToolStrip"
        Me.MainPageFillToolStrip.Size = New System.Drawing.Size(539, 25)
        Me.MainPageFillToolStrip.TabIndex = 14
        Me.MainPageFillToolStrip.Text = "MainPageFillToolStrip"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 435)
        Me.Controls.Add(Me.MainPageFillToolStrip)
        Me.Controls.Add(Me.dgvTaskLook)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblWindow)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvTaskLook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypesTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPageFillToolStrip.ResumeLayout(False)
        Me.MainPageFillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents mnuTaskCalendar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuTaskUpdate As ToolStripMenuItem
    Friend WithEvents lblWindow As Label
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuTaskAdd As ToolStripMenuItem
    Friend WithEvents mnuTask As ToolStripMenuItem
    Friend WithEvents mnuTaskView As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuFileAbout As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuFileAddUser As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents dgvTaskLook As DataGridView
    Friend WithEvents TaskProjectDataSetBindingSource As BindingSource
    Friend WithEvents TaskProjectDataSet As TaskProjectDataSet
    Friend WithEvents TasksTBindingSource As BindingSource
    Friend WithEvents Tasks_T__TableAdapter As TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter
    Friend WithEvents TasksTBindingSource1 As BindingSource
    Friend WithEvents TasksTBindingSource2 As BindingSource
    Friend WithEvents TypesTBindingSource As BindingSource
    Friend WithEvents Types_TTableAdapter As TaskProjectDataSetTableAdapters.Types_TTableAdapter
    Friend WithEvents TypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MainPageFillToolStripButton As ToolStripButton
    Friend WithEvents MainPageFillToolStrip As ToolStrip
End Class
