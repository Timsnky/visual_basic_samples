Public Class ProgressBar

    Private Sub ProgressTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ProgressTimer.Tick
        Dim Progress As Integer = 5
        ProcessProgressBar.Increment(Progress)
        ProgressLabel.Text = ProcessProgressBar.Value & "%"
    End Sub
End Class
