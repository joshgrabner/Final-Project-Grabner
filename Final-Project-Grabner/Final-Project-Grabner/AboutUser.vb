Public Class AboutUser
    Private Sub AboutUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TaskProjectDataSet.CompletedTasks_T' table. You can move, or remove it, as needed.
        Me.CompletedTasks_TTableAdapter.Fill(Me.TaskProjectDataSet.CompletedTasks_T)
        'TODO: This line of code loads data into the 'TaskProjectDataSet.User_T' table. You can move, or remove it, as needed.
        Me.User_TTableAdapter.Fill(Me.TaskProjectDataSet.User_T)

    End Sub
End Class