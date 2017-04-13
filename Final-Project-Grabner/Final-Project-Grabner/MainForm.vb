Option Strict On
Option Explicit On

Imports System.IO


Public Class MainForm
    Dim userList As List(Of String)




    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to the task tracker")

        cboDayWindow.SelectedItem = "3"





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
        TaskCalendar.ShowDialog()
    End Sub
End Class
