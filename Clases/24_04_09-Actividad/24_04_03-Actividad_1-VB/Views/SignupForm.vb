Public Class SignupForm
    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        Signup()
    End Sub

    Private Sub SignupForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AdmPasswordTxt.KeyPress, ConfirmBtn.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Signup()
            e.Handled = True
        End If
    End Sub


    Private Sub Signup()
        Dim adminPass As String = AdmPasswordTxt.Text.Trim()

        If adminPass <> "admin" Then
            MessageBox.Show("Contraseña de administrador incorrecta")
            Return
        End If

        If (String.IsNullOrEmpty(UsernameTxt.Text.Trim()) OrElse String.IsNullOrEmpty(FirstNameTxt.Text.Trim()) OrElse String.IsNullOrEmpty(LastNameTxt.Text.Trim()) OrElse String.IsNullOrEmpty(PasswordTxt.Text.Trim()) OrElse String.IsNullOrEmpty(EmailTxt.Text.Trim())) Then
            MessageBox.Show("Todos los campos son requeridos")
            Return
        End If

        Dim username As String = UsernameTxt.Text.Trim()
        Dim firstName As String = FirstNameTxt.Text.Trim()
        Dim lastName As String = LastNameTxt.Text.Trim()
        Dim password As String = PasswordTxt.Text.Trim()
        Dim email As String = EmailTxt.Text.Trim()

        Dim userService As UsersService = UsersService.GetInstance()
        Dim success As Boolean = userService.AddUser(username, firstName, lastName, password, email)

        If success Then
            MessageBox.Show("Usuario registrado correctamente")
            Me.Close()
        End If
    End Sub
End Class