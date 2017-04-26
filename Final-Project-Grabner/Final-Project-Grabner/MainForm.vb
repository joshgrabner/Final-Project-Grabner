Public Class MainForm
    Dim userList As List(Of String)




    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TaskProjectDataSet.Types_T' table. You can move, or remove it, as needed.
        Me.Types_TTableAdapter.Fill(Me.TaskProjectDataSet.Types_T)

        MessageBox.Show("Welcome to the task tracker")










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

    Private Sub cboDayWindow_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainPageFillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tasks_T__TableAdapter.MainPageFill(Me.TaskProjectDataSet._Tasks_T__)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class