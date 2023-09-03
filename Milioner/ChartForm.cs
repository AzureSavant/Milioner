using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioner
{
    public partial class ChartForm : Form
    {
        private List<int> list;

        public ChartForm()
        {
            InitializeComponent();
        }

        public ChartForm(List<int> list)
        {
            this.list = list;
            InitializeComponent();
            progressBar1.Value = list[0];
            progressBar2.Value = list[1];
            progressBar3.Value = list[2];
            progressBar4.Value = list[3];
            richTextBoxPercentA.Text = string.Format("{0}%", list[0].ToString());
            richTextBoxPercentB.Text = string.Format("{0}%", list[1].ToString());
            richTextBoxPercentC.Text = string.Format("{0}%", list[2].ToString());
            richTextBoxPercentD.Text = string.Format("{0}%", list[3].ToString());
        }
    }
}
