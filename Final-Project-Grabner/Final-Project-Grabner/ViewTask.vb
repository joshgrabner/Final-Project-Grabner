﻿Option Strict On
Option Explicit On

Public Class ViewTask
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ViewTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TaskProjectDataSet.CompletedTasks_T' table. You can move, or remove it, as needed.
        Me.CompletedTasks_TTableAdapter.Fill(Me.TaskProjectDataSet.CompletedTasks_T)
        'TODO: This line of code loads data into the 'TaskProjectDataSet.User_T' table. You can move, or remove it, as needed.
        ' Me.User_TTableAdapter.Fill(Me.TaskProjectDataSet.User_T)
        'TODO: This line of code loads data into the 'TaskProjectDataSet._Tasks_T__' table. You can move, or remove it, as needed.
        ' Me.Tasks_T__TableAdapter.Fill(Me.TaskProjectDataSet._Tasks_T__)


    End Sub

    Private Sub txtEstimateTime_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class