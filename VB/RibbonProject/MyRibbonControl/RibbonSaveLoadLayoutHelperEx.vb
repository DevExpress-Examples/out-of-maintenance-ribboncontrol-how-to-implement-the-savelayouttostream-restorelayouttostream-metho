Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Customization

Namespace RibbonProject
	Public NotInheritable Class RibbonSaveLoadLayoutHelperEx
		Private Sub New()
		End Sub
		Public Shared Sub SaveLayoutToStream(ByVal control As RibbonControl, ByVal stream As Stream)
			Dim tree As New RunTimeRibbonTreeView() With {.Ribbon = control}
			tree.CreateTree()
			Dim model As RibbonCustomizationModel = ResultModelCreator.Instance.Create(tree, control)

			Try
				Dim serializer As New XmlXtraSerializer()
				GetApplicationName(model)
				serializer.SerializeObject(model, stream, GetApplicationName(model))
			Catch e As Exception
			End Try
		End Sub
		Public Shared Sub LoadLayoutFromStream(ByVal control As MyRibbonControl, ByVal stream As MemoryStream)
			Dim model As RibbonCustomizationModel = Nothing
			Try
				model = New RibbonCustomizationModel(control)
				Dim serializer As New XmlXtraSerializer()
				serializer.DeserializeObject(model, stream, GetApplicationName(model))

			Catch e As Exception
			End Try

			If model Is Nothing OrElse (Not model.IsModelValid(control)) Then
				Return
			End If
			GetType(RibbonControl).GetMethod("ApplyCustomizationSettings", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance).Invoke(control, New Object() { model })

		End Sub
		Private Shared Function GetApplicationName(ByVal model As RibbonCustomizationModel) As String
			Return model.GetType().FullName
		End Function
	End Class
End Namespace
