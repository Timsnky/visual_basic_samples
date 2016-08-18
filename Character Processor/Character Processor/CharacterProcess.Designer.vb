<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterProcess
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
        Me.ProcessorButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProcessorButton
        '
        Me.ProcessorButton.Location = New System.Drawing.Point(30, 117)
        Me.ProcessorButton.Name = "ProcessorButton"
        Me.ProcessorButton.Size = New System.Drawing.Size(182, 46)
        Me.ProcessorButton.TabIndex = 0
        Me.ProcessorButton.Text = "CLICK TO PROCESS"
        Me.ProcessorButton.UseVisualStyleBackColor = True
        '
        'CharacterProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 262)
        Me.Controls.Add(Me.ProcessorButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CharacterProcess"
        Me.Text = "Character Processor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProcessorButton As System.Windows.Forms.Button

End Class
