<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        AddBtn = New Button()
        DivideBtn = New Button()
        SubstBtn = New Button()
        MultiplyBtn = New Button()
        UserNameLbl = New Label()
        FirstValuetTxt = New TextBox()
        SecondValuetTxt = New TextBox()
        ResultLbl = New Label()
        SuspendLayout()
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(83, 227)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(30, 23)
        AddBtn.TabIndex = 2
        AddBtn.Text = "+"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' DivideBtn
        ' 
        DivideBtn.Location = New Point(272, 227)
        DivideBtn.Name = "DivideBtn"
        DivideBtn.Size = New Size(30, 23)
        DivideBtn.TabIndex = 5
        DivideBtn.Text = "/"
        DivideBtn.UseVisualStyleBackColor = True
        ' 
        ' SubstBtn
        ' 
        SubstBtn.Location = New Point(146, 227)
        SubstBtn.Name = "SubstBtn"
        SubstBtn.Size = New Size(30, 23)
        SubstBtn.TabIndex = 3
        SubstBtn.Text = "-"
        SubstBtn.UseVisualStyleBackColor = True
        ' 
        ' MultiplyBtn
        ' 
        MultiplyBtn.Location = New Point(209, 227)
        MultiplyBtn.Name = "MultiplyBtn"
        MultiplyBtn.Size = New Size(30, 23)
        MultiplyBtn.TabIndex = 4
        MultiplyBtn.Text = "*"
        MultiplyBtn.UseVisualStyleBackColor = True
        ' 
        ' UserNameLbl
        ' 
        UserNameLbl.AutoSize = True
        UserNameLbl.Location = New Point(308, 28)
        UserNameLbl.Name = "UserNameLbl"
        UserNameLbl.Size = New Size(39, 15)
        UserNameLbl.TabIndex = 4
        UserNameLbl.Text = "Name"
        ' 
        ' FirstValuetTxt
        ' 
        FirstValuetTxt.Location = New Point(139, 102)
        FirstValuetTxt.Name = "FirstValuetTxt"
        FirstValuetTxt.Size = New Size(100, 23)
        FirstValuetTxt.TabIndex = 0
        ' 
        ' SecondValuetTxt
        ' 
        SecondValuetTxt.Location = New Point(139, 152)
        SecondValuetTxt.Name = "SecondValuetTxt"
        SecondValuetTxt.Size = New Size(100, 23)
        SecondValuetTxt.TabIndex = 1
        ' 
        ' ResultLbl
        ' 
        ResultLbl.AutoSize = True
        ResultLbl.Font = New Font("Segoe UI", 12F)
        ResultLbl.Location = New Point(153, 282)
        ResultLbl.Name = "ResultLbl"
        ResultLbl.Size = New Size(79, 21)
        ResultLbl.TabIndex = 7
        ResultLbl.Text = "Resultado"
        ResultLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CalculatorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 361)
        Controls.Add(ResultLbl)
        Controls.Add(SecondValuetTxt)
        Controls.Add(FirstValuetTxt)
        Controls.Add(UserNameLbl)
        Controls.Add(MultiplyBtn)
        Controls.Add(SubstBtn)
        Controls.Add(DivideBtn)
        Controls.Add(AddBtn)
        Name = "CalculatorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddBtn As Button
    Friend WithEvents DivideBtn As Button
    Friend WithEvents SubstBtn As Button
    Friend WithEvents MultiplyBtn As Button
    Friend WithEvents UserNameLbl As Label
    Friend WithEvents FirstValuetTxt As TextBox
    Friend WithEvents SecondValuetTxt As TextBox
    Friend WithEvents ResultLbl As Label
End Class
