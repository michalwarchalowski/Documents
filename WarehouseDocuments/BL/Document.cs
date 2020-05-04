using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace WarehouseDocuments.BL
{
   public class Document
    {
        [Key]
        public int DocumentID { get; set; }
        public DateTime DocumentDate { get; set; }
        public int CustomerNumber { get; set; }


        string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public DataTable GetAllDocuments()
        {
            
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("DocumentViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }

        public DataSet OpenDocumentID(int inDocumentID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("DocumentViewByID", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@DocumentID", inDocumentID);
                DataSet ds = new DataSet();
                sqlDa.Fill(ds);
                return ds;

           
            }
        }

        public void DeleteDocument(int inDocumentID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=WarehouseDocuments1; Integrated Security=True"))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DocumentDelete", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@DocumentID", inDocumentID);
                sqlCmd.ExecuteNonQuery();
                      };
        }

    }
}
