Option Strict On
Option Explicit On

Public Class AddTask
    Private mTaskType As Short
    Dim mUserID As Short
    Private mTime As Short
    Private mTask As New Task






    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub



    Private Sub txtEstimateTime_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TaskProjectDataSet.User_T' table. 
        'You can move, Or remove it, as needed.
        Me.User_TTableAdapter.Fill(Me.TaskProjectDataSet.User_T)
        txtTitle.Clear()
        txtEstimateTime.Clear()
        dtpAssigned.Value = DateTime.Today
        dtpDue.Value = DateTime.Today






    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        mTime = CShort(txtEstimateTime.Text)

        If mTask.Insert(False, mUserID, dtpDue.Value.Date, dtpAssigned.Value.Date,
                        mTaskType, txtTitle.Text, mTime) Then
            Me.Close()
        Else
            lblStatus.Text = "Cannot Add Task"
        End If
    End Sub

    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged
        mUserID = CShort(cboUser.SelectedValue)
    End Sub

    Private Sub radHomework_CheckedChanged(sender As Object, e As EventArgs) Handles radHomework.CheckedChanged
        If radHomework.Checked Then
            mTaskType = 1

        End If
    End Sub

    Private Sub radChore_CheckedChanged(sender As Object, e As EventArgs) Handles radChore.CheckedChanged
        If radChore.Checked Then
            mTaskType = 3

        End If
    End Sub

    Private Sub radAppointment_CheckedChanged(sender As Object, e As EventArgs) Handles radAppointment.CheckedChanged
        If radAppointment.Checked Then
            mTaskType = 2
        End If
    End Sub

    Private Sub radProject_CheckedChanged(sender As Object, e As EventArgs) Handles radProject.CheckedChanged
        If radProject.Checked Then
            mTaskType = 4
        End If
    End Sub






End Class