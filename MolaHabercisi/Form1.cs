using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MolaHabercisi
{
    public partial class Form1 : Form
    {
        private static readonly object _syncLock = new Object();
        private static readonly object _syncLock2 = new Object();
        private static readonly object _syncLock3 = new Object();

        private bool _durdurulduMu;
        private bool _saniyeMi;

        public bool DurdurulduMu
        {
            get
            {
                lock (_syncLock)
                {
                    return _durdurulduMu;
                }
            }
            set
            {
                lock (_syncLock)
                {
                    _durdurulduMu = value;
                }
            }
        }
        public bool SaniyeMi
        {
            get
            {
                lock (_syncLock3)
                {
                    return _saniyeMi;
                }
            }
            set
            {
                lock (_syncLock3)
                {
                    _saniyeMi = value;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            backgroundWorker_Dakika.WorkerReportsProgress = true;
            backgroundWorker_Dakika.WorkerSupportsCancellation = true;
            numericUpDown_Dakika.Maximum = int.MaxValue;
            numericUpDown_Saniye.Maximum = int.MaxValue;
            numericUpDown_Saniye.Value = 20;
            numericUpDown_Dakika.Value = 20;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int i = 0;
            if (this.DurdurulduMu)
            {
                i = progressBar_Dakika.Value;
                this.DurdurulduMu = false;
            }
            int dakika = progressBar_Dakika.Maximum;
            for (; i <= dakika; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    worker.ReportProgress(i);
                }

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                if (this.DurdurulduMu)
                {
                    resultLabel.Text = "Durduruldu!";
                }
                else
                {
                    resultLabel.Text = "İptal Edildi!";
                }
             
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Hata: " + e.Error.Message;
            }
            else
            {
                if (!SaniyeMi)
                {
                    DialogResult result1 = MessageBox.Show("20 saniye süreyle uzağa bakın yada gözlerini ovuşturun!",
                   "Süre Tamamlandı",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.RightAlign,
                   true);
                    if (result1 == DialogResult.OK)
                    {
                        int saniye = (int)numericUpDown_Saniye.Value;
                        progressBar_Dakika.Maximum = saniye;
                        backgroundWorker_Dakika.RunWorkerAsync();
                        this.SaniyeMi = true;
                    }    
                }
                else
                {
                    MessageBox.Show("Saniye Doldu. Yeniden haberciyi başlatmanız gerekir. ",
                        "Saniye Doldu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }              
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = String.Format("{0,2:P2}", (double)e.ProgressPercentage / (double)progressBar_Dakika.Maximum);
            progressBar_Dakika.Value = e.ProgressPercentage;
        }

        private void button_Baslat_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_Dakika.IsBusy != true)
            {
                int dakika = (int)numericUpDown_Dakika.Value * 60;
                progressBar_Dakika.Maximum = dakika;
                backgroundWorker_Dakika.RunWorkerAsync();
            }
        }

        private void button_IptalEt_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_Dakika.WorkerSupportsCancellation == true)
            {
                backgroundWorker_Dakika.CancelAsync();
            }
        }

        private void button_Durdur_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_Dakika.WorkerSupportsCancellation == true)
            {
                backgroundWorker_Dakika.CancelAsync();
                this.DurdurulduMu = true;
            }
        }
    }
}
