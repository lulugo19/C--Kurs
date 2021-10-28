using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        int zähler = 0;

        public Form1()
        {
            InitializeComponent();
            this.Focus();
        }

        private void buttonHoch_Click(object sender, EventArgs e)
        {
            zähler++;
            labelZahl.Text = zähler.ToString();
        }

        private void buttonRunter_Click(object sender, EventArgs e)
        {
            zähler--;
            labelZahl.Text = zähler.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                zähler++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                zähler--;
            }
            labelZahl.Text = zähler.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!msg.HWnd.Equals(this.Handle) &&
                (keyData == Keys.Left || keyData == Keys.Right ||
                keyData == Keys.Up || keyData == Keys.Down))
                return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void labelZahl_Click(object sender, EventArgs e)
        {

        }
    }
}
