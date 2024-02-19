Public Class form1
    Dim food() As String = IO.File.ReadAllLines("food.txt")
    Private Sub frmHolidayFoods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form Load Event

        For i As Integer = 0 To food.Count - 1
            lstDisplay.Items.Add(food(i))

        Next

    End Sub

    Private Sub btnSpecificItem_Click(sender As Object, e As EventArgs) Handles btnSpecificItem.Click
        'Specific Item 
        lstDisplay.Items.Clear()
        Dim requested As String = InputBox("Choose one Thanksgiving food!")
        Dim check As Boolean = False

        'For Loop

        For i As Integer = 0 To food.Count - 1
            Dim space As Integer = food(i).IndexOf(",")
            Dim foods As String = food(i).Substring(0, space)
            Dim foodCost As Double = CDbl(food(i).Substring(space + 1))

            If IsNumeric(requested) = True Then
                MessageBox.Show("No numbers in the textbox, please.")
                Return

            Else
                If food(i).ToUpper.StartsWith(requested.ToUpper) Then

                    lstDisplay.Items.Add("Your Item has been chosen: ")
                    lstDisplay.Items.Add(" ")
                    lstDisplay.Items.Add("Selected Item: " & foods)
                    lstDisplay.Items.Add("Cost: " & foodCost.ToString("c2"))
                    check = True

                End If


            End If

        Next
        If check = False Then
            MessageBox.Show("Your Food has not been found.")
            Return
        End If
    End Sub

    Private Sub btnSearchOverCost_Click(sender As Object, e As EventArgs) Handles btnSearchOverCost.Click
        'Search Over Given Cost

        lstDisplay.Items.Clear()
        Dim inputCost As String = InputBox("Enter a Dollar Amount!")
        Dim check As Boolean = False

        If IsNumeric(inputCost) = False Then
            MessageBox.Show("Please enter a numeric Value!")
            Return

        Else
            lstDisplay.Items.Add("Here are your requested Items:")

            For I As Integer = 0 To food.Count - 1
                Dim space As Integer = food(I).IndexOf(",")
                Dim foods As String = food(I).Substring(0, space)
                Dim foodCost As Double = CDbl(food(I).Substring(space + 1))

                If foodCost >= CDbl(inputCost) Then

                    lstDisplay.Items.Add(" ")
                    lstDisplay.Items.Add(foods)
                    lstDisplay.Items.Add("Cost: " & foodCost.ToString("c2"))
                    lstDisplay.Items.Add(" ")
                    check = True
                End If
            Next
            If check = False Then
                lstDisplay.Items.Add("We do not have any items within that price range!")
            End If
        End If

    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        'clear form
        lstDisplay.Items.Clear()
        txtCost.Clear()
        txtFood.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close form
        Me.Close()
    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        'Display all items
        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Thanksgiving Menu:")
        lstDisplay.Items.Add(" ")

        Dim totalCost As Double
        For i As Integer = 0 To food.Count - 1
            Dim space As Integer = food(i).IndexOf(",")
            Dim foods As String = food(i).Substring(0, space)
            Dim foodCost As Double = CDbl(food(i).Substring(space + 1))
            totalCost = foodCost + totalCost

            lstDisplay.Items.Add("Food: " & foods)
            lstDisplay.Items.Add("Cost: " & foodCost.ToString("c2"))
            lstDisplay.Items.Add(" ")

        Next


        lstDisplay.Items.Add("Total Cost: " & totalCost.ToString("c2"))



    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'adding Item
        lstDisplay.Items.Clear()

        Dim item, record As String
        Dim price As Double
        lstDisplay.Items.Clear()

        If IsNumeric(txtFood.Text) = True Then
            lstDisplay.Items.Add("food only")
            Return
        ElseIf IsNumeric(txtCost.Text) = False Then
            lstDisplay.Items.Add("cost only")
            Return
        End If

        ReDim Preserve food(food.Count)
        price = CDbl(txtCost.Text)
        item = CStr(txtFood.Text)
        record = item & ", " & price.ToString("c2")
        food(food.Count - 1) = record
        lstDisplay.Items.Add("Your Item has been created successfully.")
        lstDisplay.Items.Add(record)
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        'delete item
        lstDisplay.Items.Clear()

        Dim item As String
        Dim comma As Integer
        Dim check As Boolean = False
        item = CStr(txtFood.Text)

        If IsNothing(item) Then
            MessageBox.Show("Please enter a food.")
            Return
        Else
            item = CStr(txtFood.Text)
        End If

        For i As Integer = 0 To food.Count - 1
            comma = food(i).IndexOf(",")

            If item.ToUpper = food(i).ToUpper.Substring(0, comma) Then
                food(i) = food(food.Length - 1)
                food(food.Length - 1) = item
                check = True
                Exit For
            End If
        Next

        ReDim Preserve food(food.Length - 2)

        If check = False Then
            lstDisplay.Items.Add("Item was not found")
        ElseIf check = True Then
            lstDisplay.Items.Add("Item was sucessfully removed.")
        End If

    End Sub
    Private Sub btnUpdateCost_Click(sender As Object, e As EventArgs) Handles btnUpdateCost.Click
        'update costs

        Dim item, cost As String
        Dim comma As Integer
        Dim check As Boolean = False
        item = CStr(txtFood.Text)
        cost = CStr(txtCost.Text)

        If IsNumeric(txtCost.Text) = False Then
            MessageBox.Show("Please enter a price into the textbox.")
        ElseIf IsNumeric(txtFood.Text) = True Then
            MessageBox.Show("Please do not enter letters into the textbox.")
        End If

        If IsNothing(txtCost.Text) = True Then
            MessageBox.Show("Please enter a price into the textbox.")
        ElseIf IsNothing(txtFood.Text) = True Then
            MessageBox.Show("Please enter a food into the textbox.")
        End If

        For i As Integer = 0 To food.Count - 1
            comma = food(i).IndexOf(",")
            If item = food(i).Substring(0, comma) Then
                food(i) = food(i).Substring(0, comma + 1) & cost
                check = True
                Exit For
            End If

        Next

        If check = True Then
            MessageBox.Show("Item cost was updated.")
        End If
    End Sub
End Class
