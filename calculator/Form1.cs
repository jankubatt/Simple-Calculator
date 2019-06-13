using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool clkPlus = false;
        bool clkMinus = false;
        bool clkTimes = false;
        bool clkDevide = false;
        float input = 0;
        float input2 = 0;

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            string num = txtResult.Text;
            int lastNum = num.Length - 1;

            num = num.Remove(lastNum);
            txtResult.Clear();
            txtResult.Text = num;
        }

        public void BtnPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") { }           
            else
            {
                clkPlus = true;
                input = float.Parse(txtResult.Text);
                txtResult.Clear();
            }
                            
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") { }         
            else
            {
                clkMinus = true;
                input = float.Parse(txtResult.Text);
                txtResult.Clear();
            }
        }
        private void BtnTimes_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") { }          
            else
            {
                clkTimes = true;
                input = float.Parse(txtResult.Text);
                txtResult.Clear();
            }
        }
        private void BtnDevide_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "") { }            
            else
            {
                clkDevide = true;
                input = float.Parse(txtResult.Text);
                txtResult.Clear();
            }
        }

        public void BtnEquals_Click(object sender, EventArgs e)
        {
            if (clkPlus == true)
            {
                input2 = float.Parse(txtResult.Text);
                input = input + input2;
                txtResult.Text = input.ToString();
                clkPlus = false;
            }
            else if (clkMinus == true)
            {
                input2 = float.Parse(txtResult.Text);
                input = input - input2;
                txtResult.Text = input.ToString();
                clkMinus = false;
            }
            else if (clkTimes == true)
            {
                input2 = float.Parse(txtResult.Text);
                input = input * input2;
                txtResult.Text = input.ToString();
                clkTimes = false;
            }
            else if (clkDevide == true)
            {
                input2 = float.Parse(txtResult.Text);
                if (input2 == 0)
                {
                    MessageBox.Show("You can't devide by 0 you little nerd", "fgt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    input = input / input2;
                    txtResult.Text = input.ToString();
                }
                clkDevide = false;
            }
            else { }
        }
    }
}
