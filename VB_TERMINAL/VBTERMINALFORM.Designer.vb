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
        Me.PortSelect.Size = New System.Drawing.Size(203, 180)
        Me.PortSelect.TabIndex = 0
        '
        'ScanButton
        '
        Me.ScanButton.Location = New System.Drawing.Point(12, 12)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(160, 92)
        Me.ScanButton.TabIndex = 1
        Me.ScanButton.Text = "Scan"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'PortOpen
        '
        Me.PortOpen.Location = New System.Drawing.Point(12, 110)
        Me.PortOpen.Name = "PortOpen"
        Me.PortOpen.Size = New System.Drawing.Size(160, 92)
        Me.PortOpen.TabIndex = 2
        Me.PortOpen.Text = "Port Open"
        Me.PortOpen.UseVisualStyleBackColor = True
        '
        'PortData
        '
        Me.PortData.FormattingEnabled = True
        Me.PortData.ItemHeight = 16
        Me.PortData.Location = New System.Drawing.Point(178, 198)
        Me.PortData.Name = "PortData"
        Me.PortData.Size = New System.Drawing.Size(203, 180)
        Me.PortData.TabIndex = 3
        '
        'VBTERMINALFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 534)
        Me.Controls.Add(Me.PortData)
        Me.Controls.Add(Me.PortOpen)
        Me.Controls.Add(Me.ScanButton)
        Me.Controls.Add(Me.PortSelect)
        Me.Name = "VBTERMINALFORM"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PortSelect As ListBox
    Friend WithEvents ScanButton As Button
    Friend WithEvents PortOpen As Button
    Friend WithEvents PortData As ListBox
End Class
