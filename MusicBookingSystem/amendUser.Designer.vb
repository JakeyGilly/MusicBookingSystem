<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class amendUser
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
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.comboUserType = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(37, 117)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 15)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Location = New System.Drawing.Point(37, 153)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(57, 15)
        Me.lblUserType.TabIndex = 2
        Me.lblUserType.Text = "User Type"
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(287, 24)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(85, 39)
        Me.btnNewUser.TabIndex = 8
        Me.btnNewUser.Text = "Create New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(116, 229)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(35, 229)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 10
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(37, 79)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(60, 15)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "Username"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(36, 190)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(101, 47)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(144, 23)
        Me.txtId.TabIndex = 16
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(37, 47)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 15)
        Me.lblId.TabIndex = 15
        Me.lblId.Text = "Id"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(297, 229)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(287, 78)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'comboUserType
        '
        Me.comboUserType.FormattingEnabled = True
        Me.comboUserType.Location = New System.Drawing.Point(101, 153)
        Me.comboUserType.Name = "comboUserType"
        Me.comboUserType.Size = New System.Drawing.Size(144, 23)
        Me.comboUserType.TabIndex = 20
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(101, 79)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(144, 23)
        Me.txtUsername.TabIndex = 21
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(101, 114)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(144, 23)
        Me.txtPassword.TabIndex = 22
        '
        'amendUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 278)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.comboUserType)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblPassword)
        Me.Name = "amendUser"
        Me.Text = "amendLesson"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserType As Label
    Friend WithEvents btnNewUser As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents comboUserType As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
