using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void continue_checkbox1_Click(object sender, EventArgs e)
        {
            if (continue_checkbox1.Checked)
            {
                endyear_textbox1.Enabled = false;
            }
            else
            {
                endyear_textbox1.Enabled = true;
            }
        }
        private void continue_checkbox2_Click(object sender, EventArgs e)
        {
            if (continue_checkbox2.Checked)
            {
                endyear_textbox2.Enabled = false;
            }
            else
            {
                endyear_textbox2.Enabled = true;
            }
        }
        private void continue_checkbox3_Click(object sender, EventArgs e)
        {
            if (continue_checkbox3.Checked)
            {
                endyear_textbox3.Enabled = false;
            }
            else
            {
                endyear_textbox3.Enabled = true;
            }
        }
        private void continue_checkbox4_Click(object sender, EventArgs e)
        {
            if (continue_checkbox4.Checked)
            {
                endyear_textbox4.Enabled = false;
            }
            else
            {
                endyear_textbox4.Enabled = true;
            }
        }
        private void sbmit_btn_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();


        }
    }
}
