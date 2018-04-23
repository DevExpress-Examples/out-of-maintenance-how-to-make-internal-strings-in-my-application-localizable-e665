Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace MyApp
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main(ByVal args() As String)
			If args.Length > 0 AndAlso (args(0) = "en" OrElse args(0) = "fr") Then
				System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(args(0))
			End If

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace