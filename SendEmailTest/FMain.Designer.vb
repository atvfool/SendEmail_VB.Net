<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtPort = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtHost = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtFrom = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtTo = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtSubject = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtBody = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.chkSSL = New System.Windows.Forms.CheckBox()
		Me.chkHTML = New System.Windows.Forms.CheckBox()
		Me.btnSend = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Username"
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(73, 12)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(227, 20)
		Me.txtUsername.TabIndex = 1
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(73, 38)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(227, 20)
		Me.txtPassword.TabIndex = 3
		Me.txtPassword.UseSystemPasswordChar = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Password"
		'
		'txtPort
		'
		Me.txtPort.Location = New System.Drawing.Point(73, 64)
		Me.txtPort.Name = "txtPort"
		Me.txtPort.Size = New System.Drawing.Size(227, 20)
		Me.txtPort.TabIndex = 5
		Me.txtPort.Text = "25"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(26, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Port"
		'
		'txtHost
		'
		Me.txtHost.Location = New System.Drawing.Point(73, 90)
		Me.txtHost.Name = "txtHost"
		Me.txtHost.Size = New System.Drawing.Size(227, 20)
		Me.txtHost.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 93)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(29, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Host"
		'
		'txtFrom
		'
		Me.txtFrom.Location = New System.Drawing.Point(73, 136)
		Me.txtFrom.Name = "txtFrom"
		Me.txtFrom.Size = New System.Drawing.Size(227, 20)
		Me.txtFrom.TabIndex = 9
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(12, 139)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(58, 13)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "From Email"
		'
		'txtTo
		'
		Me.txtTo.Location = New System.Drawing.Point(73, 162)
		Me.txtTo.Name = "txtTo"
		Me.txtTo.Size = New System.Drawing.Size(227, 20)
		Me.txtTo.TabIndex = 11
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(12, 165)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 13)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "To Email"
		'
		'txtSubject
		'
		Me.txtSubject.Location = New System.Drawing.Point(73, 188)
		Me.txtSubject.Name = "txtSubject"
		Me.txtSubject.Size = New System.Drawing.Size(227, 20)
		Me.txtSubject.TabIndex = 13
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(12, 191)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(43, 13)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "Subject"
		'
		'txtBody
		'
		Me.txtBody.Location = New System.Drawing.Point(73, 214)
		Me.txtBody.Multiline = True
		Me.txtBody.Name = "txtBody"
		Me.txtBody.Size = New System.Drawing.Size(227, 133)
		Me.txtBody.TabIndex = 15
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(12, 217)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(31, 13)
		Me.Label8.TabIndex = 14
		Me.Label8.Text = "Body"
		'
		'chkSSL
		'
		Me.chkSSL.AutoSize = True
		Me.chkSSL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkSSL.Location = New System.Drawing.Point(12, 119)
		Me.chkSSL.Name = "chkSSL"
		Me.chkSSL.Size = New System.Drawing.Size(46, 17)
		Me.chkSSL.TabIndex = 17
		Me.chkSSL.Text = "SSL"
		Me.chkSSL.UseVisualStyleBackColor = True
		'
		'chkHTML
		'
		Me.chkHTML.AutoSize = True
		Me.chkHTML.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkHTML.Location = New System.Drawing.Point(217, 353)
		Me.chkHTML.Name = "chkHTML"
		Me.chkHTML.Size = New System.Drawing.Size(83, 17)
		Me.chkHTML.TabIndex = 18
		Me.chkHTML.Text = "HTML Body"
		Me.chkHTML.UseVisualStyleBackColor = True
		'
		'btnSend
		'
		Me.btnSend.Location = New System.Drawing.Point(12, 378)
		Me.btnSend.Name = "btnSend"
		Me.btnSend.Size = New System.Drawing.Size(83, 38)
		Me.btnSend.TabIndex = 19
		Me.btnSend.Text = "Send"
		Me.btnSend.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(223, 378)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(83, 38)
		Me.btnClose.TabIndex = 20
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'FMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(318, 453)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSend)
		Me.Controls.Add(Me.chkHTML)
		Me.Controls.Add(Me.chkSSL)
		Me.Controls.Add(Me.txtBody)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtSubject)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtTo)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtFrom)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtHost)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtPort)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtUsername)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "FMain"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Send Email Test"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtUsername As TextBox
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtPort As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtHost As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtFrom As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtTo As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtSubject As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtBody As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents chkSSL As CheckBox
	Friend WithEvents chkHTML As CheckBox
	Friend WithEvents btnSend As Button
	Friend WithEvents btnClose As Button
End Class
