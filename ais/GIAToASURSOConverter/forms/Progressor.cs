using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIAToASURSOConverter.forms
{
    public partial class Progressor : Form
    {
        public Progressor()
        {
            InitializeComponent();
        }
        public void SetCount(int count)
        {
            this.progressBar1.Maximum = count;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Value = 0;
            this.progressBar1.Step = 1;
        }

        public void Step()
        {
            this.progressBar1.PerformStep();
            this.label1.Text = "Прогресс: " + this.progressBar1.Value.ToString() + " из " + this.progressBar1.Maximum.ToString();
        }
    }
}
