Imports System.IO

Public Class User
    Public Property Username As String = String.Empty
    Public Property Password As String = String.Empty
    Public Property Email As String = String.Empty
    Public Property FirstName As String = String.Empty
    Public Property LastName As String = String.Empty
    Public Property Role As String = "user"
    Public Property ProfilePicture As String = String.Empty

    Public Sub New(username As String, firstName As String, lastName As String, password As String, email As String)
        Me.Username = username
        Me.Password = password
        Me.Email = email
        Me.FirstName = firstName
        Me.LastName = lastName
    End Sub

End Class
