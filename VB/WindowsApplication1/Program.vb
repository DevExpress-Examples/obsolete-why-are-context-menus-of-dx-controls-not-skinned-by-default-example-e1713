Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace WindowsApplication1
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			DevExpress.UserSkins.OfficeSkins.Register()
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New XtraForm1())
		End Sub
	End Class
End Namespace