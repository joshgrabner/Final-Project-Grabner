Option Strict On
Option Explicit On

Public Class AddTask
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub



    Private Sub txtEstimateTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstimateTime.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TaskProjectDataSet.User_T' table. You can move, or remove it, as needed.
        Me.User_TTableAdapter.Fill(Me.TaskProjectDataSet.User_T)

    End Sub
End Class