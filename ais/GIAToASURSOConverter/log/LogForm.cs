using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIAToASURSOConverter.log
{
    public partial class LogForm : Form
    {
        public LogForm(String log)
        {
            InitializeComponent();
            this.textBox1.Text = log;
        }
    }
}
