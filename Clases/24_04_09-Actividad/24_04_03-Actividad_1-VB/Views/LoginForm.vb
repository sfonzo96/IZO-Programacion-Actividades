Public Class LoginForm
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Login()
    End Sub

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        Dim signupForm As New SignupForm()
        signupForm.ShowDialog()
    End Sub

    Private Sub LoginForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, LoginBtn.KeyPress, UsernameTxt.KeyPress, PasswordTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
            e.Handled = True
        End If
    End Sub

    Private Sub Login()


        If (String.IsNullOrEmpty(UsernameTxt.Text.Trim()) OrElse String.IsNullOrEmpty(PasswordTxt.Text.Trim())) Then
            MessageBox.Show("Ambos campos son necesarios!")
            Return
        End If

        Dim username As String = UsernameTxt.Text.Trim()
        Dim password As String = PasswordTxt.Text.Trim()

        Dim usersService As New UsersService()
        Dim user As User = usersService.GetUser(username)

        If user Is Nothing Then
            MessageBox.Show("Usuario o contraseña incorrectos")
            Return
        End If

        If username <> user.Username OrElse password <> user.Password Then
            MessageBox.Show("Usuario o contraseña incorrectos")
            Return
        End If

        CurrentUser = user
        Me.Hide()
        Dim mainForm As New MainForm()
        mainForm.Show()
    End Sub
End Class