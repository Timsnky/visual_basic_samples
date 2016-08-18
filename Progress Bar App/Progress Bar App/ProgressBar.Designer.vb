<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressBar
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
        Me.components = New System.ComponentModel.Container()
        Me.ProcessProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProcessProgressBar
        '
        Me.ProcessProgressBar.Location = New System.Drawing.Point(12, 83)
        Me.ProcessProgressBar.Name = "ProcessProgressBar"
        Me.ProcessProgressBar.Size = New System.Drawing.Size(550, 52)
        Me.ProcessProgressBar.TabIndex = 0
        '
        'ProgressTimer
        '
        Me.ProgressTimer.Enabled = True
        Me.ProgressTimer.Interval = 1000
        '
        'ProgressLabel
        '
        Me.ProgressLabel.Location = New System.Drawing.Point(12, 55)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(55, 23)
        Me.ProgressLabel.TabIndex = 1
        Me.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 275)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.ProcessProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ProgressBar"
        Me.Text = "Progress Bar Application"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProcessProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label

End Class
