using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace GetDataInPreview {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }

        private void xrLabel1_PreviewClick(object sender, PreviewMouseEventArgs e) {
            DataRowView dataRow = e.Brick.Value as DataRowView;
            MessageBox.Show(dataRow.Row["ShipCountry"].ToString() + ": " + e.Brick.Text);
        }

    }
}
