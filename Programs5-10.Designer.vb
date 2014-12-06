<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhyUseItToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurposeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button13 = New System.Windows.Forms.Button()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Program5ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program6ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program7ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectionsToolStripMenuItem})
        Me.HowToToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HowToToolStripMenuItem.Text = "Directions"
        '
        'WhyUseItToolStripMenuItem
        '
        Me.WhyUseItToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurposeToolStripMenuItem})
        Me.WhyUseItToolStripMenuItem.Name = "WhyUseItToolStripMenuItem"
        Me.WhyUseItToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.WhyUseItToolStripMenuItem.Text = "Why use it!"
        '
        'PurposeToolStripMenuItem
        '
        Me.PurposeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Program5ToolStripMenuItem, Me.Program6ToolStripMenuItem, Me.Program7ToolStripMenuItem})
        Me.PurposeToolStripMenuItem.Name = "PurposeToolStripMenuItem"
        Me.PurposeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurposeToolStripMenuItem.Text = "Purpose"
        '
        'Program5ToolStripMenuItem
        '
        Me.Program5ToolStripMenuItem.Name = "Program5ToolStripMenuItem"
        Me.Program5ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.Program5ToolStripMenuItem.Text = "Rental Company"
        '
        'Program6ToolStripMenuItem
        '
        Me.Program6ToolStripMenuItem.Name = "Program6ToolStripMenuItem"
        Me.Program6ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.Program6ToolStripMenuItem.Text = "Class Grades"
        '
        'Program7ToolStripMenuItem
        '
        Me.Program7ToolStripMenuItem.Name = "Program7ToolStripMenuItem"
        Me.Program7ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.Program7ToolStripMenuItem.Text = "Payroll"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToToolStripMenuItem, Me.WhyUseItToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(275, 379)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 3
        Me.Button13.Text = "print"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Rental Comapny"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(160, 15)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(69, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Class Grades"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(272, 15)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(41, 13)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Payroll "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(104, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Location = New System.Drawing.Point(112, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 44)
        Me.Panel1.TabIndex = 10
        '
        'Program5ToolStripMenuItem1
        '
        Me.Program5ToolStripMenuItem1.Name = "Program5ToolStripMenuItem1"
        Me.Program5ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.Program5ToolStripMenuItem1.Text = "Rental Company"
        '
        'Program6ToolStripMenuItem1
        '
        Me.Program6ToolStripMenuItem1.Name = "Program6ToolStripMenuItem1"
        Me.Program6ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.Program6ToolStripMenuItem1.Text = "Class Grades"
        '
        'Program7ToolStripMenuItem1
        '
        Me.Program7ToolStripMenuItem1.Name = "Program7ToolStripMenuItem1"
        Me.Program7ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.Program7ToolStripMenuItem1.Text = "Payroll"
        '
        'DirectionsToolStripMenuItem
        '
        Me.DirectionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Program5ToolStripMenuItem1, Me.Program6ToolStripMenuItem1, Me.Program7ToolStripMenuItem1})
        Me.DirectionsToolStripMenuItem.Name = "DirectionsToolStripMenuItem"
        Me.DirectionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DirectionsToolStripMenuItem.Text = "Programs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(646, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Programs 5-10"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HowToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhyUseItToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurposeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DirectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program5ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program6ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program7ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
