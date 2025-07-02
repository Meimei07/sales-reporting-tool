using System.Data;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using Microsoft.Data.SqlClient;
using ProductSalesReportingTool.Repositories;

namespace ProductSalesReportingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var startDate = this.dtpStartDate.Value.ToShortDateString();
            var endDate = this.dtpEndDate.Value.ToShortDateString();
            string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Report1.repx");

            XtraReport report = new XtraReport();
            report.LoadLayout(reportPath);

            //report.DataSource = null;
            report.DataMember = "";

            SaleRepository saleRepo = new SaleRepository();
            var sales = saleRepo.GetSalesInRange(startDate, endDate);

            if (sales.Rows.Count == 0) return;

            report.DataSource = sales;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowRibbonPreview();
        }
    }
}
