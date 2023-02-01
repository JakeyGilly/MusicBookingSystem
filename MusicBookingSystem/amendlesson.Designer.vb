<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class amendLesson
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
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.comboSubject = New System.Windows.Forms.ComboBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.btnNewLesson = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.datepick = New System.Windows.Forms.DateTimePicker()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.comboTeacher = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.Location = New System.Drawing.Point(37, 117)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(47, 15)
        Me.lblTeacher.TabIndex = 0
        Me.lblTeacher.Text = "Teacher"
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
        'comboSubject
        '
        Me.comboSubject.FormattingEnabled = True
        Me.comboSubject.Location = New System.Drawing.Point(101, 79)
        Me.comboSubject.Name = "comboSubject"
        Me.comboSubject.Size = New System.Drawing.Size(144, 23)
        Me.comboSubject.TabIndex = 3
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(101, 157)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(144, 23)
        Me.txtPeriod.TabIndex = 4
        '
        'btnNewLesson
        '
        Me.btnNewLesson.Location = New System.Drawing.Point(287, 24)
        Me.btnNewLesson.Name = "btnNewLesson"
        Me.btnNewLesson.Size = New System.Drawing.Size(85, 39)
        Me.btnNewLesson.TabIndex = 8
        Me.btnNewLesson.Text = "Create New Lesson"
        Me.btnNewLesson.UseVisualStyleBackColor = True
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
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(37, 79)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 15)
        Me.lblSubject.TabIndex = 12
        Me.lblSubject.Text = "Subject"
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
        'comboTeacher
        '
        Me.comboTeacher.FormattingEnabled = True
        Me.comboTeacher.Location = New System.Drawing.Point(101, 114)
        Me.comboTeacher.Name = "comboTeacher"
        Me.comboTeacher.Size = New System.Drawing.Size(144, 23)
        Me.comboTeacher.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'amendLesson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 355)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboTeacher)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.datepick)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNewLesson)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.comboSubject)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblTeacher)
        Me.Name = "amendLesson"
        Me.Text = "amendLesson"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeacher As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents comboSubject As ComboBox
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents btnNewLesson As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents datepick As DateTimePicker
    Friend WithEvents lblSubject As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents comboTeacher As ComboBox
    Friend WithEvents Button1 As Button
End Class
