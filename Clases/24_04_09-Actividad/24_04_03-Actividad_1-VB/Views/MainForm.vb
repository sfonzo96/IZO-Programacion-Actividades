Imports System.IO

Public Class MainForm

    Public Sub New()
        InitializeComponent()

        LoadUsername()
        LoadProfilePic()
    End Sub
    Private Sub LoadPicBtn_Click(sender As Object, e As EventArgs) Handles UploadPicBtn.Click
        Dim usersService As New UsersService()
        If ProfilePicLoader.ShowDialog() = DialogResult.OK Then
            Dim picImage As Image = Image.FromFile(ProfilePicLoader.FileName)

            Dim fileName As String = Path.GetFileName(ProfilePicLoader.FileName)
            Dim filePath As String = Path.Combine(Application.StartupPath, "Uploads", fileName)
            picImage.Save(filePath)

            ProfilePicBox.Image = Image.FromFile(ProfilePicLoader.FileName)
            usersService.UpdateUserPic(CurrentUser.Username, fileName)
        End If
    End Sub

    Private Sub LoadUsername()
        MessageBox.Show($"Hola {CurrentUser.FirstName}")
        CurrentUserLbl.Text = CurrentUser.FirstName
    End Sub

    Private Sub LoadProfilePic()
        Dim appPath As String = Application.StartupPath
        Try
            ProfilePicBox.Image = Image.FromFile(Path.Combine(appPath, "Uploads", CurrentUser.ProfilePicture))
        Catch ex As FileNotFoundException
            ProfilePicBox.Image = Image.FromFile(Path.Combine(appPath, "Uploads/default.jpg"))
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim calculatorForm As New CalculatorForm()
        calculatorForm.ShowDialog()
    End Sub

    Private Sub ConcatenadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConcatenadorToolStripMenuItem.Click
        Dim concatForm As New ConcatForm()
        concatForm.ShowDialog()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ''Cierra el proceso principal (en .NET es el formulario de inicio(LoginForm))
        LoginForm.Close()
    End Sub
End Class