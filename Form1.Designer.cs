namespace obsCalculator


{ 
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslik = new System.Windows.Forms.Label();
            this.baslik_cizgi = new System.Windows.Forms.Panel();
            this.dersadialma = new System.Windows.Forms.TextBox();
            this.dersadi = new System.Windows.Forms.Label();
            this.aktsalma = new System.Windows.Forms.NumericUpDown();
            this.akt = new System.Windows.Forms.Label();
            this.vizenot = new System.Windows.Forms.Label();
            this.vizenotalma = new System.Windows.Forms.NumericUpDown();
            this.finalnot = new System.Windows.Forms.Label();
            this.finalnotalma = new System.Windows.Forms.NumericUpDown();
            this.obphesaplamabuton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aktsalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizenotalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalnotalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.baslik.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(0, 0);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(467, 56);
            this.baslik.TabIndex = 0;
            this.baslik.Text = "OBS CALCULATOR";
            this.baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // baslik_cizgi
            // 
            this.baslik_cizgi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslik_cizgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.baslik_cizgi.Location = new System.Drawing.Point(0, 56);
            this.baslik_cizgi.Name = "baslik_cizgi";
            this.baslik_cizgi.Size = new System.Drawing.Size(468, 2);
            this.baslik_cizgi.TabIndex = 1;
            // 
            // dersadialma
            // 
            this.dersadialma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersadialma.Location = new System.Drawing.Point(106, 76);
            this.dersadialma.Name = "dersadialma";
            this.dersadialma.Size = new System.Drawing.Size(137, 26);
            this.dersadialma.TabIndex = 5;
            this.dersadialma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dersadi
            // 
            this.dersadi.AutoSize = true;
            this.dersadi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersadi.Location = new System.Drawing.Point(28, 79);
            this.dersadi.Name = "dersadi";
            this.dersadi.Size = new System.Drawing.Size(61, 20);
            this.dersadi.TabIndex = 6;
            this.dersadi.Text = "Ders Adı";
            this.dersadi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // aktsalma
            // 
            this.aktsalma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aktsalma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.aktsalma.Location = new System.Drawing.Point(349, 76);
            this.aktsalma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.aktsalma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.aktsalma.Name = "aktsalma";
            this.aktsalma.Size = new System.Drawing.Size(75, 26);
            this.aktsalma.TabIndex = 7;
            this.aktsalma.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.aktsalma.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // akt
            // 
            this.akt.AutoSize = true;
            this.akt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akt.Location = new System.Drawing.Point(272, 79);
            this.akt.Name = "akt";
            this.akt.Size = new System.Drawing.Size(43, 20);
            this.akt.TabIndex = 8;
            this.akt.Text = "AKTS";
            // 
            // vizenot
            // 
            this.vizenot.AutoSize = true;
            this.vizenot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vizenot.Location = new System.Drawing.Point(28, 124);
            this.vizenot.Name = "vizenot";
            this.vizenot.Size = new System.Drawing.Size(67, 20);
            this.vizenot.TabIndex = 9;
            this.vizenot.Text = "Vize Notu";
            // 
            // vizenotalma
            // 
            this.vizenotalma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vizenotalma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.vizenotalma.Location = new System.Drawing.Point(106, 122);
            this.vizenotalma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.vizenotalma.Name = "vizenotalma";
            this.vizenotalma.Size = new System.Drawing.Size(75, 26);
            this.vizenotalma.TabIndex = 10;
            this.vizenotalma.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // finalnot
            // 
            this.finalnot.AutoSize = true;
            this.finalnot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finalnot.Location = new System.Drawing.Point(272, 128);
            this.finalnot.Name = "finalnot";
            this.finalnot.Size = new System.Drawing.Size(68, 20);
            this.finalnot.TabIndex = 11;
            this.finalnot.Text = "Final Notu";
            // 
            // finalnotalma
            // 
            this.finalnotalma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finalnotalma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.finalnotalma.Location = new System.Drawing.Point(349, 124);
            this.finalnotalma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.finalnotalma.Name = "finalnotalma";
            this.finalnotalma.Size = new System.Drawing.Size(75, 26);
            this.finalnotalma.TabIndex = 12;
            this.finalnotalma.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // obphesaplamabuton
            // 
            this.obphesaplamabuton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.obphesaplamabuton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.obphesaplamabuton.Location = new System.Drawing.Point(0, 416);
            this.obphesaplamabuton.Name = "obphesaplamabuton";
            this.obphesaplamabuton.Size = new System.Drawing.Size(468, 34);
            this.obphesaplamabuton.TabIndex = 13;
            this.obphesaplamabuton.Text = "OBP HESAPLA";
            this.obphesaplamabuton.UseVisualStyleBackColor = true;
            this.obphesaplamabuton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.obphesaplamabuton);
            this.Controls.Add(this.finalnotalma);
            this.Controls.Add(this.finalnot);
            this.Controls.Add(this.vizenotalma);
            this.Controls.Add(this.vizenot);
            this.Controls.Add(this.akt);
            this.Controls.Add(this.aktsalma);
            this.Controls.Add(this.dersadi);
            this.Controls.Add(this.dersadialma);
            this.Controls.Add(this.baslik_cizgi);
            this.Controls.Add(this.baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aktsalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizenotalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalnotalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Panel baslik_cizgi;
        private System.Windows.Forms.TextBox dersadialma;
        private System.Windows.Forms.Label dersadi;
        private System.Windows.Forms.NumericUpDown aktsalma;
        private System.Windows.Forms.Label akt;
        private System.Windows.Forms.Label vizenot;
        private System.Windows.Forms.NumericUpDown vizenotalma;
        private System.Windows.Forms.Label finalnot;
        private System.Windows.Forms.NumericUpDown finalnotalma;
        private System.Windows.Forms.Button obphesaplamabuton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

