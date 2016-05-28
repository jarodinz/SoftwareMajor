
Imports System.Data

Imports System.Data.SqlClient
Imports System.Collections.ObjectModel


Public Class ViewStudents
    Dim students As New ObservableCollection(Of Studentslist)

    Sub ViewStudents()

        Dim q As String = "SELECT * FROM Student"
        Dim Firstname As String
        Dim Surname As String
        Dim DOB As Date
        Dim cmd As New OleDb.OleDbCommand(q, connection)
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

        While reader.Read
            If Not IsDBNull(reader("Firstname")) Then
                Firstname = reader("Firstname")
            Else
                Firstname = ""
            End If

            If Not IsDBNull(reader("Surname")) Then
                Surname = reader("Surname")
            Else
                Surname = ""
            End If

            If Not IsDBNull(reader("DOB")) Then
                DOB = reader("DOB")
            Else
                DOB = ""
            End If


            Dim newStudent As New Studentslist(Firstname, Surname, DOB)


            students.Add(newStudent)



        End While


        listView.ItemsSource = students


    End Sub



    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        ViewStudents()

    End Sub
   
End Class
