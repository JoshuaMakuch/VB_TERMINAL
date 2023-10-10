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
        Me.DecimalRadioButton = New System.Windows.Forms.RadioButton()
        Me.ASCIIRadioButton = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.QYTab = New System.Windows.Forms.TabPage()
        Me.ReadDigitalInputsButton = New System.Windows.Forms.Button()
        Me.ReadDigitalCheckbox0 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox1 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox3 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox2 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox6 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox5 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.WriteDigitalOutputsButton = New System.Windows.Forms.Button()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalInputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReadDigitalCheckbox7 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        Me.QYTab.SuspendLayout()
        Me.ReadDigitalInputsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        '
        'PortSelect
        '
        Me.PortSelect.FormattingEnabled = True
        Me.PortSelect.ItemHeight = 16
        Me.PortSelect.Location = New System.Drawing.Point(172, 14)
        Me.PortSelect.Name = "PortSelect"
        Me.PortSelect.Size = New System.Drawing.Size(203, 244)
        Me.PortSelect.TabIndex = 0
        '
        'ScanButton
        '
        Me.ScanButton.Location = New System.Drawing.Point(6, 14)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(160, 92)
        Me.ScanButton.TabIndex = 1
        Me.ScanButton.Text = "Scan Ports"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'PortOpen
        '
        Me.PortOpen.Location = New System.Drawing.Point(6, 210)
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
        Me.PortData.Location = New System.Drawing.Point(172, 272)
        Me.PortData.Name = "PortData"
        Me.PortData.Size = New System.Drawing.Size(203, 260)
        Me.PortData.TabIndex = 3
        '
        'SelectBaud
        '
        Me.SelectBaud.Location = New System.Drawing.Point(6, 112)
        Me.SelectBaud.Name = "SelectBaud"
        Me.SelectBaud.Size = New System.Drawing.Size(160, 92)
        Me.SelectBaud.TabIndex = 4
        Me.SelectBaud.Text = "Select Baud"
        Me.SelectBaud.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(6, 432)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(160, 92)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'DataTextBox
        '
        Me.DataTextBox.Location = New System.Drawing.Point(381, 36)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(462, 22)
        Me.DataTextBox.TabIndex = 6
        '
        'DataPacketTextBox
        '
        Me.DataPacketTextBox.AutoSize = True
        Me.DataPacketTextBox.Location = New System.Drawing.Point(381, 17)
        Me.DataPacketTextBox.Name = "DataPacketTextBox"
        Me.DataPacketTextBox.Size = New System.Drawing.Size(81, 16)
        Me.DataPacketTextBox.TabIndex = 7
        Me.DataPacketTextBox.Text = "Data Packet"
        '
        'SendPacketButton
        '
        Me.SendPacketButton.Location = New System.Drawing.Point(384, 62)
        Me.SendPacketButton.Name = "SendPacketButton"
        Me.SendPacketButton.Size = New System.Drawing.Size(160, 44)
        Me.SendPacketButton.TabIndex = 8
        Me.SendPacketButton.Text = "Send Packet"
        Me.SendPacketButton.UseVisualStyleBackColor = True
        '
        'ClearPacketButton
        '
        Me.ClearPacketButton.Location = New System.Drawing.Point(550, 62)
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
        Me.OutTerm.Location = New System.Drawing.Point(381, 112)
        Me.OutTerm.Name = "OutTerm"
        Me.OutTerm.Size = New System.Drawing.Size(228, 372)
        Me.OutTerm.TabIndex = 10
        '
        'InTerm
        '
        Me.InTerm.FormattingEnabled = True
        Me.InTerm.ItemHeight = 16
        Me.InTerm.Location = New System.Drawing.Point(615, 114)
        Me.InTerm.Name = "InTerm"
        Me.InTerm.Size = New System.Drawing.Size(228, 372)
        Me.InTerm.TabIndex = 11
        '
        'OutputClearButton
        '
        Me.OutputClearButton.Location = New System.Drawing.Point(381, 488)
        Me.OutputClearButton.Name = "OutputClearButton"
        Me.OutputClearButton.Size = New System.Drawing.Size(160, 44)
        Me.OutputClearButton.TabIndex = 12
        Me.OutputClearButton.Text = "Clear"
        Me.OutputClearButton.UseVisualStyleBackColor = True
        '
        'InputClearButton
        '
        Me.InputClearButton.Location = New System.Drawing.Point(615, 492)
        Me.InputClearButton.Name = "InputClearButton"
        Me.InputClearButton.Size = New System.Drawing.Size(160, 44)
        Me.InputClearButton.TabIndex = 13
        Me.InputClearButton.Text = "Clear"
        Me.InputClearButton.UseVisualStyleBackColor = True
        '
        'DecimalRadioButton
        '
        Me.DecimalRadioButton.AutoSize = True
        Me.DecimalRadioButton.Checked = True
        Me.DecimalRadioButton.Location = New System.Drawing.Point(716, 64)
        Me.DecimalRadioButton.Name = "DecimalRadioButton"
        Me.DecimalRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.DecimalRadioButton.TabIndex = 14
        Me.DecimalRadioButton.TabStop = True
        Me.DecimalRadioButton.Text = "Decimal"
        Me.DecimalRadioButton.UseVisualStyleBackColor = True
        '
        'ASCIIRadioButton
        '
        Me.ASCIIRadioButton.AutoSize = True
        Me.ASCIIRadioButton.Location = New System.Drawing.Point(716, 86)
        Me.ASCIIRadioButton.Name = "ASCIIRadioButton"
        Me.ASCIIRadioButton.Size = New System.Drawing.Size(61, 20)
        Me.ASCIIRadioButton.TabIndex = 15
        Me.ASCIIRadioButton.TabStop = True
        Me.ASCIIRadioButton.Text = "ASCII"
        Me.ASCIIRadioButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SettingsTab)
        Me.TabControl1.Controls.Add(Me.QYTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 577)
        Me.TabControl1.TabIndex = 16
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.PortOpen)
        Me.SettingsTab.Controls.Add(Me.DataPacketTextBox)
        Me.SettingsTab.Controls.Add(Me.ASCIIRadioButton)
        Me.SettingsTab.Controls.Add(Me.PortSelect)
        Me.SettingsTab.Controls.Add(Me.DecimalRadioButton)
        Me.SettingsTab.Controls.Add(Me.ScanButton)
        Me.SettingsTab.Controls.Add(Me.InputClearButton)
        Me.SettingsTab.Controls.Add(Me.PortData)
        Me.SettingsTab.Controls.Add(Me.OutputClearButton)
        Me.SettingsTab.Controls.Add(Me.SelectBaud)
        Me.SettingsTab.Controls.Add(Me.InTerm)
        Me.SettingsTab.Controls.Add(Me.QuitButton)
        Me.SettingsTab.Controls.Add(Me.OutTerm)
        Me.SettingsTab.Controls.Add(Me.DataTextBox)
        Me.SettingsTab.Controls.Add(Me.ClearPacketButton)
        Me.SettingsTab.Controls.Add(Me.SendPacketButton)
        Me.SettingsTab.Location = New System.Drawing.Point(4, 25)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingsTab.Size = New System.Drawing.Size(854, 548)
        Me.SettingsTab.TabIndex = 0
        Me.SettingsTab.Text = "Settings"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'QYTab
        '
        Me.QYTab.Controls.Add(Me.ReadDigitalInputsGroupBox)
        Me.QYTab.Controls.Add(Me.CheckBox8)
        Me.QYTab.Controls.Add(Me.WriteDigitalOutputsButton)
        Me.QYTab.Controls.Add(Me.CheckBox9)
        Me.QYTab.Controls.Add(Me.CheckBox10)
        Me.QYTab.Controls.Add(Me.CheckBox11)
        Me.QYTab.Controls.Add(Me.CheckBox12)
        Me.QYTab.Controls.Add(Me.CheckBox13)
        Me.QYTab.Controls.Add(Me.CheckBox14)
        Me.QYTab.Controls.Add(Me.CheckBox15)
        Me.QYTab.Controls.Add(Me.ReadDigitalInputsButton)
        Me.QYTab.Location = New System.Drawing.Point(4, 25)
        Me.QYTab.Name = "QYTab"
        Me.QYTab.Padding = New System.Windows.Forms.Padding(3)
        Me.QYTab.Size = New System.Drawing.Size(854, 548)
        Me.QYTab.TabIndex = 1
        Me.QYTab.Text = "QY@ Board Control"
        Me.QYTab.UseVisualStyleBackColor = True
        '
        'ReadDigitalInputsButton
        '
        Me.ReadDigitalInputsButton.Location = New System.Drawing.Point(6, 69)
        Me.ReadDigitalInputsButton.Name = "ReadDigitalInputsButton"
        Me.ReadDigitalInputsButton.Size = New System.Drawing.Size(137, 69)
        Me.ReadDigitalInputsButton.TabIndex = 1
        Me.ReadDigitalInputsButton.Text = "Read Digital Inputs"
        Me.ReadDigitalInputsButton.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox0
        '
        Me.ReadDigitalCheckbox0.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox0.Enabled = False
        Me.ReadDigitalCheckbox0.Location = New System.Drawing.Point(6, 21)
        Me.ReadDigitalCheckbox0.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox0.Name = "ReadDigitalCheckbox0"
        Me.ReadDigitalCheckbox0.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox0.TabIndex = 0
        Me.ReadDigitalCheckbox0.TabStop = False
        Me.ReadDigitalCheckbox0.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox1
        '
        Me.ReadDigitalCheckbox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox1.Enabled = False
        Me.ReadDigitalCheckbox1.Location = New System.Drawing.Point(37, 21)
        Me.ReadDigitalCheckbox1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox1.Name = "ReadDigitalCheckbox1"
        Me.ReadDigitalCheckbox1.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox1.TabIndex = 2
        Me.ReadDigitalCheckbox1.TabStop = False
        Me.ReadDigitalCheckbox1.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox3
        '
        Me.ReadDigitalCheckbox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox3.Enabled = False
        Me.ReadDigitalCheckbox3.Location = New System.Drawing.Point(99, 21)
        Me.ReadDigitalCheckbox3.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox3.Name = "ReadDigitalCheckbox3"
        Me.ReadDigitalCheckbox3.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox3.TabIndex = 4
        Me.ReadDigitalCheckbox3.TabStop = False
        Me.ReadDigitalCheckbox3.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox2
        '
        Me.ReadDigitalCheckbox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox2.Enabled = False
        Me.ReadDigitalCheckbox2.Location = New System.Drawing.Point(68, 21)
        Me.ReadDigitalCheckbox2.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox2.Name = "ReadDigitalCheckbox2"
        Me.ReadDigitalCheckbox2.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox2.TabIndex = 3
        Me.ReadDigitalCheckbox2.TabStop = False
        Me.ReadDigitalCheckbox2.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox6
        '
        Me.ReadDigitalCheckbox6.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox6.Enabled = False
        Me.ReadDigitalCheckbox6.Location = New System.Drawing.Point(192, 21)
        Me.ReadDigitalCheckbox6.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox6.Name = "ReadDigitalCheckbox6"
        Me.ReadDigitalCheckbox6.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox6.TabIndex = 7
        Me.ReadDigitalCheckbox6.TabStop = False
        Me.ReadDigitalCheckbox6.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox5
        '
        Me.ReadDigitalCheckbox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox5.Enabled = False
        Me.ReadDigitalCheckbox5.Location = New System.Drawing.Point(161, 21)
        Me.ReadDigitalCheckbox5.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox5.Name = "ReadDigitalCheckbox5"
        Me.ReadDigitalCheckbox5.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox5.TabIndex = 6
        Me.ReadDigitalCheckbox5.TabStop = False
        Me.ReadDigitalCheckbox5.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox4
        '
        Me.ReadDigitalCheckbox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox4.Enabled = False
        Me.ReadDigitalCheckbox4.Location = New System.Drawing.Point(130, 21)
        Me.ReadDigitalCheckbox4.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox4.Name = "ReadDigitalCheckbox4"
        Me.ReadDigitalCheckbox4.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox4.TabIndex = 5
        Me.ReadDigitalCheckbox4.TabStop = False
        Me.ReadDigitalCheckbox4.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox8.Enabled = False
        Me.CheckBox8.Location = New System.Drawing.Point(259, 308)
        Me.CheckBox8.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox8.TabIndex = 17
        Me.CheckBox8.TabStop = False
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'WriteDigitalOutputsButton
        '
        Me.WriteDigitalOutputsButton.Location = New System.Drawing.Point(42, 339)
        Me.WriteDigitalOutputsButton.Name = "WriteDigitalOutputsButton"
        Me.WriteDigitalOutputsButton.Size = New System.Drawing.Size(137, 69)
        Me.WriteDigitalOutputsButton.TabIndex = 10
        Me.WriteDigitalOutputsButton.Text = "Write Digital Outputs"
        Me.WriteDigitalOutputsButton.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox9.Enabled = False
        Me.CheckBox9.Location = New System.Drawing.Point(228, 308)
        Me.CheckBox9.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox9.TabIndex = 16
        Me.CheckBox9.TabStop = False
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox10.Enabled = False
        Me.CheckBox10.Location = New System.Drawing.Point(197, 308)
        Me.CheckBox10.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox10.TabIndex = 15
        Me.CheckBox10.TabStop = False
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox11.Enabled = False
        Me.CheckBox11.Location = New System.Drawing.Point(166, 308)
        Me.CheckBox11.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox11.TabIndex = 14
        Me.CheckBox11.TabStop = False
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox12.Enabled = False
        Me.CheckBox12.Location = New System.Drawing.Point(135, 308)
        Me.CheckBox12.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox12.TabIndex = 13
        Me.CheckBox12.TabStop = False
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox13.Enabled = False
        Me.CheckBox13.Location = New System.Drawing.Point(104, 308)
        Me.CheckBox13.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox13.TabIndex = 12
        Me.CheckBox13.TabStop = False
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox14.Enabled = False
        Me.CheckBox14.Location = New System.Drawing.Point(73, 308)
        Me.CheckBox14.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox14.TabIndex = 11
        Me.CheckBox14.TabStop = False
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox15.Enabled = False
        Me.CheckBox15.Location = New System.Drawing.Point(42, 308)
        Me.CheckBox15.MaximumSize = New System.Drawing.Size(50, 50)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(25, 25)
        Me.CheckBox15.TabIndex = 9
        Me.CheckBox15.TabStop = False
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'ReadDigitalInputsGroupBox
        '
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox0)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox1)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox2)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox3)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox4)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox5)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox6)
        Me.ReadDigitalInputsGroupBox.Controls.Add(Me.ReadDigitalCheckbox7)
        Me.ReadDigitalInputsGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.ReadDigitalInputsGroupBox.Name = "ReadDigitalInputsGroupBox"
        Me.ReadDigitalInputsGroupBox.Size = New System.Drawing.Size(254, 57)
        Me.ReadDigitalInputsGroupBox.TabIndex = 18
        Me.ReadDigitalInputsGroupBox.TabStop = False
        Me.ReadDigitalInputsGroupBox.Text = "Digital Inputs"
        '
        'ReadDigitalCheckbox7
        '
        Me.ReadDigitalCheckbox7.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox7.Enabled = False
        Me.ReadDigitalCheckbox7.Location = New System.Drawing.Point(223, 21)
        Me.ReadDigitalCheckbox7.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox7.Name = "ReadDigitalCheckbox7"
        Me.ReadDigitalCheckbox7.Size = New System.Drawing.Size(25, 25)
        Me.ReadDigitalCheckbox7.TabIndex = 8
        Me.ReadDigitalCheckbox7.TabStop = False
        Me.ReadDigitalCheckbox7.UseVisualStyleBackColor = True
        '
        'VBTERMINALFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 594)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "VBTERMINALFORM"
        Me.Text = "VB Terminal Form"
        Me.TabControl1.ResumeLayout(False)
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        Me.QYTab.ResumeLayout(False)
        Me.ReadDigitalInputsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents DecimalRadioButton As RadioButton
    Friend WithEvents ASCIIRadioButton As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SettingsTab As TabPage
    Friend WithEvents QYTab As TabPage
    Friend WithEvents ReadDigitalInputsButton As Button
    Friend WithEvents ReadDigitalCheckbox0 As CheckBox
    Friend WithEvents ReadDigitalCheckbox6 As CheckBox
    Friend WithEvents ReadDigitalCheckbox5 As CheckBox
    Friend WithEvents ReadDigitalCheckbox4 As CheckBox
    Friend WithEvents ReadDigitalCheckbox3 As CheckBox
    Friend WithEvents ReadDigitalCheckbox2 As CheckBox
    Friend WithEvents ReadDigitalCheckbox1 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents WriteDigitalOutputsButton As Button
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents ReadDigitalInputsGroupBox As GroupBox
    Friend WithEvents ReadDigitalCheckbox7 As CheckBox
End Class
