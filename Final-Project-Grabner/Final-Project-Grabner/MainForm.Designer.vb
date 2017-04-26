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
        Me.mnuTitleStrip = New System.Windows.Forms.MenuStrip()
        Me.TaskProjectDataSet = New Final_Project_Grabner.TaskProjectDataSet()
        Me.Tasks_T__TableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter()
        Me.TaskProjectDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypesTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaskProjectDataSet1 = New Final_Project_Grabner.TaskProjectDataSet()
        Me.dgvTaskLook = New System.Windows.Forms.DataGridView()
        Me.TasksTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypesTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Types_TTableAdapter = New Final_Project_Grabner.TaskProjectDataSetTableAdapters.Types_TTableAdapter()
        Me.TasksTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TasksTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.mnuTitleStrip.SuspendLayout()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskProjectDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypesTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTaskLook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypesTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TasksTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusStrip1.Size = New System.Drawing.Size(647, 22)
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
        Me.lblWindow.Location = New System.Drawing.Point(235, 24)
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
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFileAbout
        '
        Me.mnuFileAbout.Name = "mnuFileAbout"
        Me.mnuFileAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileAbout.Text = "View User"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFileAddUser
        '
        Me.mnuFileAddUser.Name = "mnuFileAddUser"
        Me.mnuFileAddUser.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileAddUser.Text = "Add User"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAddUser, Me.ToolStripSeparator1, Me.mnuFileAbout, Me.ToolStripSeparator4, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuTitleStrip
        '
        Me.mnuTitleStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTask})
        Me.mnuTitleStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuTitleStrip.Name = "mnuTitleStrip"
        Me.mnuTitleStrip.Size = New System.Drawing.Size(647, 24)
        Me.mnuTitleStrip.TabIndex = 7
        Me.mnuTitleStrip.Text = "MenuStrip1"
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
        'TaskProjectDataSetBindingSource1
        '
        Me.TaskProjectDataSetBindingSource1.DataSource = Me.TaskProjectDataSet
        Me.TaskProjectDataSetBindingSource1.Position = 0
        '
        'TaskProjectDataSet1
        '
        Me.TaskProjectDataSet1.DataSetName = "TaskProjectDataSet"
        Me.TaskProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvTaskLook
        '
        Me.dgvTaskLook.AllowUserToAddRows = False
        Me.dgvTaskLook.AllowUserToDeleteRows = False
        Me.dgvTaskLook.AutoGenerateColumns = False
        Me.dgvTaskLook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskLook.DataSource = Me.TaskProjectDataSet1
        Me.dgvTaskLook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTaskLook.Location = New System.Drawing.Point(0, 0)
        Me.dgvTaskLook.Name = "dgvTaskLook"
        Me.dgvTaskLook.ReadOnly = True
        Me.dgvTaskLook.Size = New System.Drawing.Size(642, 361)
        Me.dgvTaskLook.TabIndex = 12
        '
        'TasksTBindingSource1
        '
        Me.TasksTBindingSource1.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource1.DataSource = Me.TaskProjectDataSet
        '
        'TypesTBindingSource
        '
        Me.TypesTBindingSource.DataMember = "Types_T"
        Me.TypesTBindingSource.DataSource = Me.TaskProjectDataSet
        '
        'Types_TTableAdapter
        '
        Me.Types_TTableAdapter.ClearBeforeFill = True
        '
        'TasksTBindingSource
        '
        Me.TasksTBindingSource.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource.DataSource = Me.TaskProjectDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvTaskLook)
        Me.Panel1.Location = New System.Drawing.Point(4, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 361)
        Me.Panel1.TabIndex = 13
        '
        'TasksTBindingSource2
        '
        Me.TasksTBindingSource2.DataMember = "Tasks_T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TasksTBindingSource2.DataSource = Me.TaskProjectDataSet
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblWindow)
        Me.Controls.Add(Me.mnuTitleStrip)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuTitleStrip.ResumeLayout(False)
        Me.mnuTitleStrip.PerformLayout()
        CType(Me.TaskProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskProjectDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypesTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTaskLook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypesTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TasksTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mnuTitleStrip As MenuStrip
    Friend WithEvents TaskProjectDataSet As TaskProjectDataSet
    Friend WithEvents Tasks_T__TableAdapter As TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter
    Friend WithEvents TaskProjectDataSetBindingSource1 As BindingSource
    Friend WithEvents TypesTBindingSource1 As BindingSource
    Friend WithEvents TaskProjectDataSet1 As TaskProjectDataSet
    Friend WithEvents dgvTaskLook As DataGridView
    Friend WithEvents TypesTBindingSource As BindingSource
    Friend WithEvents Types_TTableAdapter As TaskProjectDataSetTableAdapters.Types_TTableAdapter
    Friend WithEvents TasksTBindingSource1 As BindingSource
    Friend WithEvents TasksTBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TasksTBindingSource2 As BindingSource
End Class
