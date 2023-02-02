<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnTimetable = New System.Windows.Forms.Button()
        Me.btnLesson = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(690, 415)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnDebug.TabIndex = 0
        Me.btnDebug.Text = "FileDebug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(207, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Music Booking Sytem Prototype"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(644, 21)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(644, 47)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(38, 15)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Hello "
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(189, 204)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(84, 32)
        Me.btnBooking.TabIndex = 4
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnTimetable
        '
        Me.btnTimetable.Location = New System.Drawing.Point(335, 209)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Size = New System.Drawing.Size(75, 23)
        Me.btnTimetable.TabIndex = 5
        Me.btnTimetable.Text = "Timetable"
        Me.btnTimetable.UseVisualStyleBackColor = True
        '
        'btnLesson
        '
        Me.btnLesson.Location = New System.Drawing.Point(497, 226)
        Me.btnLesson.Name = "btnLesson"
        Me.btnLesson.Size = New System.Drawing.Size(75, 23)
        Me.btnLesson.TabIndex = 6
        Me.btnLesson.Text = "Lesson"
        Me.btnLesson.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(255, 300)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(75, 23)
        Me.btnUser.TabIndex = 7
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(407, 300)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnRoom.TabIndex = 8
        Me.btnRoom.Text = "Room"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnLesson)
        Me.Controls.Add(Me.btnTimetable)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDebug)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDebug As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnTimetable As Button
    Friend WithEvents btnLesson As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnRoom As Button
End Class
