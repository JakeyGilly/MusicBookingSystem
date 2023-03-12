<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lessons
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
        Me.lstLessons = New System.Windows.Forms.ListBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.btnNewLesson = New System.Windows.Forms.Button()
        Me.comboSubject = New System.Windows.Forms.ComboBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.comboTeacher = New System.Windows.Forms.ComboBox()
        Me.comboDay = New System.Windows.Forms.ComboBox()
        Me.numPeriod = New System.Windows.Forms.NumericUpDown()
        CType(Me.numPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstLessons
        '
        Me.lstLessons.FormattingEnabled = True
        Me.lstLessons.ItemHeight = 15
        Me.lstLessons.Location = New System.Drawing.Point(230, 12)
        Me.lstLessons.Name = "lstLessons"
        Me.lstLessons.Size = New System.Drawing.Size(247, 259)
        Me.lstLessons.TabIndex = 0
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
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(16, 103)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 15)
        Me.lblSubject.TabIndex = 29
        Me.lblSubject.Text = "Subject"
        '
        'btnNewLesson
        '
        Me.btnNewLesson.Location = New System.Drawing.Point(48, 12)
        Me.btnNewLesson.Name = "btnNewLesson"
        Me.btnNewLesson.Size = New System.Drawing.Size(85, 39)
        Me.btnNewLesson.TabIndex = 27
        Me.btnNewLesson.Text = "Create New Lessons"
        Me.btnNewLesson.UseVisualStyleBackColor = True
        '
        'comboSubject
        '
        Me.comboSubject.FormattingEnabled = True
        Me.comboSubject.Location = New System.Drawing.Point(80, 100)
        Me.comboSubject.Name = "comboSubject"
        Me.comboSubject.Size = New System.Drawing.Size(144, 23)
        Me.comboSubject.TabIndex = 26
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(16, 187)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(27, 15)
        Me.lblDay.TabIndex = 25
        Me.lblDay.Text = "Day"
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
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.Location = New System.Drawing.Point(16, 132)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(47, 15)
        Me.lblTeacher.TabIndex = 23
        Me.lblTeacher.Text = "Teacher"
        '
        'comboTeacher
        '
        Me.comboTeacher.FormattingEnabled = True
        Me.comboTeacher.Location = New System.Drawing.Point(80, 129)
        Me.comboTeacher.Name = "comboTeacher"
        Me.comboTeacher.Size = New System.Drawing.Size(144, 23)
        Me.comboTeacher.TabIndex = 39
        '
        'comboDay
        '
        Me.comboDay.FormattingEnabled = True
        Me.comboDay.Location = New System.Drawing.Point(80, 187)
        Me.comboDay.Name = "comboDay"
        Me.comboDay.Size = New System.Drawing.Size(144, 23)
        Me.comboDay.TabIndex = 40
        '
        'numPeriod
        '
        Me.numPeriod.Location = New System.Drawing.Point(80, 158)
        Me.numPeriod.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numPeriod.Name = "numPeriod"
        Me.numPeriod.Size = New System.Drawing.Size(144, 23)
        Me.numPeriod.TabIndex = 41
        '
        'Lessons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 285)
        Me.Controls.Add(Me.numPeriod)
        Me.Controls.Add(Me.comboDay)
        Me.Controls.Add(Me.comboTeacher)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.btnNewLesson)
        Me.Controls.Add(Me.comboSubject)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblTeacher)
        Me.Controls.Add(Me.lstLessons)
        Me.Name = "Lessons"
        Me.Text = "Lessons"
        CType(Me.numPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLessons As ListBox
    Friend WithEvents chkUpdate As CheckBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblSubject As Label
    Friend WithEvents btnNewLesson As Button
    Friend WithEvents comboSubject As ComboBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblTeacher As Label
    Friend WithEvents comboTeacher As ComboBox
    Friend WithEvents comboDay As ComboBox
    Friend WithEvents numPeriod As NumericUpDown
End Class
