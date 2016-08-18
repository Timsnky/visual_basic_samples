Public Class StudentDetails

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDetailsDataSet)

    End Sub


    Private Sub StudentBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDetailsDataSet)

    End Sub
    Private Sub StudentBindingNavigatorSaveItem_Click_2(sender As System.Object, e As System.EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDetailsDataSet)

    End Sub

    Private Sub StudentDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDetailsDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDetailsDataSet.Student)

    End Sub
End Class