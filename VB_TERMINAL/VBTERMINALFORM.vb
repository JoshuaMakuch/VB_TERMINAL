'Joshua Makuch
'RCET 3371
'September 29, 2023
'VB Terminal Form
'https://github.com/JoshuaMakuch/VB_TERMINAL

Public Class VBTERMINALFORM

    Dim PortState As Boolean

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

End Class
