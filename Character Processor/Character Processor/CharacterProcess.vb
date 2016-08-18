Imports System.Text

Public Class CharacterProcess

    Private Sub ProcessorButton_Click(sender As System.Object, e As System.EventArgs) Handles ProcessorButton.Click
        Dim Entered As String
        Entered = InputBox("Enter a Character to Process the Next", Me.Text)
        'handle multiple character input errors
        If Entered.ToCharArray.Length > 1 Then
            MessageBox.Show("Only single character can be entered", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'convert string to ascii
            Dim NextChars As Integer = Asc(Entered)
            'move to next character
            NextChars += 1
            'variable to hold next character
            Dim NextChar As Char
            NextChar = ChrW(NextChars)
            MessageBox.Show("The Next Character is: " & NextChar.ToString & ".", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
