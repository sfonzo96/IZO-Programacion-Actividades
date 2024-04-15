<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        ProfilePicBox = New PictureBox()
        MenuStrip1 = New MenuStrip()
        FuncionalidadesToolStripMenuItem = New ToolStripMenuItem()
        CalculadoraToolStripMenuItem = New ToolStripMenuItem()
        ConcatenadorToolStripMenuItem = New ToolStripMenuItem()
        UploadPicBtn = New Button()
        CurrentUserLbl = New Label()
        ProfilePicLoader = New OpenFileDialog()
        CType(ProfilePicBox, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProfilePicBox
        ' 
        ProfilePicBox.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfilePicBox.Cursor = Cursors.Hand
        ProfilePicBox.Location = New Point(1048, 41)
        ProfilePicBox.Name = "ProfilePicBox"
        ProfilePicBox.Size = New Size(50, 50)
        ProfilePicBox.SizeMode = PictureBoxSizeMode.StretchImage
        ProfilePicBox.TabIndex = 0
        ProfilePicBox.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FuncionalidadesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1121, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FuncionalidadesToolStripMenuItem
        ' 
        FuncionalidadesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CalculadoraToolStripMenuItem, ConcatenadorToolStripMenuItem})
        FuncionalidadesToolStripMenuItem.Name = "FuncionalidadesToolStripMenuItem"
        FuncionalidadesToolStripMenuItem.Size = New Size(73, 20)
        FuncionalidadesToolStripMenuItem.Text = "Funciones"
        ' 
        ' CalculadoraToolStripMenuItem
        ' 
        CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        CalculadoraToolStripMenuItem.Size = New Size(180, 22)
        CalculadoraToolStripMenuItem.Text = "Calculadora"
        ' 
        ' ConcatenadorToolStripMenuItem
        ' 
        ConcatenadorToolStripMenuItem.Name = "ConcatenadorToolStripMenuItem"
        ConcatenadorToolStripMenuItem.Size = New Size(180, 22)
        ConcatenadorToolStripMenuItem.Text = "Concatenador"
        ' 
        ' UploadPicBtn
        ' 
        UploadPicBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        UploadPicBtn.Location = New Point(1048, 95)
        UploadPicBtn.Name = "UploadPicBtn"
        UploadPicBtn.Size = New Size(50, 23)
        UploadPicBtn.TabIndex = 2
        UploadPicBtn.Text = "Nueva"
        UploadPicBtn.UseVisualStyleBackColor = True
        ' 
        ' CurrentUserLbl
        ' 
        CurrentUserLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CurrentUserLbl.AutoSize = True
        CurrentUserLbl.Location = New Point(980, 59)
        CurrentUserLbl.Name = "CurrentUserLbl"
        CurrentUserLbl.Size = New Size(62, 15)
        CurrentUserLbl.TabIndex = 3
        CurrentUserLbl.Text = "UserName"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1121, 663)
        Controls.Add(CurrentUserLbl)
        Controls.Add(UploadPicBtn)
        Controls.Add(ProfilePicBox)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        CType(ProfilePicBox, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProfilePicBox As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FuncionalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConcatenadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadPicBtn As Button
    Friend WithEvents CurrentUserLbl As Label
    Friend WithEvents ProfilePicLoader As OpenFileDialog
End Class
