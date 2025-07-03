using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProductSalesReportingTool.Models;

namespace ProductSalesReportingTool.Repositories
{
    public class SaleRepository
    {
        string conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public DataTable GetSalesInRange(string startDate, string endDate)
        {
            string sql = "select PRODUCTCODE, PRODUCTNAME, QUANTITY, UNITPRICE from PRODUCTSALES where SALEDATE between @startDate and @endDate";
            //MessageBox.Show(conString);

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No sale record!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return dt;
        }
    }
}
