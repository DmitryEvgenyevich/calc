using System.ComponentModel.Design.Serialization;
using System.Linq;
enum Operation
{
    Multiplication,
    Division,
    Addendum,
    Subtraction
}

namespace calc
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private bool temp = false;
        private Operation element;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Substring(0, 1) == "-")
                {
                    textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                }
                else 
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(".") & textBox1.Text.Length > 0)
                textBox1.Text += ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (temp == false)
                num1 = int.Parse(textBox1.Text);

            else
                num1 = calc();

            textBox1.Text = "";
            temp = true;
            element = Operation.Multiplication;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (temp == false)
                num1 = int.Parse(textBox1.Text);

            else
                num1 = calc();

            textBox1.Text = "";
            temp = true;
            element = Operation.Division;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (temp == false)
                num1 = int.Parse(textBox1.Text);

            else
                num1 = calc();

            textBox1.Text = "";
            temp = true;
            element = Operation.Subtraction;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (temp == false)
                num1 = int.Parse(textBox1.Text);

            else
                num1 = calc();

            textBox1.Text = "";
            element = Operation.Addendum;
            temp = true;
        }

        private double calc() 
        {
            num2 = int.Parse(textBox1.Text);

            if (element == Operation.Multiplication)
                num1 = num1 * num2;

            else if (element == Operation.Division)
                num1 = num1 / num2;

            else if (element == Operation.Subtraction)
                num1 = num1 - num2;

            else if (element == Operation.Addendum)
                num1 = num1 + num2;

            return num1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                calc();
            }
            MessageBox.Show($"Result {num1}");
        }
    }
}