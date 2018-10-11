Imports System.ComponentModel
Public Class User

#Region "Private Variables"
    Private sPassword As String
#End Region

#Region "Public Properties"
    Public Property Email As String
    Public Property Name As String
    Public Property Surname As String
    Public Property Bookings As BindingList(Of Booking)
#End Region

#Region "Methods"
    Public Sub New()
        Email = ""
        Name = ""
        Surname = ""
        sPassword = ""
        Bookings = New BindingList(Of Booking)
    End Sub

    Public Sub New(aEmail As String, aName As String, aSurname As String, aPassword As String)
        Email = aEmail
        Name = aName
        Surname = aSurname
        sPassword = aPassword
        Bookings = New BindingList(Of Booking)
    End Sub

    Public Function CheckLogin(aPassword As String)
        Return aPassword = sPassword
    End Function
#End Region

End Class