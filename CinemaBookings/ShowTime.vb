Public Class ShowTime
#Region "Private Variables"
    Private dtShow As DateTime
    Private aSeats(0 To 12, 0 To 12) As Integer
#End Region

#Region "Public Properties"
    Public Property Show As DateTime
        Get
            Return dtShow
        End Get
        Set(value As DateTime)
            dtShow = value
        End Set
    End Property

    Public Property Seats
        Get
            Return aSeats
        End Get
        Set(value)
            aSeats = value
        End Set
    End Property
#End Region
End Class
