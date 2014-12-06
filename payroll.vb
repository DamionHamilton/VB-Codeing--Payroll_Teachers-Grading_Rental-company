'Damion Hamilton
'Program used to Calculate Employee's Pay

Public Class payroll
    Dim otp, gp, d, np As Double
    Dim pr As Double
    Dim h As Integer
    Dim ln, fn, num As String
    Dim hos As Double = 25.65
    Dim ud As Double = 7.85
    Dim fed As Double = 0.18
    Dim state As Double = 0.045
    Dim userinput As String
    Dim snum As String

    ''Button4 = Exit button

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    ''Display all employees reading form payroll data file

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sr As IO.StreamReader = IO.File.OpenText("C:\Users\Damion\Desktop\My Programs\final Programs 5--10\Programs 5--10\Employees.txt")

        Dim srt As String = "{0,-4}  {1,-8}{2,-6}    {3,-3}{4,-7}     {5,-12}     {6,-9}   {7,-10}    {8,-7}"
        ListBox1.Visible = True
        ListBox1.Items.Clear()

        ListBox1.Items.Add(String.Format(srt, "No.", "Last_Name", "First_Name", "Hours", "Payrate", "Overtime_pay", "Gross_Pay", "Deductions", "Net_Pay"))
        ListBox1.Items.Add("")




        For i = 1 To 5

            otp = 0
            num = sr.ReadLine
            ln = sr.ReadLine
            fn = sr.ReadLine
            pr = sr.ReadLine
            h = sr.ReadLine

            otp = overtime(otp)
            gp = gross(gp)
            d = deduction(d)
            np = net(np)

            ListBox1.Items.Add(String.Format(srt, num, ln, fn, h, pr, Format(otp, "currency"), Format(gp, "currency"), Format(d, "currency"), Format(np, "Currency")))


        Next
        sr.Close()
    End Sub

    ''Label1 = search for employee reading from Payroll data file searching for entered employees I.d number within the textbox1 control


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("C:\Users\Damion\Desktop\My Programs\final Programs 5--10\Programs 5--10\Employees.txt")

        Dim srt As String = "{0,-4}  {1,-8}{2,-6}    {3,-3}      {4,-7}     {5,-12}     {6,-9}   {7,-10}    {8,-7}"

        userinput = TextBox1.Text

        Do
            num = sr.ReadLine
            ln = sr.ReadLine
            fn = sr.ReadLine
            pr = sr.ReadLine
            h = sr.ReadLine
            otp = overtime(otp)
            gp = gross(gp)
            d = deduction(d)
            np = net(np)
            ListBox1.Items.Clear()

        Loop Until userinput = num
        ListBox1.Visible = True

        ListBox1.Items.Add(String.Format(srt, "No.", "Last_Name", "First_Name", "Hours", "Payrate", "Overtime_pay", "Gross_Pay", "Deductions", "Net_Pay"))
        ListBox1.Items.Add("")
        ListBox1.Items.Add(String.Format(srt, num, ln, fn, h, pr, Format(otp, "currency"), Format(gp, "currency"), Format(d, "currency"), Format(np, "Currency")))
        ListBox1.Items.Add("")

    End Sub

    ''Function to calculate overtime pay for employees with more than 40 hours

    Function overtime(ByVal otp As Double) As Double


        Dim temp As Double
        Dim temp1 As Double
        Dim temp2 As Double
        Dim temp3 As Double



        If (h > 40) Then

            temp = h - 40
            temp1 = pr / 2
            temp2 = temp1 + pr
            temp3 = temp2 * temp
            otp = temp3

        ElseIf (h < 40) Then

            otp = 0
        End If
        Return (otp)
    End Function

    ''Function which calculate gross pay for employees

    Function gross(ByVal gp As Double) As Double


        If (h <= 40) Then
            gp = pr * h

        ElseIf (h > 40) Then

            gp = pr * 40 + otp

        End If
        Return (gp)
    End Function

    ''Function used to deduct pre set tax and deduction fees from gross pay of employees

    Function deduction(ByVal d As Double) As Double

        Dim gtemp As Double
        Dim g1temp As Double


        gtemp = gp * fed
        g1temp = gp * state
        d = gtemp + g1temp + 25.65 + 7.85


        Return (d)

    End Function
    Function net(ByVal np As Double) As Double
        np = gp - d
        Return (np)

    End Function

    ''Button6 = Printpreview button

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    '' Button5 = Print button

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PrintForm1.Print()
    End Sub

    ''Button1 = clear all open fields

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub payroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class