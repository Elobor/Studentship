<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(12, 43)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(272, 277)
		Me.TextBox1.TabIndex = 0
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(105, 326)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(82, 37)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Go"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(272, 23)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Проект студента грппы ИЭ-65-19 Изотова Д.А."
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(299, 375)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "Form1"
		Me.Text = "Простой цикл"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
End Class
