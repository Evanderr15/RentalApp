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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpK
            // 
            this.dtpK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpK.Location = new System.Drawing.Point(195, 306);
            this.dtpK.Name = "dtpK";
            this.dtpK.Size = new System.Drawing.Size(180, 22);
            this.dtpK.TabIndex = 2;
            this.dtpK.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Pengembalian";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 568);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.IndianRed;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSimpan.Location = new System.Drawing.Point(41, 510);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 47);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Save";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Pelanggan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tanggal Mulai";
            // 
            // dtpM
            // 
            this.dtpM.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpM.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpM.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpM.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpM.Location = new System.Drawing.Point(195, 252);
            this.dtpM.Name = "dtpM";
            this.dtpM.Size = new System.Drawing.Size(180, 22);
            this.dtpM.TabIndex = 11;
            // 
            // txtIDT
            // 
            this.txtIDT.BackColor = System.Drawing.Color.SeaShell;
            this.txtIDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDT.Location = new System.Drawing.Point(195, 98);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.Size = new System.Drawing.Size(89, 22);
            this.txtIDT.TabIndex = 12;
            // 
            // CBPel
            // 
            this.CBPel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPel.FormattingEnabled = true;
            this.CBPel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBPel.Location = new System.Drawing.Point(195, 145);
            this.CBPel.Name = "CBPel";
            this.CBPel.Size = new System.Drawing.Size(89, 24);
            this.CBPel.TabIndex = 13;
            // 
            // CBBar
            // 
            this.CBBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBar.FormattingEnabled = true;
            this.CBBar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBBar.Location = new System.Drawing.Point(195, 200);
            this.CBBar.Name = "CBBar";
            this.CBBar.Size = new System.Drawing.Size(89, 24);
            this.CBBar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(195, 405);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(136, 22);
            this.txtTotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Biaya";
            // 
            // CBStatus
            // 
            this.CBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Aktif",
            "Selesai"});
            this.CBStatus.Location = new System.Drawing.Point(195, 357);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(89, 24);
            this.CBStatus.TabIndex = 19;
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.Color.IndianRed;
            this.btnUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUP.Location = new System.Drawing.Point(149, 510);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(93, 47);
            this.btnUP.TabIndex = 20;
            this.btnUP.Text = "Update";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnCL
            // 
            this.btnCL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCL.Location = new System.Drawing.Point(258, 510);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(93, 47);
            this.btnCL.TabIndex = 21;
            this.btnCL.Text = "Clear";
            this.btnCL.UseVisualStyleBackColor = false;
            this.btnCL.Click += new System.EventHandler(this.btnCL_Click);
            // 
            // btnSc
            // 
            this.btnSc.BackColor = System.Drawing.Color.IndianRed;
            this.btnSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSc.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSc.Location = new System.Drawing.Point(1093, 40);
            this.btnSc.Name = "btnSc";
            this.btnSc.Size = new System.Drawing.Size(93, 33);
            this.btnSc.TabIndex = 22;
            this.btnSc.Text = "Search";
            this.btnSc.UseVisualStyleBackColor = false;
            this.btnSc.Click += new System.EventHandler(this.btnSc_Click);
            // 
            // btnBb
            // 
            this.btnBb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBb.Location = new System.Drawing.Point(12, 16);
            this.btnBb.Name = "btnBb";
            this.btnBb.Size = new System.Drawing.Size(64, 30);
            this.btnBb.TabIndex = 23;
            this.btnBb.Text = "Back";
            this.btnBb.UseVisualStyleBackColor = true;
            this.btnBb.Click += new System.EventHandler(this.btnBb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1192, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 33);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(180, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(180, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(180, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(180, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(180, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = ":";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(180, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(180, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = ":";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}