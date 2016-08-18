Public Class MultiplicationTable

    Private Sub MultiplicationTableTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles MultiplicationTableTextBox.TextChanged

    End Sub

    Private Sub MultiplicationTable_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MultiplicationTableTextBox.TextAlign = HorizontalAlignment.Center
        MultiplicationTableTextBox.Text = "Multiplication Table"
        'variable to hold product
        Dim Product As String = String.Empty
        MultiplicationTableTextBox.Text += ControlChars.NewLine
        MultiplicationTableTextBox.Text += ControlChars.NewLine
        MultiplicationTableTextBox.TextAlign = HorizontalAlignment.Left
        Product += "*" & ControlChars.Tab
        For Head As Integer = 1 To 7 Step 1
            Product += Head.ToString & ControlChars.Tab
        Next Head
        For ColHead As Integer = 1 To 7
            Product += ControlChars.NewLine & ColHead.ToString
            For Inner As Integer = 1 To 7 Step 1
                Product += ControlChars.Tab & (Inner * ColHead).ToString
            Next Inner
        Next
        MultiplicationTableTextBox.Text = Product
    End Sub
End Class
