using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double results = 0;
        String operation = "";
        bool value = false;

        private void button_Click(object sender, EventArgs e)
        {
            if((textDisplay.Text == "0") || (value)){
                textDisplay.Text = "";
                value = false;
            }
            Button number = (Button)sender;
            if(number.Text == ".")
            {
                if (!textDisplay.Text.Contains(".")) 
                    textDisplay.Text = textDisplay.Text + number.Text;
            }
            else 
                textDisplay.Text =  textDisplay.Text + number.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textDisplay.Text) * (-1.0);
            textDisplay.Text = System.Convert.ToString(a);
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button number = (Button)(sender);
            operation = number.Text;
            results = Double.Parse(textDisplay.Text);
            textDisplay.Text = "";
            lblShowDisplay.Text = System.Convert.ToString(results) + " " + operation;

        }

      

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShowDisplay.Text = "";
            switch(operation)
            {
                case "+":
                    textDisplay.Text = (results + Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = (results - Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "*":
                    textDisplay.Text = (results * Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "/":
                    textDisplay.Text = (results / Double.Parse(textDisplay.Text)).ToString();
                    break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            lblShowDisplay.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text.Length >0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);

            }
            if(textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }
    }
}
