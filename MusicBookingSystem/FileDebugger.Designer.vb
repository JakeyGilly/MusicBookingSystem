<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileDebugger
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLesson = New System.Windows.Forms.Button()
        Me.btnSearchBookings = New System.Windows.Forms.Button()
        Me.btnSearchLessons = New System.Windows.Forms.Button()
        Me.btnSearchRooms = New System.Windows.Forms.Button()
        Me.btnSearchUser = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(98, 93)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(327, 244)
        Me.lstOutput.TabIndex = 0
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(529, 37)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(112, 41)
        Me.btnBooking.TabIndex = 1
        Me.btnBooking.Text = "Read Bookings"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(640, 343)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnLesson
        '
        Me.btnLesson.Location = New System.Drawing.Point(529, 84)
        Me.btnLesson.Name = "btnLesson"
        Me.btnLesson.Size = New System.Drawing.Size(112, 41)
        Me.btnLesson.TabIndex = 4
        Me.btnLesson.Text = "Read Lessons"
        Me.btnLesson.UseVisualStyleBackColor = True
        '
        'btnSearchBookings
        '
        Me.btnSearchBookings.Location = New System.Drawing.Point(529, 219)
        Me.btnSearchBookings.Name = "btnSearchBookings"
        Me.btnSearchBookings.Size = New System.Drawing.Size(144, 23)
        Me.btnSearchBookings.TabIndex = 5
        Me.btnSearchBookings.Text = "Search Bookings By Id"
        Me.btnSearchBookings.UseVisualStyleBackColor = True
        '
        'btnSearchLessons
        '
        Me.btnSearchLessons.Location = New System.Drawing.Point(529, 248)
        Me.btnSearchLessons.Name = "btnSearchLessons"
        Me.btnSearchLessons.Size = New System.Drawing.Size(144, 23)
        Me.btnSearchLessons.TabIndex = 6
        Me.btnSearchLessons.Text = "Search Lessons By Id"
        Me.btnSearchLessons.UseVisualStyleBackColor = True
        '
        'btnSearchRooms
        '
        Me.btnSearchRooms.Location = New System.Drawing.Point(529, 307)
        Me.btnSearchRooms.Name = "btnSearchRooms"
        Me.btnSearchRooms.Size = New System.Drawing.Size(144, 23)
        Me.btnSearchRooms.TabIndex = 10
        Me.btnSearchRooms.Text = "Search Rooms By Id"
        Me.btnSearchRooms.UseVisualStyleBackColor = True
        '
        'btnSearchUser
        '
        Me.btnSearchUser.Location = New System.Drawing.Point(529, 278)
        Me.btnSearchUser.Name = "btnSearchUser"
        Me.btnSearchUser.Size = New System.Drawing.Size(144, 23)
        Me.btnSearchUser.TabIndex = 9
        Me.btnSearchUser.Text = "Search Users By Id"
        Me.btnSearchUser.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(529, 172)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(112, 41)
        Me.btnRoom.TabIndex = 8
        Me.btnRoom.Text = "Read Rooms"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(529, 125)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(112, 41)
        Me.btnUser.TabIndex = 7
        Me.btnUser.Text = "Read User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'FileDebugger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 407)
        Me.Controls.Add(Me.btnSearchRooms)
        Me.Controls.Add(Me.btnSearchUser)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnSearchLessons)
        Me.Controls.Add(Me.btnSearchBookings)
        Me.Controls.Add(Me.btnLesson)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "FileDebugger"
        Me.Text = "Form1"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLesson As Button
    Friend WithEvents btnSearchBookings As Button
    Friend WithEvents btnSearchLessons As Button
    Friend WithEvents btnSearchRooms As Button
    Friend WithEvents btnSearchUser As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnUser As Button
End Class
