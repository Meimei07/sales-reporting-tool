using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProductSalesReportingTool.Models;

namespace ProductSalesReportingTool.Repositories
{
    public class SaleRepository
    {
        private readonly string conString = "Data Source=DESKTOP-8PRJCMU\\STEPDB;Initial Catalog=SaleDb;User ID=sa;password=123;Trust Server Certificate=True;";

        public List<SaleDto> GetSales()
        {
            var sales = new List<SaleDto>();

            try
            {
                using(SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    string sql = "SELECT PRODUCTCODE, PRODUCTNAME, QUANTITY, UNITPRICE, SALEDATE FROM PRODUCTSALES";
                    using(SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                SaleDto sale = new SaleDto();
                                sale.ProductCode = reader["PRODUCTCODE"].ToString();
                                sale.ProductName = reader["PRODUCTNAME"].ToString();
                                sale.Quantity = (int)reader["QUANTITY"];
                                sale.UnitPrice = (decimal)reader["UNITPRICE"];
                                sale.Total = sale.Quantity * sale.UnitPrice;
                                sale.SaleDate = Convert.ToDateTime(reader["SALEDATE"]).ToString("dd-MMM-yyyy");


                                sales.Add(sale);
                            }
                            con.Close();
                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                //Console.WriteLine("Exception: " + ex.Message);
            }

            return sales;
        }
    }
}
