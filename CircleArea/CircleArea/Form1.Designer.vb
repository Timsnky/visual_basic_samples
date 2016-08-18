<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Area = New System.Windows.Forms.Label()
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.ComputeAreaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Radius"
        '
        'Area
        '
        Me.Area.AutoSize = True
        Me.Area.Location = New System.Drawing.Point(73, 227)
        Me.Area.Name = "Area"
        Me.Area.Size = New System.Drawing.Size(70, 13)
        Me.Area.TabIndex = 1
        Me.Area.Text = "Area of Circle"
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.Location = New System.Drawing.Point(213, 91)
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RadiusTextBox.TabIndex = 2
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(213, 220)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaTextBox.TabIndex = 3
        '
        'ComputeAreaButton
        '
        Me.ComputeAreaButton.Location = New System.Drawing.Point(139, 158)
        Me.ComputeAreaButton.Name = "ComputeAreaButton"
        Me.ComputeAreaButton.Size = New System.Drawing.Size(96, 31)
        Me.ComputeAreaButton.TabIndex = 4
        Me.ComputeAreaButton.Text = "Compute Area"
        Me.ComputeAreaButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 388)
        Me.Controls.Add(Me.ComputeAreaButton)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.RadiusTextBox)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Area As System.Windows.Forms.Label
    Friend WithEvents RadiusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComputeAreaButton As System.Windows.Forms.Button

End Class
