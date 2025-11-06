namespace RentalApp
{
    partial class Barang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.txtHsewa = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtNB = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSave.Location = new System.Drawing.Point(976, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.OliveDrab;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnS.Location = new System.Drawing.Point(1084, 145);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(89, 35);
            this.btnS.TabIndex = 2;
            this.btnS.Text = "Search";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.OliveDrab;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnC.Location = new System.Drawing.Point(976, 195);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(89, 35);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Clear";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.OliveDrab;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnU.Location = new System.Drawing.Point(1084, 195);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(89, 35);
            this.btnU.TabIndex = 4;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(634, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(634, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Harga Sewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(634, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stok";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(634, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama Barang";
            // 
            // txtIDB
            // 
            this.txtIDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDB.Location = new System.Drawing.Point(769, 93);
            this.txtIDB.Name = "txtIDB";
            this.txtIDB.Size = new System.Drawing.Size(140, 26);
            this.txtIDB.TabIndex = 9;
            // 
            // txtHsewa
            // 
            this.txtHsewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHsewa.Location = new System.Drawing.Point(769, 198);
            this.txtHsewa.Name = "txtHsewa";
            this.txtHsewa.Size = new System.Drawing.Size(140, 26);
            this.txtHsewa.TabIndex = 10;
            this.txtHsewa.TextChanged += new System.EventHandler(this.txtHsewa_TextChanged);
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStok.Location = new System.Drawing.Point(769, 254);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(140, 26);
            this.txtStok.TabIndex = 11;
            // 
            // txtNB
            // 
            this.txtNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNB.Location = new System.Drawing.Point(769, 144);
            this.txtNB.Name = "txtNB";
            this.txtNB.Size = new System.Drawing.Size(140, 26);
            this.txtNB.TabIndex = 12;
            this.txtNB.TextChanged += new System.EventHandler(this.txtNB_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBack.Location = new System.Drawing.Point(1183, 638);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 31);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(748, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(748, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(748, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(748, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = ":";
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNB);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHsewa);
            this.Controls.Add(this.txtIDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDB;
        private System.Windows.Forms.TextBox txtHsewa;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtNB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}