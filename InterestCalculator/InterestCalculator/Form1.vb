Public Class InterestCalcForm

    Private Sub ComputeButton_Click(sender As System.Object, e As System.EventArgs) Handles ComputeButton.Click
        Dim Principle As Single = 1000000
        Dim Rate As Single = 0.05
        Dim Amount As Single
        Dim YearAmount As String = ""
        For Year As Integer = 1 To 10 Step 1
            Amount = Principle * ((1 + Rate) ^ Year)
            YearAmount = "Year " & Year & ":" & ControlChars.Tab & "Ksh" & Amount.ToString & ControlChars.NewLine
            InterestListBox.Items.Add(YearAmount.ToString)
        Next Year

    End Sub
End Class
