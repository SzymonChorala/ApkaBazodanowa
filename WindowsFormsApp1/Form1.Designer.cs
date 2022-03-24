namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDATA = new System.Windows.Forms.Label();
            this.labelPLN = new System.Windows.Forms.Label();
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelGBP = new System.Windows.Forms.Label();
            this.labelCHF = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button = new System.Windows.Forms.Button();
            this.textBoxPLN = new System.Windows.Forms.TextBox();
            this.textBoxEUR = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxGBP = new System.Windows.Forms.TextBox();
            this.textBoxCHF = new System.Windows.Forms.TextBox();
            this.pictureBoxCHF = new System.Windows.Forms.PictureBox();
            this.pictureBoxGBP = new System.Windows.Forms.PictureBox();
            this.pictureBoxUSD = new System.Windows.Forms.PictureBox();
            this.pictureBoxEUR = new System.Windows.Forms.PictureBox();
            this.pictureBoxPLN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCHF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPLN)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDATA
            // 
            this.labelDATA.AutoSize = true;
            this.labelDATA.Location = new System.Drawing.Point(32, 13);
            this.labelDATA.Name = "labelDATA";
            this.labelDATA.Size = new System.Drawing.Size(33, 13);
            this.labelDATA.TabIndex = 0;
            this.labelDATA.Text = "Data:";
            // 
            // labelPLN
            // 
            this.labelPLN.AutoSize = true;
            this.labelPLN.Location = new System.Drawing.Point(32, 71);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(28, 13);
            this.labelPLN.TabIndex = 1;
            this.labelPLN.Text = "PLN";
            this.labelPLN.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelEUR
            // 
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(32, 143);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(30, 13);
            this.labelEUR.TabIndex = 2;
            this.labelEUR.Text = "EUR";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(32, 212);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(30, 13);
            this.labelUSD.TabIndex = 3;
            this.labelUSD.Text = "USD";
            // 
            // labelGBP
            // 
            this.labelGBP.AutoSize = true;
            this.labelGBP.Location = new System.Drawing.Point(32, 276);
            this.labelGBP.Name = "labelGBP";
            this.labelGBP.Size = new System.Drawing.Size(29, 13);
            this.labelGBP.TabIndex = 4;
            this.labelGBP.Text = "GBP";
            // 
            // labelCHF
            // 
            this.labelCHF.AutoSize = true;
            this.labelCHF.Location = new System.Drawing.Point(30, 345);
            this.labelCHF.Name = "labelCHF";
            this.labelCHF.Size = new System.Drawing.Size(28, 13);
            this.labelCHF.TabIndex = 5;
            this.labelCHF.Text = "CHF";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(259, 427);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 12;
            this.button.Text = "Przelicz";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxPLN
            // 
            this.textBoxPLN.Location = new System.Drawing.Point(139, 103);
            this.textBoxPLN.Name = "textBoxPLN";
            this.textBoxPLN.Size = new System.Drawing.Size(100, 20);
            this.textBoxPLN.TabIndex = 13;
            this.textBoxPLN.Click += new System.EventHandler(this.textBoxPLN_Click);
            // 
            // textBoxEUR
            // 
            this.textBoxEUR.Location = new System.Drawing.Point(139, 176);
            this.textBoxEUR.Name = "textBoxEUR";
            this.textBoxEUR.Size = new System.Drawing.Size(100, 20);
            this.textBoxEUR.TabIndex = 14;
            this.textBoxEUR.Click += new System.EventHandler(this.textBoxEUR_Click);
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(139, 242);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxUSD.TabIndex = 15;
            this.textBoxUSD.Click += new System.EventHandler(this.textBoxUSD_Click);
            // 
            // textBoxGBP
            // 
            this.textBoxGBP.Location = new System.Drawing.Point(139, 307);
            this.textBoxGBP.Name = "textBoxGBP";
            this.textBoxGBP.Size = new System.Drawing.Size(100, 20);
            this.textBoxGBP.TabIndex = 16;
            this.textBoxGBP.Click += new System.EventHandler(this.textBoxGBP_Click);
            // 
            // textBoxCHF
            // 
            this.textBoxCHF.Location = new System.Drawing.Point(139, 378);
            this.textBoxCHF.Name = "textBoxCHF";
            this.textBoxCHF.Size = new System.Drawing.Size(100, 20);
            this.textBoxCHF.TabIndex = 17;
            this.textBoxCHF.Click += new System.EventHandler(this.textBoxCHF_Click);
            // 
            // pictureBoxCHF
            // 
            this.pictureBoxCHF.Image = global::WindowsFormsApp1.Properties.Resources.chf;
            this.pictureBoxCHF.Location = new System.Drawing.Point(33, 361);
            this.pictureBoxCHF.Name = "pictureBoxCHF";
            this.pictureBoxCHF.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCHF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCHF.TabIndex = 11;
            this.pictureBoxCHF.TabStop = false;
            // 
            // pictureBoxGBP
            // 
            this.pictureBoxGBP.Image = global::WindowsFormsApp1.Properties.Resources.uk;
            this.pictureBoxGBP.Location = new System.Drawing.Point(33, 292);
            this.pictureBoxGBP.Name = "pictureBoxGBP";
            this.pictureBoxGBP.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxGBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGBP.TabIndex = 10;
            this.pictureBoxGBP.TabStop = false;
            // 
            // pictureBoxUSD
            // 
            this.pictureBoxUSD.Image = global::WindowsFormsApp1.Properties.Resources.usa;
            this.pictureBoxUSD.Location = new System.Drawing.Point(33, 228);
            this.pictureBoxUSD.Name = "pictureBoxUSD";
            this.pictureBoxUSD.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUSD.TabIndex = 9;
            this.pictureBoxUSD.TabStop = false;
            // 
            // pictureBoxEUR
            // 
            this.pictureBoxEUR.Image = global::WindowsFormsApp1.Properties.Resources.eu;
            this.pictureBoxEUR.Location = new System.Drawing.Point(33, 159);
            this.pictureBoxEUR.Name = "pictureBoxEUR";
            this.pictureBoxEUR.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxEUR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEUR.TabIndex = 8;
            this.pictureBoxEUR.TabStop = false;
            // 
            // pictureBoxPLN
            // 
            this.pictureBoxPLN.Image = global::WindowsFormsApp1.Properties.Resources.polska;
            this.pictureBoxPLN.Location = new System.Drawing.Point(35, 87);
            this.pictureBoxPLN.Name = "pictureBoxPLN";
            this.pictureBoxPLN.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPLN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPLN.TabIndex = 7;
            this.pictureBoxPLN.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 481);
            this.Controls.Add(this.textBoxCHF);
            this.Controls.Add(this.textBoxGBP);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxEUR);
            this.Controls.Add(this.textBoxPLN);
            this.Controls.Add(this.button);
            this.Controls.Add(this.pictureBoxCHF);
            this.Controls.Add(this.pictureBoxGBP);
            this.Controls.Add(this.pictureBoxUSD);
            this.Controls.Add(this.pictureBoxEUR);
            this.Controls.Add(this.pictureBoxPLN);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelCHF);
            this.Controls.Add(this.labelGBP);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.labelEUR);
            this.Controls.Add(this.labelPLN);
            this.Controls.Add(this.labelDATA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCHF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPLN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDATA;
        private System.Windows.Forms.Label labelPLN;
        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelGBP;
        private System.Windows.Forms.Label labelCHF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBoxPLN;
        private System.Windows.Forms.PictureBox pictureBoxEUR;
        private System.Windows.Forms.PictureBox pictureBoxUSD;
        private System.Windows.Forms.PictureBox pictureBoxGBP;
        private System.Windows.Forms.PictureBox pictureBoxCHF;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxPLN;
        private System.Windows.Forms.TextBox textBoxEUR;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textBoxGBP;
        private System.Windows.Forms.TextBox textBoxCHF;
    }
}

