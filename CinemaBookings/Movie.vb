Imports System.ComponentModel
Public Class Movie
#Region "Private Variables"
    Private sName, sGenre, sID As String
#End Region

#Region "Public Properties"
    Public Property Name As String
        Get
            Return sName
        End Get
        Set(value As String)
            sName = value
        End Set
    End Property

    Public Property Genre As String
        Get
            Return sGenre
        End Get
        Set(value As String)
            sGenre = value
        End Set
    End Property

    Public Property ID As String
        Get
            Return sID
        End Get
        Set(value As String)
            sID = value
        End Set
    End Property

    Public Property Shows As BindingList(Of ShowTime)
#End Region
End Class
