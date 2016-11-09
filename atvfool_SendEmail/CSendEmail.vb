Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class CSendEmail


#Region "Properties"



	Private c_strUsername As String = String.Empty
	Private c_strPassword As String = String.Empty
	Private c_blnSSL As Boolean = False
	Private c_strPort As String = String.Empty ' Non-Encrypted: 25/587; TLS: 587; SSL: 465;
	Private c_strSMTPHost As String = String.Empty

	Property SMTPUsername As String
		Get
			Return c_strUsername
		End Get
		Set(value As String)
			c_strUsername = value
		End Set
	End Property

	Property SMTPPassword As String
		Get
			Return c_strPassword
		End Get
		Set(value As String)
			c_strPassword = value
		End Set
	End Property

	Property SSLEnabled As Boolean
		Get
			Return c_blnSSL
		End Get
		Set(value As Boolean)
			c_blnSSL = value
		End Set
	End Property

	Property Port As String
		Get
			Return c_strPort
		End Get
		Set(value As String)
			c_strPort = value
		End Set
	End Property

	Property SMTPHost As String
		Get
			Return c_strSMTPHost
		End Get
		Set(value As String)
			c_strSMTPHost = value
		End Set
	End Property
#End Region


#Region "Methods"

	''' <summary>
	''' Constructor
	''' </summary>
	Public Sub New()

		Try

			init("", "", False, "", "")

		Catch excError As Exception
			Throw excError
		End Try

	End Sub

	''' <summary>
	''' Constructor with variables
	''' </summary>
	''' <param name="strUsername">SMTP Username</param>
	''' <param name="strPassword">SMTP Password</param>
	''' <param name="blnSSL">SSL Enabled</param>
	''' <param name="strPort">SMTP Port</param>
	''' <param name="strSMTPHost">SMTP Host address</param>
	Public Sub New(ByVal strUsername As String,
				   ByVal strPassword As String,
				   ByVal blnSSL As Boolean,
				   ByVal strPort As String,
				   ByVal strSMTPHost As String)

		Try

			init(strUsername, strPassword, blnSSL, strPort, strSMTPHost)

		Catch excError As Exception
			Throw excError
		End Try

	End Sub

	''' <summary>
	''' Initializes Class level variables
	''' </summary>
	''' <param name="strUsername">SMTP Username</param>
	''' <param name="strPassword">SMTP Password</param>
	''' <param name="blnSSL">SSL Enabled</param>
	''' <param name="strPort">SMTP Port</param>
	''' <param name="strSMTPHost">SMTP Host address</param>
	Protected Sub init(ByVal strUsername As String,
					 ByVal strPassword As String,
					 ByVal blnSSL As Boolean,
					 ByVal strPort As String,
					 ByVal strSMTPHost As String)

		Try

			SMTPUsername = strUsername
			SMTPPassword = strPassword
			SSLEnabled = blnSSL
			Port = strPort
			SMTPHost = strSMTPHost

		Catch excError As Exception
			Throw excError
		End Try

	End Sub

	''' <summary>
	''' Sends an email
	''' </summary>
	''' <param name="strFrom">From email Address</param>
	''' <param name="strTo"> To Email Address</param>
	''' <param name="strSubject">Message Subject</param>
	''' <param name="strBody">Message Body</param>
	''' <param name="blnHTMLBody">If the body contains stylized HTML set to true</param>
	''' <returns>True if success</returns>
	Public Function SendEmail(ByVal strFrom As String,
							  ByVal strTo As String,
							  ByVal strSubject As String,
							  ByVal strBody As String,
							  Optional ByVal blnHTMLBody As Boolean = False) As Boolean

		Dim blnSuccess As Boolean = False

		Try

			Dim smtpServer As New SmtpClient
			Dim emailMessage As New MailMessage
			smtpServer.UseDefaultCredentials = False
			smtpServer.Credentials = New Net.NetworkCredential(SMTPUsername, SMTPPassword)
			smtpServer.Port = Port
			smtpServer.EnableSsl = SSLEnabled
			smtpServer.Host = SMTPHost

			emailMessage.From = New MailAddress(strFrom)
			emailMessage.To.Add(strTo)
			emailMessage.Subject = strSubject
			emailMessage.IsBodyHtml = blnHTMLBody
			emailMessage.Body = strBody

			smtpServer.Send(emailMessage)

			blnSuccess = True

		Catch excError As Exception
			Throw excError
		End Try

		Return blnSuccess

	End Function

	''' <summary>
	''' Check if an email is valid
	''' </summary>
	''' <param name="strEmail">Email to check</param>
	''' <returns>True if Valid</returns>
	Public Function IsValidEmail(ByVal strEmail As String) As Boolean

		Dim blnResult As Boolean = False

		Try

			Dim maAddress As New MailAddress(strEmail)

			blnResult = True
		Catch excError As Exception
			' Blank because fails if email is not valid
			blnResult = False
		End Try

		Return blnResult

	End Function

#End Region


End Class
