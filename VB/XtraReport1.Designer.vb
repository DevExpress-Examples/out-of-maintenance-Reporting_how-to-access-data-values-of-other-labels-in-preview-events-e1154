Imports Microsoft.VisualBasic
Imports System
Namespace GetDataInPreview
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.nwindDataSet1 = New GetDataInPreview.nwindDataSet()
			Me.ordersTableAdapter = New GetDataInPreview.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail.Height = 33
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCountry", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(17, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(175, 25)
			Me.xrLabel1.Text = "xrLabel1"
'			Me.xrLabel1.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.xrLabel1_PreviewClick);
'			Me.xrLabel1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel1_BeforePrint);
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.DataAdapter = Me.ordersTableAdapter
			Me.DataMember = "Orders"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "8.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private ordersTableAdapter As GetDataInPreview.nwindDataSetTableAdapters.OrdersTableAdapter
	End Class
End Namespace
