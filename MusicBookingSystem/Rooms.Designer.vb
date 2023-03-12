<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rooms
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
        Me.lstRooms = New System.Windows.Forms.ListBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnNewRoom = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstRooms
        '
        Me.lstRooms.FormattingEnabled = True
        Me.lstRooms.ItemHeight = 15
        Me.lstRooms.Location = New System.Drawing.Point(230, 12)
        Me.lstRooms.Name = "lstRooms"
        Me.lstRooms.Size = New System.Drawing.Size(247, 259)
        Me.lstRooms.TabIndex = 0
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 103)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 15)
        Me.lblName.TabIndex = 29
        Me.lblName.Text = "Name"
        '
        'btnNewRoom
        '
        Me.btnNewRoom.Location = New System.Drawing.Point(48, 12)
        Me.btnNewRoom.Name = "btnNewRoom"
        Me.btnNewRoom.Size = New System.Drawing.Size(85, 39)
        Me.btnNewRoom.TabIndex = 27
        Me.btnNewRoom.Text = "Create New Rooms"
        Me.btnNewRoom.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(144, 23)
        Me.txtName.TabIndex = 37
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 285)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnNewRoom)
        Me.Controls.Add(Me.lstRooms)
        Me.Name = "Rooms"
        Me.Text = "Rooms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRooms As ListBox
    Friend WithEvents chkUpdate As CheckBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnNewRoom As Button
    Friend WithEvents txtName As TextBox
End Class
