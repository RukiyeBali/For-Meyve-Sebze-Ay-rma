namespace for_örnek
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
            this.btnAyikla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstKarisik = new System.Windows.Forms.ListBox();
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.lstSebze = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAyikla
            // 
            this.btnAyikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyikla.Location = new System.Drawing.Point(164, 232);
            this.btnAyikla.Name = "btnAyikla";
            this.btnAyikla.Size = new System.Drawing.Size(120, 38);
            this.btnAyikla.TabIndex = 0;
            this.btnAyikla.Text = "Ayıkla";
            this.btnAyikla.UseVisualStyleBackColor = true;
            this.btnAyikla.Click += new System.EventHandler(this.btnAyikla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meyve ve Sebzeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meyveler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(337, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sebzeler";
            // 
            // lstKarisik
            // 
            this.lstKarisik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKarisik.FormattingEnabled = true;
            this.lstKarisik.ItemHeight = 16;
            this.lstKarisik.Items.AddRange(new object[] {
            "Brokoli",
            "Çilek",
            "Muz",
            "Karpuz",
            "Mandalina",
            "Kavun",
            "Kuru soğan",
            "Salatalık",
            "Domates",
            "Kıvırcık"});
            this.lstKarisik.Location = new System.Drawing.Point(17, 52);
            this.lstKarisik.Name = "lstKarisik";
            this.lstKarisik.Size = new System.Drawing.Size(120, 164);
            this.lstKarisik.TabIndex = 4;
            // 
            // lstMeyve
            // 
            this.lstMeyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.ItemHeight = 16;
            this.lstMeyve.Location = new System.Drawing.Point(164, 52);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(120, 164);
            this.lstMeyve.TabIndex = 5;
            // 
            // lstSebze
            // 
            this.lstSebze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSebze.FormattingEnabled = true;
            this.lstSebze.ItemHeight = 16;
            this.lstSebze.Location = new System.Drawing.Point(308, 52);
            this.lstSebze.Name = "lstSebze";
            this.lstSebze.Size = new System.Drawing.Size(120, 164);
            this.lstSebze.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 282);
            this.Controls.Add(this.lstSebze);
            this.Controls.Add(this.lstMeyve);
            this.Controls.Add(this.lstKarisik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyikla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstKarisik;
        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.ListBox lstSebze;
    }
}

