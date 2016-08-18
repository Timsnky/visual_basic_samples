Public Class SalesManager
    Const WEEKLYPAY As Single = 2500
    Const QUOTA As Single = 1000
    Const RATE As Single = 0.15

    Private Sub ComputeSalesButton_Click(sender As System.Object, e As System.EventArgs) Handles ComputeSalesButton.Click
        'clear previous data
        SalesTeamListBox.Items.Clear()
        'define array to hold names of sales person
        Dim SalesName() As String = New String() {"", "", "", "", "", "", "", "", "", ""}
        'array to hold daily sales
        Dim DailySales() As String = New String() {"", "", "", "", "", "", "", "", "", ""}
        'use inputbox dialog to enter name and daily sales
        For Datas As Integer = 0 To SalesName.Length - 1 Step 1
            SalesName(Datas) = InputBox("Enter Sales Person Name", Me.Text)
            DailySales(Datas) = InputBox("Enter Daily Sales for Sales Person", Me.Text)
        Next Datas
        Dim WeeklySales() As Single = New Single(9) {}
        Dim WeeklySalary() As Single = New Single(9) {}
        Dim Commission() As Single = New Single(9) {}
        'perform error handling
        Try
            For J As Integer = 0 To SalesName.Length - 1 Step 1
                WeeklySales(J) = Single.Parse(DailySales(J), Globalization.NumberStyles.Float) * 7
                'compute commission
                If WeeklySales(J) > QUOTA Then
                    Commission(J) = Convert.ToSingle((WeeklySales(J) * RATE))
                Else
                    Commission(J) = 0.0
                End If
            Next J
            For K As Integer = 0 To SalesName.Length - 1 Step 1
                WeeklySalary(K) = WEEKLYPAY + Commission(K)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim DisplayFormat As String = "Sales Person Name " & ControlChars.Tab & " Daily Sales " & ControlChars.Tab & _
                        " Weekly Sales " & ControlChars.Tab & " Weekly Salary "
        SalesTeamListBox.Items.Add(DisplayFormat)
        'display the result
        For D As Integer = 0 To SalesName.Length - 1 Step 1
            SalesTeamListBox.Items.Add(SalesName(D) & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & DailySales(D).ToString _
                                       & ControlChars.Tab & ControlChars.Tab &
                                       WeeklySales(D) & ControlChars.Tab & ControlChars.Tab & WeeklySalary(D))
        Next D


    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class
