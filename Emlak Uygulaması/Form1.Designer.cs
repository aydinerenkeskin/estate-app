namespace Emlak_Uygulaması
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
            this.custumerSave = new System.Windows.Forms.Button();
            this.estateSave = new System.Windows.Forms.Button();
            this.workingPlaceAdd = new System.Windows.Forms.Button();
            this.newSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custumerSave
            // 
            this.custumerSave.Location = new System.Drawing.Point(104, 238);
            this.custumerSave.Name = "custumerSave";
            this.custumerSave.Size = new System.Drawing.Size(159, 104);
            this.custumerSave.TabIndex = 0;
            this.custumerSave.Text = "Müşteri Kaydı";
            this.custumerSave.UseVisualStyleBackColor = true;
            this.custumerSave.Click += new System.EventHandler(this.custumerSave_Click);
            // 
            // estateSave
            // 
            this.estateSave.Location = new System.Drawing.Point(104, 107);
            this.estateSave.Name = "estateSave";
            this.estateSave.Size = new System.Drawing.Size(159, 111);
            this.estateSave.TabIndex = 1;
            this.estateSave.Text = "Emlak Kaydı";
            this.estateSave.UseVisualStyleBackColor = true;
            this.estateSave.Click += new System.EventHandler(this.estateSave_Click);
            // 
            // workingPlaceAdd
            // 
            this.workingPlaceAdd.Location = new System.Drawing.Point(319, 107);
            this.workingPlaceAdd.Name = "workingPlaceAdd";
            this.workingPlaceAdd.Size = new System.Drawing.Size(163, 114);
            this.workingPlaceAdd.TabIndex = 2;
            this.workingPlaceAdd.Text = "İş Yeri Kaydı";
            this.workingPlaceAdd.UseVisualStyleBackColor = true;
            this.workingPlaceAdd.Click += new System.EventHandler(this.workingPlaceAdd_Click);
            // 
            // newSave
            // 
            this.newSave.Location = new System.Drawing.Point(319, 238);
            this.newSave.Name = "newSave";
            this.newSave.Size = new System.Drawing.Size(163, 104);
            this.newSave.TabIndex = 3;
            this.newSave.Text = "Yeni Emlak Kayıt";
            this.newSave.UseVisualStyleBackColor = true;
            this.newSave.Click += new System.EventHandler(this.newSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 464);
            this.Controls.Add(this.newSave);
            this.Controls.Add(this.workingPlaceAdd);
            this.Controls.Add(this.estateSave);
            this.Controls.Add(this.custumerSave);
            this.Name = "Form1";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button custumerSave;
        private System.Windows.Forms.Button estateSave;
        private System.Windows.Forms.Button workingPlaceAdd;
        private System.Windows.Forms.Button newSave;
    }
}

