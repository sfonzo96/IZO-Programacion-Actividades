<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        UsernameLbl = New Label()
        PasswordLbl = New Label()
        UsernameTxt = New TextBox()
        PasswordTxt = New TextBox()
        LoginBtn = New Button()
        SignupBtn = New Button()
        SuspendLayout()
        ' 
        ' UsernameLbl
        ' 
        UsernameLbl.AutoSize = True
        UsernameLbl.Location = New Point(91, 80)
        UsernameLbl.Name = "UsernameLbl"
        UsernameLbl.Size = New Size(47, 15)
        UsernameLbl.TabIndex = 0
        UsernameLbl.Text = "Usuario"
        ' 
        ' PasswordLbl
        ' 
        PasswordLbl.AutoSize = True
        PasswordLbl.Location = New Point(91, 124)
        PasswordLbl.Name = "PasswordLbl"
        PasswordLbl.Size = New Size(67, 15)
        PasswordLbl.TabIndex = 1
        PasswordLbl.Text = "Contraseña"
        ' 
        ' UsernameTxt
        ' 
        UsernameTxt.Location = New Point(166, 77)
        UsernameTxt.Name = "UsernameTxt"
        UsernameTxt.PlaceholderText = "Usuario"
        UsernameTxt.Size = New Size(100, 23)
        UsernameTxt.TabIndex = 0
        ' 
        ' PasswordTxt
        ' 
        PasswordTxt.Location = New Point(166, 121)
        PasswordTxt.Name = "PasswordTxt"
        PasswordTxt.PasswordChar = "*"c
        PasswordTxt.PlaceholderText = "Contraseña"
        PasswordTxt.Size = New Size(100, 23)
        PasswordTxt.TabIndex = 1
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(179, 163)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(75, 23)
        LoginBtn.TabIndex = 2
        LoginBtn.Text = "Ingresar"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' SignupBtn
        ' 
        SignupBtn.Location = New Point(179, 195)
        SignupBtn.Name = "SignupBtn"
        SignupBtn.Size = New Size(75, 23)
        SignupBtn.TabIndex = 3
        SignupBtn.Text = "Registrar"
        SignupBtn.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 279)
        Controls.Add(SignupBtn)
        Controls.Add(LoginBtn)
        Controls.Add(PasswordTxt)
        Controls.Add(UsernameTxt)
        Controls.Add(PasswordLbl)
        Controls.Add(UsernameLbl)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameLbl As Label
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents SignupBtn As Button
End Class
