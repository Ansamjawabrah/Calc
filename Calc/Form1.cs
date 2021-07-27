using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculater : Form
    {
        bool op_performed = false ;
        public Calculater()
        {
            InitializeComponent();
        }

        private void button_ck(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (op_performed))
                textBox1.Clear();
                op_performed = false;
               Button b = (Button)sender;
              if (b.Text ==".")
            {
                if(!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + b.Text;

            }
            else 
                textBox1.Text = textBox1.Text + b.Text;
            
        }
        string op="";
        double result=0;
        private void op_click(object sender, EventArgs e)
        {   Button b = (Button)sender;
            if (result != 0)
            {
                button16.PerformClick();
                op = b.Text;
          
                label1.Text = result + " " + op;
                op_performed = true;
            }
            else
            {
                
                op = b.Text;
                result = double.Parse(textBox1.Text);
                label1.Text = result + " " + op;
                op_performed = true;
            }
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
               textBox1.Text = "0";
               result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                    
                default:
                    break;




            }
            result = double.Parse(textBox1.Text);
            label1.Text = " ";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double lg = double.Parse(textBox1.Text);
            lg = Math.Log10(lg);
            textBox1.Text = lg.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(textBox1.Text);
            sq = Math.Sqrt(sq);
            textBox1.Text = sq.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double sn = double.Parse(textBox1.Text);
            sn = sn * 3.1415926535 / 180;
            sn = Math.Sin(sn);
            textBox1.Text = sn.ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            double cn = double.Parse(textBox1.Text);
            cn = cn * 3.141592653589976323 / 180;
            cn = Math.Cos(cn);
            textBox1.Text = cn.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double tn = double.Parse(textBox1.Text);
            tn = tn * 3.1415926535 / 180;
            tn = Math.Tan(tn);
            textBox1.Text = tn.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int bn = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(bn,2);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int hx = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(hx, 16);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double exp = double.Parse(textBox1.Text);
            exp = Math.Exp(exp);
            textBox1.Text = exp.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double lg = double.Parse(textBox1.Text);
            lg = Math.Log2(lg);
            textBox1.Text = lg.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
           Double a = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
            textBox1.Text = a.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double a = double.Parse(textBox1.Text) * double.Parse(textBox1.Text)* double.Parse(textBox1.Text);
            textBox1.Text = a.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox1.Text) / 100.0;
            textBox1.Text = b.ToString();

        }
    }
}
