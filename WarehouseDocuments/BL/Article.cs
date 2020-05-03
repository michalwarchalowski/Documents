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
   public class Article
    {
        [Key]
        public int ArticleID { get; set; }
        public int DocumentID { get; set; }
        public string ArticleName { get; set; }
        public int Quantity { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }



        public void DeleteArticle(int ArticleID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=WarehouseDocuments1; Integrated Security=True"))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("ArticleDelete", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ArticleID", ArticleID);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
