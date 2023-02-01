<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class amendBooking
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
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.comboRoom = New System.Windows.Forms.ComboBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.btnNewBooking = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.datepick = New System.Windows.Forms.DateTimePicker()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(37, 117)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(39, 15)
        Me.lblRoom.TabIndex = 0
        Me.lblRoom.Text = "Room"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(37, 157)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(41, 15)
        Me.lblPeriod.TabIndex = 1
        Me.lblPeriod.Text = "Period"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(37, 194)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(31, 15)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        '
        'comboRoom
        '
        Me.comboRoom.FormattingEnabled = True
        Me.comboRoom.Location = New System.Drawing.Point(101, 114)
        Me.comboRoom.Name = "comboRoom"
        Me.comboRoom.Size = New System.Drawing.Size(144, 23)
        Me.comboRoom.TabIndex = 3
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(101, 157)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(144, 23)
        Me.txtPeriod.TabIndex = 4
        '
        'btnNewBooking
        '
        Me.btnNewBooking.Location = New System.Drawing.Point(287, 24)
        Me.btnNewBooking.Name = "btnNewBooking"
        Me.btnNewBooking.Size = New System.Drawing.Size(85, 39)
        Me.btnNewBooking.TabIndex = 8
        Me.btnNewBooking.Text = "Create New Booking"
        Me.btnNewBooking.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(116, 289)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(35, 289)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 10
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'datepick
        '
        Me.datepick.Location = New System.Drawing.Point(101, 194)
        Me.datepick.Name = "datepick"
        Me.datepick.Size = New System.Drawing.Size(144, 23)
        Me.datepick.TabIndex = 11
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(101, 79)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(144, 23)
        Me.txtUser.TabIndex = 13
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(37, 79)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 15)
        Me.lblUser.TabIndex = 12
        Me.lblUser.Text = "User"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(36, 250)
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
        Me.btnBack.Location = New System.Drawing.Point(297, 289)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'amendBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 355)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.datepick)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNewBooking)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.comboRoom)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblRoom)
        Me.Name = "amendBooking"
        Me.Text = "amendBooking"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblRoom As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents comboRoom As ComboBox
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents btnNewBooking As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents datepick As DateTimePicker
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
End Class
