Imports System.IO.Ports
Imports System.Runtime.InteropServices

Imports AmerLatheGUI.Form1
Public Class Firmware


    Private WithEvents SP As SerialPort
    Public connected As Boolean = False
    Public Event ConnectionStatusChanged(isConnected As Boolean)
    Public Event DataReceived(XPOS As UInt32, ZPOS As UInt32, SSPEED As UShort, SPOS As UShort, IOs As Byte)


    Private Shared ReadOnly PacketOutSize As Integer = Marshal.SizeOf(GetType(PacketOut))
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure PacketOut
        Public CMD As Byte    ' 0=move, 1=stop, 2=home
        Public DIR As Byte    ' XXXXXX0X = X-, XXXXXX1X = X+, XXXX1XXX = Z+ , XXXX0XXX = Z-
        Public XSTEPS As UInt32
        Public ZSTEPS As UInt32
        Public SSPEED As UShort
        Public FRATE As UShort
        Public TAIL As Byte
    End Structure

    Private Shared ReadOnly PacketFromFirmwareSize As Integer = Marshal.SizeOf(GetType(PacketFromFirmware))
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure PacketFromFirmware

        Public XPOS As UInt32
        Public ZPOS As UInt32
        Public SSPEED As UShort
        Public SPOS As UShort
        Public IOs As Byte
        Public TAIL As Byte
    End Structure



    Public Function Connect(portName As String, baudRate As Integer) As Boolean
        Try
            SP = New SerialPort(portName, baudRate)
            SP.Open()
            connected = True
            RaiseEvent ConnectionStatusChanged(connected)
            Return True
        Catch ex As Exception
            Debug.WriteLine("Error connecting to serial port: " & ex.Message)
            connected = False
            Return False
        End Try


    End Function

    Private Sub MarkDisconnected()
        If connected Then
            connected = False
            RaiseEvent ConnectionStatusChanged(connected)
        End If
    End Sub

    Sub StatusChanged(sender As Object, e As EventArgs) Handles SP.Disposed ' make this trigger when we lose connection to the serial port
        If connected Then
            connected = False
            RaiseEvent ConnectionStatusChanged(connected)
        End If
    End Sub

    Private Sub SerialError(sender As Object, e As SerialErrorReceivedEventArgs) Handles SP.ErrorReceived
        If SP Is Nothing OrElse Not SP.IsOpen Then
            MarkDisconnected()
        End If
    End Sub

    Private Sub SerialPinChanged(sender As Object, e As SerialPinChangedEventArgs) Handles SP.PinChanged
        If SP Is Nothing OrElse Not SP.IsOpen Then
            MarkDisconnected()
        End If
    End Sub

    Private Sub DataRecived() Handles SP.DataReceived
        Try
            If SP.BytesToRead >= PacketFromFirmwareSize Then
                Dim buffer(PacketFromFirmwareSize - 1) As Byte
                SP.Read(buffer, 0, buffer.Length)
                Dim ArduinoPacket As PacketFromFirmware = BytesToFirmwarePacket(buffer)
                RaiseEvent DataReceived(ArduinoPacket.XPOS, ArduinoPacket.ZPOS, ArduinoPacket.SSPEED, ArduinoPacket.SPOS, ArduinoPacket.IOs)

                'Dim packet As PacketFromFirmware = BytesToFirmwarePacket(buffer)
                'MsgBox($"Received packet: XPOS={packet.XPOS}, ZPOS={packet.ZPOS}, SSPEED={packet.SSPEED}, SPOS={packet.SPOS}, IOs={packet.IOs}")
                ' RaiseEvent DataReceived(packet)
            Else

                'MsgBox(SP.ReadLine)

            End If
        Catch ex As InvalidOperationException
            MarkDisconnected()
        Catch ex As IO.IOException
            MarkDisconnected()
        Catch ex As UnauthorizedAccessException
            MarkDisconnected()
        End Try
    End Sub

    Private Function BytesToPacket(bytes As Byte()) As PacketOut
        If bytes Is Nothing OrElse bytes.Length <> PacketOutSize Then
            Throw New ArgumentException($"Packet must be exactly {PacketOutSize} bytes.", NameOf(bytes))
        End If

        Dim ptr = Marshal.AllocHGlobal(PacketOutSize)

        Try
            Marshal.Copy(bytes, 0, ptr, PacketOutSize)
            Return DirectCast(Marshal.PtrToStructure(ptr, GetType(PacketOut)), PacketOut)
        Finally
            Marshal.FreeHGlobal(ptr)
        End Try
    End Function

    Private Function BytesToFirmwarePacket(bytes As Byte()) As PacketFromFirmware
        If bytes Is Nothing OrElse bytes.Length <> PacketFromFirmwareSize Then
            Throw New ArgumentException($"Packet must be exactly {PacketFromFirmwareSize} bytes.", NameOf(bytes))
        End If

        Dim ptr = Marshal.AllocHGlobal(PacketFromFirmwareSize)

        Try
            Marshal.Copy(bytes, 0, ptr, PacketFromFirmwareSize)
            Return DirectCast(Marshal.PtrToStructure(ptr, GetType(PacketFromFirmware)), PacketFromFirmware)
        Finally
            Marshal.FreeHGlobal(ptr)
        End Try
    End Function
    Private Function PacketToBytes(packet As PacketOut) As Byte()
        Dim bytes(PacketOutSize - 1) As Byte
        Dim ptr = Marshal.AllocHGlobal(PacketOutSize)

        Try
            Marshal.StructureToPtr(packet, ptr, False)
            Marshal.Copy(ptr, bytes, 0, PacketOutSize)
            Return bytes
        Finally
            Marshal.FreeHGlobal(ptr)
        End Try
    End Function

    Public Function MoveInSteps(XSTEPS As UInt32, ZSTEPS As UInt32, XDIR As Boolean, ZDIR As Boolean, speed As UShort, rate As UShort) As Boolean
        Dim P As PacketOut
        P.CMD = 1
        P.DIR = ((XDIR << 1) Or (ZDIR << 3))
        P.XSTEPS = XSTEPS
        P.ZSTEPS = ZSTEPS
        P.SSPEED = speed
        P.FRATE = rate
        P.TAIL = &HFF

        If SP IsNot Nothing AndAlso SP.IsOpen Then
            Dim packetBytes = PacketToBytes(P)
            SP.Write(packetBytes, 0, packetBytes.Length)
            Return True
        End If

        Return False
    End Function
End Class
