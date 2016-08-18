<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterestCalcForm
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
        Me.InterestListBox = New System.Windows.Forms.ListBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InterestListBox
        '
        Me.InterestListBox.FormattingEnabled = True
        Me.InterestListBox.Location = New System.Drawing.Point(12, 80)
        Me.InterestListBox.Name = "InterestListBox"
        Me.InterestListBox.Size = New System.Drawing.Size(250, 251)
        Me.InterestListBox.TabIndex = 0
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(53, 348)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(131, 23)
        Me.ComputeButton.TabIndex = 1
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Amount for Period"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InterestCalcForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 383)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.InterestListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InterestCalcForm"
        Me.Text = "Interest Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InterestListBox As System.Windows.Forms.ListBox
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
