namespace RentalApp
{
    partial class Transaksi
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
            this.dtpK = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpM = new System.Windows.Forms.DateTimePicker();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.CBPel = new System.Windows.Forms.ComboBox();
            this.CBBar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.btnSc = new System.Windows.Forms.Button();
            this.btnBb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpK
            // 
            this.dtpK.Location = new System.Drawing.Point(157, 178);
            this.dtpK.Name = "dtpK";
            this.dtpK.Size = new System.Drawing.Size(180, 20);
            this.dtpK.TabIndex = 2;
            this.dtpK.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Transaksi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Pengembalian:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 99);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(394, 131);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 33);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Save";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Pelanggan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tanggal Mulai:";
            // 
            // dtpM
            // 
            this.dtpM.Location = new System.Drawing.Point(157, 144);
            this.dtpM.Name = "dtpM";
            this.dtpM.Size = new System.Drawing.Size(180, 20);
            this.dtpM.TabIndex = 11;
            // 
            // txtIDT
            // 
            this.txtIDT.Location = new System.Drawing.Point(157, 45);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.Size = new System.Drawing.Size(100, 20);
            this.txtIDT.TabIndex = 12;
            // 
            // CBPel
            // 
            this.CBPel.FormattingEnabled = true;
            this.CBPel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBPel.Location = new System.Drawing.Point(157, 75);
            this.CBPel.Name = "CBPel";
            this.CBPel.Size = new System.Drawing.Size(100, 21);
            this.CBPel.TabIndex = 13;
            // 
            // CBBar
            // 
            this.CBBar.FormattingEnabled = true;
            this.CBBar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBBar.Location = new System.Drawing.Point(157, 110);
            this.CBBar.Name = "CBBar";
            this.CBBar.Size = new System.Drawing.Size(100, 21);
            this.CBBar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(157, 247);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Biaya:";
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Aktif",
            "Selesai"});
            this.CBStatus.Location = new System.Drawing.Point(157, 213);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(100, 21);
            this.CBStatus.TabIndex = 19;
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(493, 178);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(93, 33);
            this.btnUP.TabIndex = 20;
            this.btnUP.Text = "Update";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(394, 178);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(93, 33);
            this.btnCL.TabIndex = 21;
            this.btnCL.Text = "Clear";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.btnCL_Click);
            // 
            // btnSc
            // 
            this.btnSc.Location = new System.Drawing.Point(493, 130);
            this.btnSc.Name = "btnSc";
            this.btnSc.Size = new System.Drawing.Size(93, 33);
            this.btnSc.TabIndex = 22;
            this.btnSc.Text = "Search";
            this.btnSc.UseVisualStyleBackColor = true;
            this.btnSc.Click += new System.EventHandler(this.btnSc_Click);
            // 
            // btnBb
            // 
            this.btnBb.Location = new System.Drawing.Point(12, 12);
            this.btnBb.Name = "btnBb";
            this.btnBb.Size = new System.Drawing.Size(62, 25);
            this.btnBb.TabIndex = 23;
            this.btnBb.Text = "Back";
            this.btnBb.UseVisualStyleBackColor = true;
            this.btnBb.Click += new System.EventHandler(this.btnBb_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnBb);
            this.Controls.Add(this.btnSc);
            this.Controls.Add(this.btnCL);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBBar);
            this.Controls.Add(this.CBPel);
            this.Controls.Add(this.txtIDT);
            this.Controls.Add(this.dtpM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpK);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpM;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.ComboBox CBPel;
        private System.Windows.Forms.ComboBox CBBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.Button btnSc;
        private System.Windows.Forms.Button btnBb;
    }
}