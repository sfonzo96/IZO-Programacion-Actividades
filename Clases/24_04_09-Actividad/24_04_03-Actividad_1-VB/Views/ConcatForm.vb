Public Class ConcatForm
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FirstNameTxt.Text = Context.CurrentUser.FirstName
        UserNameLbl.Text = Context.CurrentUser.FirstName
    End Sub

    Private Sub ConcatBtn_Click(sender As Object, e As EventArgs) Handles ConcatBtn.Click
        Concatenate()
    End Sub

    Private Sub ConcatForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNameTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Concatenate()
            e.Handled = True
        End If
    End Sub
    Private Sub Concatenate()
        Dim lastName As String = LastNameTxt.Text.Trim()

        If String.IsNullOrEmpty(lastName) Then
            MessageBox.Show("El campo Apellido no puede estar vacío!")
            Return
        End If

        FullNameLbl.Text = $"{lastName} {Context.CurrentUser.FirstName}"
    End Sub
End Class