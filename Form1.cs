using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getPercentage
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            btnCalc.Enabled = false;
            btnClear.Enabled = false;
            txtPct.Enabled = false;

            txtNetPct.ReadOnly = true;
            txtNetPct.Enabled = false;
            txtResult.ReadOnly = true;
            txtResult.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float init, pct, netPct, result;

            init = Convert.ToSingle(txtInit.Text);
            pct = Convert.ToSingle(txtPct.Text);

            netPct = (init * pct) / 100;
            result = init + netPct;

            txtNetPct.Enabled = true;
            txtNetPct.Text = Convert.ToString(netPct);
            txtResult.Enabled = true;
            txtResult.Text = Convert.ToString(result);

            btnCalc.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInit.Clear();

            txtPct.Clear();
            txtPct.Enabled = false;
            txtNetPct.Clear();
            txtNetPct.Enabled = false;
            txtResult.Clear();
            txtResult.Enabled = false;

            btnClear.Enabled = false;
        }

        private void txtInit_TextChanged(object sender, EventArgs e)
        {
            txtNetPct.Clear();
            txtNetPct.Enabled = false;
            txtResult.Clear();
            txtResult.Enabled = false;

            if (txtInit.Text.Length < 1)
            {
                if(txtPct.Text.Length < 1)
                {
                    txtPct.Enabled = false;
                    btnClear.Enabled = false;
                }
                txtNetPct.Clear();
                txtResult.Clear();

                btnCalc.Enabled = false;
            }
            else if(!txtInit.Equals(txtInit.Text) && txtPct.Text.Length > 0)
            {
                btnCalc.Enabled = true;
            }
            else
            {
                btnClear.Enabled = true;
                txtPct.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure you want to quit ?";
            const string caption = "Percentage Calculator";

            var dialog = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void txtPct_TextChanged(object sender, EventArgs e)
        {
            txtNetPct.Clear();
            txtNetPct.Enabled = false;
            txtResult.Clear();
            txtResult.Enabled = false;

            if (txtPct.Text.Length < 1)
            {
                if (txtInit.Text.Length < 1)
                {
                    txtPct.Enabled = false;
                    btnClear.Enabled = false;
                }
                txtNetPct.Clear();
                txtResult.Clear();

                btnCalc.Enabled = false;
            }
            else if (!txtInit.Equals(txtInit.Text) && txtInit.Text.Length < 1)
            {
                btnCalc.Enabled = false;
            }
            else
            {
                btnCalc.Enabled = true;
                btnClear.Enabled = true;
            }
        }

        private void txtNetPct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
