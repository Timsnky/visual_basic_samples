<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesManager
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
        Me.SalesTeamListBox = New System.Windows.Forms.ListBox()
        Me.ComputeSalesButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SalesTeamListBox
        '
        Me.SalesTeamListBox.FormattingEnabled = True
        Me.SalesTeamListBox.Location = New System.Drawing.Point(12, 55)
        Me.SalesTeamListBox.Name = "SalesTeamListBox"
        Me.SalesTeamListBox.Size = New System.Drawing.Size(580, 290)
        Me.SalesTeamListBox.TabIndex = 0
        '
        'ComputeSalesButton
        '
        Me.ComputeSalesButton.Location = New System.Drawing.Point(12, 378)
        Me.ComputeSalesButton.Name = "ComputeSalesButton"
        Me.ComputeSalesButton.Size = New System.Drawing.Size(140, 23)
        Me.ComputeSalesButton.TabIndex = 1
        Me.ComputeSalesButton.Text = "Compute Sales"
        Me.ComputeSalesButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(261, 378)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(140, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SalesManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 413)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ComputeSalesButton)
        Me.Controls.Add(Me.SalesTeamListBox)
        Me.Name = "SalesManager"
        Me.Text = "Sales Team Manager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalesTeamListBox As System.Windows.Forms.ListBox
    Friend WithEvents ComputeSalesButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
