Option Strict On
Option Explicit On


Public Class Task

    Dim mDueDate As Date
    Dim mDateAssigned As Date
    Dim mTaskTitle As String
    Dim mAssignedTo As Short
    Dim mIsComplete As Boolean
    Dim mMinutes As Short
    Dim mTaskType As Short


    Private adapter As New _
        TaskProjectDataSetTableAdapters.Tasks_T__TableAdapter


    Public Property IsComplete As Boolean
        Get
            Return mIsComplete

        End Get
        Set(value As Boolean)
            mIsComplete = value
        End Set
    End Property

    Public Property DueDate As Date
        Get
            Return mDueDate

        End Get
        Set(value As Date)
            mDueDate = value
        End Set
    End Property

    Public Property DateAssigned As Date
        Get
            Return mDateAssigned
        End Get
        Set(value As Date)
            mDateAssigned = value

        End Set
    End Property

    Public Property TaskTitle As String
        Get
            Return mTaskTitle
        End Get
        Set(value As String)
            mTaskTitle = value
        End Set
    End Property

    Public Property AssignedTo As Short
        Get
            Return mAssignedTo
        End Get
        Set(value As Short)
            mAssignedTo = value
        End Set
    End Property


    'Property for how long the task is expected to take
    Public Property Minutes As Short
        Get
            Return mMinutes
        End Get
        Set(value As Short)
            mMinutes = value
        End Set
    End Property

    Public ReadOnly Property Tasks As DataTable
        Get
            Return adapter.GetData()

        End Get
    End Property


    Public Overrides Function ToString() As String

        Return mAssignedTo & ", " & mTaskTitle & ", " & mDateAssigned.ToString("d") & ", " & mDueDate.ToString("d")
    End Function

    'Public Sub New(ByVal pAssignedTo As Short, ByVal pDueDate As Date, ByVal pDateAssigned As Date,
    '               ByVal pTaskType As Short, ByVal pTaskTitle As String, ByVal pMinutes As Short)
    '    mAssignedTo = pAssignedTo
    '    mDateAssigned = pDateAssigned
    '    mTaskTitle = pTaskTitle
    '    mDueDate = pDueDate
    '    mMinutes = pMinutes
    '    mTaskType = pTaskType


    '    'Task completion is default set to False on creation
    '    mIsComplete = False

    'End Sub

    'Public Function GetByUserID(ByVal userId As Short) As DataTable
    '    Dim table As DataTable = adapter.GetData
    'End Function

    Public Function Insert(ByVal pCompletion As Boolean, ByVal pAssignedTo As Short,
                           ByVal pDueDate As Date, ByVal pDateAssigned As Date, ByVal pTaskType As Short,
                           ByVal pTaskTitle As String, ByVal pMinutes As Short) As Boolean
        Try
            adapter.Insert(pCompletion, pAssignedTo, pDueDate, pDateAssigned, pTaskType,
                           pTaskTitle, pMinutes)
            Return True


        Catch ex As Exception
            Return False
        End Try

    End Function




End Class
