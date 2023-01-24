namespace Emlak_Uygulaması
{
    partial class CheckCustomer
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
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuildingId = new System.Windows.Forms.TextBox();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnBuilding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(669, 36);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtCustomer.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 178);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBuildingId
            // 
            this.txtBuildingId.Location = new System.Drawing.Point(669, 115);
            this.txtBuildingId.Name = "txtBuildingId";
            this.txtBuildingId.Size = new System.Drawing.Size(100, 22);
            this.txtBuildingId.TabIndex = 2;
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(669, 158);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(100, 22);
            this.txtCompanyId.TabIndex = 3;
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(365, 302);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(196, 57);
            this.btnCompany.TabIndex = 4;
            this.btnCompany.Text = "Emlak Kartı";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnBuilding
            // 
            this.btnBuilding.Location = new System.Drawing.Point(612, 302);
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.Size = new System.Drawing.Size(196, 57);
            this.btnBuilding.TabIndex = 5;
            this.btnBuilding.Text = "Bina Kartı";
            this.btnBuilding.UseVisualStyleBackColor = true;
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);
            // 
            // CheckCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 447);
            this.Controls.Add(this.btnBuilding);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.txtBuildingId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCustomer);
            this.Name = "CheckCustomer";
            this.Text = "Müşteri Kontrol Ekranı";
            this.Load += new System.EventHandler(this.CheckCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuildingId;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnBuilding;
    }
}