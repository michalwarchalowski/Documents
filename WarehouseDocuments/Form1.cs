using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WarehouseDocuments.BL;
using System.Configuration;

namespace WarehouseDocuments
{
    
    public partial class Form1 : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
     
        int inDocumentID = 0;
        Customer customer;
        Document document;
        Article article;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDocumentDataGridView();
            RefreshCustomerList();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }


        void Clear()
        {
            cmbCustomer.SelectedIndex = 0;
            txtNumberClient.Text = "";
            txtTotalGrossPrice.Text = "";
            txtTotalNetPrice.Text = "";
            documentDate.Value = DateTime.Now;
            if (dgvDetails.DataSource == null)
                dgvDetails.Rows.Clear();
            else
                dgvDetails.DataSource = (dgvDetails.DataSource as DataTable).Clone();
            inDocumentID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        void FillDocumentDataGridView()
        {

            document = new Document();
            dgvDocument.DataSource = document.GetAllDocuments();
            dgvDocument.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocument.Columns[2].Visible = false;
            dgvDocument.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocument.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocument.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocument.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        void RefreshCustomerList()
        {

            customer = new Customer();
            cmbCustomer.DataSource=customer.RefreshCustomerList();
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerNumber";

            cmbCustomer1.DataSource = customer.RefreshCustomerList();
            cmbCustomer1.DisplayMember = "CustomerName";
            cmbCustomer1.ValueMember = "CustomerNumber";


        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateModel())
            {


                int _DocumentID = 0;
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("DocumentAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@DocumentID", inDocumentID);
                    sqlCmd.Parameters.AddWithValue("@DocumentDate", documentDate.Value);
                    sqlCmd.Parameters.AddWithValue("@CustomerNumber", txtNumberClient.Text);
                    //   sqlCmd.Parameters.AddWithValue("@CustomerName", txtClientName.Text);
                    sqlCmd.Parameters.AddWithValue("@CustomerName", cmbCustomer.Text);
                    _DocumentID = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }

                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    sqlCon.Open();
                    foreach (DataGridViewRow dgvRow in dgvDetails.Rows)
                    {
                        if (dgvRow.IsNewRow) break;
                        else
                        {
                            SqlCommand sqlCmd = new SqlCommand("ArticleAddOrEdit", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@ArticleID", Convert.ToInt32(dgvRow.Cells["ArticleID"].Value == DBNull.Value ? "0" : dgvRow.Cells["ArticleID"].Value));

                            sqlCmd.Parameters.AddWithValue("@DocumentID", _DocumentID);

                            sqlCmd.Parameters.AddWithValue("@ArticleName", dgvRow.Cells["ArticleName"].Value == DBNull.Value ? "" : dgvRow.Cells["ArticleName"].Value);

                            sqlCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(dgvRow.Cells["Quantity"].Value == DBNull.Value ? 0 : dgvRow.Cells["Quantity"].Value));

                            sqlCmd.Parameters.AddWithValue("@NetPrice", Convert.ToDecimal(dgvRow.Cells["NetPrice"].Value == DBNull.Value ? 0.00M : dgvRow.Cells["NetPrice"].Value));

                            //  MessageBox.Show(Convert.ToDecimal(dgvRow.Cells["NetPrice"].Value).ToString().Replace(",","."));
                            sqlCmd.Parameters.AddWithValue("@GrossPrice", Convert.ToDecimal(dgvRow.Cells["GrossPrice"].Value == DBNull.Value ? 0.00M : dgvRow.Cells["GrossPrice"].Value));
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                }
                FillDocumentDataGridView();
                Clear();
                MessageBox.Show("Zapisanie dokumentu powiodło się");
            }
        }

        private void dgvDocument_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //document = new Document();
            if (dgvDocument.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvDocument.CurrentRow;
                inDocumentID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                DataSet ds= document.OpenDocumentID(inDocumentID);
                DataRow dr = ds.Tables[0].Rows[0];
                documentDate.Value = Convert.ToDateTime(dr["documentDate"].ToString());
                cmbCustomer.SelectedValue = Convert.ToInt32(dr["CustomerNumber"].ToString());
                txtNumberClient.Text = (Convert.ToInt32(cmbCustomer.SelectedIndex).ToString());


                dgvDetails.AutoGenerateColumns = false;
                dgvDetails.DataSource = ds.Tables[1];

                btnDelete.Enabled = true;
                btnSave.Text = "Uaktualnij";
                tabControl1.SelectedIndex = 0;
                TotalPrice();

            }
        }

        private void dgvDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           article = new Article();
            DataGridViewRow dgvRow = dgvDetails.CurrentRow;
            if (dgvRow.Cells["ArticleID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy chcesz skasować tą pozycję ?", "Kasowanie pozycji", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    article.DeleteArticle(Convert.ToInt32(dgvRow.Cells["ArticleID"].Value));

                }
                else
                    e.Cancel = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            document = new Document();
            if (MessageBox.Show("Czy chcesz skasować ten dokument ?", "Kasowanie dokumentu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                document.DeleteDocument(inDocumentID);
                Clear();
                FillDocumentDataGridView();
                MessageBox.Show("Skasowano dokument");

            }
        }


        void TotalPrice()
        {
            decimal totalNetPrice = 0.00M;
            decimal totalGrossPrice = 0.00M;
            foreach (DataGridViewRow dgvRow in dgvDetails.Rows)
            {
                if (dgvRow.IsNewRow) break;
                totalNetPrice = totalNetPrice + Convert.ToDecimal(dgvRow.Cells["NetPrice"].Value == DBNull.Value ? 0.00M : dgvRow.Cells["NetPrice"].Value) * Convert.ToInt32(dgvRow.Cells["Quantity"].Value == DBNull.Value ? 0 : dgvRow.Cells["Quantity"].Value);
               dgvRow.Cells["GrossPrice"].Value =Math.Round( (Convert.ToDecimal(dgvRow.Cells["NetPrice"].Value == DBNull.Value ? 0.00M : dgvRow.Cells["NetPrice"].Value) * 1.23M),2);
                  totalGrossPrice = totalGrossPrice + Convert.ToDecimal(dgvRow.Cells["GrossPrice"].Value) * Convert.ToInt32(dgvRow.Cells["Quantity"].Value == DBNull.Value ? 0 : dgvRow.Cells["Quantity"].Value);
            }

            txtTotalNetPrice.Text =Math.Round( totalNetPrice,2).ToString() ;
          txtTotalGrossPrice.Text =Math.Round( totalGrossPrice,2).ToString();
        }

        private void dgvDetails_CurrentCellChanged(object sender, EventArgs e)
        {
            TotalPrice();
        }

        private void cmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNumberClient.Text=(Convert.ToInt32( cmbCustomer.SelectedIndex).ToString());
        }


        void CreateNewCustomer()
        {
            customer.CreateNewCustomer(txtNewCustomer.Text);
            RefreshCustomerList();
            MessageBox.Show("Dodano nowego klienta do bazy");
  
        }



        bool ValidateModel()
        {
            bool _isValid = true;
            if(Convert.ToInt32(cmbCustomer.SelectedIndex)==0)
            {
                MessageBox.Show("Wymgany jest wybór klienta");
                 _isValid = false;
            }
            return _isValid;
                
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewCustomer();
        }
    }
}
