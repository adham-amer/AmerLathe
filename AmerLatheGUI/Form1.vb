Imports System.IO.Ports
Imports System.Runtime.InteropServices
Public Class Form1
    Private WithEvents Arduino As Firmware = New Firmware()

    Dim jogxsteps As UInt32
    Dim jogzsteps As UInt32
    Dim xmotorstepsperrev As UShort = 200
    Dim zmotorstepsperrev As UShort = 200
    Dim xaxislead As UShort = 5
    Dim zaxislead As UShort = 5 'in mm
    Dim xmicrostepping As UShort = 8
    Dim zmicrostepping As UShort = 8
    Dim xmaxsteps As UInt32 = 20000
    Dim ymaxsteps As UInt32 = 20000

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Dim g As Integer = 1 - (&H1 << 1)
        'MsgBox(g)

        Arduino.Connect("COM3", 115200)
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



    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        'MsgBox(e.X)
    End Sub



    Private Sub JOGXN_Click(sender As Object, e As EventArgs) Handles JOGXN.Click

        Arduino.MoveInSteps(jogxsteps, 0, 0, 0, 1000, 545)

    End Sub


    Sub UpdateUI(XPOS As UInt32, ZPOS As UInt32, SSPEED As UShort, SPOS As UShort, IOs As Byte) Handles Arduino.DataReceived
        If InvokeRequired Then
            BeginInvoke(New Action(Of UInt32, UInt32, UShort, UShort, Byte)(AddressOf UpdateUI), XPOS, ZPOS, SSPEED, SPOS, IOs)
            Return
        End If


        x.Text = Math.Round(XPOS * NumericUpDown2.Value / (NumericUpDown1.Value * NumericUpDown3.Value), 2) & " mm"
        z.Text = Math.Round(ZPOS * NumericUpDown2.Value / (NumericUpDown1.Value * NumericUpDown3.Value), 2) & " mm"

    End Sub

    Sub ConnectionStatusChanged(isConnected As Boolean) Handles Arduino.ConnectionStatusChanged
        If InvokeRequired Then
            BeginInvoke(New Action(Of Boolean)(AddressOf ConnectionStatusChanged), isConnected)
            Return
        End If
        If isConnected Then
            Status.Text = "Connected"
            Status.BackColor = Color.Green
        Else
            Status.Text = "Disconnected"
            Status.BackColor = Color.Red
        End If
    End Sub




    Sub changejogsteps(value As Integer)
        jogxsteps = value * xaxislead / (xmotorstepsperrev * xmicrostepping)
        jogzsteps = value * zaxislead / (zmotorstepsperrev * zmicrostepping)

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If sender.Checked Then
            changejogsteps(sender.tag)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If sender.Checked Then
            changejogsteps(sender.tag)
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If sender.Checked Then
            changejogsteps(sender.tag)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If sender.Checked Then
            changejogsteps(sender.tag)
        End If
    End Sub

    Private Sub JOGXP_Click(sender As Object, e As EventArgs) Handles JOGXP.Click
        Arduino.MoveInSteps(jogxsteps, 0, 1, 0, 1000, 545)
    End Sub

    Private Sub JOGZN_Click(sender As Object, e As EventArgs) Handles JOGZN.Click
        Arduino.MoveInSteps(0, jogzsteps, 0, 0, 1000, 545)
    End Sub

    Private Sub JOGZP_Click(sender As Object, e As EventArgs) Handles JOGZP.Click
        Arduino.MoveInSteps(0, jogzsteps, 0, 1, 1000, 545)
    End Sub
End Class
