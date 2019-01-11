using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTest
{
    public partial class Form1 : Form
    {
        private string Num;

        public Form1()
        {
            InitializeComponent();
            Num = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Num += "1";
            txtResult.Text = Num;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Num += "2";
            txtResult.Text = Num;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Num += "3";
            txtResult.Text = Num;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Num += "4";
            txtResult.Text = Num;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Num += "5";
            txtResult.Text = Num;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Num += "6";
            txtResult.Text = Num;
        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnPlu_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnEqa_Click(object sender, EventArgs e)
        {

        }
    }
}
