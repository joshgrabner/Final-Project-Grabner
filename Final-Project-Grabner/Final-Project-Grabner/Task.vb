Option Strict On
Option Explicit On


Public Class Task

    Dim mDueDate As Date
    Dim mDateAssigned As Date
    Dim mTaskTitle As String
    Dim mAssignedTo As String
    Dim mIsComplete As Boolean



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

    Public Property AssignedTo As String
        Get
            Return mAssignedTo
        End Get
        Set(value As String)
            mAssignedTo = value
        End Set
    End Property

    Public Overrides Function ToString() As String

        Return mAssignedTo & ", " & mTaskTitle & ", " & mDateAssigned.ToString("d") & ", " & mDueDate.ToString("d")
    End Function

    Public Sub New(ByVal pAssignedTo As String, ByVal pTaskTitle As String, ByVal pDueDate As Date, ByVal pDateAssigned As Date)
        mAssignedTo = pAssignedTo
        mDateAssigned = pDateAssigned
        mTaskTitle = pTaskTitle
        mDueDate = pDueDate

    End Sub

End Class
