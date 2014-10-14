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
        Me.rdoRock = New System.Windows.Forms.RadioButton()
        Me.rdoPaper = New System.Windows.Forms.RadioButton()
        Me.rdoScissors = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHumanDisplay = New System.Windows.Forms.Label()
        Me.lblComputerDisplay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOutcome = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblHumanScore = New System.Windows.Forms.Label()
        Me.lblCompScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPlay2 = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdoRock
        '
        Me.rdoRock.AutoSize = True
        Me.rdoRock.Location = New System.Drawing.Point(29, 111)
        Me.rdoRock.Name = "rdoRock"
        Me.rdoRock.Size = New System.Drawing.Size(51, 17)
        Me.rdoRock.TabIndex = 0
        Me.rdoRock.TabStop = True
        Me.rdoRock.Text = "Rock"
        Me.rdoRock.UseVisualStyleBackColor = True
        '
        'rdoPaper
        '
        Me.rdoPaper.AutoSize = True
        Me.rdoPaper.Location = New System.Drawing.Point(29, 134)
        Me.rdoPaper.Name = "rdoPaper"
        Me.rdoPaper.Size = New System.Drawing.Size(53, 17)
        Me.rdoPaper.TabIndex = 1
        Me.rdoPaper.TabStop = True
        Me.rdoPaper.Text = "Paper"
        Me.rdoPaper.UseVisualStyleBackColor = True
        '
        'rdoScissors
        '
        Me.rdoScissors.AutoSize = True
        Me.rdoScissors.Location = New System.Drawing.Point(29, 157)
        Me.rdoScissors.Name = "rdoScissors"
        Me.rdoScissors.Size = New System.Drawing.Size(64, 17)
        Me.rdoScissors.TabIndex = 2
        Me.rdoScissors.TabStop = True
        Me.rdoScissors.Text = "Scissors"
        Me.rdoScissors.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 53)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rock...Paper...Scissors!!!"
        '
        'lblHumanDisplay
        '
        Me.lblHumanDisplay.AutoSize = True
        Me.lblHumanDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumanDisplay.Location = New System.Drawing.Point(152, 177)
        Me.lblHumanDisplay.Name = "lblHumanDisplay"
        Me.lblHumanDisplay.Size = New System.Drawing.Size(0, 24)
        Me.lblHumanDisplay.TabIndex = 4
        '
        'lblComputerDisplay
        '
        Me.lblComputerDisplay.AutoSize = True
        Me.lblComputerDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerDisplay.Location = New System.Drawing.Point(354, 177)
        Me.lblComputerDisplay.Name = "lblComputerDisplay"
        Me.lblComputerDisplay.Size = New System.Drawing.Size(0, 24)
        Me.lblComputerDisplay.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(484, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Computer"
        '
        'lblOutcome
        '
        Me.lblOutcome.AutoSize = True
        Me.lblOutcome.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutcome.Location = New System.Drawing.Point(138, 109)
        Me.lblOutcome.MinimumSize = New System.Drawing.Size(300, 18)
        Me.lblOutcome.Name = "lblOutcome"
        Me.lblOutcome.Size = New System.Drawing.Size(300, 18)
        Me.lblOutcome.TabIndex = 8
        Me.lblOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(29, 180)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 9
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblHumanScore
        '
        Me.lblHumanScore.AutoSize = True
        Me.lblHumanScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumanScore.Location = New System.Drawing.Point(221, 282)
        Me.lblHumanScore.Name = "lblHumanScore"
        Me.lblHumanScore.Size = New System.Drawing.Size(49, 54)
        Me.lblHumanScore.TabIndex = 10
        Me.lblHumanScore.Text = "0"
        '
        'lblCompScore
        '
        Me.lblCompScore.AutoSize = True
        Me.lblCompScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompScore.Location = New System.Drawing.Point(315, 282)
        Me.lblCompScore.Name = "lblCompScore"
        Me.lblCompScore.Size = New System.Drawing.Size(49, 54)
        Me.lblCompScore.TabIndex = 11
        Me.lblCompScore.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "You"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PC"
        '
        'btnPlay2
        '
        Me.btnPlay2.Location = New System.Drawing.Point(29, 210)
        Me.btnPlay2.Name = "btnPlay2"
        Me.btnPlay2.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay2.TabIndex = 14
        Me.btnPlay2.Text = "Play"
        Me.btnPlay2.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(488, 312)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 15
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 366)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnPlay2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCompScore)
        Me.Controls.Add(Me.lblHumanScore)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblOutcome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblComputerDisplay)
        Me.Controls.Add(Me.lblHumanDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdoScissors)
        Me.Controls.Add(Me.rdoPaper)
        Me.Controls.Add(Me.rdoRock)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoRock As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rdoScissors As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHumanDisplay As System.Windows.Forms.Label
    Friend WithEvents lblComputerDisplay As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOutcome As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblHumanScore As System.Windows.Forms.Label
    Friend WithEvents lblCompScore As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPlay2 As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button

End Class
