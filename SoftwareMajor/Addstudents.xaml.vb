

Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel


Public Class Addstu1



    Sub AddStudents()
        Dim firstname As String
        Dim Surname As String
        Dim DOB As Date


        firstname = First.Text
        Surname = lastname.Text
        DOB = tbdob.Text

        Dim q As String = "INSERT INTO Student(Firstname, Surname, DOB) VALUES ('" & firstname & "','" & Surname & "',  '" & DOB & "'  )"

        Dim cmd As New OleDb.OleDbCommand(q, connection)
        cmd.ExecuteNonQuery()

        MsgBox("worked")





    End Sub

    Private Sub AddStu_Click(sender As Object, e As RoutedEventArgs) Handles AddStu.Click
        AddStudents()
    End Sub
End Class
