namespace WarehouseDocuments
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.ArticleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalGrossPrice = new System.Windows.Forms.TextBox();
            this.txtTotalNetPrice = new System.Windows.Forms.TextBox();
            this.txtNumberClient = new System.Windows.Forms.TextBox();
            this.documentDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDocument = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustomer1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewCustomer = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabPage1.Controls.Add(this.cmbCustomer);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.dgvDetails);
            this.tabPage1.Controls.Add(this.txtTotalGrossPrice);
            this.tabPage1.Controls.Add(this.txtTotalNetPrice);
            this.tabPage1.Controls.Add(this.txtNumberClient);
            this.tabPage1.Controls.Add(this.documentDate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Szczegóły";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(199, 134);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 24);
            this.cmbCustomer.TabIndex = 14;
            this.cmbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomer_SelectionChangeCommitted);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(350, 451);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 451);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleID,
            this.ArticleName,
            this.Quantity,
            this.NetPrice,
            this.GrossPrice});
            this.dgvDetails.Location = new System.Drawing.Point(6, 254);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(591, 181);
            this.dgvDetails.TabIndex = 10;
            this.dgvDetails.CurrentCellChanged += new System.EventHandler(this.dgvDetails_CurrentCellChanged);
            this.dgvDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDetails_UserDeletingRow);
            // 
            // ArticleID
            // 
            this.ArticleID.DataPropertyName = "ArticleID";
            this.ArticleID.HeaderText = "ArticleID";
            this.ArticleID.MinimumWidth = 6;
            this.ArticleID.Name = "ArticleID";
            this.ArticleID.Visible = false;
            this.ArticleID.Width = 125;
            // 
            // ArticleName
            // 
            this.ArticleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArticleName.DataPropertyName = "ArticleName";
            this.ArticleName.HeaderText = "Nazwa Artykułu";
            this.ArticleName.MinimumWidth = 6;
            this.ArticleName.Name = "ArticleName";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ilość";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 65;
            // 
            // NetPrice
            // 
            this.NetPrice.DataPropertyName = "NetPrice";
            this.NetPrice.HeaderText = "Cena Netto";
            this.NetPrice.MinimumWidth = 6;
            this.NetPrice.Name = "NetPrice";
            this.NetPrice.Width = 125;
            // 
            // GrossPrice
            // 
            this.GrossPrice.DataPropertyName = "GrossPrice";
            this.GrossPrice.HeaderText = "Cena Brutto";
            this.GrossPrice.MinimumWidth = 6;
            this.GrossPrice.Name = "GrossPrice";
            this.GrossPrice.ReadOnly = true;
            this.GrossPrice.Width = 125;
            // 
            // txtTotalGrossPrice
            // 
            this.txtTotalGrossPrice.Enabled = false;
            this.txtTotalGrossPrice.Location = new System.Drawing.Point(292, 181);
            this.txtTotalGrossPrice.Name = "txtTotalGrossPrice";
            this.txtTotalGrossPrice.Size = new System.Drawing.Size(48, 22);
            this.txtTotalGrossPrice.TabIndex = 9;
            // 
            // txtTotalNetPrice
            // 
            this.txtTotalNetPrice.Enabled = false;
            this.txtTotalNetPrice.Location = new System.Drawing.Point(142, 181);
            this.txtTotalNetPrice.Name = "txtTotalNetPrice";
            this.txtTotalNetPrice.Size = new System.Drawing.Size(48, 22);
            this.txtTotalNetPrice.TabIndex = 8;
            // 
            // txtNumberClient
            // 
            this.txtNumberClient.Enabled = false;
            this.txtNumberClient.Location = new System.Drawing.Point(199, 87);
            this.txtNumberClient.Name = "txtNumberClient";
            this.txtNumberClient.Size = new System.Drawing.Size(50, 22);
            this.txtNumberClient.TabIndex = 6;
            // 
            // documentDate
            // 
            this.documentDate.CustomFormat = "dd-MM-yyyy";
            this.documentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.documentDate.Location = new System.Drawing.Point(199, 37);
            this.documentDate.Name = "documentDate";
            this.documentDate.Size = new System.Drawing.Size(200, 22);
            this.documentDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cena brutto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena netto: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NumerKlienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa klienta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data dokumentu:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDocument);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista dokumentów";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDocument
            // 
            this.dgvDocument.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Location = new System.Drawing.Point(0, 3);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.RowHeadersWidth = 51;
            this.dgvDocument.RowTemplate.Height = 24;
            this.dgvDocument.Size = new System.Drawing.Size(635, 485);
            this.dgvDocument.TabIndex = 0;
            this.dgvDocument.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDocument_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabPage3.Controls.Add(this.btnCreateNewCustomer);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbCustomer1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtNewCustomer);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(641, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stwórz nowego klienta";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(118, 114);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewCustomer.TabIndex = 4;
            this.btnCreateNewCustomer.Text = "Dodaj";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lista klientów";
            // 
            // cmbCustomer1
            // 
            this.cmbCustomer1.FormattingEnabled = true;
            this.cmbCustomer1.Location = new System.Drawing.Point(118, 168);
            this.cmbCustomer1.Name = "cmbCustomer1";
            this.cmbCustomer1.Size = new System.Drawing.Size(121, 24);
            this.cmbCustomer1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nazwa klienta";
            // 
            // txtNewCustomer
            // 
            this.txtNewCustomer.Location = new System.Drawing.Point(118, 75);
            this.txtNewCustomer.Name = "txtNewCustomer";
            this.txtNewCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtNewCustomer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker documentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalGrossPrice;
        private System.Windows.Forms.TextBox txtTotalNetPrice;
        private System.Windows.Forms.TextBox txtNumberClient;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPrice;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewCustomer;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCustomer1;
    }
}

