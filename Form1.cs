using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string Mul;
        public string N1;
        public string N2;
        public bool n2=false;
        public Form1()
        {
            InitializeComponent();

            textBox2.Text = "0";        
        }

       
	
        private void number9_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox2.Text = "0";
            }
            Button But = (Button)sender;
            if (textBox2.Text=="0")
            {
                textBox2.Text = But.Text;

            }
            else
            textBox2.Text = textBox2.Text + But.Text;
            this.Enabled = true;           
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text+",";
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string numb =  textBox2.Text;
            string t = string.Empty;


            if (numb == String.Empty || numb.Length == 1)
            {
                textBox2.Text = "0";
            }
            else
            {
                for (int i = 0; i < numb.Length - 1; i++)
                {

                    t += numb[i];

                }
                textBox2.Text = t;
            }
        }

        


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            N2 = textBox2.Text;
            double numb = 0;
            double M1 = Convert.ToDouble(N1);
            double M2 = Convert.ToDouble(N2);
            if (M1 == 0 && M2==0 )
            {

            }
            else
            {
                if (Mul == buttonPlus.Text)
                {
                    numb = M1 + M2;
                }
                else if (Mul == buttonMinus.Text)
                {
                    numb = M1 - M2;
                }
                else if (Mul == buttonDivide.Text)
                {
                    numb = M1 / M2;
                }
                else if (Mul == buttonMul.Text)
                {
                    numb = M1 * M2;
                }
                else if (Mul == buttonPercent.Text)
                {
                    numb = (M1 * M2) / 100;
                }
                
                else if (listBox1.SelectedItem.ToString() == "Root")
                {
                    numb = Math.Sqrt(M2);

                }
                else if (listBox1.SelectedItem.ToString() == "Square")
                {
                    numb = Math.Pow(M2, 2);
                }
                else if (listBox1.SelectedItem.ToString() == "Other Functions")
                {
                    numb = Math.Pow(M2, 2);
                }
            }
            
            n2 = true;
            textBox2.Text = Convert.ToString( numb);
            N1 = "0";
            N2 = "0";
            Mul = " ";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox2.Text);
            number = -number;
            textBox2.Text=number.ToString();
        }
        private void buttonMul_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }  
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }
        private void buttonClick(object sender)
        {
            Button But = (Button)sender;

            Mul = But.Text;
            N1 = textBox2.Text;
            n2 = true;
        }

    }
}
