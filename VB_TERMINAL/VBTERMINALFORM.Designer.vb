<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBTERMINALFORM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PortSelect = New System.Windows.Forms.ListBox()
        Me.ScanButton = New System.Windows.Forms.Button()
        Me.PortOpen = New System.Windows.Forms.Button()
        Me.PortData = New System.Windows.Forms.ListBox()
        Me.SelectBaud = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        Me.DataPacketTextBox = New System.Windows.Forms.Label()
        Me.SendPacketButton = New System.Windows.Forms.Button()
        Me.ClearPacketButton = New System.Windows.Forms.Button()
        Me.OutTerm = New System.Windows.Forms.ListBox()
        Me.InTerm = New System.Windows.Forms.ListBox()
        Me.OutputClearButton = New System.Windows.Forms.Button()
        Me.InputClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PortSelect
        '
        Me.PortSelect.FormattingEnabled = True
        Me.PortSelect.ItemHeight = 16
        Me.PortSelect.Location = New System.Drawing.Point(178, 12)
        Me.PortSelect.Name = "PortSelect"
        Me.PortSelect.Size = New System.Drawing.Size(203, 244)
        Me.PortSelect.TabIndex = 0
        '
        'ScanButton
        '
        Me.ScanButton.Location = New System.Drawing.Point(12, 12)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(160, 92)
        Me.ScanButton.TabIndex = 1
        Me.ScanButton.Text = "Scan Ports"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'PortOpen
        '
        Me.PortOpen.Location = New System.Drawing.Point(12, 208)
        Me.PortOpen.Name = "PortOpen"
        Me.PortOpen.Size = New System.Drawing.Size(160, 92)
        Me.PortOpen.TabIndex = 2
        Me.PortOpen.Text = "Connect"
        Me.PortOpen.UseVisualStyleBackColor = True
        '
        'PortData
        '
        Me.PortData.FormattingEnabled = True
        Me.PortData.ItemHeight = 16
        Me.PortData.Location = New System.Drawing.Point(178, 270)
        Me.PortData.Name = "PortData"
        Me.PortData.Size = New System.Drawing.Size(203, 260)
        Me.PortData.TabIndex = 3
        '
        'SelectBaud
        '
        Me.SelectBaud.Location = New System.Drawing.Point(12, 110)
        Me.SelectBaud.Name = "SelectBaud"
        Me.SelectBaud.Size = New System.Drawing.Size(160, 92)
        Me.SelectBaud.TabIndex = 4
        Me.SelectBaud.Text = "Select Baud"
        Me.SelectBaud.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(12, 430)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(160, 92)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'DataTextBox
        '
        Me.DataTextBox.Location = New System.Drawing.Point(387, 34)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(462, 22)
        Me.DataTextBox.TabIndex = 6
        '
        'DataPacketTextBox
        '
        Me.DataPacketTextBox.AutoSize = True
        Me.DataPacketTextBox.Location = New System.Drawing.Point(387, 15)
        Me.DataPacketTextBox.Name = "DataPacketTextBox"
        Me.DataPacketTextBox.Size = New System.Drawing.Size(81, 16)
        Me.DataPacketTextBox.TabIndex = 7
        Me.DataPacketTextBox.Text = "Data Packet"
        '
        'SendPacketButton
        '
        Me.SendPacketButton.Location = New System.Drawing.Point(390, 60)
        Me.SendPacketButton.Name = "SendPacketButton"
        Me.SendPacketButton.Size = New System.Drawing.Size(160, 44)
        Me.SendPacketButton.TabIndex = 8
        Me.SendPacketButton.Text = "Send Packet"
        Me.SendPacketButton.UseVisualStyleBackColor = True
        '
        'ClearPacketButton
        '
        Me.ClearPacketButton.Location = New System.Drawing.Point(556, 60)
        Me.ClearPacketButton.Name = "ClearPacketButton"
        Me.ClearPacketButton.Size = New System.Drawing.Size(160, 44)
        Me.ClearPacketButton.TabIndex = 9
        Me.ClearPacketButton.Text = "Clear Packet"
        Me.ClearPacketButton.UseVisualStyleBackColor = True
        '
        'OutTerm
        '
        Me.OutTerm.FormattingEnabled = True
        Me.OutTerm.ItemHeight = 16
        Me.OutTerm.Location = New System.Drawing.Point(387, 110)
        Me.OutTerm.Name = "OutTerm"
        Me.OutTerm.Size = New System.Drawing.Size(228, 372)
        Me.OutTerm.TabIndex = 10
        '
        'InTerm
        '
        Me.InTerm.FormattingEnabled = True
        Me.InTerm.ItemHeight = 16
        Me.InTerm.Location = New System.Drawing.Point(621, 112)
        Me.InTerm.Name = "InTerm"
        Me.InTerm.Size = New System.Drawing.Size(228, 372)
        Me.InTerm.TabIndex = 11
        '
        'OutputClearButton
        '
        Me.OutputClearButton.Location = New System.Drawing.Point(387, 486)
        Me.OutputClearButton.Name = "OutputClearButton"
        Me.OutputClearButton.Size = New System.Drawing.Size(160, 44)
        Me.OutputClearButton.TabIndex = 12
        Me.OutputClearButton.Text = "Clear"
        Me.OutputClearButton.UseVisualStyleBackColor = True
        '
        'InputClearButton
        '
        Me.InputClearButton.Location = New System.Drawing.Point(621, 490)
        Me.InputClearButton.Name = "InputClearButton"
        Me.InputClearButton.Size = New System.Drawing.Size(160, 44)
        Me.InputClearButton.TabIndex = 13
        Me.InputClearButton.Text = "Clear"
        Me.InputClearButton.UseVisualStyleBackColor = True
        '
        'VBTERMINALFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 534)
        Me.Controls.Add(Me.InputClearButton)
        Me.Controls.Add(Me.OutputClearButton)
        Me.Controls.Add(Me.InTerm)
        Me.Controls.Add(Me.OutTerm)
        Me.Controls.Add(Me.ClearPacketButton)
        Me.Controls.Add(Me.SendPacketButton)
        Me.Controls.Add(Me.DataPacketTextBox)
        Me.Controls.Add(Me.DataTextBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.SelectBaud)
        Me.Controls.Add(Me.PortData)
        Me.Controls.Add(Me.PortOpen)
        Me.Controls.Add(Me.ScanButton)
        Me.Controls.Add(Me.PortSelect)
        Me.Name = "VBTERMINALFORM"
        Me.Text = "VB Terminal Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PortSelect As ListBox
    Friend WithEvents ScanButton As Button
    Friend WithEvents PortOpen As Button
    Friend WithEvents PortData As ListBox
    Friend WithEvents SelectBaud As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents DataTextBox As TextBox
    Friend WithEvents DataPacketTextBox As Label
    Friend WithEvents SendPacketButton As Button
    Friend WithEvents ClearPacketButton As Button
    Friend WithEvents OutTerm As ListBox
    Friend WithEvents InTerm As ListBox
    Friend WithEvents OutputClearButton As Button
    Friend WithEvents InputClearButton As Button
End Class
