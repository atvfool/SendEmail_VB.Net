Imports atvfool_SendEmail

Public Class FMain

	Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

		Try

			Dim clsSendEmail As New CSendEmail(txtUsername.Text, txtPassword.Text, chkSSL.Checked, txtPort.Text, txtHost.Text)

			Dim strErrors As String = "The following error(s) occurred: " & vbCrLf
			Dim blnError As Boolean = False
			If Not clsSendEmail.IsValidEmail(txtFrom.Text) Then
				blnError = True
				strErrors &= vbTab & "-The From Address is not valid" & vbCrLf
			End If
			If Not clsSendEmail.IsValidEmail(txtTo.Text) Then
				blnError = True
				strErrors &= vbTab & "-The To Address is not valid" & vbCrLf
			End If

			If blnError Then
				MessageBox.Show(strErrors)
				Exit Sub
			End If

			If clsSendEmail.SendEmail(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text, chkHTML.Checked) Then
				MessageBox.Show("Success")
			Else
				MessageBox.Show("Failed")
			End If


		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Application.Exit()
	End Sub

	Private Sub FMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
		Application.Exit()
	End Sub

End Class
