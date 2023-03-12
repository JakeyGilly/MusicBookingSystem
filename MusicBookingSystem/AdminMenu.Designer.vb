<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMenu
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnTimetable = New System.Windows.Forms.Button()
        Me.btnLesson = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(170, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(255, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Music Booking System"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(12, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(38, 15)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Hello "
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(354, 161)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(100, 50)
        Me.btnBooking.TabIndex = 4
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnTimetable
        '
        Me.btnTimetable.Location = New System.Drawing.Point(248, 161)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Size = New System.Drawing.Size(100, 50)
        Me.btnTimetable.TabIndex = 5
        Me.btnTimetable.Text = "Timetable"
        Me.btnTimetable.UseVisualStyleBackColor = True
        '
        'btnLesson
        '
        Me.btnLesson.Location = New System.Drawing.Point(142, 161)
        Me.btnLesson.Name = "btnLesson"
        Me.btnLesson.Size = New System.Drawing.Size(100, 50)
        Me.btnLesson.TabIndex = 6
        Me.btnLesson.Text = "Lesson"
        Me.btnLesson.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(196, 217)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(100, 50)
        Me.btnUser.TabIndex = 7
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(302, 217)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(100, 50)
        Me.btnRoom.TabIndex = 8
        Me.btnRoom.Text = "Room"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitle.Location = New System.Drawing.Point(221, 45)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(154, 32)
        Me.lblSubtitle.TabIndex = 9
        Me.lblSubtitle.Text = "Admin Menu"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 27)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnLesson)
        Me.Controls.Add(Me.btnTimetable)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminMenu"
        Me.Text = "AdminMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnTimetable As Button
    Friend WithEvents btnLesson As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnLogout As Button
End Class
