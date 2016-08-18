Public Class StudentGrid

    Private Sub StudentGrid_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentGridDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentGridDataSet.Student)
        Try
            Me.StudentTableAdapter.Fill(Me.StudentGridDataSet.Student)
        Catch ex As Exception
            Dim MessageString As String = "Error: " &
            ControlChars.NewLine & ex.Message
            Dim TitleString As String = "Student Data Load Failed"
            MessageBox.Show(MessageString, TitleString,
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class