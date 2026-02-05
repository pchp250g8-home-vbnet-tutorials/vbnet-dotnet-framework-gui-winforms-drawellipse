Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g = e.Graphics
        Dim rcPaint = New Rectangle(0, 0, ClientSize.Width, ClientSize.Height)
        Dim oRedPen = New Pen(Color.Red, 5)
        Dim oYellowBrush = Brushes.Yellow
        g.Clear(Color.Black)
        g.DrawEllipse(oRedPen, rcPaint)
        g.FillEllipse(oYellowBrush, rcPaint)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Invalidate()
    End Sub
End Class
