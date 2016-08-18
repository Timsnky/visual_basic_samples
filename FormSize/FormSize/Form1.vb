Public Class DemoForm

    Private Sub DemoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'variables to hold screen size and height
        'values obtained from screen class' primary screen property, bounds property of system.drawing.rectangle structure
        Dim ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim ScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        'setting form size property
        Dim Height As Integer = Convert.ToInt32((0.5 * ScreenHeight))
        Dim Width As Integer = Convert.ToInt32((0.75 * ScreenWidth))
        'setting form size property
        Me.Width = Width
        Me.Height = Height
        'set start position at center
        Me.StartPosition = FormStartPosition.CenterScreen
        'disallow form resizing
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
End Class
