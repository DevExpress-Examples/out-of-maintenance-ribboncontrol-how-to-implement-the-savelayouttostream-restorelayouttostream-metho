Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon
Imports System.IO

Namespace RibbonProject
	Partial Public Class XtraForm1
		Inherits RibbonForm
		Private _Stream As New MemoryStream()
		Public Sub New()
			InitializeComponent()
			ribbonControl1.SaveLayoutToStream(_Stream)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			_Stream.Seek(0, SeekOrigin.Begin)
			ribbonControl1.RestoreLayoutToStream(_Stream)
		End Sub
	End Class
End Namespace