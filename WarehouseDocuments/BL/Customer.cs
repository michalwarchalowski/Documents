using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDocuments.BL
{
    public class Customer
    {
        [Key]
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }


       public DataTable RefreshCustomerList()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=WarehouseDocuments1; Integrated Security=True"))
            {
                string query = "select * from customers";
                //  SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                return dt;

            }


        }

        public void CreateNewCustomer(string customerName)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=WarehouseDocuments1; Integrated Security=True"))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("CreateNewCustomer", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.ExecuteNonQuery();

            }
        }

    }
}
