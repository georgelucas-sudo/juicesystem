Public Class Form1

    'for breakfast'
    Const PanCakes As Integer = 5000
    Const Chapats As Integer = 3000
    Const Bread As Integer = 2500
    Const JuiceSoda As Integer = 3000
    Const Eggs As Integer = 1500
    Const Tea As Integer = 2000

    'for lunch'
    Const PilawoLiver As Integer = 15000
    Const ChipsChicken As Integer = 20000
    Const beafChips As Integer = 14000
    Const ChickenMatooke As Integer = 35000
    Const PlainChips As Integer = 7000


    'other variables
    Dim cost, balance As Integer
    Dim mealCounter As Integer



    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        'lets first capture the total amount of selected meals'
        Dim isBreakFastSelected As Boolean


        If CheckBox1.Checked = True Then
            cost += PanCakes
            isBreakFastSelected = True


        End If
        If CheckBox2.Checked = True Then
            cost += Chapats
            isBreakFastSelected = True

        End If
        If CheckBox3.Checked = True Then
            cost += Bread
            isBreakFastSelected = True
        End If
        If CheckBox4.Checked = True Then
            cost += JuiceSoda
            isBreakFastSelected = True


        End If
        If CheckBox5.Checked = True Then
            cost += Eggs
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
            MsgBox("please select something")

        ElseIf txtAmount.Text = "" Then

            MsgBox("Where is your money")


            cost = 0


        ElseIf amount >= cost And isBreakFastSelected = True


            mealCounter += 1

            ListBox1.Items.Add("****Meal number " & mealCounter & "****")



            If CheckBox1.Checked = True Then

                ListBox1.Items.Add("pancake,")
            End If
            If CheckBox2.Checked = True Then


                ListBox1.Items.Add("chapats,")
            End If
            If CheckBox3.Checked = True Then


                ListBox1.Items.Add("bread,")
            End If
            If CheckBox4.Checked = True Then


                ListBox1.Items.Add("juice,")
            End If
            If CheckBox5.Checked = True Then


                ListBox1.Items.Add("Eggs,")
            End If
            If CheckBox6.Checked = True Then


                ListBox1.Items.Add("Tea,")

            End If

            lblCost.Text = cost
            lblBalance.Text = amount - cost




            ListBox1.Items.Add("...." & cost &
               ".....")

            cost = 0





        Else

            MsgBox("You don't have enough money, add again this amount " & cost - amount)
            cost = 0


        End If

    End Sub
End Class
