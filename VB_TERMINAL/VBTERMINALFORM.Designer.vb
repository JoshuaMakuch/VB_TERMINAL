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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.QYTab = New System.Windows.Forms.TabPage()
        Me.AnalogInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnalogInputVoltageLabel = New System.Windows.Forms.Label()
        Me.AnalogInputProgressBar = New System.Windows.Forms.ProgressBar()
        Me.AnalogInputValueLabel = New System.Windows.Forms.Label()
        Me.AnalogInputBarLabel = New System.Windows.Forms.Label()
        Me.AnalogOutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnalogOutputBar = New System.Windows.Forms.TrackBar()
        Me.AnalogOutputBarLabel = New System.Windows.Forms.Label()
        Me.AnalogOutputVoltageLabel = New System.Windows.Forms.Label()
        Me.AnalogOutputCountLabel = New System.Windows.Forms.Label()
        Me.QuitButton2 = New System.Windows.Forms.Button()
        Me.DigitalOutputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DigitalWriteCheckBox0 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox4 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox5 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox6 = New System.Windows.Forms.CheckBox()
        Me.DigitalWriteCheckBox7 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalInputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReadDigitalCheckbox0 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox1 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox2 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox3 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox4 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox5 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox6 = New System.Windows.Forms.CheckBox()
        Me.ReadDigitalCheckbox7 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        Me.QYTab.SuspendLayout()
        Me.AnalogInputGroupBox.SuspendLayout()
        Me.AnalogOutputGroupBox.SuspendLayout()
        CType(Me.AnalogOutputBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DigitalOutputsGroupBox.SuspendLayout()
        Me.ReadDigitalInputsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        Me.SettingsTab.Controls.Add(Me.PortSelect)
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
        Me.QYTab.Controls.Add(Me.AnalogInputGroupBox)
        Me.QYTab.Controls.Add(Me.AnalogOutputGroupBox)
        Me.QYTab.Controls.Add(Me.QuitButton2)
        Me.QYTab.Controls.Add(Me.DigitalOutputsGroupBox)
        Me.QYTab.Controls.Add(Me.ReadDigitalInputsGroupBox)
        Me.QYTab.Location = New System.Drawing.Point(4, 25)
        Me.QYTab.Name = "QYTab"
        Me.QYTab.Padding = New System.Windows.Forms.Padding(3)
        Me.QYTab.Size = New System.Drawing.Size(854, 548)
        Me.QYTab.TabIndex = 1
        Me.QYTab.Text = "QY@ Board Control"
        Me.QYTab.UseVisualStyleBackColor = True
        '
        'AnalogInputGroupBox
        '
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputVoltageLabel)
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputProgressBar)
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputValueLabel)
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputBarLabel)
        Me.AnalogInputGroupBox.Location = New System.Drawing.Point(6, 279)
        Me.AnalogInputGroupBox.Name = "AnalogInputGroupBox"
        Me.AnalogInputGroupBox.Size = New System.Drawing.Size(368, 124)
        Me.AnalogInputGroupBox.TabIndex = 28
        Me.AnalogInputGroupBox.TabStop = False
        Me.AnalogInputGroupBox.Text = "Analog Inputs"
        '
        'AnalogInputVoltageLabel
        '
        Me.AnalogInputVoltageLabel.AutoSize = True
        Me.AnalogInputVoltageLabel.Location = New System.Drawing.Point(6, 85)
        Me.AnalogInputVoltageLabel.Name = "AnalogInputVoltageLabel"
        Me.AnalogInputVoltageLabel.Size = New System.Drawing.Size(131, 16)
        Me.AnalogInputVoltageLabel.TabIndex = 29
        Me.AnalogInputVoltageLabel.Text = "Analog Input Voltage"
        '
        'AnalogInputProgressBar
        '
        Me.AnalogInputProgressBar.Location = New System.Drawing.Point(6, 42)
        Me.AnalogInputProgressBar.Maximum = 1023
        Me.AnalogInputProgressBar.Name = "AnalogInputProgressBar"
        Me.AnalogInputProgressBar.Size = New System.Drawing.Size(346, 23)
        Me.AnalogInputProgressBar.TabIndex = 27
        '
        'AnalogInputValueLabel
        '
        Me.AnalogInputValueLabel.AutoSize = True
        Me.AnalogInputValueLabel.Location = New System.Drawing.Point(4, 68)
        Me.AnalogInputValueLabel.Name = "AnalogInputValueLabel"
        Me.AnalogInputValueLabel.Size = New System.Drawing.Size(119, 16)
        Me.AnalogInputValueLabel.TabIndex = 28
        Me.AnalogInputValueLabel.Text = "Analog Input Value"
        '
        'AnalogInputBarLabel
        '
        Me.AnalogInputBarLabel.AutoSize = True
        Me.AnalogInputBarLabel.Location = New System.Drawing.Point(4, 23)
        Me.AnalogInputBarLabel.Name = "AnalogInputBarLabel"
        Me.AnalogInputBarLabel.Size = New System.Drawing.Size(91, 16)
        Me.AnalogInputBarLabel.TabIndex = 26
        Me.AnalogInputBarLabel.Text = "Analog Input 1"
        '
        'AnalogOutputGroupBox
        '
        Me.AnalogOutputGroupBox.Controls.Add(Me.AnalogOutputBar)
        Me.AnalogOutputGroupBox.Controls.Add(Me.AnalogOutputBarLabel)
        Me.AnalogOutputGroupBox.Controls.Add(Me.AnalogOutputVoltageLabel)
        Me.AnalogOutputGroupBox.Controls.Add(Me.AnalogOutputCountLabel)
        Me.AnalogOutputGroupBox.Location = New System.Drawing.Point(6, 132)
        Me.AnalogOutputGroupBox.Name = "AnalogOutputGroupBox"
        Me.AnalogOutputGroupBox.Size = New System.Drawing.Size(368, 141)
        Me.AnalogOutputGroupBox.TabIndex = 25
        Me.AnalogOutputGroupBox.TabStop = False
        Me.AnalogOutputGroupBox.Text = "Analog Outputs"
        '
        'AnalogOutputBar
        '
        Me.AnalogOutputBar.Location = New System.Drawing.Point(6, 38)
        Me.AnalogOutputBar.Maximum = 1023
        Me.AnalogOutputBar.Name = "AnalogOutputBar"
        Me.AnalogOutputBar.Size = New System.Drawing.Size(346, 56)
        Me.AnalogOutputBar.TabIndex = 20
        '
        'AnalogOutputBarLabel
        '
        Me.AnalogOutputBarLabel.AutoSize = True
        Me.AnalogOutputBarLabel.Location = New System.Drawing.Point(3, 19)
        Me.AnalogOutputBarLabel.Name = "AnalogOutputBarLabel"
        Me.AnalogOutputBarLabel.Size = New System.Drawing.Size(101, 16)
        Me.AnalogOutputBarLabel.TabIndex = 21
        Me.AnalogOutputBarLabel.Text = "Analog Output 1"
        '
        'AnalogOutputVoltageLabel
        '
        Me.AnalogOutputVoltageLabel.AutoSize = True
        Me.AnalogOutputVoltageLabel.Location = New System.Drawing.Point(3, 113)
        Me.AnalogOutputVoltageLabel.Name = "AnalogOutputVoltageLabel"
        Me.AnalogOutputVoltageLabel.Size = New System.Drawing.Size(141, 16)
        Me.AnalogOutputVoltageLabel.TabIndex = 23
        Me.AnalogOutputVoltageLabel.Text = "Analog Output Voltage"
        '
        'AnalogOutputCountLabel
        '
        Me.AnalogOutputCountLabel.AutoSize = True
        Me.AnalogOutputCountLabel.Location = New System.Drawing.Point(3, 97)
        Me.AnalogOutputCountLabel.Name = "AnalogOutputCountLabel"
        Me.AnalogOutputCountLabel.Size = New System.Drawing.Size(129, 16)
        Me.AnalogOutputCountLabel.TabIndex = 22
        Me.AnalogOutputCountLabel.Text = "Analog Output Value"
        '
        'QuitButton2
        '
        Me.QuitButton2.Location = New System.Drawing.Point(750, 497)
        Me.QuitButton2.Name = "QuitButton2"
        Me.QuitButton2.Size = New System.Drawing.Size(101, 45)
        Me.QuitButton2.TabIndex = 24
        Me.QuitButton2.Text = "Quit"
        Me.QuitButton2.UseVisualStyleBackColor = True
        '
        'DigitalOutputsGroupBox
        '
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox0)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox1)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox2)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox3)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox4)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox5)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox6)
        Me.DigitalOutputsGroupBox.Controls.Add(Me.DigitalWriteCheckBox7)
        Me.DigitalOutputsGroupBox.Location = New System.Drawing.Point(6, 69)
        Me.DigitalOutputsGroupBox.Name = "DigitalOutputsGroupBox"
        Me.DigitalOutputsGroupBox.Size = New System.Drawing.Size(254, 57)
        Me.DigitalOutputsGroupBox.TabIndex = 19
        Me.DigitalOutputsGroupBox.TabStop = False
        Me.DigitalOutputsGroupBox.Text = "Digital Outputs"
        '
        'DigitalWriteCheckBox0
        '
        Me.DigitalWriteCheckBox0.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox0.Location = New System.Drawing.Point(6, 21)
        Me.DigitalWriteCheckBox0.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox0.Name = "DigitalWriteCheckBox0"
        Me.DigitalWriteCheckBox0.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox0.TabIndex = 0
        Me.DigitalWriteCheckBox0.TabStop = False
        Me.DigitalWriteCheckBox0.Text = "MSB"
        Me.DigitalWriteCheckBox0.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox1
        '
        Me.DigitalWriteCheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox1.Location = New System.Drawing.Point(37, 21)
        Me.DigitalWriteCheckBox1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox1.Name = "DigitalWriteCheckBox1"
        Me.DigitalWriteCheckBox1.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox1.TabIndex = 2
        Me.DigitalWriteCheckBox1.TabStop = False
        Me.DigitalWriteCheckBox1.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox2
        '
        Me.DigitalWriteCheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox2.Location = New System.Drawing.Point(68, 21)
        Me.DigitalWriteCheckBox2.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox2.Name = "DigitalWriteCheckBox2"
        Me.DigitalWriteCheckBox2.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox2.TabIndex = 3
        Me.DigitalWriteCheckBox2.TabStop = False
        Me.DigitalWriteCheckBox2.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox3
        '
        Me.DigitalWriteCheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox3.Location = New System.Drawing.Point(99, 21)
        Me.DigitalWriteCheckBox3.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox3.Name = "DigitalWriteCheckBox3"
        Me.DigitalWriteCheckBox3.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox3.TabIndex = 4
        Me.DigitalWriteCheckBox3.TabStop = False
        Me.DigitalWriteCheckBox3.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox4
        '
        Me.DigitalWriteCheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox4.Location = New System.Drawing.Point(130, 21)
        Me.DigitalWriteCheckBox4.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox4.Name = "DigitalWriteCheckBox4"
        Me.DigitalWriteCheckBox4.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox4.TabIndex = 5
        Me.DigitalWriteCheckBox4.TabStop = False
        Me.DigitalWriteCheckBox4.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox5
        '
        Me.DigitalWriteCheckBox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox5.Location = New System.Drawing.Point(161, 21)
        Me.DigitalWriteCheckBox5.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox5.Name = "DigitalWriteCheckBox5"
        Me.DigitalWriteCheckBox5.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox5.TabIndex = 6
        Me.DigitalWriteCheckBox5.TabStop = False
        Me.DigitalWriteCheckBox5.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox6
        '
        Me.DigitalWriteCheckBox6.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox6.Location = New System.Drawing.Point(192, 21)
        Me.DigitalWriteCheckBox6.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox6.Name = "DigitalWriteCheckBox6"
        Me.DigitalWriteCheckBox6.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox6.TabIndex = 7
        Me.DigitalWriteCheckBox6.TabStop = False
        Me.DigitalWriteCheckBox6.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox7
        '
        Me.DigitalWriteCheckBox7.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox7.Location = New System.Drawing.Point(223, 21)
        Me.DigitalWriteCheckBox7.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox7.Name = "DigitalWriteCheckBox7"
        Me.DigitalWriteCheckBox7.Size = New System.Drawing.Size(25, 25)
        Me.DigitalWriteCheckBox7.TabIndex = 8
        Me.DigitalWriteCheckBox7.TabStop = False
        Me.DigitalWriteCheckBox7.Text = "LSB"
        Me.DigitalWriteCheckBox7.UseVisualStyleBackColor = True
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
        Me.ReadDigitalCheckbox0.Text = "MSB"
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
        Me.ReadDigitalCheckbox7.Text = "L"
        Me.ReadDigitalCheckbox7.UseVisualStyleBackColor = True
        '
        'VBTERMINALFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 590)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "VBTERMINALFORM"
        Me.Text = "VB Terminal Form"
        Me.TabControl1.ResumeLayout(False)
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        Me.QYTab.ResumeLayout(False)
        Me.AnalogInputGroupBox.ResumeLayout(False)
        Me.AnalogInputGroupBox.PerformLayout()
        Me.AnalogOutputGroupBox.ResumeLayout(False)
        Me.AnalogOutputGroupBox.PerformLayout()
        CType(Me.AnalogOutputBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DigitalOutputsGroupBox.ResumeLayout(False)
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SettingsTab As TabPage
    Friend WithEvents QYTab As TabPage
    Friend WithEvents ReadDigitalCheckbox0 As CheckBox
    Friend WithEvents ReadDigitalCheckbox6 As CheckBox
    Friend WithEvents ReadDigitalCheckbox5 As CheckBox
    Friend WithEvents ReadDigitalCheckbox4 As CheckBox
    Friend WithEvents ReadDigitalCheckbox3 As CheckBox
    Friend WithEvents ReadDigitalCheckbox2 As CheckBox
    Friend WithEvents ReadDigitalCheckbox1 As CheckBox
    Friend WithEvents ReadDigitalInputsGroupBox As GroupBox
    Friend WithEvents ReadDigitalCheckbox7 As CheckBox
    Friend WithEvents DigitalOutputsGroupBox As GroupBox
    Friend WithEvents DigitalWriteCheckBox0 As CheckBox
    Friend WithEvents DigitalWriteCheckBox1 As CheckBox
    Friend WithEvents DigitalWriteCheckBox2 As CheckBox
    Friend WithEvents DigitalWriteCheckBox3 As CheckBox
    Friend WithEvents DigitalWriteCheckBox4 As CheckBox
    Friend WithEvents DigitalWriteCheckBox5 As CheckBox
    Friend WithEvents DigitalWriteCheckBox6 As CheckBox
    Friend WithEvents DigitalWriteCheckBox7 As CheckBox
    Friend WithEvents AnalogOutputCountLabel As Label
    Friend WithEvents AnalogOutputBarLabel As Label
    Friend WithEvents AnalogOutputBar As TrackBar
    Friend WithEvents AnalogOutputVoltageLabel As Label
    Friend WithEvents QuitButton2 As Button
    Friend WithEvents AnalogOutputGroupBox As GroupBox
    Friend WithEvents AnalogInputBarLabel As Label
    Friend WithEvents AnalogInputVoltageLabel As Label
    Friend WithEvents AnalogInputValueLabel As Label
    Friend WithEvents AnalogInputGroupBox As GroupBox
    Friend WithEvents AnalogInputProgressBar As ProgressBar
End Class
