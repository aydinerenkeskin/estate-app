namespace Emlak_Uygulaması
{
    partial class AssignCustomer
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
            this.lblBuilding = new System.Windows.Forms.Label();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCompany = new System.Windows.Forms.Label();
            this.newRecord = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.checkCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Location = new System.Drawing.Point(656, 10);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(44, 16);
            this.lblBuilding.TabIndex = 0;
            this.lblBuilding.Text = "label1";
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(115, 10);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(171, 22);
            this.txtCustomerSearch.TabIndex = 1;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Ara";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 222);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(656, 39);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(44, 16);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "label3";
            // 
            // newRecord
            // 
            this.newRecord.Location = new System.Drawing.Point(607, 179);
            this.newRecord.Name = "newRecord";
            this.newRecord.Size = new System.Drawing.Size(181, 74);
            this.newRecord.TabIndex = 6;
            this.newRecord.Text = "Yeni Kayıt Oluştur";
            this.newRecord.UseVisualStyleBackColor = true;
            this.newRecord.Click += new System.EventHandler(this.newRecord_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(659, 67);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtCustomer.TabIndex = 7;
            // 
            // checkCustomer
            // 
            this.checkCustomer.Location = new System.Drawing.Point(607, 276);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Size = new System.Drawing.Size(181, 68);
            this.checkCustomer.TabIndex = 8;
            this.checkCustomer.Text = "Müşteriye Ait Evler";
            this.checkCustomer.UseVisualStyleBackColor = true;
            this.checkCustomer.Click += new System.EventHandler(this.checkCustomer_Click);
            // 
            // AssignCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.newRecord);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.lblBuilding);
            this.Name = "AssignCustomer";
            this.Text = "Müşteri Atama Ekranı";
            this.Load += new System.EventHandler(this.AssignCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button newRecord;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button checkCustomer;
    }
}