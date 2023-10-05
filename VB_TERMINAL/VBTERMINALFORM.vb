'Joshua Makuch
'RCET 3371
'September 29, 2023
'VB Terminal Form
'https://github.com/JoshuaMakuch/VB_TERMINAL

Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class VBTERMINALFORM

    Dim PortState As Boolean
    Public receiveByte(18) As Byte 'Receive Data Bytes

    'On Form unload, close the port as to not have it stuck open and inaccessible
    Private Sub VBTERMINALFORM_UnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SerialPort1.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Initially Sets Serial Port information
    Private Sub VBTERMINALFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PortSelect.Items.Clear()
        PortState = False
        SerialPort1.BaudRate = 9600 '9600 baud rate
        SerialPort1.DataBits = 8 '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None 'no parity
        Timer1.Enabled = True 'timer set to 50ms
    End Sub

    'Find and display all available com ports
    Private Sub ScanButton_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        PortSelect.Items.Clear() 'Clear current list
        For Each sp As String In My.Computer.Ports.SerialPortNames
            PortSelect.Items.Add(sp) 'add discovered port to listbox
        Next
    End Sub

    'This opens a port and notifies the user if its wrong
    Private Sub PortOpen_Click(sender As Object, e As EventArgs) Handles PortOpen.Click
        If PortOpen.Text = "Connect" Then
            Try
                SerialPort1.Open()
                PortOpen.Text = "Disconnect"
                PortState = True
            Catch ex As Exception
                MsgBox("Port Already Open Or Port Unavailable")
                PortOpen.Text = "Connect"
                PortState = False
            End Try
        Else
            Try
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            PortState = False
            PortOpen.Text = "Connect"
        End If
    End Sub

    'Every 100mS it will update the PortData List box
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim DataIn As String
        DataIn = ""
        PortData.Items.Clear()
        PortData.Items.Add("Com Port = " & SerialPort1.PortName) 'show current baud rate
        PortData.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'show current baud rate
        PortData.Items.Add("Data Bits = " & SerialPort1.DataBits)
        PortData.Items.Add("Stop Bits = " & SerialPort1.StopBits)
        PortData.Items.Add("Parity = " & SerialPort1.Parity)
    End Sub

    'This is what will set the port when the user clicks on something in the Port Select
    Private Sub PortSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortSelect.SelectedIndexChanged
        Try
            SerialPort1.Close() 'try to close port before change
        Catch ex As Exception

        End Try
        PortOpen.Text = "Connect"
        PortState = False
        Try
            SerialPort1.BaudRate = PortSelect.SelectedItem 'see if Baud Rate data Is in the list box
        Catch ex As Exception
            SerialPort1.PortName = PortSelect.SelectedItem ' bot Baud Rate, save port Name
        End Try
    End Sub

    'Handles when the select baud rate button is pressed
    Private Sub SelectBaud_Click(sender As Object, e As EventArgs) Handles SelectBaud.Click
        PortSelect.Items.Clear() 'Clear list Box and load Baud Rate values
        PortSelect.Items.Add(1200)
        PortSelect.Items.Add(2400)
        PortSelect.Items.Add(4800)
        PortSelect.Items.Add(9600)
        PortSelect.Items.Add(19200)
        PortSelect.Items.Add(38400)
        PortSelect.Items.Add(57600)
        PortSelect.Items.Add(115200)
        PortSelect.Items.Add(230400)
        PortSelect.Items.Add(460800)
        PortSelect.Items.Add(921600)
    End Sub

    'Handles the quit button
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Try
            SerialPort1.Close()
            Close()
        Catch ex As Exception

        End Try
    End Sub

    'Handles send packet button
    Private Sub SendPacketButton_Click(sender As Object, e As EventArgs) Handles SendPacketButton.Click
        Timer1.Enabled = False 'stop timer
        Dim DataOut 'Transmit Variable
        Dim DataIn1, DataIn2, DataIn3, DataIn4 As Integer 'Receive Variables
        DataOut = DataTextBox.Text 'Load transmit variable with information from text box
        If PortState = True Then 'Test if port is open
            If DataOut IsNot "" Then 'Test transmit data is not blank
                SerialPort1.DiscardInBuffer()
                SerialPort1.Write(DataOut) 'Send 4 bytes of data
                OutTerm.Items.Add(DataOut) 'Log sent data
            Else 'Send Data was blank
                Timer1.Enabled = True 'restart timer
                Exit Sub 'Leave
            End If
            Try 'Attempt to receive

                Thread.Sleep(100)
                SerialPort1.Read(receiveByte, 0, 4) 'Read 4 bytes of data Serial Port

                DataIn1 = receiveByte(0) 'Save Byte0
                DataIn2 = receiveByte(1) 'Save Byte1
                DataIn3 = receiveByte(2) 'Save Byte2
                DataIn4 = receiveByte(3) 'Save Byte3
                'Add data to input list box
                InTerm.Items.Add(Chr(DataIn1) & vbTab & Chr(DataIn2) & vbTab & Chr(DataIn3) & vbTab & Chr(DataIn4))

                'Clear the receiveByte array to ensure that when the data sent out is smaller than previously it doesnt hold onto old data
                For n As Integer = 0 To receiveByte.Length - 1
                    receiveByte(n) = 0
                Next

            Catch ex As Exception

            End Try

        Else
            MsgBox("Please configure and open serial port to procede") 'Failure if port is not open
        End If
        Timer1.Enabled = True 'restart timer 


    End Sub

    'Clear Packet Button
    Private Sub ClearPacketButton_Click(sender As Object, e As EventArgs) Handles ClearPacketButton.Click
        DataTextBox.Text = ""
    End Sub

    'Handles output clear button click
    Private Sub OutputClearButton_Click(sender As Object, e As EventArgs) Handles OutputClearButton.Click
        OutTerm.Items.Clear()
    End Sub

    'Handles input clear button click
    Private Sub InputClearButton_Click(sender As Object, e As EventArgs) Handles InputClearButton.Click
        InTerm.Items.Clear()
    End Sub

End Class
