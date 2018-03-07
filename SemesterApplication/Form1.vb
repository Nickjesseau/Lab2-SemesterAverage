'Name:                Average Units Shipped
'Author:              Nicholas Jesseau
'Date:                Feburary 20th, 2018
'Description:         A windows Form that is used to calculate the letter
'                     grade, the average grade of an array of grades.
Option Strict On
Public Class frmSemesterGrades
    'Declarations
    'Variables
    'used for input validation
    Dim inputUnits As Double
    'Declaring the array
    Private arrayGrades(5) As Double
    'Boolean for validation
    Dim isValid As Boolean = False
    'Storing letter grade for further use
    Dim letterGrade As String

    Private Sub frmSemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Code for exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close the form
        Me.Close()
    End Sub

    'code for enter button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Constants
        'Declaring last day
        Dim lastGrade As Integer = 6
        'Variables
        'Declaring total for math equation
        Dim totalGrade As Double = 0
        'The math output is stored here
        Dim averageGrade As Double = 0

        'Looping through to get the total grade
        For index As Integer = 0 To arrayGrades.Length - 1
            totalGrade = totalGrade + arrayGrades(index)

        Next
        'after finding total grade divide it by total grades
        averageGrade = totalGrade / lastGrade

        'displaying the result
        lbAverage.Text = averageGrade.ToString("n2")

        'Passing the semester average through grade evaulation
        GradeEvaluation(averageGrade)

        'Displaying the outcome
        lbSemesterResult.Text = letterGrade

        'Setting the input boxes so they cannot be used
        tbCourseInput1.Enabled = False
        tbCourseInput2.Enabled = False
        tbCourseInput3.Enabled = False
        tbCourseInput4.Enabled = False
        tbCourseInput5.Enabled = False
        tbCourseInput6.Enabled = False
        btnCalculate.Enabled = False

        'Focusing to reset the form
        btnReset.Focus()
    End Sub

    'Code for validation
    Private Sub InputValidation(tbInput As String)

        'testing if the input is a double
        If (Not Double.TryParse(tbInput, inputUnits)) Then
            'Displaying error message
            lbErrorOutput.Text = ("Please enter a number")
            'setting bool to false to loop it again
            isValid = False

            'checking if the input is between required range
        ElseIf (Convert.ToDouble(tbInput) < 0 Or (Convert.ToDouble(tbInput) >= 100)) Then
            'displaying error message
            lbErrorOutput.Text = ("Please enter a grade between 0 and 100")
            'setting bool to false to loop again
            isValid = False

        Else
            'setting bool to true to continue code
            isValid = True
        End If
    End Sub

    'Code for Grade Evaluation
    Public Sub GradeEvaluation(ByVal inputUnits As Double)
        'Seleting the correct grade
        Select Case inputUnits
            Case 0 To 49.99
                letterGrade = "F"
            Case 50 To 52.99
                letterGrade = "D-"
            Case 53 To 56.99
                letterGrade = "D"
            Case 57 To 59.99
                letterGrade = "D+"
            Case 60 To 62.99
                letterGrade = "C-"
            Case 63 To 66.99
                letterGrade = "C"
            Case 67 To 69.99
                letterGrade = "C+"
            Case 70 To 72.99
                letterGrade = "B-"
            Case 73 To 76.99
                letterGrade = "B"
            Case 77 To 79.99
                letterGrade = "B+"
            Case 80 To 84.99
                letterGrade = "A-"
            Case 85 To 89.99
                letterGrade = "A"
            Case 90 To 100
                letterGrade = "A+"
        End Select
    End Sub

    'Code for lost focus 1
    Private Sub tbCourseInput1_LostFocus(sender As Object, e As EventArgs) Handles tbCourseInput1.LostFocus
        'validating the textbox
        InputValidation(tbCourseInput1.Text)

        'if statment to see if code will continue or loop
        If (isValid = False) Then
            tbCourseInput1.Focus()
            tbCourseInput1.SelectAll()
        End If
        'code is continuing and applying the input to the array
        If (isValid = True) Then
            GradeEvaluation(inputUnits)
            arrayGrades(0) = inputUnits
            lbCourseResult1.Text = letterGrade
        End If
    End Sub

    'Code for lost focus 2
    Private Sub tbCourseInput2_LostFocus(sender As Object, e As EventArgs) Handles tbCourseInput2.LostFocus
        'validating the textbox
        If (tbCourseInput1.Text = "") Then
            tbCourseInput1.Focus()
        Else
            InputValidation(tbCourseInput2.Text)
            'if statment to see if code will continue or loop
            If (isValid = False) Then
                tbCourseInput2.Focus()
                tbCourseInput2.SelectAll()
                'code is continuing and applying the input to the array
            End If
            If (isValid = True) Then
                GradeEvaluation(inputUnits)
                arrayGrades(1) = inputUnits
                lbCourseResult2.Text = letterGrade
            End If
        End If
    End Sub

    'Code for lost focus 3
    Private Sub tbCourseInput3_LostFocus(sender As Object, e As EventArgs) Handles tbCourseInput3.LostFocus
        'validating the textbox
        If (tbCourseInput2.Text = "") Then
            tbCourseInput2.Focus()
        Else
            InputValidation(tbCourseInput3.Text)
            'if statment to see if code will continue or loop
            If (isValid = False) Then
                tbCourseInput3.Focus()
                tbCourseInput3.SelectAll()
                'code is continuing and applying the input to the array
            End If
            If (isValid = True) Then
                GradeEvaluation(inputUnits)
                arrayGrades(2) = inputUnits
                lbCourseResult3.Text = letterGrade
            End If
        End If
    End Sub

    'Code for lost focus 4
    Private Sub tbCourseInput4_LostFocus(sender As Object, e As EventArgs) Handles tbCourseInput4.LostFocus
        'validating the textbox
        If (tbCourseInput3.Text = "") Then
            tbCourseInput3.Focus()
        Else
            InputValidation(tbCourseInput4.Text)
            'if statment to see if code will continue or loop
            If (isValid = False) Then
                tbCourseInput4.Focus()
                tbCourseInput4.SelectAll()
                'code is continuing and applying the input to the array
            End If
            If (isValid = True) Then
                GradeEvaluation(inputUnits)
                arrayGrades(3) = inputUnits
                lbCourseResult4.Text = letterGrade
            End If
        End If
    End Sub

    'Code for lost focus 5
    Private Sub tbCourseInput5_LostFocus(sender As Object, e As EventArgs) Handles tbCourseInput5.LostFocus
        'validating the textbox
        If (tbCourseInput4.Text = "") Then
            tbCourseInput4.Focus()
        Else
            InputValidation(tbCourseInput5.Text)
            'if statment to see if code will continue or loop
            If (isValid = False) Then
                tbCourseInput5.Focus()
                tbCourseInput5.SelectAll()
                'code is continuing and applying the input to the array
            End If
            If (isValid = True) Then
                GradeEvaluation(inputUnits)
                arrayGrades(4) = inputUnits
                lbCourseResult5.Text = letterGrade
            End If
        End If
    End Sub

    'Code for lost focus 6
    Private Sub tbCourseInput6_LostFocus(sender As Object, e As EventArgs) Handles tbCourseInput6.LostFocus
        'validating the textbox
        If (tbCourseInput5.Text = "") Then
            tbCourseInput5.Focus()
        Else
            InputValidation(tbCourseInput6.Text)
            'if statment to see if code will continue or loop
            If (isValid = False) Then
                tbCourseInput6.Focus()
                tbCourseInput6.SelectAll()
                'code is continuing and applying the input to the array
            End If
            If (isValid = True) Then
                GradeEvaluation(inputUnits)
                arrayGrades(5) = inputUnits
                lbCourseResult6.Text = letterGrade
            End If
        End If
    End Sub

    'code for button reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'callnig the reset method
        ResetMethod()
        'Calling the reset method
        ResetMethod()
    End Sub

    'Code for reset method
    Private Sub ResetMethod()

        tbCourseInput1.Focus()

        'Reset the input text box
        tbCourseInput1.ResetText()
        'Reset the input text box
        tbCourseInput2.ResetText()
        'Reset the input text box
        tbCourseInput3.ResetText()
        'Reset the input text box
        tbCourseInput4.ResetText()
        'Reset the input text box
        tbCourseInput5.ResetText()
        'Reset the input text box
        tbCourseInput6.ResetText()

        'resetting the labels
        lbCourseResult1.ResetText()
        lbCourseResult2.ResetText()
        lbCourseResult3.ResetText()
        lbCourseResult4.ResetText()
        lbCourseResult5.ResetText()
        lbCourseResult6.ResetText()
        lbAverage.ResetText()

        'Activating the text boxes again
        tbCourseInput1.Enabled = True
        tbCourseInput2.Enabled = True
        tbCourseInput3.Enabled = True
        tbCourseInput4.Enabled = True
        tbCourseInput5.Enabled = True
        tbCourseInput6.Enabled = True
        btnCalculate.Enabled = True

        'Reseting the label result
        lbSemesterResult.ResetText()
        'Resetting the error output
        lbErrorOutput.ResetText()

        'For loop to reset the array
        For index As Integer = 0 To arrayGrades.Length - 1

            'Setting each element to 0
            arrayGrades(index) = 0
        Next
    End Sub
End Class