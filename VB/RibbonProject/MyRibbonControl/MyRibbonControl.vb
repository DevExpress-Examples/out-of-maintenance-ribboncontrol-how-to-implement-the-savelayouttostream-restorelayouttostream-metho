Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Customization

Namespace RibbonProject
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyRibbonControl
		Inherits RibbonControl
		Public Sub New()

		End Sub

		Public Sub SaveLayoutToStream(ByVal stream As Stream)
			RibbonSaveLoadLayoutHelperEx.SaveLayoutToStream(Me, stream)
		End Sub
		Public Sub RestoreLayoutToStream(ByVal stream As MemoryStream)
			RibbonSaveLoadLayoutHelperEx.LoadLayoutFromStream(Me, stream)
		End Sub
	End Class
End Namespace