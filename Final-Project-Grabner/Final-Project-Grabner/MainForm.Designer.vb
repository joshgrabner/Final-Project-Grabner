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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboUsers = New System.Windows.Forms.ToolStripComboBox()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTaskAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileAddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTaskView = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboDayWindow = New System.Windows.Forms.ComboBox()
        Me.lblWindow = New System.Windows.Forms.Label()
        Me.lblSelectExplainer = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTaskUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTaskCalendar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuTask, Me.cboUsers})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(519, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 381)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAddUser, Me.ToolStripSeparator1, Me.mnuFileAbout, Me.ToolStripSeparator4, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 23)
        Me.mnuFile.Text = "File"
        '
        'mnuTask
        '
        Me.mnuTask.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTaskAdd, Me.mnuTaskView, Me.ToolStripSeparator2, Me.mnuTaskUpdate, Me.ToolStripSeparator3, Me.mnuTaskCalendar})
        Me.mnuTask.Name = "mnuTask"
        Me.mnuTask.Size = New System.Drawing.Size(47, 23)
        Me.mnuTask.Text = "Tasks"
        '
        'cboUsers
        '
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(121, 23)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuTaskAdd
        '
        Me.mnuTaskAdd.Name = "mnuTaskAdd"
        Me.mnuTaskAdd.Size = New System.Drawing.Size(152, 22)
        Me.mnuTaskAdd.Text = "Add Task"
        '
        'mnuFileAddUser
        '
        Me.mnuFileAddUser.Name = "mnuFileAddUser"
        Me.mnuFileAddUser.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileAddUser.Text = "Add User"
        '
        'mnuTaskView
        '
        Me.mnuTaskView.Name = "mnuTaskView"
        Me.mnuTaskView.Size = New System.Drawing.Size(152, 22)
        Me.mnuTaskView.Text = "View Task"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(519, 259)
        Me.DataGridView1.TabIndex = 2
        '
        'cboDayWindow
        '
        Me.cboDayWindow.FormattingEnabled = True
        Me.cboDayWindow.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboDayWindow.Location = New System.Drawing.Point(365, 81)
        Me.cboDayWindow.Name = "cboDayWindow"
        Me.cboDayWindow.Size = New System.Drawing.Size(121, 21)
        Me.cboDayWindow.TabIndex = 4
        '
        'lblWindow
        '
        Me.lblWindow.AutoSize = True
        Me.lblWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindow.Location = New System.Drawing.Point(143, 82)
        Me.lblWindow.Name = "lblWindow"
        Me.lblWindow.Size = New System.Drawing.Size(158, 20)
        Me.lblWindow.TabIndex = 5
        Me.lblWindow.Text = "Three Day Outlook"
        '
        'lblSelectExplainer
        '
        Me.lblSelectExplainer.AutoSize = True
        Me.lblSelectExplainer.Location = New System.Drawing.Point(315, 54)
        Me.lblSelectExplainer.Name = "lblSelectExplainer"
        Me.lblSelectExplainer.Size = New System.Drawing.Size(204, 13)
        Me.lblSelectExplainer.TabIndex = 6
        Me.lblSelectExplainer.Text = "Choose the number of days to look ahead"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuTaskUpdate
        '
        Me.mnuTaskUpdate.Name = "mnuTaskUpdate"
        Me.mnuTaskUpdate.Size = New System.Drawing.Size(152, 22)
        Me.mnuTaskUpdate.Text = "Update Task"
        '
        'mnuTaskCalendar
        '
        Me.mnuTaskCalendar.Name = "mnuTaskCalendar"
        Me.mnuTaskCalendar.Size = New System.Drawing.Size(152, 22)
        Me.mnuTaskCalendar.Text = "Calendar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFileAbout
        '
        Me.mnuFileAbout.Name = "mnuFileAbout"
        Me.mnuFileAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileAbout.Text = "About"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 403)
        Me.Controls.Add(Me.lblSelectExplainer)
        Me.Controls.Add(Me.lblWindow)
        Me.Controls.Add(Me.cboDayWindow)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = " Task Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuTask As ToolStripMenuItem
    Friend WithEvents cboUsers As ToolStripComboBox
    Friend WithEvents mnuFileAddUser As ToolStripMenuItem
    Friend WithEvents mnuTaskAdd As ToolStripMenuItem
    Friend WithEvents mnuTaskView As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cboDayWindow As ComboBox
    Friend WithEvents lblWindow As Label
    Friend WithEvents lblSelectExplainer As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuTaskUpdate As ToolStripMenuItem
    Friend WithEvents mnuFileAbout As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuTaskCalendar As ToolStripMenuItem
End Class
