Public Class MainForm
    Dim userList As List(Of String)




    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TaskProjectDataSet._Tasks_T__' table. You can move, or remove it, as needed.
        ' Me.Tasks_T__TableAdapter.Fill(Me.TaskProjectDataSet._Tasks_T__)
        'TODO: This line of code loads data into the 'TaskProjectDataSet._Tasks_T__' table. You can move, or remove it, as needed.
        'Me.Tasks_T__TableAdapter.Fill(Me.TaskProjectDataSet._Tasks_T__)
        'TODO: This line of code loads data into the 'FinalProjectDatabaseDataSet.InProgress' table. You can move, or remove it, as needed.
        'Me.InProgressTableAdapter.Fill(Me.FinalProjectDatabaseDataSet.InProgress)
        MessageBox.Show("Welcome to the task tracker")

        ' dgvTaskLook.DataSource =






    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()

    End Sub

    Private Sub mnuTaskUpdate_Click(sender As Object, e As EventArgs) Handles mnuTaskUpdate.Click
        UpdateTask.ShowDialog()

    End Sub

    Private Sub mnuTaskAdd_Click(sender As Object, e As EventArgs) Handles mnuTaskAdd.Click
        AddTask.ShowDialog()

    End Sub

    Private Sub mnuTaskView_Click(sender As Object, e As EventArgs) Handles mnuTaskView.Click
        ViewTask.ShowDialog()

    End Sub

    Private Sub mnuTaskCalendar_Click(sender As Object, e As EventArgs) Handles mnuTaskCalendar.Click
        'TaskCalendar.ShowDialog()
    End Sub

    Private Sub cboDayWindow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDayWindow.SelectedIndexChanged

    End Sub
End Class