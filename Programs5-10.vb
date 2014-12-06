Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rental.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grade.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        payroll.Show()

    End Sub

   



    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DirectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectionsToolStripMenuItem.Click



    End Sub

    Private Sub HowToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToToolStripMenuItem.Click

    End Sub

  

   

    Private Sub Program5ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program5ToolStripMenuItem1.Click
        MsgBox("First click the appropriat link below to open the file containg Rental Company," & ControlChars.NewLine & "next click the Display rental Rates button you will be then given a choice of three options" & ControlChars.NewLine & "You are to inter 1,2, or 3 for the type of equipment you wish to rent" & ControlChars.NewLine & "after you have chose your equipment, enter a h if you want a half day renal quote or f for full day quote then click display customer bill." & ControlChars.NewLine & " Your bill will then be displayed.")
        MsgBox("Click exit to close program")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Program6ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program6ToolStripMenuItem1.Click
        MsgBox("First click the appropriat link below to open the file containg Class Grades," & ControlChars.NewLine & "If you just want to view all Students just click the Display all button" & ControlChars.NewLine & "If you wish to view a individual student first Enter the Student Social # in the text box provided " & ControlChars.NewLine & "after you have you have entered the Social click Display student." & ControlChars.NewLine & " The student should then be displayed " & ControlChars.NewLine & " you can then click the Display all and you should see all students including the student you entered", MsgBoxStyle.Information, "Direction")

        MsgBox("Click exit to close program")
    End Sub

    Private Sub Program7ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program7ToolStripMenuItem1.Click
        MsgBox("First click the appropriat link below to open the file containg Payroll," & ControlChars.NewLine & "Then click start, the program should now be runing " & ControlChars.NewLine & "If you just want to view all Employees just click the Display all button" & ControlChars.NewLine & "If you wish to search for a employee first Enter the employee's Social in the text box provided " & ControlChars.NewLine & "after you have you have entered the Social click Display search." & ControlChars.NewLine & " The employee should then be displayed " & ControlChars.NewLine & " you can then click the Display all and you should see all employees including the employee you searched", MsgBoxStyle.Information, "Direction")

        MsgBox("Click exit to close program")
    End Sub

   


    

  

    Private Sub Program5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program5ToolStripMenuItem.Click
        MsgBox("The purpose of Eddie's Equipment Rental" & ControlChars.NewLine & " is to first give you the over view of Equipment we offer," & ControlChars.NewLine & " along with the prices for half-day rental and full-day rental" & ControlChars.NewLine & " after giving the prices and equipment the program will also provide" & ControlChars.NewLine & "you with the amount of the customers bill after the calculations are done a $30.00 deposit is already calculated in the bill.   ", MsgBoxStyle.Information, "Purpose")

    End Sub

    Private Sub Program6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program6ToolStripMenuItem.Click
        MsgBox("The purpose of the Letter Grade Program" & ControlChars.NewLine & " is to read from a data file and output the Lastname,Fristname, Social," & ControlChars.NewLine & " six grades, calculate the avg of those grades, come up with the minnimum grade," & ControlChars.NewLine & " as well as the Maximum grade and also output the Letter grade of all students" & ControlChars.NewLine & " the program should also display a idividual student after the info has been entered", MsgBoxStyle.Information, "Purpose")
    End Sub

    Private Sub Program7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program7ToolStripMenuItem.Click
        MsgBox("The purpose of the Payroll company program" & ControlChars.NewLine & " is to read from a data file and output the Lastname,Firstname,work I.D. " & ControlChars.NewLine & " Hours worked, Payrate, calculate the overtime pay, Gross Pay, deductions, along with the net pay" & ControlChars.NewLine & " the program also displays a individual worker after you have entered the information" & ControlChars.NewLine & " This program has Federal tax,stat tax,hospitalization deductions and union dues already calculated", MsgBoxStyle.Information, "Purpose")
    End Sub



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub ViewProgramTabsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        PrintForm2.Print()
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        rental.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        grade.Show()
    End Sub

   

   

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        payroll.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label1.Visible = True

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label2.Visible = True
    End Sub

    

    

    

    
    
End Class
