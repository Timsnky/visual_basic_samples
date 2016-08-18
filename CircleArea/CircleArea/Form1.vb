Public Class Form1

    Private Sub ComputeAreaButton_Click(sender As System.Object, e As System.EventArgs) Handles ComputeAreaButton.Click
        'Initialise Radius variable and assign it the value in the textbox, check if its a number using globalisation
        Dim Radius As Decimal = Decimal.Parse(RadiusTextBox.Text, Globalization.NumberStyles.Number)
        'Initialise Area variable and assign it value from the GetArea function with radius as the parameter
        Dim Area As Decimal = GetArea(Radius)
        'Display calculated area in textbox
        AreaTextBox.Text = Area.ToString()
    End Sub

    'Function to handle the area calculation
    Private Function GetArea(ByVal Radius As Decimal) As Decimal
        Dim Area As Decimal
        Area = Math.PI * Radius * Radius
        Return Area
    End Function
End Class
