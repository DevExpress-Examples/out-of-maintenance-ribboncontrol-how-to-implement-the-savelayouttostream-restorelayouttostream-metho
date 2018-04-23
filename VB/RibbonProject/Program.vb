Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace RibbonProject
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(True)
			SkinManager.EnableFormSkins()
			Application.Run(New XtraForm1())
		End Sub
	End Class
End Namespace
