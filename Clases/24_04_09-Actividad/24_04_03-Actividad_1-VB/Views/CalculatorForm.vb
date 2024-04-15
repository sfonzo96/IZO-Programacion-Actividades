Public Class CalculatorForm
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        UserNameLbl.Text = Context.CurrentUser.FirstName
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        'Try
        '    Dim firstValue As Double = FirstValuetTxt.Text
        '    Dim secondValue As Double = SecondValuetTxt.Text

        '    ResultLbl.Text = firstValue + secondValue
        'Catch ex As InvalidCastException
        '    MessageBox.Show("Alguno de los valores no es válido!")
        'End Try

        If String.IsNullOrEmpty(FirstValuetTxt.Text.Trim()) OrElse String.IsNullOrEmpty(SecondValuetTxt.Text.Trim()) Then
            MessageBox.Show("Ambos valores son necesarios!")
            Return
        End If

        Dim firstValue As Double
        Dim secondValue As Double

        If Not Double.TryParse(FirstValuetTxt.Text.Trim(), firstValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        If Not Double.TryParse(SecondValuetTxt.Text.Trim(), secondValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        ResultLbl.Text = firstValue + secondValue
    End Sub

    Private Sub SubstBtn_Click(sender As Object, e As EventArgs) Handles SubstBtn.Click
        If String.IsNullOrEmpty(FirstValuetTxt.Text.Trim()) OrElse String.IsNullOrEmpty(SecondValuetTxt.Text.Trim()) Then
            MessageBox.Show("Ambos valores son necesarios!")
            Return
        End If

        Dim firstValue As Double
        Dim secondValue As Double

        If Not Double.TryParse(FirstValuetTxt.Text.Trim(), firstValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        If Not Double.TryParse(SecondValuetTxt.Text.Trim(), secondValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        ResultLbl.Text = firstValue - secondValue
    End Sub

    Private Sub MultiplyBtn_Click(sender As Object, e As EventArgs) Handles MultiplyBtn.Click
        If String.IsNullOrEmpty(FirstValuetTxt.Text.Trim()) OrElse String.IsNullOrEmpty(SecondValuetTxt.Text.Trim()) Then
            MessageBox.Show("Ambos valores son necesarios!")
            Return
        End If

        Dim firstValue As Double
        Dim secondValue As Double

        If Not Double.TryParse(FirstValuetTxt.Text.Trim(), firstValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        If Not Double.TryParse(SecondValuetTxt.Text.Trim(), secondValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        ResultLbl.Text = firstValue * secondValue
    End Sub

    Private Sub DivideBtn_Click(sender As Object, e As EventArgs) Handles DivideBtn.Click
        If String.IsNullOrEmpty(FirstValuetTxt.Text.Trim()) OrElse String.IsNullOrEmpty(SecondValuetTxt.Text.Trim()) Then
            MessageBox.Show("Ambos valores son necesarios!")
            Return
        End If

        Dim firstValue As Double
        Dim secondValue As Double

        If Not Double.TryParse(FirstValuetTxt.Text.Trim(), firstValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        If Not Double.TryParse(SecondValuetTxt.Text.Trim(), secondValue) Then
            MessageBox.Show("El primer valor ingresado no es válido!")
            Return
        End If

        If secondValue = 0 Then
            MessageBox.Show("El divisor no puede ser 0!")
            ResultLbl.Text = "-"
            Return
        End If

        ResultLbl.Text = firstValue / secondValue
    End Sub
End Class