Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CourseGridDataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.CourseGridDataSet.Course)

    End Sub

    Private Sub CourseGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load Course table
            Me.CourseTableAdapter.Fill(Me.CourseGridDataSet.Course)
        Catch ex As Exception
            Dim MessageString As String = "Error: " &
            ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Course Data Load Failed"
            MessageBox.Show(MessageString, TitleString,
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Console.WriteLine("YES")
        Console.WriteLine(DataGridView1.Item(e.RowIndex, e.ColumnIndex).Value)
    End Sub
End Class
