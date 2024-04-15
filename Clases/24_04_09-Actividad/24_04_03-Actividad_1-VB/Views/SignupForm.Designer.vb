<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        UsernameTxt = New TextBox()
        UsernameLbl = New Label()
        FirstNameTxt = New TextBox()
        FirstNameLbl = New Label()
        LastNameTxt = New TextBox()
        LastNameLbl = New Label()
        PasswordTxt = New TextBox()
        PasswordLbl = New Label()
        EmailTxt = New TextBox()
        EmailLbl = New Label()
        ConfirmBtn = New Button()
        AdminLbl = New Label()
        AdmPasswordTxt = New TextBox()
        SuspendLayout()
        ' 
        ' UsernameTxt
        ' 
        UsernameTxt.Location = New Point(166, 40)
        UsernameTxt.Name = "UsernameTxt"
        UsernameTxt.PlaceholderText = "Usuario"
        UsernameTxt.Size = New Size(100, 23)
        UsernameTxt.TabIndex = 0
        ' 
        ' UsernameLbl
        ' 
        UsernameLbl.AutoSize = True
        UsernameLbl.Location = New Point(88, 43)
        UsernameLbl.Name = "UsernameLbl"
        UsernameLbl.Size = New Size(47, 15)
        UsernameLbl.TabIndex = 3
        UsernameLbl.Text = "Usuario"
        ' 
        ' FirstNameTxt
        ' 
        FirstNameTxt.Location = New Point(166, 69)
        FirstNameTxt.Name = "FirstNameTxt"
        FirstNameTxt.PlaceholderText = "Nombre"
        FirstNameTxt.Size = New Size(100, 23)
        FirstNameTxt.TabIndex = 1
        ' 
        ' FirstNameLbl
        ' 
        FirstNameLbl.AutoSize = True
        FirstNameLbl.Location = New Point(88, 72)
        FirstNameLbl.Name = "FirstNameLbl"
        FirstNameLbl.Size = New Size(51, 15)
        FirstNameLbl.TabIndex = 5
        FirstNameLbl.Text = "Nombre"
        ' 
        ' LastNameTxt
        ' 
        LastNameTxt.Location = New Point(166, 98)
        LastNameTxt.Name = "LastNameTxt"
        LastNameTxt.PlaceholderText = "Apellido"
        LastNameTxt.Size = New Size(100, 23)
        LastNameTxt.TabIndex = 2
        ' 
        ' LastNameLbl
        ' 
        LastNameLbl.AutoSize = True
        LastNameLbl.Location = New Point(88, 101)
        LastNameLbl.Name = "LastNameLbl"
        LastNameLbl.Size = New Size(51, 15)
        LastNameLbl.TabIndex = 7
        LastNameLbl.Text = "Apellido"
        ' 
        ' PasswordTxt
        ' 
        PasswordTxt.Location = New Point(166, 127)
        PasswordTxt.Name = "PasswordTxt"
        PasswordTxt.PasswordChar = "*"c
        PasswordTxt.PlaceholderText = "Contraseña"
        PasswordTxt.Size = New Size(100, 23)
        PasswordTxt.TabIndex = 3
        ' 
        ' PasswordLbl
        ' 
        PasswordLbl.AutoSize = True
        PasswordLbl.Location = New Point(88, 130)
        PasswordLbl.Name = "PasswordLbl"
        PasswordLbl.Size = New Size(67, 15)
        PasswordLbl.TabIndex = 9
        PasswordLbl.Text = "Contraseña"
        ' 
        ' EmailTxt
        ' 
        EmailTxt.Location = New Point(166, 156)
        EmailTxt.Name = "EmailTxt"
        EmailTxt.PlaceholderText = "Email"
        EmailTxt.Size = New Size(100, 23)
        EmailTxt.TabIndex = 4
        ' 
        ' EmailLbl
        ' 
        EmailLbl.AutoSize = True
        EmailLbl.Location = New Point(88, 159)
        EmailLbl.Name = "EmailLbl"
        EmailLbl.Size = New Size(36, 15)
        EmailLbl.TabIndex = 11
        EmailLbl.Text = "Email"
        ' 
        ' ConfirmBtn
        ' 
        ConfirmBtn.Location = New Point(174, 199)
        ConfirmBtn.Name = "ConfirmBtn"
        ConfirmBtn.Size = New Size(75, 23)
        ConfirmBtn.TabIndex = 7
        ConfirmBtn.Text = "Confirmar"
        ConfirmBtn.UseVisualStyleBackColor = True
        ' 
        ' AdminLbl
        ' 
        AdminLbl.AutoSize = True
        AdminLbl.Location = New Point(332, 119)
        AdminLbl.Name = "AdminLbl"
        AdminLbl.Size = New Size(43, 15)
        AdminLbl.TabIndex = 14
        AdminLbl.Text = "Admin"
        ' 
        ' AdmPasswordTxt
        ' 
        AdmPasswordTxt.Location = New Point(310, 137)
        AdmPasswordTxt.Name = "AdmPasswordTxt"
        AdmPasswordTxt.PasswordChar = "*"c
        AdmPasswordTxt.PlaceholderText = "Clave"
        AdmPasswordTxt.Size = New Size(100, 23)
        AdmPasswordTxt.TabIndex = 6
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 279)
        Controls.Add(AdmPasswordTxt)
        Controls.Add(AdminLbl)
        Controls.Add(ConfirmBtn)
        Controls.Add(EmailTxt)
        Controls.Add(EmailLbl)
        Controls.Add(PasswordTxt)
        Controls.Add(PasswordLbl)
        Controls.Add(LastNameTxt)
        Controls.Add(LastNameLbl)
        Controls.Add(FirstNameTxt)
        Controls.Add(FirstNameLbl)
        Controls.Add(UsernameTxt)
        Controls.Add(UsernameLbl)
        Name = "SignupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignupForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents FirstNameTxt As TextBox
    Friend WithEvents FirstNameLbl As Label
    Friend WithEvents LastNameTxt As TextBox
    Friend WithEvents LastNameLbl As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents AdminLbl As Label
    Friend WithEvents AdmPasswordTxt As TextBox
End Class
