using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barname_sazi_4_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "1";
            
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "9";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txt_res.Text = "";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            
           double a = Convert.ToInt32(txt_res.Text);
            txt_res.Text = "";
            int op = 1;


        }

        private void btn_eqwl_Click(object sender, EventArgs e)
        {



        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "0";
        }
    }
}
