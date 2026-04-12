Imports System.IO.Ports
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawGrid()
    End Sub


    Sub DrawGrid()
        Dim bmp As New Bitmap(Panel2.Width, Panel2.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Panel2.BackColor)


            Dim P As New Pen(Color.LightYellow, 1)
            For x As Integer = 0 To (Panel2.Width - 10) Step 60

                g.DrawLine(P, x + 10, CInt(Panel2.Height / 2), x + 20, CInt(Panel2.Height / 2))
                g.DrawLine(P, x + 30, CInt(Panel2.Height / 2), x + 60, CInt(Panel2.Height / 2))
            Next
        End Using
        Panel2.BackgroundImage = bmp

    End Sub

End Class
