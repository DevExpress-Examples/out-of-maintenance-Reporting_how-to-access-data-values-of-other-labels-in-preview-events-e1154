Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace GetDataInPreview
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel1.BeforePrint
			CType(sender, XRLabel).Tag = GetCurrentRow()
		End Sub

		Private Sub xrLabel1_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel1.PreviewClick
			Dim dataRow As DataRowView = TryCast(e.Brick.Value, DataRowView)
			MessageBox.Show(dataRow.Row("ShipCountry").ToString() & ": " & e.Brick.Text)
		End Sub

	End Class
End Namespace
