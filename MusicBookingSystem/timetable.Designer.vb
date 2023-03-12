<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Timetable
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
        Me.dataTimetable = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTimetable = New System.Windows.Forms.Label()
        Me.comboRoom = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        CType(Me.dataTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataTimetable
        '
        Me.dataTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTimetable.Location = New System.Drawing.Point(42, 84)
        Me.dataTimetable.Name = "dataTimetable"
        Me.dataTimetable.RowHeadersWidth = 100
        Me.dataTimetable.RowTemplate.Height = 25
        Me.dataTimetable.Size = New System.Drawing.Size(605, 154)
        Me.dataTimetable.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(572, 244)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTimetable
        '
        Me.lblTimetable.AutoSize = True
        Me.lblTimetable.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimetable.Location = New System.Drawing.Point(288, 9)
        Me.lblTimetable.Name = "lblTimetable"
        Me.lblTimetable.Size = New System.Drawing.Size(120, 32)
        Me.lblTimetable.TabIndex = 2
        Me.lblTimetable.Text = "Timetable"
        '
        'comboRoom
        '
        Me.comboRoom.FormattingEnabled = True
        Me.comboRoom.Location = New System.Drawing.Point(214, 44)
        Me.comboRoom.Name = "comboRoom"
        Me.comboRoom.Size = New System.Drawing.Size(284, 23)
        Me.comboRoom.TabIndex = 3
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(572, 31)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(42, 31)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 5
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'Timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 311)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.comboRoom)
        Me.Controls.Add(Me.lblTimetable)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dataTimetable)
        Me.Name = "Timetable"
        Me.Text = "Timetable"
        CType(Me.dataTimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataTimetable As DataGridView
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTimetable As Label
    Friend WithEvents comboRoom As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
End Class
