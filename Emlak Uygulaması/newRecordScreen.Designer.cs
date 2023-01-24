namespace Emlak_Uygulaması
{
    partial class newRecordScreen
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
            this.txtSearchEstate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBuilding = new System.Windows.Forms.TextBox();
            this.txtBuildingId = new System.Windows.Forms.TextBox();
            this.txtEstateId = new System.Windows.Forms.TextBox();
            this.assignBuilding = new System.Windows.Forms.Button();
            this.assignCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchEstate
            // 
            this.txtSearchEstate.Location = new System.Drawing.Point(106, 12);
            this.txtSearchEstate.Name = "txtSearchEstate";
            this.txtSearchEstate.Size = new System.Drawing.Size(100, 22);
            this.txtSearchEstate.TabIndex = 0;
            this.txtSearchEstate.TextChanged += new System.EventHandler(this.txtSearchEstate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emlak Ara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 161);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 282);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(863, 161);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bina Ara:";
            // 
            // txtSearchBuilding
            // 
            this.txtSearchBuilding.Location = new System.Drawing.Point(151, 254);
            this.txtSearchBuilding.Name = "txtSearchBuilding";
            this.txtSearchBuilding.Size = new System.Drawing.Size(100, 22);
            this.txtSearchBuilding.TabIndex = 3;
            this.txtSearchBuilding.TextChanged += new System.EventHandler(this.txtSearchBuilding_TextChanged);
            // 
            // txtBuildingId
            // 
            this.txtBuildingId.Location = new System.Drawing.Point(1031, 232);
            this.txtBuildingId.Name = "txtBuildingId";
            this.txtBuildingId.Size = new System.Drawing.Size(100, 22);
            this.txtBuildingId.TabIndex = 6;
            // 
            // txtEstateId
            // 
            this.txtEstateId.Location = new System.Drawing.Point(1031, 195);
            this.txtEstateId.Name = "txtEstateId";
            this.txtEstateId.Size = new System.Drawing.Size(100, 22);
            this.txtEstateId.TabIndex = 8;
            // 
            // assignBuilding
            // 
            this.assignBuilding.Location = new System.Drawing.Point(922, 282);
            this.assignBuilding.Name = "assignBuilding";
            this.assignBuilding.Size = new System.Drawing.Size(205, 68);
            this.assignBuilding.TabIndex = 9;
            this.assignBuilding.Text = "Ev Ata";
            this.assignBuilding.UseVisualStyleBackColor = true;
            this.assignBuilding.Click += new System.EventHandler(this.assignBuilding_Click);
            // 
            // assignCustomer
            // 
            this.assignCustomer.Location = new System.Drawing.Point(922, 376);
            this.assignCustomer.Name = "assignCustomer";
            this.assignCustomer.Size = new System.Drawing.Size(205, 67);
            this.assignCustomer.TabIndex = 10;
            this.assignCustomer.Text = "Müşteri Ata";
            this.assignCustomer.UseVisualStyleBackColor = true;
            this.assignCustomer.Click += new System.EventHandler(this.assignCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(919, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bina Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(919, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Emlak Numarası";
            // 
            // newRecordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 617);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assignCustomer);
            this.Controls.Add(this.assignBuilding);
            this.Controls.Add(this.txtEstateId);
            this.Controls.Add(this.txtBuildingId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchBuilding);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchEstate);
            this.Name = "newRecordScreen";
            this.Text = "Yeni Kayıt Ekleme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchEstate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBuilding;
        private System.Windows.Forms.TextBox txtBuildingId;
        private System.Windows.Forms.TextBox txtEstateId;
        private System.Windows.Forms.Button assignBuilding;
        private System.Windows.Forms.Button assignCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}