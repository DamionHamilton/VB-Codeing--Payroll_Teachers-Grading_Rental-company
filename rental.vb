'Damion Hamilton
'Program used to Produce Rental company bill
'Reading from user input

Public Class rental

    'Button1 = Displays Rental Rates

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = "{0,-2} {1,-19}  {2,-9} {3,-9}"

        ListBox1.Visible = True
        ListBox1.Items.Add(String.Format(str, "", "Price of Equipment", "Half-day", "Full-day"))
        ListBox1.Items.Add("")
        ListBox1.Items.Add(String.Format(str, "1.", "Rug cleaner", "$16.00", "$24.00"))
        ListBox1.Items.Add(String.Format(str, "2.", "Lawn Mower", "$12.00", "$18.00"))
        ListBox1.Items.Add(String.Format(str, "3.", "Paint sprayer", "$20.00", "$30.00"))

    End Sub

    'Button2 = Displays Customer Bill and process Calculations

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox2.Visible = True
        Dim fd1, fd2, fd3 As Double 'fdn is full day price data n
        Dim hd1, hd2, hd3 As Double 'hdn is full day price data n
        Dim de As Double = 30.0
        Dim num As Integer
        Dim num2 As Char
        Dim dep As String = "Deposit"
        Dim a As String = "Rug Cleaner"
        Dim b As String = "Lawn Mower"
        Dim c As String = "Paint Sprayer"
        Dim d As String = "(Full day rental)"
        Dim h As String = "(Half day rental)"
        Dim t As String = "Total"
        Dim st As String = "{0,-14}  {1,7:c}   {2,19}"

        Dim l As Integer


        num = TextBox1.Text
        num2 = TextBox2.Text.ToUpper

        fd1 = 24.0
        fd2 = 18.0
        fd3 = 30.0
        hd1 = 16.0
        hd2 = 12.0
        hd3 = 20.0
        l = fd1 + de

        ListBox2.Items.Clear()


        If (num = 1 And num2 = "F") Then
            ListBox2.Items.Add("Receipt from Eddie's Equipment rental")
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, a, Format(fd1, "currency"), d))
            ListBox2.Items.Add(String.Format(st, dep, Format(de, "currency"), ""))
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, t, Format(fd1 + de, "currency"), ""))


        ElseIf (num = 1 And num2 = "H") Then

            ListBox2.Items.Add("Receipt from Eddie's Equipment rental")
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, a, Format(hd1, "currency"), h))
            ListBox2.Items.Add(String.Format(st, dep, Format(de, "currency"), ""))
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, t, Format(hd1 + de, "currency"), ""))

        ElseIf (num = 2 And num2 = "F") Then
            ListBox2.Items.Add("Receipt from Eddie's Equipment rental")
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, b, Format(fd2, "currency"), d))
            ListBox2.Items.Add(String.Format(st, dep, Format(de, "currency"), ""))
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, t, Format(fd2 + de, "currency"), ""))

        ElseIf (num = 2 And num2 = "H") Then

            ListBox2.Items.Add("Receipt from Eddie's Equipment rental")
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, b, Format(hd2, "currency"), h))
            ListBox2.Items.Add(String.Format(st, dep, Format(de, "currency"), ""))
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, t, Format(hd2 + de, "currency"), ""))

        ElseIf (num = 3 And num2 = "F") Then
            ListBox2.Items.Add("Receipt from Eddie's Equipment rental")
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, c, Format(fd3, "currency"), d))
            ListBox2.Items.Add(String.Format(st, dep, Format(de, "currency"), ""))
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, t, Format(fd3 + de, "currency"), ""))

        ElseIf (num = 3 And num2 = "H") Then
            ListBox2.Items.Add("Receipt from Eddie's Equipment rental")
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, c, Format(hd3, "currency"), h))
            ListBox2.Items.Add(String.Format(st, dep, Format(de, "currency"), ""))
            ListBox2.Items.Add("")
            ListBox2.Items.Add(String.Format(st, t, Format(hd3 + de, "currency"), ""))

        Else
            ListBox2.Items.Add("Error renter item number or letter please.")


        End If
    End Sub

    'Button5 = Clear button, clears/closes all open fields

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Visible = False
        ListBox2.Visible = False


    End Sub

    'Button8 = Print Preview

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    'Button7 = Print

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        PrintForm1.Print()
    End Sub

    'Button6 = Exit program button

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()


    End Sub


    Private Sub rental_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Button3 = Displays Directions

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Before starting the program click the display Rental rates button" & ControlChars.NewLine & " to display the rates for the corresponding tool. " & ControlChars.NewLine & "Once display rental rates have been displayed," & ControlChars.NewLine & "the corresponding number for the tool should be entered into" & ControlChars.NewLine & " the first textbox." & ControlChars.NewLine & "Next the corresponding letter for half-day(h) or full-day(f) rental;" & ControlChars.NewLine & " needs to be entered into the second text box." & ControlChars.NewLine & "After all required informantion has been enterd, the user should" & ControlChars.NewLine & " click display customer's bill button to view bill.", MsgBoxStyle.Information, "Direction")
    End Sub
End Class