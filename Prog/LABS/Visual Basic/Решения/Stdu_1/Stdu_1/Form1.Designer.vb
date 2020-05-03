<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.lblTime = New System.Windows.Forms.Label()
		Me.clockTimer = New System.Windows.Forms.Timer(Me.components)
		Me.tboxHour = New System.Windows.Forms.TextBox()
		Me.tboxMinutes = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.checkIsOn = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'lblTime
		'
		Me.lblTime.AccessibleName = ""
		Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblTime.Location = New System.Drawing.Point(12, 9)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(288, 114)
		Me.lblTime.TabIndex = 0
		Me.lblTime.Text = "lblSignal"
		Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'clockTimer
		'
		Me.clockTimer.Enabled = True
		Me.clockTimer.Interval = 1000
		'
		'tboxHour
		'
		Me.tboxHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.tboxHour.Location = New System.Drawing.Point(109, 121)
		Me.tboxHour.MaxLength = 2
		Me.tboxHour.Name = "tboxHour"
		Me.tboxHour.Size = New System.Drawing.Size(48, 31)
		Me.tboxHour.TabIndex = 1
		Me.tboxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tboxMinutes
		'
		Me.tboxMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.tboxMinutes.Location = New System.Drawing.Point(208, 121)
		Me.tboxMinutes.MaxLength = 2
		Me.tboxMinutes.Name = "tboxMinutes"
		Me.tboxMinutes.Size = New System.Drawing.Size(48, 31)
		Me.tboxMinutes.TabIndex = 2
		Me.tboxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(262, 133)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(38, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Минут"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(163, 133)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Часов"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 133)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(91, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Подать сигнал в"
		'
		'checkIsOn
		'
		Me.checkIsOn.AutoSize = True
		Me.checkIsOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.checkIsOn.Location = New System.Drawing.Point(55, 161)
		Me.checkIsOn.Name = "checkIsOn"
		Me.checkIsOn.Size = New System.Drawing.Size(201, 29)
		Me.checkIsOn.TabIndex = 6
		Me.checkIsOn.Text = "Включить сигнал"
		Me.checkIsOn.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(312, 202)
		Me.Controls.Add(Me.checkIsOn)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.tboxMinutes)
		Me.Controls.Add(Me.tboxHour)
		Me.Controls.Add(Me.lblTime)
		Me.Name = "Form1"
		Me.Text = "Signal"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTime As Label
    Friend WithEvents clockTimer As Timer
	Friend WithEvents tboxHour As TextBox
	Friend WithEvents tboxMinutes As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents checkIsOn As CheckBox
End Class
