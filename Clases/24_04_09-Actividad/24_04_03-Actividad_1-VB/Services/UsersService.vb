Imports System.IO
Imports System.Text.Json
Imports System.Windows.Forms

Public Class UsersService
    Private Shared Instance As UsersService

    Private ReadOnly DataPath As String = Path.Combine(Application.StartupPath, "Data/users.json")

    Public Sub New()
    End Sub

    Public Function AddUser(username As String, firstName As String, lastName As String, password As String, email As String) As Boolean
        If Me.UserExists(username) Then
            MessageBox.Show("Ya existe un registro con ese usuario")
            Return False
        End If

        Dim user As New User(username, firstName, lastName, password, email)
        Dim users As List(Of User) = Me.GetUsers()
        users.Add(user)
        Me.UpdateUsersJson(users)

        Return True
    End Function

    Public Function GetUser(username As String) As User
        Dim users As List(Of User) = Me.GetUsers()
        Dim user = users.SingleOrDefault(Function(u) u.Username = username)
        Return user
    End Function

    Public Function UpdateUserPic(username As String, path As String) As Boolean
        Dim users As List(Of User) = Me.GetUsers()
        For Each user In users
            If user.Username = username Then
                user.ProfilePicture = path
                UpdateUsersJson(users)
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub UpdateUsersJson(users As List(Of User))
        Dim jsonData As String = JsonSerializer.Serialize(users)
        File.WriteAllText(Me.DataPath, jsonData)
    End Sub

    Public Function UserExists(username As String) As Boolean
        Dim users As List(Of User) = Me.GetUsers()
        For Each user In users
            If user.Username = username Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function GetUsers() As List(Of User)
        Dim jsonData As String = File.ReadAllText(Me.DataPath)
        Dim users As List(Of User) = JsonSerializer.Deserialize(Of List(Of User))(jsonData)
        Return users
    End Function

    Public Shared Function GetInstance() As UsersService
        If UsersService.Instance Is Nothing Then
            UsersService.Instance = New UsersService()
        End If
        Return UsersService.Instance
    End Function
End Class
