<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bookings
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
        Me.lstBookings = New System.Windows.Forms.ListBox()
        Me.numPeriod = New System.Windows.Forms.NumericUpDown()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.datePick = New System.Windows.Forms.DateTimePicker()
        Me.btnNewBooking = New System.Windows.Forms.Button()
        Me.comboRoom = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        CType(Me.numPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstBookings
        '
        Me.lstBookings.FormattingEnabled = True
        Me.lstBookings.ItemHeight = 15
        Me.lstBookings.Location = New System.Drawing.Point(230, 12)
        Me.lstBookings.Name = "lstBookings"
        Me.lstBookings.Size = New System.Drawing.Size(247, 259)
        Me.lstBookings.TabIndex = 0
        '
        'numPeriod
        '
        Me.numPeriod.Location = New System.Drawing.Point(80, 158)
        Me.numPeriod.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numPeriod.Name = "numPeriod"
        Me.numPeriod.Size = New System.Drawing.Size(144, 23)
        Me.numPeriod.TabIndex = 37
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
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(16, 103)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 15)
        Me.lblUser.TabIndex = 29
        Me.lblUser.Text = "User"
        '
        'datePick
        '
        Me.datePick.Location = New System.Drawing.Point(80, 187)
        Me.datePick.Name = "datePick"
        Me.datePick.Size = New System.Drawing.Size(144, 23)
        Me.datePick.TabIndex = 28
        '
        'btnNewBooking
        '
        Me.btnNewBooking.Location = New System.Drawing.Point(48, 12)
        Me.btnNewBooking.Name = "btnNewBooking"
        Me.btnNewBooking.Size = New System.Drawing.Size(85, 39)
        Me.btnNewBooking.TabIndex = 27
        Me.btnNewBooking.Text = "Create New Booking"
        Me.btnNewBooking.UseVisualStyleBackColor = True
        '
        'comboRoom
        '
        Me.comboRoom.FormattingEnabled = True
        Me.comboRoom.Location = New System.Drawing.Point(80, 129)
        Me.comboRoom.Name = "comboRoom"
        Me.comboRoom.Size = New System.Drawing.Size(144, 23)
        Me.comboRoom.TabIndex = 26
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(16, 187)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(31, 15)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Date"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(16, 160)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(41, 15)
        Me.lblPeriod.TabIndex = 24
        Me.lblPeriod.Text = "Period"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(16, 132)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(39, 15)
        Me.lblRoom.TabIndex = 23
        Me.lblRoom.Text = "Room"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(80, 100)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(144, 23)
        Me.txtUser.TabIndex = 38
        '
        'Bookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 285)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.numPeriod)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.datePick)
        Me.Controls.Add(Me.btnNewBooking)
        Me.Controls.Add(Me.comboRoom)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lstBookings)
        Me.Name = "Bookings"
        Me.Text = "Bookings"
        CType(Me.numPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBookings As ListBox
    Friend WithEvents numPeriod As NumericUpDown
    Friend WithEvents chkUpdate As CheckBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents datePick As DateTimePicker
    Friend WithEvents btnNewBooking As Button
    Friend WithEvents comboRoom As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents txtUser As TextBox
End Class
