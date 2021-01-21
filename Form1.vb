'Jenna Lambert
'9/11/18
'Average App
Public Class Form1 'Starting Form
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click 'Starting Sub. Button click event: when the user clicks the "Calculate" Button.
        Dim Num1 As Double 'defining variable "Num1" as a double variable
        Dim Num2 As Double 'defining variable "num2" as a double variable
        Dim Num3 As Double 'defining variable "num3" as a double variable
        Dim Avg As Double 'defining varibale "Avg" as a double variable
        Num1 = txtNum1.Text 'setting variable Num1 to the text property of txtnum1
        Num2 = txtNum2.Text 'setting variable num2 to the text property of txtnum2
        Num3 = txtNum3.Text 'setting variable num3 to the text property of txtnum3
        Avg = (Num1 + Num2 + Num3) / 3 'calcualting the average and setting it equal to variable Avg
        lblAvg.Text = Avg 'setting variable avg to the text property of lblAvg
    End Sub 'ending sub
    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged 'starting sub. text chacnged event: when the user changes the text in txtnum1
        lblAvg.Text = " " 'changing the text in lblavg to be blank
    End Sub 'ending sub
    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged 'starting sub. text changed event: when the user changes the text in txtnum2
        lblAvg.Text = " " 'changing the text in lblavg to be blank
    End Sub 'ending sub
    Private Sub txtNum3_TextChanged(sender As Object, e As EventArgs) Handles txtNum3.TextChanged 'starting sub. text changed event: when the user changes the text in txtnum3
        lblAvg.Text = " " 'changing the text in lblavg to be blank
    End Sub 'ending sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class 'ending class
