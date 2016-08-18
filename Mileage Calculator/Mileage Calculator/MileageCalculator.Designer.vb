<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MileageCalculator
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
        Me.MileageListBox = New System.Windows.Forms.ListBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MileageListBox
        '
        Me.MileageListBox.FormattingEnabled = True
        Me.MileageListBox.Location = New System.Drawing.Point(12, 26)
        Me.MileageListBox.Name = "MileageListBox"
        Me.MileageListBox.Size = New System.Drawing.Size(305, 264)
        Me.MileageListBox.TabIndex = 0
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(12, 335)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(102, 23)
        Me.ComputeButton.TabIndex = 1
        Me.ComputeButton.Text = "&COMPUTE"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(174, 335)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&XIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MileageCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 370)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.MileageListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MileageCalculator"
        Me.Text = "Mileage Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MileageListBox As System.Windows.Forms.ListBox
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
