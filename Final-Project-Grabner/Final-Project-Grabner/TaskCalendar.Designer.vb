<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskCalendar
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
        Me.dgvCalendar = New System.Windows.Forms.DataGridView()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cal = New System.Windows.Forms.MonthCalendar()
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCalendar
        '
        Me.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalendar.Location = New System.Drawing.Point(12, 192)
        Me.dgvCalendar.Name = "dgvCalendar"
        Me.dgvCalendar.Size = New System.Drawing.Size(491, 285)
        Me.dgvCalendar.TabIndex = 0
        '
        'cboUser
        '
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(37, 58)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(121, 21)
        Me.cboUser.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(51, 18)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(71, 13)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Select a User"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(186, 505)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close Calendar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cal
        '
        Me.cal.Location = New System.Drawing.Point(276, 18)
        Me.cal.Name = "cal"
        Me.cal.TabIndex = 4
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 555)
        Me.Controls.Add(Me.cal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.dgvCalendar)
        Me.Name = "Calendar"
        Me.Text = "Calendar"
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCalendar As DataGridView
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents lblUser As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents cal As MonthCalendar
End Class
