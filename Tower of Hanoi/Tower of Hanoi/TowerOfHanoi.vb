Public Class TowerOfHanoi
    'EXPLANATION TO TOWER OF HANOI PROBLEM
    ' 1. only one disc can be moved at a time, and
    ' 2. you can never place a larger disc on top of a smaller one.
    ' The process involves the following steps:
    ' a. Move n-1 discs from the source post to the temporary post.
    ' b. Move the last disc to the destination post.
    ' c. Move n-1 discs back from the temporary post to the destination post.
    'n refers to number of discs in initial stack
    'module level integer array to hold number of discs
    Private DiscCounts(2) As Integer
    'multidimensional integer array to hold the moves
    Private Moves(,) As Integer
    'module level integer variable to track disc movement
    Private MovesIndex As Integer
    Private Sub TowerOfHanoi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
    End Sub
    Private Sub Tower(ByVal Discs As Integer, ByVal InitialPeg As Integer, ByVal FinalPeg As Integer, ByVal TempPeg As Integer)
        If Discs > 0 Then
            'recursive call that moves n-1 discs from InitialPeg to TemPPeg
            Tower(Discs - 1, InitialPeg, FinalPeg, TempPeg)
            'move last disc from initial peg to destination peg
            DiscCounts(InitialPeg) -= 1
            DiscCounts(FinalPeg) += 1
            'record moves in array for later use
            Moves(MovesIndex, 0) = InitialPeg
            Moves(MovesIndex, 1) = FinalPeg
            MovesIndex += 1
            'recursive call to move n-1 discs from temp peg to finalpeg
            Tower(Discs - 1, TempPeg, FinalPeg, InitialPeg)
        End If
    End Sub
    Public Function GetMoves() As Integer(,)
        Tower(DiscCounts(0), 0, 1, 2)
        Return Moves
    End Function

    Private Sub SolveButton_Click(sender As System.Object, e As System.EventArgs) Handles SolveButton.Click
        DiscCounts(0) = Integer.Parse(DisksTextBox.Text, Globalization.NumberStyles.Integer)
        DiscCounts(1) = 0
        DiscCounts(2) = 0
        MovesIndex = 0
        'declaring  the Moves array as dynamic array
        ReDim Moves(2 ^ Integer.Parse(DisksTextBox.Text, Globalization.NumberStyles.Integer) - 2, 1)
        Dim MyMoves(,) As Integer = GetMoves()
        For I As Integer = 0 To MyMoves.Length - 1
            For J As Integer = 0 To MyMoves.Length - 1
                InstructionTextBox.Text += MyMoves(I, J)
            Next
        Next I
    End Sub
End Class
