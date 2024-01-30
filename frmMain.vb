' General Procedures and Repetition Programming Assignment.
' This program displays the total cost and names of these helping to serve.
' Benjamin Andrews.


' “I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor.
' Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.” 


Imports System.Runtime.Remoting.Services

Public Class frmMain


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes application.

        Me.Close()

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add items to combo box.

        cboServing.Items.Add("Morning")
        cboServing.Items.Add("Afternoon")
        cboServing.Items.Add("Evening")

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Error checking.

        If txtPeople.Text = "" Then
            MessageBox.Show("Enter your number of people.")
            txtPeople.Focus()
            Return
        End If

        If txtVolunteers.Text = "" Then
            MessageBox.Show("Enter your number of volunteers.")
            txtVolunteers.Focus()
            Return
        End If

        If cboServing.SelectedIndex = -1 Then
            MessageBox.Show("Select a serving time.")
            cboServing.Focus()
            Return
        End If

        ' Declare variables

        Dim strServingTime As String
        Dim intCost As Integer
        Dim intNumPeople As Integer
        Dim intNumVol As Integer
        Dim intTotal As Integer


        ' Store text box values in variables

        Integer.TryParse(txtVolunteers.Text, intNumVol)
        Integer.TryParse(txtPeople.Text, intNumPeople)

        ' Calculate total count and apply discount

        strServingTime = cboServing.SelectedItem
        intCost = getCost(strServingTime)
        If intNumPeople < 10 Then
            intTotal = intCost * intNumPeople
        ElseIf intNumPeople >= 10 Then
            intTotal = (intCost * intNumPeople) - (0.1 * intCost * intNumPeople)
        End If


        ' Listbox display

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Here are your serving details:")
        lstDisplay.Items.Add("You are serving in the " & strServingTime)
        lstDisplay.Items.Add("The total cost is: " & FormatCurrency(intTotal))
        If intNumPeople >= 10 Then
            lstDisplay.Items.Add("You recieved a 10% discount.")
        End If
        lstDisplay.Items.Add("You are bringing " & intNumVol & " volunteers.")
        lstDisplay.Items.Add("-------------------------------------------------")

        If intNumVol > 0 Then
            lstDisplay.Items.Add("The names of your volunteers are: ")
            volNames(intNumVol)
        End If


    End Sub

    ' Cost function.
    Function getCost(ByVal strservingtime As String)
        Dim inttimecost As Integer


        Select Case strservingtime
            Case "Morning"
                inttimecost = 10
            Case "Afternoon"
                inttimecost = 30
            Case "Evening"
                inttimecost = 50

        End Select
        Return inttimecost

    End Function

    ' Sub to get and display volunteer names.

    Sub volNames(ByVal intNumVol As Integer)
        For intNumVol = 1 To intNumVol

            lstDisplay.Items.Add(InputBox("Enter Volunteer Name: "))

        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear textboxes, listbox, and combobox

        txtPeople.Text = String.Empty
        txtVolunteers.Text = String.Empty
        lstDisplay.Items.Clear()
        cboServing.Text = String.Empty


    End Sub
End Class
