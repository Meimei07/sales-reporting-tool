using System.Data;
using ProductSalesReportingTool.Repositories;

namespace ProductSalesReportingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadSales();
        }

        private void ReadSales()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ProductCode");
            dataTable.Columns.Add("ProductName");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("UnitPrice");
            dataTable.Columns.Add("Total");
            dataTable.Columns.Add("SaleDate");

            var repo = new SaleRepository();
            var sales = repo.GetSales();

            foreach(var sale in sales)
            {
                var row = dataTable.NewRow();

                row["ProductCode"] = sale.ProductCode;
                row["ProductName"] = sale.ProductName;
                row["Quantity"] = sale.Quantity;
                row["UnitPrice"] = sale.UnitPrice;
                row["Total"] = sale.Total;
                row["SaleDate"] = sale.SaleDate;

                dataTable.Rows.Add(row);
            }

            this.salesTable.DataSource = dataTable;
        }
    }
}
