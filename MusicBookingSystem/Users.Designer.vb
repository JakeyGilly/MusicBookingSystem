<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.comboUserType = New System.Windows.Forms.ComboBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.ItemHeight = 15
        Me.lstUsers.Location = New System.Drawing.Point(230, 12)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(247, 259)
        Me.lstUsers.TabIndex = 0
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Location = New System.Drawing.Point(16, 216)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(64, 19)
        Me.chkUpdate.TabIndex = 36
        Me.chkUpdate.Text = "Update"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(139, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 39)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(149, 243)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(80, 71)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(144, 23)
        Me.txtId.TabIndex = 32
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(16, 71)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 15)
        Me.lblId.TabIndex = 31
        Me.lblId.Text = "Id"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(16, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(16, 103)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(60, 15)
        Me.lblUsername.TabIndex = 29
        Me.lblUsername.Text = "Username"
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(48, 12)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(85, 39)
        Me.btnNewUser.TabIndex = 27
        Me.btnNewUser.Text = "Create New Users"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(80, 100)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(144, 23)
        Me.txtUsername.TabIndex = 37
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(80, 129)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(144, 23)
        Me.txtPassword.TabIndex = 39
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(16, 132)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 15)
        Me.lblPassword.TabIndex = 38
        Me.lblPassword.Text = "Password"
        '
        'comboUserType
        '
        Me.comboUserType.FormattingEnabled = True
        Me.comboUserType.Location = New System.Drawing.Point(80, 158)
        Me.comboUserType.Name = "comboUserType"
        Me.comboUserType.Size = New System.Drawing.Size(144, 23)
        Me.comboUserType.TabIndex = 40
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Location = New System.Drawing.Point(16, 161)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(57, 15)
        Me.lblUserType.TabIndex = 41
        Me.lblUserType.Text = "User Type"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 285)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.comboUserType)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.lstUsers)
        Me.Name = "Users"
        Me.Text = "Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstUsers As ListBox
    Friend WithEvents chkUpdate As CheckBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnNewUser As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents comboUserType As ComboBox
    Friend WithEvents lblUserType As Label
End Class
