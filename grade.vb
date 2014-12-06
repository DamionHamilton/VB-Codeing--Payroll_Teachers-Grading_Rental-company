'Damion Hamilton
'Program used to Produce Teaher Class Grades
'Reading from temp. file

Public Class grade
    Dim userinput As String
    Dim lname As String
    Dim fname As String
    Dim ss As Integer
    Dim g1 As Integer
    Dim g2 As Integer
    Dim g3 As Integer
    Dim g4 As Integer
    Dim g5 As Integer
    Dim g6 As Integer
    Dim avg As Integer
    Dim min As Integer
    Dim max As Integer
    Dim lg As Char


    Dim count As Integer

    Dim st1 As String = "{0,-3} {1,-11}{2,-11}{3,-5}{4,-6}{5,-6}{6,-6}{7,-6}{8,-6}{9,-6}{10,-6}{11,-6}{12,-6}{13,-12}"

    '''Function for Caculating grade point Average

    Function average(ByRef avg As Integer) As Integer


        Dim a As Integer

        a = (g1 + g2 + g3 + g4 + g5 + g6) / 6


        Return (a)

    End Function

    ''''Function for calculating smallest grade of student

    Function minnm(ByRef min As Integer) As Integer

        If (g1 <= g2 And g1 <= g3 And g1 <= g4 And g1 <= g5 And g1 <= g6) Then
            min = g1
        ElseIf (g2 <= g1 And g2 <= g3 And g2 <= g4 And g2 <= g5 And g2 <= g6) Then
            min = g2
        ElseIf (g3 <= g1 And g3 <= g2 And g3 <= g4 And g3 <= g5 And g3 <= g6) Then
            min = g3
        ElseIf (g4 <= g1 And g4 <= g2 And g4 <= g3 And g4 <= g5 And g4 <= g6) Then
            min = g4
        ElseIf (g5 <= g1 And g5 <= g2 And g5 <= g3 And g5 <= g4 And g5 <= g6) Then
            min = g5
        ElseIf (g6 <= g1 And g6 <= g2 And g6 <= g3 And g6 <= g4 And g6 <= g5) Then
            min = g6
        End If





        Return (min)

    End Function

    ''''Function for Calculating Highest grade of student

    Function maxim(ByRef max As Integer) As Integer


        If (g1 >= g2 And g1 >= g3 And g1 >= g4 And g1 >= g5 And g1 >= g6) Then
            max = g1
        ElseIf (g2 >= g1 And g2 >= g3 And g2 >= g4 And g2 >= g5 And g2 >= g6) Then
            max = g2
        ElseIf (g3 >= g1 And g3 >= g2 And g3 >= g4 And g3 >= g5 And g3 >= g6) Then
            max = g3
        ElseIf (g4 >= g1 And g4 >= g2 And g4 >= g3 And g4 >= g5 And g4 >= g6) Then
            max = g4
        ElseIf (g5 >= g1 And g5 >= g2 And g5 >= g3 And g5 >= g4 And g5 >= g6) Then
            max = g5
        ElseIf (g6 >= g1 And g6 >= g2 And g6 >= g3 And g6 >= g4 And g6 >= g5) Then
            max = g6
        End If



        Return (max)

    End Function

    '''Function to determind the grade of student by letters


    Function letter(ByRef lg As Char) As Char


        Select Case (avg)
            Case Is >= 90
                lg = "A"
            Case 80 To 89
                lg = "B"
            Case 70 To 79
                lg = "C"
            Case 60 To 69
                lg = "D"
            Case 59 To 0
                lg = "F"
        End Select

        Return (lg)
    End Function

    '''Button2 = Display students information reading from data file

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Visible = True
        ListBox1.Items.Clear()
        Dim sr As IO.StreamReader = IO.File.OpenText("C:\Users\Damion\Desktop\My Programs\final Programs 5--10\Programs 5--10\Students.txt")


        userinput = TextBox1.Text



        Do
            ss = sr.ReadLine
            lname = sr.ReadLine
            fname = sr.ReadLine
            g1 = sr.ReadLine
            g2 = sr.ReadLine
            g3 = sr.ReadLine
            g4 = sr.ReadLine
            g5 = sr.ReadLine
            g6 = sr.ReadLine

            avg = average(avg)
            min = minnm(min)
            max = maxim(max)
            lg = letter(lg)

        Loop Until userinput = ss



        ListBox1.Items.Add(String.Format(st1, "", "Lname", "Fname", "SS#", "G1", "G2", "G3", "G4", "G5", "G6", "Avg.", "Min.", "Max.", "Letter_grade"))
        ListBox1.Items.Add("")
        ListBox1.Items.Add(String.Format(st1, "", lname, fname, ss, g1, g2, g3, g4, g5, g6, avg, min, max, lg))

















    End Sub

    Private Sub grade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    '''Button1 = Display all students in data file


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Visible = True

        ListBox1.Items.Clear()
        ListBox1.Items.Add(String.Format(st1, "NO.", "Lname", "Fname", "SS#", "G1", "G2", "G3", "G4", "G5", "G6", "Avg.", "Min.", "Max.", "Letter_grade"))
        ListBox1.Items.Add("")

        Dim sr As IO.StreamReader = IO.File.OpenText("C:\Users\Damion\Desktop\My Programs\final Programs 5--10\Programs 5--10\Students.txt")



        For i = 1 To 10

            count = i
            ss = sr.ReadLine
            lname = sr.ReadLine
            fname = sr.ReadLine
            g1 = sr.ReadLine
            g2 = sr.ReadLine
            g3 = sr.ReadLine
            g4 = sr.ReadLine
            g5 = sr.ReadLine
            g6 = sr.ReadLine

            avg = average(avg)
            min = minnm(min)
            max = maxim(max)
            lg = letter(lg)


            ListBox1.Items.Add(String.Format(st1, count, lname, fname, ss, g1, g2, g3, g4, g5, g6, avg, min, max, lg))



        Next


        sr.Close()

    End Sub

    '''Button5 = Exit button


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    '''Button 4 = PrintPreview


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub


    ''' Button3 = Print


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrintForm1.Print()
    End Sub

    ''' Button 8 = Clear all open fields

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
        ListBox1.Visible = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class