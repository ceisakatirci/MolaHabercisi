namespace MolaHabercisi
{
    partial class frmMolaHabercisi
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
            this.backgroundWorker_Dakika = new System.ComponentModel.BackgroundWorker();
            this.progressBar_Dakika = new System.Windows.Forms.ProgressBar();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button_Baslat = new System.Windows.Forms.Button();
            this.button_IptalEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Dakika = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Saniye = new System.Windows.Forms.NumericUpDown();
            this.button_Durdur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Saniye)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker_Dakika
            // 
            this.backgroundWorker_Dakika.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker_Dakika.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker_Dakika.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar_Dakika
            // 
            this.progressBar_Dakika.Location = new System.Drawing.Point(16, 102);
            this.progressBar_Dakika.Name = "progressBar_Dakika";
            this.progressBar_Dakika.Size = new System.Drawing.Size(538, 23);
            this.progressBar_Dakika.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 77);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(45, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Yüzde%";
            // 
            // button_Baslat
            // 
            this.button_Baslat.Location = new System.Drawing.Point(16, 149);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(75, 23);
            this.button_Baslat.TabIndex = 2;
            this.button_Baslat.Text = "Başlat";
            this.button_Baslat.UseVisualStyleBackColor = true;
            this.button_Baslat.Click += new System.EventHandler(this.button_Baslat_Click);
            // 
            // button_IptalEt
            // 
            this.button_IptalEt.Location = new System.Drawing.Point(199, 149);
            this.button_IptalEt.Name = "button_IptalEt";
            this.button_IptalEt.Size = new System.Drawing.Size(75, 23);
            this.button_IptalEt.TabIndex = 2;
            this.button_IptalEt.Text = "İptal Et";
            this.button_IptalEt.UseVisualStyleBackColor = true;
            this.button_IptalEt.Click += new System.EventHandler(this.button_IptalEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dakika";
            // 
            // numericUpDown_Dakika
            // 
            this.numericUpDown_Dakika.Location = new System.Drawing.Point(71, 12);
            this.numericUpDown_Dakika.Name = "numericUpDown_Dakika";
            this.numericUpDown_Dakika.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Dakika.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saniye";
            // 
            // numericUpDown_Saniye
            // 
            this.numericUpDown_Saniye.Location = new System.Drawing.Point(71, 40);
            this.numericUpDown_Saniye.Name = "numericUpDown_Saniye";
            this.numericUpDown_Saniye.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Saniye.TabIndex = 3;
            // 
            // button_Durdur
            // 
            this.button_Durdur.Location = new System.Drawing.Point(108, 149);
            this.button_Durdur.Name = "button_Durdur";
            this.button_Durdur.Size = new System.Drawing.Size(75, 23);
            this.button_Durdur.TabIndex = 2;
            this.button_Durdur.Text = "Durdur";
            this.button_Durdur.UseVisualStyleBackColor = true;
            this.button_Durdur.Click += new System.EventHandler(this.button_Durdur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 202);
            this.Controls.Add(this.numericUpDown_Saniye);
            this.Controls.Add(this.numericUpDown_Dakika);
            this.Controls.Add(this.button_IptalEt);
            this.Controls.Add(this.button_Durdur);
            this.Controls.Add(this.button_Baslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.progressBar_Dakika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mola Habercisi";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Saniye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker_Dakika;
        private System.Windows.Forms.ProgressBar progressBar_Dakika;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.Button button_IptalEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Dakika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Saniye;
        private System.Windows.Forms.Button button_Durdur;
    }
}

