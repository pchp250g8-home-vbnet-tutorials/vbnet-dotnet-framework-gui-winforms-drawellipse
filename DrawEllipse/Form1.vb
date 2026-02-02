Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g = e.Graphics
        g.Clear(Color.Black)
        g.DrawEllipse(Pens.Yellow, 0, 0, ClientSize.Width, ClientSize.Height)
        g.FillEllipse(Brushes.Red, 0, 0, ClientSize.Width, ClientSize.Height)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Invalidate()
    End Sub
End Class
