<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConcatForm
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
        UserNameLbl = New Label()
        LastNameTxt = New TextBox()
        FirstNameTxt = New TextBox()
        ConcatBtn = New Button()
        FullNameLbl = New Label()
        SuspendLayout()
        ' 
        ' UserNameLbl
        ' 
        UserNameLbl.AutoSize = True
        UserNameLbl.Location = New Point(308, 28)
        UserNameLbl.Name = "UserNameLbl"
        UserNameLbl.Size = New Size(39, 15)
        UserNameLbl.TabIndex = 5
        UserNameLbl.Text = "Name"
        ' 
        ' LastNameTxt
        ' 
        LastNameTxt.Location = New Point(142, 121)
        LastNameTxt.Name = "LastNameTxt"
        LastNameTxt.PlaceholderText = "Apellido"
        LastNameTxt.Size = New Size(100, 23)
        LastNameTxt.TabIndex = 0
        ' 
        ' FirstNameTxt
        ' 
        FirstNameTxt.Location = New Point(142, 161)
        FirstNameTxt.Name = "FirstNameTxt"
        FirstNameTxt.ReadOnly = True
        FirstNameTxt.Size = New Size(100, 23)
        FirstNameTxt.TabIndex = 1
        ' 
        ' ConcatBtn
        ' 
        ConcatBtn.Location = New Point(149, 210)
        ConcatBtn.Name = "ConcatBtn"
        ConcatBtn.Size = New Size(87, 23)
        ConcatBtn.TabIndex = 2
        ConcatBtn.Text = "Concatenar"
        ConcatBtn.UseVisualStyleBackColor = True
        ' 
        ' FullNameLbl
        ' 
        FullNameLbl.AutoSize = True
        FullNameLbl.Font = New Font("Segoe UI", 12F)
        FullNameLbl.Location = New Point(154, 254)
        FullNameLbl.Name = "FullNameLbl"
        FullNameLbl.Size = New Size(77, 21)
        FullNameLbl.TabIndex = 9
        FullNameLbl.Text = "FullName"
        FullNameLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ConcatForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 361)
        Controls.Add(FullNameLbl)
        Controls.Add(ConcatBtn)
        Controls.Add(FirstNameTxt)
        Controls.Add(LastNameTxt)
        Controls.Add(UserNameLbl)
        Name = "ConcatForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ConcatForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserNameLbl As Label
    Friend WithEvents LastNameTxt As TextBox
    Friend WithEvents FirstNameTxt As TextBox
    Friend WithEvents ConcatBtn As Button
    Friend WithEvents FullNameLbl As Label
End Class
