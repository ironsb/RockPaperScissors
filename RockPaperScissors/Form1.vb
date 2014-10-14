Public Class Form1
    Dim intCompScore As Integer = 0
    Dim intHumanScore As Integer = 0

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intCompThrow As Integer
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        Select Case intCompThrow
            Case 1
                Me.lblComputerDisplay.Text = "Rock"
            Case 2
                Me.lblComputerDisplay.Text = "Paper"
            Case 3
                Me.lblComputerDisplay.Text = "Scissors"
        End Select

        Select Case Me.rdoRock.Checked
            Case True
                Me.lblHumanDisplay.Text = "Rock"
                Select Case intCompThrow
                    Case 1
                        Me.lblOutcome.Text = "You tied!"
                    Case 2
                        Me.lblOutcome.Text = "Paper beats rock. Computer wins!"
                        Me.intCompScore += 1
                    Case 3
                        Me.lblOutcome.Text = "Rock beats scissors. You win!"
                        Me.intHumanScore += 1
                End Select
        End Select

        Select Case Me.rdoPaper.Checked
            Case True
                Me.lblHumanDisplay.Text = "Paper"
                Select Case intCompThrow
                    Case 1
                        Me.lblOutcome.Text = "Paper beats rock. You win!"
                        Me.intHumanScore += 1
                    Case 2
                        Me.lblOutcome.Text = "You tied!"
                    Case 3
                        Me.lblOutcome.Text = "Scissors beat paper. Computer wins!"
                        Me.intCompScore += 1
                End Select
        End Select
        Select Case Me.rdoScissors.Checked
            Case True
                Me.lblHumanDisplay.Text = "Scissors"
                Select Case intCompThrow
                    Case 1
                        Me.lblOutcome.Text = "Rock beats scissors. Computer wins!"
                        Me.intCompScore += 1
                    Case 2
                        Me.lblOutcome.Text = "Scissors beat paper. You win!"
                        Me.intHumanScore += 1
                    Case 3
                        Me.lblOutcome.Text = "You tied!"
                End Select
        End Select
        Me.lblHumanScore.Text = intHumanScore
        Me.lblCompScore.Text = intCompScore
    End Sub

    Private Sub btnPlay2_Click(sender As Object, e As EventArgs) Handles btnPlay2.Click
        Dim intCompThrow As Integer
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If intCompThrow = 1 Then
            Me.lblComputerDisplay.Text = "Rock"
        ElseIf intCompThrow = 2 Then
            Me.lblComputerDisplay.Text = "Paper"
        ElseIf intCompThrow = 3 Then
            Me.lblComputerDisplay.Text = "Scissors"
        End If

        If Me.rdoRock.Checked = True Then
            Me.lblHumanDisplay.Text = "Rock"
            If intCompThrow = 1 Then
                Me.lblOutcome.Text = "You tied!"
            ElseIf intCompThrow = 2 Then
                Me.lblOutcome.Text = "Paper beats rock. Computer wins!"
                Me.intCompScore += 1
            ElseIf intCompThrow = 3 Then
                Me.lblOutcome.Text = "Rock beats scissors. You win!"
                Me.intHumanScore += 1
            End If
        End If

        If Me.rdoPaper.Checked = True Then
            Me.lblHumanDisplay.Text = "Paper"
            If intCompThrow = 1 Then
                Me.lblOutcome.Text = "Paper beats rock. You win!"
                Me.intHumanScore += 1
            ElseIf intCompThrow = 2 Then
                Me.lblOutcome.Text = "You tied!"
            ElseIf intCompThrow = 3 Then
                Me.lblOutcome.Text = "Scissors beat paper. Computer wins!"
                Me.intCompScore += 1
            End If
        End If

        If Me.rdoScissors.Checked = True Then
            Me.lblHumanDisplay.Text = "Scissors"
            If intCompThrow = 1 Then
                Me.lblOutcome.Text = "Rock beats scissors. Computer wins!"
                Me.intCompScore += 1
            ElseIf intCompThrow = 2 Then
                Me.lblOutcome.Text = "Scissors beat paper. You win!"
                Me.intHumanScore += 1
            ElseIf intCompThrow = 3 Then
                Me.lblOutcome.Text = "You tied!"
            End If
        End If
        Me.lblHumanScore.Text = intHumanScore
        Me.lblCompScore.Text = intCompScore
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.lblCompScore.Text = "0"
        Me.lblHumanScore.Text = "0"
        Me.intCompScore = 0
        Me.intHumanScore = 0
        Me.lblComputerDisplay.Text = ""
        Me.lblHumanDisplay.Text = ""
        Me.lblOutcome.Text = ""
    End Sub
End Class
