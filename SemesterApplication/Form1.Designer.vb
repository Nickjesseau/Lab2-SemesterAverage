<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
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
        Me.components = New System.ComponentModel.Container()
        Me.lbCourse1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SemesterApplicationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbCourseInput1 = New System.Windows.Forms.TextBox()
        Me.tbCourseInput2 = New System.Windows.Forms.TextBox()
        Me.tbCourseInput3 = New System.Windows.Forms.TextBox()
        Me.tbCourseInput4 = New System.Windows.Forms.TextBox()
        Me.tbCourseInput5 = New System.Windows.Forms.TextBox()
        Me.tbCourseInput6 = New System.Windows.Forms.TextBox()
        Me.lbCourseResult1 = New System.Windows.Forms.Label()
        Me.lbCourseResult2 = New System.Windows.Forms.Label()
        Me.lbCourseResult3 = New System.Windows.Forms.Label()
        Me.lbCourseResult4 = New System.Windows.Forms.Label()
        Me.lbCourseResult5 = New System.Windows.Forms.Label()
        Me.lbCourseResult6 = New System.Windows.Forms.Label()
        Me.lbAverage = New System.Windows.Forms.Label()
        Me.lbSemesterResult = New System.Windows.Forms.Label()
        Me.lbErrorOutput = New System.Windows.Forms.Label()
        Me.lbSemesterAverage = New System.Windows.Forms.Label()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbCourse1
        '
        Me.lbCourse1.Location = New System.Drawing.Point(31, 18)
        Me.lbCourse1.Name = "lbCourse1"
        Me.lbCourse1.Size = New System.Drawing.Size(60, 15)
        Me.lbCourse1.TabIndex = 0
        Me.lbCourse1.Text = "Course &1:"
        Me.lbCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(99, 418)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterApplicationToolTip.SetToolTip(Me.btnCalculate, "Calculate the Average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(182, 418)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.SemesterApplicationToolTip.SetToolTip(Me.btnReset, "Reset the Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.SemesterApplicationToolTip.SetToolTip(Me.btnExit, "Exit the Form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbCourseInput1
        '
        Me.tbCourseInput1.Location = New System.Drawing.Point(113, 17)
        Me.tbCourseInput1.Name = "tbCourseInput1"
        Me.tbCourseInput1.Size = New System.Drawing.Size(101, 20)
        Me.tbCourseInput1.TabIndex = 1
        Me.tbCourseInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterApplicationToolTip.SetToolTip(Me.tbCourseInput1, "Course 1 Mark")
        '
        'tbCourseInput2
        '
        Me.tbCourseInput2.Location = New System.Drawing.Point(113, 56)
        Me.tbCourseInput2.Name = "tbCourseInput2"
        Me.tbCourseInput2.Size = New System.Drawing.Size(101, 20)
        Me.tbCourseInput2.TabIndex = 4
        Me.tbCourseInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterApplicationToolTip.SetToolTip(Me.tbCourseInput2, "Course 2 Mark")
        '
        'tbCourseInput3
        '
        Me.tbCourseInput3.Location = New System.Drawing.Point(113, 95)
        Me.tbCourseInput3.Name = "tbCourseInput3"
        Me.tbCourseInput3.Size = New System.Drawing.Size(101, 20)
        Me.tbCourseInput3.TabIndex = 7
        Me.tbCourseInput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterApplicationToolTip.SetToolTip(Me.tbCourseInput3, "Course 3 Mark")
        '
        'tbCourseInput4
        '
        Me.tbCourseInput4.Location = New System.Drawing.Point(113, 134)
        Me.tbCourseInput4.Name = "tbCourseInput4"
        Me.tbCourseInput4.Size = New System.Drawing.Size(101, 20)
        Me.tbCourseInput4.TabIndex = 10
        Me.tbCourseInput4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterApplicationToolTip.SetToolTip(Me.tbCourseInput4, "Course 4 Mark")
        '
        'tbCourseInput5
        '
        Me.tbCourseInput5.Location = New System.Drawing.Point(113, 173)
        Me.tbCourseInput5.Name = "tbCourseInput5"
        Me.tbCourseInput5.Size = New System.Drawing.Size(101, 20)
        Me.tbCourseInput5.TabIndex = 13
        Me.tbCourseInput5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterApplicationToolTip.SetToolTip(Me.tbCourseInput5, "Course 5 Mark")
        '
        'tbCourseInput6
        '
        Me.tbCourseInput6.Location = New System.Drawing.Point(113, 212)
        Me.tbCourseInput6.Name = "tbCourseInput6"
        Me.tbCourseInput6.Size = New System.Drawing.Size(101, 20)
        Me.tbCourseInput6.TabIndex = 16
        Me.tbCourseInput6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterApplicationToolTip.SetToolTip(Me.tbCourseInput6, "Course 6 Mark")
        '
        'lbCourseResult1
        '
        Me.lbCourseResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseResult1.Location = New System.Drawing.Point(230, 17)
        Me.lbCourseResult1.Name = "lbCourseResult1"
        Me.lbCourseResult1.Size = New System.Drawing.Size(101, 20)
        Me.lbCourseResult1.TabIndex = 2
        Me.lbCourseResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbCourseResult1, "Course 1 Result")
        '
        'lbCourseResult2
        '
        Me.lbCourseResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseResult2.Location = New System.Drawing.Point(230, 56)
        Me.lbCourseResult2.Name = "lbCourseResult2"
        Me.lbCourseResult2.Size = New System.Drawing.Size(101, 20)
        Me.lbCourseResult2.TabIndex = 5
        Me.lbCourseResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbCourseResult2, "Course 2 Result")
        '
        'lbCourseResult3
        '
        Me.lbCourseResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseResult3.Location = New System.Drawing.Point(230, 95)
        Me.lbCourseResult3.Name = "lbCourseResult3"
        Me.lbCourseResult3.Size = New System.Drawing.Size(101, 20)
        Me.lbCourseResult3.TabIndex = 8
        Me.lbCourseResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbCourseResult3, "Course 3 Result")
        '
        'lbCourseResult4
        '
        Me.lbCourseResult4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseResult4.Location = New System.Drawing.Point(230, 134)
        Me.lbCourseResult4.Name = "lbCourseResult4"
        Me.lbCourseResult4.Size = New System.Drawing.Size(101, 20)
        Me.lbCourseResult4.TabIndex = 11
        Me.lbCourseResult4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbCourseResult4, "Course 4 Result")
        '
        'lbCourseResult5
        '
        Me.lbCourseResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseResult5.Location = New System.Drawing.Point(230, 173)
        Me.lbCourseResult5.Name = "lbCourseResult5"
        Me.lbCourseResult5.Size = New System.Drawing.Size(101, 20)
        Me.lbCourseResult5.TabIndex = 14
        Me.lbCourseResult5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbCourseResult5, "Course 5 Result")
        '
        'lbCourseResult6
        '
        Me.lbCourseResult6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseResult6.Location = New System.Drawing.Point(230, 212)
        Me.lbCourseResult6.Name = "lbCourseResult6"
        Me.lbCourseResult6.Size = New System.Drawing.Size(101, 20)
        Me.lbCourseResult6.TabIndex = 17
        Me.lbCourseResult6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbCourseResult6, "Course 6 Result")
        '
        'lbAverage
        '
        Me.lbAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverage.Location = New System.Drawing.Point(113, 244)
        Me.lbAverage.Name = "lbAverage"
        Me.lbAverage.Size = New System.Drawing.Size(101, 20)
        Me.lbAverage.TabIndex = 19
        Me.lbAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbAverage, "Average")
        '
        'lbSemesterResult
        '
        Me.lbSemesterResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterResult.Location = New System.Drawing.Point(230, 244)
        Me.lbSemesterResult.Name = "lbSemesterResult"
        Me.lbSemesterResult.Size = New System.Drawing.Size(101, 20)
        Me.lbSemesterResult.TabIndex = 20
        Me.lbSemesterResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbSemesterResult, "Semester Result")
        '
        'lbErrorOutput
        '
        Me.lbErrorOutput.BackColor = System.Drawing.SystemColors.Control
        Me.lbErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbErrorOutput.Location = New System.Drawing.Point(34, 270)
        Me.lbErrorOutput.Name = "lbErrorOutput"
        Me.lbErrorOutput.Size = New System.Drawing.Size(297, 145)
        Me.lbErrorOutput.TabIndex = 21
        Me.lbErrorOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterApplicationToolTip.SetToolTip(Me.lbErrorOutput, "Error Output")
        '
        'lbSemesterAverage
        '
        Me.lbSemesterAverage.Location = New System.Drawing.Point(31, 249)
        Me.lbSemesterAverage.Name = "lbSemesterAverage"
        Me.lbSemesterAverage.Size = New System.Drawing.Size(60, 15)
        Me.lbSemesterAverage.TabIndex = 18
        Me.lbSemesterAverage.Text = "&Semester:"
        Me.lbSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse2
        '
        Me.lbCourse2.Location = New System.Drawing.Point(31, 57)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(60, 15)
        Me.lbCourse2.TabIndex = 3
        Me.lbCourse2.Text = "Course &2:"
        Me.lbCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse3
        '
        Me.lbCourse3.Location = New System.Drawing.Point(31, 96)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(60, 15)
        Me.lbCourse3.TabIndex = 6
        Me.lbCourse3.Text = "Course &3:"
        Me.lbCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse4
        '
        Me.lbCourse4.Location = New System.Drawing.Point(31, 135)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(60, 15)
        Me.lbCourse4.TabIndex = 9
        Me.lbCourse4.Text = "Course &4:"
        Me.lbCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse5
        '
        Me.lbCourse5.Location = New System.Drawing.Point(31, 174)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(60, 15)
        Me.lbCourse5.TabIndex = 12
        Me.lbCourse5.Text = "Course &5:"
        Me.lbCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse6
        '
        Me.lbCourse6.Location = New System.Drawing.Point(31, 213)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(60, 15)
        Me.lbCourse6.TabIndex = 15
        Me.lbCourse6.Text = "Course &6:"
        Me.lbCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(355, 453)
        Me.Controls.Add(Me.lbErrorOutput)
        Me.Controls.Add(Me.lbSemesterResult)
        Me.Controls.Add(Me.lbAverage)
        Me.Controls.Add(Me.lbSemesterAverage)
        Me.Controls.Add(Me.lbCourseResult6)
        Me.Controls.Add(Me.lbCourseResult5)
        Me.Controls.Add(Me.lbCourseResult4)
        Me.Controls.Add(Me.lbCourseResult3)
        Me.Controls.Add(Me.lbCourseResult2)
        Me.Controls.Add(Me.lbCourseResult1)
        Me.Controls.Add(Me.tbCourseInput6)
        Me.Controls.Add(Me.tbCourseInput5)
        Me.Controls.Add(Me.tbCourseInput4)
        Me.Controls.Add(Me.tbCourseInput3)
        Me.Controls.Add(Me.tbCourseInput2)
        Me.Controls.Add(Me.tbCourseInput1)
        Me.Controls.Add(Me.lbCourse6)
        Me.Controls.Add(Me.lbCourse5)
        Me.Controls.Add(Me.lbCourse4)
        Me.Controls.Add(Me.lbCourse3)
        Me.Controls.Add(Me.lbCourse2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbCourse1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCourse1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents SemesterApplicationToolTip As ToolTip
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbCourse2 As Label
    Friend WithEvents lbCourse3 As Label
    Friend WithEvents lbCourse4 As Label
    Friend WithEvents lbCourse5 As Label
    Friend WithEvents lbCourse6 As Label
    Friend WithEvents tbCourseInput1 As TextBox
    Friend WithEvents tbCourseInput2 As TextBox
    Friend WithEvents tbCourseInput3 As TextBox
    Friend WithEvents tbCourseInput4 As TextBox
    Friend WithEvents tbCourseInput5 As TextBox
    Friend WithEvents tbCourseInput6 As TextBox
    Friend WithEvents lbCourseResult1 As Label
    Friend WithEvents lbCourseResult2 As Label
    Friend WithEvents lbCourseResult3 As Label
    Friend WithEvents lbCourseResult4 As Label
    Friend WithEvents lbCourseResult5 As Label
    Friend WithEvents lbCourseResult6 As Label
    Friend WithEvents lbSemesterAverage As Label
    Friend WithEvents lbAverage As Label
    Friend WithEvents lbSemesterResult As Label
    Friend WithEvents lbErrorOutput As Label
End Class
