﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBTERMINALFORM))
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.DecimalRadioButton = New System.Windows.Forms.RadioButton()
        Me.ASCIIRadioButton = New System.Windows.Forms.RadioButton()
        Me.PICTab = New System.Windows.Forms.TabPage()
        Me.PICTabReceivedTextBoxLabel = New System.Windows.Forms.Label()
        Me.PICTabAnalogInputBar = New System.Windows.Forms.TrackBar()
        Me.PICTabAnalogInputVoltageLabel = New System.Windows.Forms.Label()
        Me.PICTabAnalogInputValueLabel = New System.Windows.Forms.Label()
        Me.PICTabAnalogInputBarLabel = New System.Windows.Forms.Label()
        Me.ManualSendCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServoStateLabel = New System.Windows.Forms.Label()
        Me.PICTabQuitButton = New System.Windows.Forms.Button()
        Me.ManualSendRadioButton = New System.Windows.Forms.RadioButton()
        Me.ContinousSendRadioButton = New System.Windows.Forms.RadioButton()
        Me.ServoStateTrackBar = New System.Windows.Forms.TrackBar()
        Me.QYTab = New System.Windows.Forms.TabPage()
        Me.AnalogInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnalogInputBar = New System.Windows.Forms.TrackBar()
        Me.AnalogInputVoltageLabel = New System.Windows.Forms.Label()
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
        Me.ASCIITableTab = New System.Windows.Forms.TabPage()
        Me.ASCIITablePicturebox = New System.Windows.Forms.PictureBox()
        Me.PICTabReceivedTextBox = New System.Windows.Forms.TextBox()
        Me.PICTabTransmittedDataTextBox = New System.Windows.Forms.TextBox()
        Me.PICTabTransmittedTextBoxLabel = New System.Windows.Forms.Label()
        Me.PICTabAnalogTemperatureBar = New System.Windows.Forms.TrackBar()
        Me.PICTabAnalogTemperatureValueLabel = New System.Windows.Forms.Label()
        Me.PICTabTemperatureBarLabel = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        Me.PICTab.SuspendLayout()
        CType(Me.PICTabAnalogInputBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServoStateTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QYTab.SuspendLayout()
        Me.AnalogInputGroupBox.SuspendLayout()
        CType(Me.AnalogInputBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnalogOutputGroupBox.SuspendLayout()
        CType(Me.AnalogOutputBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DigitalOutputsGroupBox.SuspendLayout()
        Me.ReadDigitalInputsGroupBox.SuspendLayout()
        Me.ASCIITableTab.SuspendLayout()
        CType(Me.ASCIITablePicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICTabAnalogTemperatureBar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.SettingsTab)
        Me.TabControl.Controls.Add(Me.PICTab)
        Me.TabControl.Controls.Add(Me.QYTab)
        Me.TabControl.Controls.Add(Me.ASCIITableTab)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(905, 612)
        Me.TabControl.TabIndex = 16
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.DecimalRadioButton)
        Me.SettingsTab.Controls.Add(Me.ASCIIRadioButton)
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
        Me.SettingsTab.Size = New System.Drawing.Size(897, 583)
        Me.SettingsTab.TabIndex = 0
        Me.SettingsTab.Text = "Settings"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'DecimalRadioButton
        '
        Me.DecimalRadioButton.AutoSize = True
        Me.DecimalRadioButton.Checked = True
        Me.DecimalRadioButton.Location = New System.Drawing.Point(716, 64)
        Me.DecimalRadioButton.Name = "DecimalRadioButton"
        Me.DecimalRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.DecimalRadioButton.TabIndex = 15
        Me.DecimalRadioButton.TabStop = True
        Me.DecimalRadioButton.Text = "Decimal"
        Me.DecimalRadioButton.UseVisualStyleBackColor = True
        '
        'ASCIIRadioButton
        '
        Me.ASCIIRadioButton.AutoSize = True
        Me.ASCIIRadioButton.Location = New System.Drawing.Point(716, 90)
        Me.ASCIIRadioButton.Name = "ASCIIRadioButton"
        Me.ASCIIRadioButton.Size = New System.Drawing.Size(106, 20)
        Me.ASCIIRadioButton.TabIndex = 14
        Me.ASCIIRadioButton.Text = "ASCII Format"
        Me.ASCIIRadioButton.UseVisualStyleBackColor = True
        '
        'PICTab
        '
        Me.PICTab.Controls.Add(Me.PICTabAnalogTemperatureBar)
        Me.PICTab.Controls.Add(Me.PICTabAnalogTemperatureValueLabel)
        Me.PICTab.Controls.Add(Me.PICTabTemperatureBarLabel)
        Me.PICTab.Controls.Add(Me.PICTabTransmittedDataTextBox)
        Me.PICTab.Controls.Add(Me.PICTabTransmittedTextBoxLabel)
        Me.PICTab.Controls.Add(Me.PICTabReceivedTextBox)
        Me.PICTab.Controls.Add(Me.PICTabReceivedTextBoxLabel)
        Me.PICTab.Controls.Add(Me.PICTabAnalogInputBar)
        Me.PICTab.Controls.Add(Me.PICTabAnalogInputVoltageLabel)
        Me.PICTab.Controls.Add(Me.PICTabAnalogInputValueLabel)
        Me.PICTab.Controls.Add(Me.PICTabAnalogInputBarLabel)
        Me.PICTab.Controls.Add(Me.ManualSendCheckBox)
        Me.PICTab.Controls.Add(Me.ServoStateLabel)
        Me.PICTab.Controls.Add(Me.PICTabQuitButton)
        Me.PICTab.Controls.Add(Me.ManualSendRadioButton)
        Me.PICTab.Controls.Add(Me.ContinousSendRadioButton)
        Me.PICTab.Controls.Add(Me.ServoStateTrackBar)
        Me.PICTab.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PICTab.Location = New System.Drawing.Point(4, 25)
        Me.PICTab.Name = "PICTab"
        Me.PICTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PICTab.Size = New System.Drawing.Size(897, 583)
        Me.PICTab.TabIndex = 3
        Me.PICTab.Text = "PIC Tab"
        Me.PICTab.UseVisualStyleBackColor = True
        '
        'PICTabReceivedTextBoxLabel
        '
        Me.PICTabReceivedTextBoxLabel.AutoSize = True
        Me.PICTabReceivedTextBoxLabel.Location = New System.Drawing.Point(3, 450)
        Me.PICTabReceivedTextBoxLabel.Name = "PICTabReceivedTextBoxLabel"
        Me.PICTabReceivedTextBoxLabel.Size = New System.Drawing.Size(101, 16)
        Me.PICTabReceivedTextBoxLabel.TabIndex = 37
        Me.PICTabReceivedTextBoxLabel.Text = "Received Data:"
        '
        'PICTabAnalogInputBar
        '
        Me.PICTabAnalogInputBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PICTabAnalogInputBar.Enabled = False
        Me.PICTabAnalogInputBar.Location = New System.Drawing.Point(6, 111)
        Me.PICTabAnalogInputBar.Maximum = 1023
        Me.PICTabAnalogInputBar.Name = "PICTabAnalogInputBar"
        Me.PICTabAnalogInputBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PICTabAnalogInputBar.Size = New System.Drawing.Size(56, 336)
        Me.PICTabAnalogInputBar.TabIndex = 33
        '
        'PICTabAnalogInputVoltageLabel
        '
        Me.PICTabAnalogInputVoltageLabel.AutoSize = True
        Me.PICTabAnalogInputVoltageLabel.Location = New System.Drawing.Point(68, 127)
        Me.PICTabAnalogInputVoltageLabel.Name = "PICTabAnalogInputVoltageLabel"
        Me.PICTabAnalogInputVoltageLabel.Size = New System.Drawing.Size(131, 16)
        Me.PICTabAnalogInputVoltageLabel.TabIndex = 36
        Me.PICTabAnalogInputVoltageLabel.Text = "Analog Input Voltage"
        '
        'PICTabAnalogInputValueLabel
        '
        Me.PICTabAnalogInputValueLabel.AutoSize = True
        Me.PICTabAnalogInputValueLabel.Location = New System.Drawing.Point(68, 111)
        Me.PICTabAnalogInputValueLabel.Name = "PICTabAnalogInputValueLabel"
        Me.PICTabAnalogInputValueLabel.Size = New System.Drawing.Size(119, 16)
        Me.PICTabAnalogInputValueLabel.TabIndex = 35
        Me.PICTabAnalogInputValueLabel.Text = "Analog Input Value"
        '
        'PICTabAnalogInputBarLabel
        '
        Me.PICTabAnalogInputBarLabel.AutoSize = True
        Me.PICTabAnalogInputBarLabel.Location = New System.Drawing.Point(3, 92)
        Me.PICTabAnalogInputBarLabel.Name = "PICTabAnalogInputBarLabel"
        Me.PICTabAnalogInputBarLabel.Size = New System.Drawing.Size(91, 16)
        Me.PICTabAnalogInputBarLabel.TabIndex = 34
        Me.PICTabAnalogInputBarLabel.Text = "Analog Input 1"
        '
        'ManualSendCheckBox
        '
        Me.ManualSendCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.ManualSendCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualSendCheckBox.Location = New System.Drawing.Point(679, 29)
        Me.ManualSendCheckBox.Name = "ManualSendCheckBox"
        Me.ManualSendCheckBox.Size = New System.Drawing.Size(212, 56)
        Me.ManualSendCheckBox.TabIndex = 32
        Me.ManualSendCheckBox.Text = "Send"
        Me.ManualSendCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ManualSendCheckBox.UseVisualStyleBackColor = True
        '
        'ServoStateLabel
        '
        Me.ServoStateLabel.AutoSize = True
        Me.ServoStateLabel.Location = New System.Drawing.Point(6, 10)
        Me.ServoStateLabel.Name = "ServoStateLabel"
        Me.ServoStateLabel.Size = New System.Drawing.Size(90, 16)
        Me.ServoStateLabel.TabIndex = 31
        Me.ServoStateLabel.Text = "Servo State: ?"
        '
        'PICTabQuitButton
        '
        Me.PICTabQuitButton.Location = New System.Drawing.Point(790, 532)
        Me.PICTabQuitButton.Name = "PICTabQuitButton"
        Me.PICTabQuitButton.Size = New System.Drawing.Size(101, 45)
        Me.PICTabQuitButton.TabIndex = 25
        Me.PICTabQuitButton.Text = "Quit"
        Me.PICTabQuitButton.UseVisualStyleBackColor = True
        '
        'ManualSendRadioButton
        '
        Me.ManualSendRadioButton.AutoSize = True
        Me.ManualSendRadioButton.Checked = True
        Me.ManualSendRadioButton.Location = New System.Drawing.Point(551, 29)
        Me.ManualSendRadioButton.Name = "ManualSendRadioButton"
        Me.ManualSendRadioButton.Size = New System.Drawing.Size(107, 20)
        Me.ManualSendRadioButton.TabIndex = 2
        Me.ManualSendRadioButton.TabStop = True
        Me.ManualSendRadioButton.Text = "Manual Send"
        Me.ManualSendRadioButton.UseVisualStyleBackColor = True
        '
        'ContinousSendRadioButton
        '
        Me.ContinousSendRadioButton.AutoSize = True
        Me.ContinousSendRadioButton.Location = New System.Drawing.Point(551, 55)
        Me.ContinousSendRadioButton.Name = "ContinousSendRadioButton"
        Me.ContinousSendRadioButton.Size = New System.Drawing.Size(122, 20)
        Me.ContinousSendRadioButton.TabIndex = 1
        Me.ContinousSendRadioButton.Text = "Continous Send"
        Me.ContinousSendRadioButton.UseVisualStyleBackColor = True
        '
        'ServoStateTrackBar
        '
        Me.ServoStateTrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ServoStateTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.ServoStateTrackBar.Location = New System.Drawing.Point(6, 29)
        Me.ServoStateTrackBar.Maximum = 20
        Me.ServoStateTrackBar.Minimum = 1
        Me.ServoStateTrackBar.Name = "ServoStateTrackBar"
        Me.ServoStateTrackBar.Size = New System.Drawing.Size(539, 56)
        Me.ServoStateTrackBar.TabIndex = 0
        Me.ServoStateTrackBar.Value = 20
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
        Me.QYTab.Size = New System.Drawing.Size(897, 583)
        Me.QYTab.TabIndex = 1
        Me.QYTab.Text = "QY@ Board Control"
        Me.QYTab.UseVisualStyleBackColor = True
        '
        'AnalogInputGroupBox
        '
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputBar)
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputVoltageLabel)
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputValueLabel)
        Me.AnalogInputGroupBox.Controls.Add(Me.AnalogInputBarLabel)
        Me.AnalogInputGroupBox.Location = New System.Drawing.Point(6, 173)
        Me.AnalogInputGroupBox.Name = "AnalogInputGroupBox"
        Me.AnalogInputGroupBox.Size = New System.Drawing.Size(208, 391)
        Me.AnalogInputGroupBox.TabIndex = 28
        Me.AnalogInputGroupBox.TabStop = False
        Me.AnalogInputGroupBox.Text = "Analog Inputs"
        '
        'AnalogInputBar
        '
        Me.AnalogInputBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AnalogInputBar.Enabled = False
        Me.AnalogInputBar.Location = New System.Drawing.Point(7, 42)
        Me.AnalogInputBar.Maximum = 1023
        Me.AnalogInputBar.Name = "AnalogInputBar"
        Me.AnalogInputBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.AnalogInputBar.Size = New System.Drawing.Size(56, 336)
        Me.AnalogInputBar.TabIndex = 24
        '
        'AnalogInputVoltageLabel
        '
        Me.AnalogInputVoltageLabel.AutoSize = True
        Me.AnalogInputVoltageLabel.Location = New System.Drawing.Point(69, 58)
        Me.AnalogInputVoltageLabel.Name = "AnalogInputVoltageLabel"
        Me.AnalogInputVoltageLabel.Size = New System.Drawing.Size(131, 16)
        Me.AnalogInputVoltageLabel.TabIndex = 29
        Me.AnalogInputVoltageLabel.Text = "Analog Input Voltage"
        '
        'AnalogInputValueLabel
        '
        Me.AnalogInputValueLabel.AutoSize = True
        Me.AnalogInputValueLabel.Location = New System.Drawing.Point(69, 42)
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
        Me.AnalogOutputGroupBox.Location = New System.Drawing.Point(220, 173)
        Me.AnalogOutputGroupBox.Name = "AnalogOutputGroupBox"
        Me.AnalogOutputGroupBox.Size = New System.Drawing.Size(217, 391)
        Me.AnalogOutputGroupBox.TabIndex = 25
        Me.AnalogOutputGroupBox.TabStop = False
        Me.AnalogOutputGroupBox.Text = "Analog Outputs"
        '
        'AnalogOutputBar
        '
        Me.AnalogOutputBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AnalogOutputBar.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.AnalogOutputBar.Location = New System.Drawing.Point(6, 38)
        Me.AnalogOutputBar.Maximum = 1023
        Me.AnalogOutputBar.Name = "AnalogOutputBar"
        Me.AnalogOutputBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.AnalogOutputBar.Size = New System.Drawing.Size(56, 346)
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
        Me.AnalogOutputVoltageLabel.Location = New System.Drawing.Point(68, 63)
        Me.AnalogOutputVoltageLabel.Name = "AnalogOutputVoltageLabel"
        Me.AnalogOutputVoltageLabel.Size = New System.Drawing.Size(141, 16)
        Me.AnalogOutputVoltageLabel.TabIndex = 23
        Me.AnalogOutputVoltageLabel.Text = "Analog Output Voltage"
        '
        'AnalogOutputCountLabel
        '
        Me.AnalogOutputCountLabel.AutoSize = True
        Me.AnalogOutputCountLabel.Location = New System.Drawing.Point(68, 41)
        Me.AnalogOutputCountLabel.Name = "AnalogOutputCountLabel"
        Me.AnalogOutputCountLabel.Size = New System.Drawing.Size(129, 16)
        Me.AnalogOutputCountLabel.TabIndex = 22
        Me.AnalogOutputCountLabel.Text = "Analog Output Value"
        '
        'QuitButton2
        '
        Me.QuitButton2.Location = New System.Drawing.Point(790, 532)
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
        Me.DigitalOutputsGroupBox.Location = New System.Drawing.Point(6, 94)
        Me.DigitalOutputsGroupBox.Name = "DigitalOutputsGroupBox"
        Me.DigitalOutputsGroupBox.Size = New System.Drawing.Size(457, 71)
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
        Me.DigitalWriteCheckBox0.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox0.TabIndex = 0
        Me.DigitalWriteCheckBox0.TabStop = False
        Me.DigitalWriteCheckBox0.Text = "MSB"
        Me.DigitalWriteCheckBox0.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox1
        '
        Me.DigitalWriteCheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox1.Location = New System.Drawing.Point(62, 21)
        Me.DigitalWriteCheckBox1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox1.Name = "DigitalWriteCheckBox1"
        Me.DigitalWriteCheckBox1.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox1.TabIndex = 2
        Me.DigitalWriteCheckBox1.TabStop = False
        Me.DigitalWriteCheckBox1.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox2
        '
        Me.DigitalWriteCheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox2.Location = New System.Drawing.Point(118, 21)
        Me.DigitalWriteCheckBox2.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox2.Name = "DigitalWriteCheckBox2"
        Me.DigitalWriteCheckBox2.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox2.TabIndex = 3
        Me.DigitalWriteCheckBox2.TabStop = False
        Me.DigitalWriteCheckBox2.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox3
        '
        Me.DigitalWriteCheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox3.Location = New System.Drawing.Point(174, 21)
        Me.DigitalWriteCheckBox3.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox3.Name = "DigitalWriteCheckBox3"
        Me.DigitalWriteCheckBox3.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox3.TabIndex = 4
        Me.DigitalWriteCheckBox3.TabStop = False
        Me.DigitalWriteCheckBox3.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox4
        '
        Me.DigitalWriteCheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox4.Location = New System.Drawing.Point(230, 21)
        Me.DigitalWriteCheckBox4.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox4.Name = "DigitalWriteCheckBox4"
        Me.DigitalWriteCheckBox4.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox4.TabIndex = 5
        Me.DigitalWriteCheckBox4.TabStop = False
        Me.DigitalWriteCheckBox4.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox5
        '
        Me.DigitalWriteCheckBox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox5.Location = New System.Drawing.Point(286, 21)
        Me.DigitalWriteCheckBox5.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox5.Name = "DigitalWriteCheckBox5"
        Me.DigitalWriteCheckBox5.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox5.TabIndex = 6
        Me.DigitalWriteCheckBox5.TabStop = False
        Me.DigitalWriteCheckBox5.UseVisualStyleBackColor = True
        '
        'DigitalWriteCheckBox6
        '
        Me.DigitalWriteCheckBox6.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.DigitalWriteCheckBox6.Location = New System.Drawing.Point(342, 21)
        Me.DigitalWriteCheckBox6.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox6.Name = "DigitalWriteCheckBox6"
        Me.DigitalWriteCheckBox6.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox6.TabIndex = 7
        Me.DigitalWriteCheckBox6.TabStop = False
        Me.DigitalWriteCheckBox6.UseVisualStyleBackColor = False
        '
        'DigitalWriteCheckBox7
        '
        Me.DigitalWriteCheckBox7.Appearance = System.Windows.Forms.Appearance.Button
        Me.DigitalWriteCheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.DigitalWriteCheckBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DigitalWriteCheckBox7.Location = New System.Drawing.Point(398, 21)
        Me.DigitalWriteCheckBox7.MaximumSize = New System.Drawing.Size(50, 50)
        Me.DigitalWriteCheckBox7.Name = "DigitalWriteCheckBox7"
        Me.DigitalWriteCheckBox7.Size = New System.Drawing.Size(50, 41)
        Me.DigitalWriteCheckBox7.TabIndex = 8
        Me.DigitalWriteCheckBox7.TabStop = False
        Me.DigitalWriteCheckBox7.Text = "LSB"
        Me.DigitalWriteCheckBox7.UseVisualStyleBackColor = False
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
        Me.ReadDigitalInputsGroupBox.Size = New System.Drawing.Size(457, 82)
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
        Me.ReadDigitalCheckbox0.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox0.TabIndex = 0
        Me.ReadDigitalCheckbox0.TabStop = False
        Me.ReadDigitalCheckbox0.Text = "MSB"
        Me.ReadDigitalCheckbox0.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox1
        '
        Me.ReadDigitalCheckbox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox1.Enabled = False
        Me.ReadDigitalCheckbox1.Location = New System.Drawing.Point(62, 21)
        Me.ReadDigitalCheckbox1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox1.Name = "ReadDigitalCheckbox1"
        Me.ReadDigitalCheckbox1.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox1.TabIndex = 2
        Me.ReadDigitalCheckbox1.TabStop = False
        Me.ReadDigitalCheckbox1.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox2
        '
        Me.ReadDigitalCheckbox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox2.Enabled = False
        Me.ReadDigitalCheckbox2.Location = New System.Drawing.Point(118, 21)
        Me.ReadDigitalCheckbox2.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox2.Name = "ReadDigitalCheckbox2"
        Me.ReadDigitalCheckbox2.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox2.TabIndex = 3
        Me.ReadDigitalCheckbox2.TabStop = False
        Me.ReadDigitalCheckbox2.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox3
        '
        Me.ReadDigitalCheckbox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox3.Enabled = False
        Me.ReadDigitalCheckbox3.Location = New System.Drawing.Point(174, 21)
        Me.ReadDigitalCheckbox3.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox3.Name = "ReadDigitalCheckbox3"
        Me.ReadDigitalCheckbox3.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox3.TabIndex = 4
        Me.ReadDigitalCheckbox3.TabStop = False
        Me.ReadDigitalCheckbox3.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox4
        '
        Me.ReadDigitalCheckbox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox4.Enabled = False
        Me.ReadDigitalCheckbox4.Location = New System.Drawing.Point(230, 21)
        Me.ReadDigitalCheckbox4.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox4.Name = "ReadDigitalCheckbox4"
        Me.ReadDigitalCheckbox4.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox4.TabIndex = 5
        Me.ReadDigitalCheckbox4.TabStop = False
        Me.ReadDigitalCheckbox4.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox5
        '
        Me.ReadDigitalCheckbox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox5.Enabled = False
        Me.ReadDigitalCheckbox5.Location = New System.Drawing.Point(286, 21)
        Me.ReadDigitalCheckbox5.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox5.Name = "ReadDigitalCheckbox5"
        Me.ReadDigitalCheckbox5.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox5.TabIndex = 6
        Me.ReadDigitalCheckbox5.TabStop = False
        Me.ReadDigitalCheckbox5.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox6
        '
        Me.ReadDigitalCheckbox6.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox6.Enabled = False
        Me.ReadDigitalCheckbox6.Location = New System.Drawing.Point(342, 21)
        Me.ReadDigitalCheckbox6.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox6.Name = "ReadDigitalCheckbox6"
        Me.ReadDigitalCheckbox6.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox6.TabIndex = 7
        Me.ReadDigitalCheckbox6.TabStop = False
        Me.ReadDigitalCheckbox6.UseVisualStyleBackColor = True
        '
        'ReadDigitalCheckbox7
        '
        Me.ReadDigitalCheckbox7.Appearance = System.Windows.Forms.Appearance.Button
        Me.ReadDigitalCheckbox7.BackColor = System.Drawing.Color.Transparent
        Me.ReadDigitalCheckbox7.Enabled = False
        Me.ReadDigitalCheckbox7.ForeColor = System.Drawing.Color.Black
        Me.ReadDigitalCheckbox7.Location = New System.Drawing.Point(398, 21)
        Me.ReadDigitalCheckbox7.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ReadDigitalCheckbox7.Name = "ReadDigitalCheckbox7"
        Me.ReadDigitalCheckbox7.Size = New System.Drawing.Size(50, 47)
        Me.ReadDigitalCheckbox7.TabIndex = 8
        Me.ReadDigitalCheckbox7.TabStop = False
        Me.ReadDigitalCheckbox7.Text = "LSB"
        Me.ReadDigitalCheckbox7.UseVisualStyleBackColor = False
        '
        'ASCIITableTab
        '
        Me.ASCIITableTab.Controls.Add(Me.ASCIITablePicturebox)
        Me.ASCIITableTab.Location = New System.Drawing.Point(4, 25)
        Me.ASCIITableTab.Name = "ASCIITableTab"
        Me.ASCIITableTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ASCIITableTab.Size = New System.Drawing.Size(897, 583)
        Me.ASCIITableTab.TabIndex = 2
        Me.ASCIITableTab.Text = "ASCII Table"
        Me.ASCIITableTab.UseVisualStyleBackColor = True
        '
        'ASCIITablePicturebox
        '
        Me.ASCIITablePicturebox.Image = CType(resources.GetObject("ASCIITablePicturebox.Image"), System.Drawing.Image)
        Me.ASCIITablePicturebox.Location = New System.Drawing.Point(3, 6)
        Me.ASCIITablePicturebox.Name = "ASCIITablePicturebox"
        Me.ASCIITablePicturebox.Size = New System.Drawing.Size(891, 574)
        Me.ASCIITablePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ASCIITablePicturebox.TabIndex = 17
        Me.ASCIITablePicturebox.TabStop = False
        '
        'PICTabReceivedTextBox
        '
        Me.PICTabReceivedTextBox.Location = New System.Drawing.Point(6, 469)
        Me.PICTabReceivedTextBox.Name = "PICTabReceivedTextBox"
        Me.PICTabReceivedTextBox.Size = New System.Drawing.Size(227, 22)
        Me.PICTabReceivedTextBox.TabIndex = 38
        '
        'PICTabTransmittedDataTextBox
        '
        Me.PICTabTransmittedDataTextBox.Location = New System.Drawing.Point(6, 522)
        Me.PICTabTransmittedDataTextBox.Name = "PICTabTransmittedDataTextBox"
        Me.PICTabTransmittedDataTextBox.Size = New System.Drawing.Size(227, 22)
        Me.PICTabTransmittedDataTextBox.TabIndex = 40
        '
        'PICTabTransmittedTextBoxLabel
        '
        Me.PICTabTransmittedTextBoxLabel.AutoSize = True
        Me.PICTabTransmittedTextBoxLabel.Location = New System.Drawing.Point(3, 503)
        Me.PICTabTransmittedTextBoxLabel.Name = "PICTabTransmittedTextBoxLabel"
        Me.PICTabTransmittedTextBoxLabel.Size = New System.Drawing.Size(116, 16)
        Me.PICTabTransmittedTextBoxLabel.TabIndex = 39
        Me.PICTabTransmittedTextBoxLabel.Text = "Transmitted Data: "
        '
        'PICTabAnalogTemperatureBar
        '
        Me.PICTabAnalogTemperatureBar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PICTabAnalogTemperatureBar.Enabled = False
        Me.PICTabAnalogTemperatureBar.Location = New System.Drawing.Point(223, 111)
        Me.PICTabAnalogTemperatureBar.Maximum = 1023
        Me.PICTabAnalogTemperatureBar.Name = "PICTabAnalogTemperatureBar"
        Me.PICTabAnalogTemperatureBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PICTabAnalogTemperatureBar.Size = New System.Drawing.Size(56, 336)
        Me.PICTabAnalogTemperatureBar.TabIndex = 41
        '
        'PICTabAnalogTemperatureValueLabel
        '
        Me.PICTabAnalogTemperatureValueLabel.AutoSize = True
        Me.PICTabAnalogTemperatureValueLabel.Location = New System.Drawing.Point(285, 111)
        Me.PICTabAnalogTemperatureValueLabel.Name = "PICTabAnalogTemperatureValueLabel"
        Me.PICTabAnalogTemperatureValueLabel.Size = New System.Drawing.Size(169, 16)
        Me.PICTabAnalogTemperatureValueLabel.TabIndex = 43
        Me.PICTabAnalogTemperatureValueLabel.Text = "Analog Temperature Value"
        '
        'PICTabTemperatureBarLabel
        '
        Me.PICTabTemperatureBarLabel.AutoSize = True
        Me.PICTabTemperatureBarLabel.Location = New System.Drawing.Point(220, 92)
        Me.PICTabTemperatureBarLabel.Name = "PICTabTemperatureBarLabel"
        Me.PICTabTemperatureBarLabel.Size = New System.Drawing.Size(85, 16)
        Me.PICTabTemperatureBarLabel.TabIndex = 42
        Me.PICTabTemperatureBarLabel.Text = "Temperature"
        '
        'VBTERMINALFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 636)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "VBTERMINALFORM"
        Me.Text = "VB Terminal Form"
        Me.TabControl.ResumeLayout(False)
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        Me.PICTab.ResumeLayout(False)
        Me.PICTab.PerformLayout()
        CType(Me.PICTabAnalogInputBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServoStateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QYTab.ResumeLayout(False)
        Me.AnalogInputGroupBox.ResumeLayout(False)
        Me.AnalogInputGroupBox.PerformLayout()
        CType(Me.AnalogInputBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnalogOutputGroupBox.ResumeLayout(False)
        Me.AnalogOutputGroupBox.PerformLayout()
        CType(Me.AnalogOutputBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DigitalOutputsGroupBox.ResumeLayout(False)
        Me.ReadDigitalInputsGroupBox.ResumeLayout(False)
        Me.ASCIITableTab.ResumeLayout(False)
        CType(Me.ASCIITablePicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICTabAnalogTemperatureBar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl As TabControl
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
    Friend WithEvents DecimalRadioButton As RadioButton
    Friend WithEvents ASCIIRadioButton As RadioButton
    Friend WithEvents ASCIITableTab As TabPage
    Friend WithEvents ASCIITablePicturebox As PictureBox
    Friend WithEvents AnalogInputBar As TrackBar
    Friend WithEvents PICTab As TabPage
    Friend WithEvents ServoStateTrackBar As TrackBar
    Friend WithEvents ManualSendRadioButton As RadioButton
    Friend WithEvents ContinousSendRadioButton As RadioButton
    Friend WithEvents PICTabQuitButton As Button
    Friend WithEvents ServoStateLabel As Label
    Friend WithEvents ManualSendCheckBox As CheckBox
    Friend WithEvents PICTabAnalogInputBar As TrackBar
    Friend WithEvents PICTabAnalogInputVoltageLabel As Label
    Friend WithEvents PICTabAnalogInputValueLabel As Label
    Friend WithEvents PICTabAnalogInputBarLabel As Label
    Friend WithEvents PICTabReceivedTextBoxLabel As Label
    Friend WithEvents PICTabReceivedTextBox As TextBox
    Friend WithEvents PICTabTransmittedDataTextBox As TextBox
    Friend WithEvents PICTabTransmittedTextBoxLabel As Label
    Friend WithEvents PICTabAnalogTemperatureBar As TrackBar
    Friend WithEvents PICTabAnalogTemperatureValueLabel As Label
    Friend WithEvents PICTabTemperatureBarLabel As Label
End Class
