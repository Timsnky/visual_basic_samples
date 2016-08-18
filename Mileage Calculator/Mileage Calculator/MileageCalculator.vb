Public Class MileageCalculator

    Private Sub ComputeButton_Click(sender As System.Object, e As System.EventArgs) Handles ComputeButton.Click
        'Clear previous entries
        MileageListBox.Items.Clear()
        Dim UserEntry() As String = New String() {"", "", "", ""}
        Dim Prompts() As String = New String() {"Enter Mileage In Km At Start of Journey", "Enter Mileage In Km At End of Journey", _
                                              "Enter Fuel Level in Gallons at Start of Journey", _
                                              "Enter Fuel Level in Gallons at End of Journey"}
        'use a loop to enter values to be used in computation
        For Entry As Integer = 0 To UserEntry.Length - 1 Step 1
            UserEntry(Entry) = InputBox(Prompts(Entry), Me.Text, "0.0")

        Next

        Dim Length As Single
        Dim FuelConsumption As Single, Fuel As Single
        'computations
        Try
            'trap errors due to wrong entry
            If Single.Parse(UserEntry(0), Globalization.NumberStyles.Float) > Single.Parse(UserEntry(1), Globalization.NumberStyles.Float) Then
                MessageBox.Show("Mileage at Journey end cannot be less than at Journey start", Me.Text, MessageBoxButtons.OK)
                Exit Sub
            ElseIf Single.Parse(UserEntry(3), Globalization.NumberStyles.Float) > Single.Parse(UserEntry(2), Globalization.NumberStyles.Float) Then
                MessageBox.Show("Mileage Calculator assumes no refueling mid journey", Me.Text, MessageBoxButtons.OK)
                Exit Sub
            Else
                Length = Single.Parse(UserEntry(1), Globalization.NumberStyles.Float) - Single.Parse(UserEntry(0), Globalization.NumberStyles.Float)
                Fuel = Single.Parse(UserEntry(2), Globalization.NumberStyles.Float) - Single.Parse(UserEntry(3), Globalization.NumberStyles.Float)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        FuelConsumption = Fuel / Length
        'populate list box
        MileageListBox.Items.Add("Distance         " & ControlChars.Tab & Length.ToString & " KM")
        MileageListBox.Items.Add("Fuel Consumed    " & ControlChars.Tab & Fuel.ToString & " Gallons")
        MileageListBox.Items.Add("Fuel Consumption " & ControlChars.Tab & FuelConsumption.ToString & " Gallons/KM")
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class
