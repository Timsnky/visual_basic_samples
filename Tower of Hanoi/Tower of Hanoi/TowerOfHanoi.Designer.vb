<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TowerOfHanoi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisksTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InstructionTextBox = New System.Windows.Forms.TextBox()
        Me.SolveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Disks"
        '
        'DisksTextBox
        '
        Me.DisksTextBox.Location = New System.Drawing.Point(158, 23)
        Me.DisksTextBox.Name = "DisksTextBox"
        Me.DisksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DisksTextBox.TabIndex = 1
        Me.DisksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Instruction"
        '
        'InstructionTextBox
        '
        Me.InstructionTextBox.Location = New System.Drawing.Point(158, 96)
        Me.InstructionTextBox.Multiline = True
        Me.InstructionTextBox.Name = "InstructionTextBox"
        Me.InstructionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.InstructionTextBox.Size = New System.Drawing.Size(279, 97)
        Me.InstructionTextBox.TabIndex = 3
        '
        'SolveButton
        '
        Me.SolveButton.Location = New System.Drawing.Point(201, 242)
        Me.SolveButton.Name = "SolveButton"
        Me.SolveButton.Size = New System.Drawing.Size(120, 23)
        Me.SolveButton.TabIndex = 4
        Me.SolveButton.Text = "SOLVE"
        Me.SolveButton.UseVisualStyleBackColor = True
        '
        'TowerOfHanoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 300)
        Me.Controls.Add(Me.SolveButton)
        Me.Controls.Add(Me.InstructionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DisksTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TowerOfHanoi"
        Me.Text = "Tower Of Hanoi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DisksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InstructionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SolveButton As System.Windows.Forms.Button

End Class
