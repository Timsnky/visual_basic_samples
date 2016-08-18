<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiplicationTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MultiplicationTableTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MultiplicationTableTextBox
        '
        Me.MultiplicationTableTextBox.Location = New System.Drawing.Point(12, 12)
        Me.MultiplicationTableTextBox.Multiline = True
        Me.MultiplicationTableTextBox.Name = "MultiplicationTableTextBox"
        Me.MultiplicationTableTextBox.ReadOnly = True
        Me.MultiplicationTableTextBox.Size = New System.Drawing.Size(900, 406)
        Me.MultiplicationTableTextBox.TabIndex = 0
        '
        'MultiplicationTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 430)
        Me.Controls.Add(Me.MultiplicationTableTextBox)
        Me.Name = "MultiplicationTable"
        Me.Text = "Multiplication Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MultiplicationTableTextBox As System.Windows.Forms.TextBox

End Class
