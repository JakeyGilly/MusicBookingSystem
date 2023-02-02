<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class amendRoom
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
        Me.btnNewRoom = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNewRoom
        '
        Me.btnNewRoom.Location = New System.Drawing.Point(287, 24)
        Me.btnNewRoom.Name = "btnNewRoom"
        Me.btnNewRoom.Size = New System.Drawing.Size(85, 39)
        Me.btnNewRoom.TabIndex = 8
        Me.btnNewRoom.Text = "Create New Room"
        Me.btnNewRoom.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(117, 159)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(36, 159)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 10
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(37, 79)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 15)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(37, 120)
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
        Me.btnBack.Location = New System.Drawing.Point(298, 159)
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
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(101, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(144, 23)
        Me.txtName.TabIndex = 21
        '
        'amendRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 209)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNewRoom)
        Me.Name = "amendRoom"
        Me.Text = "amendLesson"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewRoom As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtName As TextBox
End Class
