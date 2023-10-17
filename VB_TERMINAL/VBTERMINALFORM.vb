'Joshua Makuch
'RCET 3371
'September 29, 2023
'VB Terminal Form
'https://github.com/JoshuaMakuch/VB_TERMINAL

Imports System.IO
Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Messaging
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class VBTERMINALFORM

    Dim PortState As Boolean
    Public receiveByte(18) As Byte 'Receive Data Bytes

    Dim NewData As Integer
    Dim DataIn1, DataIn2, DataIn3, DataIn4, DataIn5, DataIn6, DataIn7, DataIn8 As Integer
    Dim SettingsButtonState As Boolean
    Dim QYATBoardSampleTime As Integer

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
        SettingsButtonState = True
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

    'Every 1mS it will update the PortData List box
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim DataIn As String
        DataIn = ""
        PortData.Items.Clear()
        PortData.Items.Add("Com Port = " & SerialPort1.PortName) 'show current baud rate
        PortData.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'show current baud rate
        PortData.Items.Add("Data Bits = " & SerialPort1.DataBits)
        PortData.Items.Add("Stop Bits = " & SerialPort1.StopBits)
        PortData.Items.Add("Parity = " & SerialPort1.Parity)

        If TabControl1.SelectedIndex = 0 Then 'This is the settings tab
            CheckForReceived()
        ElseIf TabControl1.SelectedIndex = 1 Then 'This is the QY@ board tab
            QYBoardTabHandle()
        End If

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
            If SettingsButtonState = True Then SerialPort1.PortName = PortSelect.SelectedItem
            SerialPort1.BaudRate = PortSelect.SelectedItem 'see if Baud Rate data Is in the list box
        Catch ex As Exception

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
        SettingsButtonState = False
    End Sub

    'Handles the quit button
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click, QuitButton2.Click
        Try
            SerialPort1.Close()
            Close()
        Catch ex As Exception

        End Try
    End Sub

    'Handles send packet button
    Private Sub SendPacketButton_Click(sender As Object, e As EventArgs) Handles SendPacketButton.Click

        Timer1.Enabled = False 'stop timer
        Dim DataOut As String 'Transmit Variable

        DataOut = DataTextBox.Text

        If PortState = True Then 'Test if port is open
            If DataOut IsNot "" Then 'Test transmit data is not blank
                SerialPort1.Write(DataOut)
                OutTerm.Items.Add(DataOut)
            Else 'Send Data was blank
                Timer1.Enabled = True 'restart timer
                Exit Sub 'Leave
            End If
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





    '*** SERIAL PORT HANDLING *************************************************************************************************************************************************************************



    'Whenever the com port says we have information
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        SerialPort1.Read(receiveByte, 0, 8)

        Select Case NewData
            Case = 0
                DataIn1 = receiveByte(0)
            Case = 1
                DataIn2 = receiveByte(1)
            Case = 2
                DataIn3 = receiveByte(2)
            Case = 3
                DataIn4 = receiveByte(3)
            Case = 4
                DataIn5 = receiveByte(4)
            Case = 5
                DataIn6 = receiveByte(5)
            Case = 6
                DataIn7 = receiveByte(6)
            Case = 7
                DataIn8 = receiveByte(7)
            Case Else
                NewData = 0
                Exit Sub
        End Select

        NewData += 1

    End Sub




    '*** Custom Subs ********************************************************************************************************************************************************************************


    Sub QYBoardTabHandle()
        If PortState = True Then
            '*** Read Digital Inputs **************************************************************
            Dim FinalWritePacket(7) As Byte
            FinalWritePacket(0) = &H30

            '*** Write Digital Outputs ************************************************************

            Dim FinalDec As Integer 'This holds onto all weighted button data

            If DigitalWriteCheckBox0.Checked Then FinalDec = FinalDec + 128
            If DigitalWriteCheckBox1.Checked Then FinalDec = FinalDec + 64
            If DigitalWriteCheckBox2.Checked Then FinalDec = FinalDec + 32
            If DigitalWriteCheckBox3.Checked Then FinalDec = FinalDec + 16
            If DigitalWriteCheckBox4.Checked Then FinalDec = FinalDec + 8
            If DigitalWriteCheckBox5.Checked Then FinalDec = FinalDec + 4
            If DigitalWriteCheckBox6.Checked Then FinalDec = FinalDec + 2
            If DigitalWriteCheckBox7.Checked Then FinalDec = FinalDec + 1

            FinalWritePacket(1) = &H20
            FinalWritePacket(2) = FinalDec

            '*** Read Analog Inputs ***************************************************************

            FinalWritePacket(3) = &H51

            '*** Write Analog Outputs *************************************************************
            Dim UpperAnaOutVal As Integer = AnalogOutputBar.Value / (1023 / 255)

            FinalWritePacket(4) = &H41
            FinalWritePacket(5) = UpperAnaOutVal
            FinalWritePacket(6) = &HFF
            AnalogOutputCountLabel.Text = AnalogOutputBar.Value
            AnalogOutputVoltageLabel.Text = CStr(Math.Round(AnalogOutputBar.Value * 3.3 / 1023, 2)) & " V"


            '*** Read Full Input String ***********************************************************
            WritePacketToOutput(FinalWritePacket)
            If QYATBoardSampleTime > 3 Then
                Try
                    Dim InValString As String = CheckForReceived()
                    Dim DigInVal As Integer = Convert.ToInt32(InValString.Chars(0) & InValString.Chars(1), 16)
                    If DigInVal >= 128 Then ReadDigitalCheckbox0.Checked = True : DigInVal -= 128 Else ReadDigitalCheckbox0.Checked = False
                    If DigInVal >= 64 Then ReadDigitalCheckbox1.Checked = True : DigInVal -= 64 Else ReadDigitalCheckbox1.Checked = False
                    If DigInVal >= 32 Then ReadDigitalCheckbox2.Checked = True : DigInVal -= 32 Else ReadDigitalCheckbox2.Checked = False
                    If DigInVal >= 16 Then ReadDigitalCheckbox3.Checked = True : DigInVal -= 16 Else ReadDigitalCheckbox3.Checked = False
                    If DigInVal >= 8 Then ReadDigitalCheckbox4.Checked = True : DigInVal -= 8 Else ReadDigitalCheckbox4.Checked = False
                    If DigInVal >= 4 Then ReadDigitalCheckbox5.Checked = True : DigInVal -= 4 Else ReadDigitalCheckbox5.Checked = False
                    If DigInVal >= 2 Then ReadDigitalCheckbox6.Checked = True : DigInVal -= 2 Else ReadDigitalCheckbox6.Checked = False
                    If DigInVal >= 1 Then ReadDigitalCheckbox7.Checked = True : DigInVal -= 1 Else ReadDigitalCheckbox7.Checked = False

                    Dim AnaInVal As Integer = (Convert.ToInt32(InValString.Chars(2), 16) * 64) + (Convert.ToInt32(InValString.Chars(3), 16) * 4) + (Convert.ToInt32(InValString.Chars(4), 16) / 32)
                    'AnalogInputProgressBar.Value = AnaInVal
                    AnalogInputValueLabel.Text = AnaInVal
                    AnalogInputVoltageLabel.Text = CStr(Math.Round(AnaInVal * 3.3 / 1023, 2)) & " V"

                Catch ex As Exception

                End Try
                QYATBoardSampleTime = 0
            Else
                QYATBoardSampleTime += 1
            End If

        Else
            PortIsBad()
        End If
    End Sub

    'This is used to send data from 
    Private Sub WritePacketToOutput(MyMessage() As Byte)
        Dim OutTermString As String = ""
        Timer1.Enabled = False 'stop timer
        Dim NewVar(8) As Byte
        If PortState = True Then 'Test if port is open
            Try
                For i As Integer = 0 To MyMessage.Length - 1
                    NewVar(i) = MyMessage(i)
                    OutTermString = OutTermString & "." & Hex(MyMessage(i))
                Next
                SerialPort1.Write(NewVar, 0, NewVar.Length)
                OutTerm.Items.Add(OutTermString)
            Catch ex As Exception
                PortIsBad()
            End Try
        Else
            PortIsBad()
        End If
        Timer1.Enabled = True 'restart timer
    End Sub

    'This is used to recieve new data only when desired
    Private Function CheckForReceived()

        Dim DataIn As String = ""
        Dim Input1, Input2, Input3, Input4, Input5, Input6, Input7, Input8 As Integer

        If NewData > 0 Then 'Test NewData if >0 there is information to display  Select Case NewData
            Select Case NewData
                Case = 8
                    Input8 = DataIn8
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 7
                    Input7 = DataIn7
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 6
                    Input6 = DataIn6
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 5
                    Input5 = DataIn5
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 4
                    Input4 = DataIn4
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 3
                    Input3 = DataIn3
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 2
                    Input2 = DataIn2
                    NewData -= 1
            End Select
            Select Case NewData
                Case = 1
                    Input1 = DataIn1
                    NewData -= 1
                    InTerm.Items.Add(Hex(Input1) & Hex(Input2) & Hex(Input3) & Hex(Input4) & Hex(Input5) & Hex(Input6) & Hex(Input7) & Hex(Input8))
            End Select

            DataIn = Hex(Input1) & Hex(Input2) & Hex(Input3) & Hex(Input4) & Hex(Input5) & Hex(Input6) & Hex(Input7) & Hex(Input8)


        End If

        Return (DataIn)

    End Function

    'This is called alot so it was put into a sub
    Private Sub PortIsBad()
        SerialPort1.Close()
        PortOpen.Text = "Connect"
        PortState = False
        TabControl1.SelectedIndex = 0
        ScanButton.Select()
        MsgBox("Please configure and open serial port to procede") 'Failure if port is not open
    End Sub



End Class
