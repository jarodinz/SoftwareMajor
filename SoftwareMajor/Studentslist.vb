Imports System.ComponentModel
Public Class Studentslist
    Implements INotifyPropertyChanged

    Private _firstname As String
    Private _lastname As String
    Private _DOB As String

    Sub New(firstname As String,
            Surname As String,
            DOB As Date)

        _firstname = firstname
        _lastname = Surname
        _DOB = DOB

    End Sub


    Property Firstname As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
            OnPropertyChanged("Firstname")

        End Set
    End Property

    Property Surname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
            OnPropertyChanged("Surname")

        End Set
    End Property

    Property DOB As String
        Get
            Return _DOB
        End Get
        Set(value As String)
            _DOB = value
            OnPropertyChanged("DOB")

        End Set
    End Property

    Protected Sub OnPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

End Class
