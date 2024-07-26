<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblUsername = New Label()
        lblPassword = New Label()
        btnLogin = New Button()
        btnCancel = New Button()
        txtUser = New TextBox()
        txtPass = New TextBox()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(203, 57)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 25)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(203, 194)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(87, 25)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(203, 330)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(176, 72)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(565, 330)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(198, 72)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(434, 57)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(245, 31)
        txtUser.TabIndex = 4
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(434, 194)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(245, 31)
        txtPass.TabIndex = 5
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1228, 742)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
End Class
