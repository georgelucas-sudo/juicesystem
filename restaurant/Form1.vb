Public Class Form1

    'for drinks'
    Const Soda As Integer = 5000
    Const Water As Integer = 3000
    Const Mango_juice As Integer = 2500
    Const Orange_juice As Integer = 3000
    Const Passion_juice As Integer = 1500
    Const Tea As Integer = 2000




    'other variables
    Dim cost, balance As Integer
    Dim mealCounter As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False

        cost = 0

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        'lets first capture the total amount of selected meals'
        Dim isBreakFastSelected As Boolean


        If CheckBox1.Checked = True Then
            cost += Soda
            isBreakFastSelected = True


        End If
        If CheckBox2.Checked = True Then
            cost += Water
            isBreakFastSelected = True

        End If
        If CheckBox3.Checked = True Then
            cost += Mango_juice
            isBreakFastSelected = True
        End If
        If CheckBox4.Checked = True Then
            cost += Orange_juice
            isBreakFastSelected = True


        End If
        If CheckBox5.Checked = True Then
            cost += Passion_juice
            isBreakFastSelected = True


        End If
        If CheckBox6.Checked = True Then
            cost += Tea
            isBreakFastSelected = True


        End If





        ' lets check whether the user entered money or not
        Dim amount As Integer

        If txtAmount.Text = "" Then
            amount = 0
        Else
            amount = Integer.Parse(txtAmount.Text)


        End If


        If cost = 0 Then
            MsgBox("please select something", MsgBoxStyle.Critical)

        ElseIf txtAmount.Text = "" Then

            MsgBox("Where is your money", MsgBoxStyle.Critical)


            cost = 0


        ElseIf amount >= cost And isBreakFastSelected = True Then


            mealCounter += 1

            ListBox1.Items.Add("****Drink number " & mealCounter & "****")



            If CheckBox1.Checked = True Then

                ListBox1.Items.Add("Soda,")

            End If
            If CheckBox2.Checked = True Then


                ListBox1.Items.Add("Water,")
            End If
            If CheckBox3.Checked = True Then


                ListBox1.Items.Add("Mango Juice,")
            End If
            If CheckBox4.Checked = True Then


                ListBox1.Items.Add("Orange Juice,")
            End If
            If CheckBox5.Checked = True Then


                ListBox1.Items.Add("Passion Juice,")
            End If
            If CheckBox6.Checked = True Then


                ListBox1.Items.Add("Tea,")

            End If



            lblCost.Text = cost
            lblBalance.Text = amount - cost

            ListBox1.Items.Add("...." & cost & ".....")

            cost = 0





        Else

            MsgBox("You don't have enough money, add again this amount " & (cost - amount), MsgBoxStyle.Critical)
            cost = 0


        End If

    End Sub
End Class
