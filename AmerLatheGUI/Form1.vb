Imports System.IO.Ports
Imports System.Runtime.InteropServices
Public Class Form1
    Public Connected As Boolean = False
    Public SerialPort1 As SerialPort
    Private Shared ReadOnly PacketSize As Integer = Marshal.SizeOf(GetType(Packet))
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure Packet
        Public CMD As Byte
        Public XSTEPS As UShort
        Public ZSTEPS As UShort
        Public SSPEED As UShort
        Public FRATE As UShort
        Public TAIL As Byte
    End Structure



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

    Private Function PacketToBytes(packet As Packet) As Byte()
        Dim bytes(PacketSize - 1) As Byte
        Dim ptr = Marshal.AllocHGlobal(PacketSize)

        Try
            Marshal.StructureToPtr(packet, ptr, False)
            Marshal.Copy(ptr, bytes, 0, PacketSize)
            Return bytes
        Finally
            Marshal.FreeHGlobal(ptr)
        End Try
    End Function

    Private Function BytesToPacket(bytes As Byte()) As Packet
        If bytes Is Nothing OrElse bytes.Length <> PacketSize Then
            Throw New ArgumentException($"Packet must be exactly {PacketSize} bytes.", NameOf(bytes))
        End If

        Dim ptr = Marshal.AllocHGlobal(PacketSize)

        Try
            Marshal.Copy(bytes, 0, ptr, PacketSize)
            Return DirectCast(Marshal.PtrToStructure(ptr, GetType(Packet)), Packet)
        Finally
            Marshal.FreeHGlobal(ptr)
        End Try
    End Function

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        'MsgBox(e.X)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim T As String() = {"Connected", "Not Connected"}
        Dim C As Color() = {Color.Green, Color.Red}
        If Not Connected Then
            Try
                SerialPort1 = New SerialPort("COM3", 115200)
                SerialPort1.Open()

                Connected = True
                Label2.Text = T(0) & " on " & SerialPort1.PortName
                Label2.BackColor = C(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Connected = False
                Label2.Text = T(1)
                Label2.BackColor = C(1)
            End Try

        Else
            While SerialPort1.BytesToRead > 1
                Dim xsteps As UShort = SerialPort1.ReadByte() Or (SerialPort1.ReadByte() << 8)
                x.Text = xsteps * 5.0 / NumericUpDown1.Value

                ' Dim responseBytes(PacketSize - 1) As Byte
                ' SerialPort1.Read(responseBytes, 0, responseBytes.Length)

                ' Dim response As Packet = BytesToPacket(responseBytes)
                'MsgBox($"CMD={response.CMD}, X={response.XSTEPS}, Z={response.ZSTEPS}, S={response.SSPEED}, F={response.FRATE}, TAIL={response.TAIL}")
                '// You can add code here to handle the response packet as needed

            End While

        End If


    End Sub

    Private Sub JOGXN_Click(sender As Object, e As EventArgs) Handles JOGXN.Click
        Dim P As Packet


        For Each ctrl As Object In GroupBox1.Controls
            If TypeOf ctrl Is RadioButton Then
                If ctrl.Checked Then
                    P.XSTEPS = ctrl.Tag * NumericUpDown1.Value / 5
                    MsgBox($"XSTEPS={P.XSTEPS}")
                    Exit For
                End If
            End If
        Next
        P.TAIL = &HFF
        Dim packetBytes = PacketToBytes(P)
        If Connected Then
            SerialPort1.Write(packetBytes, 0, packetBytes.Length)


        End If
    End Sub
End Class
