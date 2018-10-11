Imports System.ComponentModel
Public Class Cinema

#Region "Private Variables"

#End Region

#Region "Public Properties"
    Public Property Name As String
    Public Property Address As String
    Public Property ID As Integer
    Public Property ShowTimes As BindingList(Of ShowTime)
#End Region

#Region "Methods"
    Public Sub New(aName As String, aAddress As String, aID As Integer, aShowTimes As ShowTime)
        Name = aName
        Address = aAddress
        ID = aID
        ShowTimes = aShowTimes
    End Sub
#End Region

End Class
