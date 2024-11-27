namespace Bitcoin_calculator
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
            this.valivaluuta = new System.Windows.Forms.ComboBox();
            this.rated = new System.Windows.Forms.Button();
            this.sisesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valivaluuta
            // 
            this.valivaluuta.FormattingEnabled = true;
            this.valivaluuta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.valivaluuta.Location = new System.Drawing.Point(787, 219);
            this.valivaluuta.Name = "valivaluuta";
            this.valivaluuta.Size = new System.Drawing.Size(121, 21);
            this.valivaluuta.TabIndex = 0;
            this.valivaluuta.Text = "Vali valuuta";
            this.valivaluuta.SelectedIndexChanged += new System.EventHandler(this.valivaluuta_SelectedIndexChanged);
            // 
            // rated
            // 
            this.rated.Location = new System.Drawing.Point(787, 246);
            this.rated.Name = "rated";
            this.rated.Size = new System.Drawing.Size(110, 54);
            this.rated.TabIndex = 1;
            this.rated.Text = "Arvuta BTC kurss";
            this.rated.UseVisualStyleBackColor = true;
            this.rated.Click += new System.EventHandler(this.button1_Click);
            // 
            // sisesta
            // 
            this.sisesta.Location = new System.Drawing.Point(787, 193);
            this.sisesta.Name = "sisesta";
            this.sisesta.Size = new System.Drawing.Size(121, 20);
            this.sisesta.TabIndex = 2;
            this.sisesta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(806, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Siseta Btc hulk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tulemus
            // 
            this.tulemus.Location = new System.Drawing.Point(787, 319);
            this.tulemus.Name = "tulemus";
            this.tulemus.Size = new System.Drawing.Size(100, 20);
            this.tulemus.TabIndex = 4;
            this.tulemus.Text = "Pole";
            this.tulemus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(806, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tulemus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bitcoin_calculator.Properties.Resources.OIP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tulemus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sisesta);
            this.Controls.Add(this.rated);
            this.Controls.Add(this.valivaluuta);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox valivaluuta;
        private System.Windows.Forms.Button rated;
        private System.Windows.Forms.TextBox sisesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tulemus;
        private System.Windows.Forms.Label label2;
    }
}

