Public Class Form1
	Private Sub checkIsOn_CheckedChanged(sender As Object, e As EventArgs) Handles checkIsOn.CheckedChanged
		If tboxHour.ReadOnly = False Then
			tboxHour.ReadOnly = True
			tboxMinutes.ReadOnly = True
		Else
			tboxHour.ReadOnly = False
			tboxMinutes.ReadOnly = False
		End If
	End Sub

	Private Sub clockTimer_Tick(sender As Object, e As EventArgs) Handles clockTimer.Tick
		Static Check As Boolean
		Check = Not Check
		lblTime.Text = Now
		If checkIsOn.Checked Then
			If Format(Now.Hour, "00") = tboxHour.Text Then
				If Format(Now.Minute, "00") = tboxMinutes.Text Then
					Beep()
					If Check Then
						lblTime.Text = "Сигнал!"
					End If
				End If
			End If
		End If
	End Sub

End Class
