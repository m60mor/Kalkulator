using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        decimal first = 0;
        decimal second = 0;
        string oper = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            textBox1.Text = "0";
            textBox1.Font = new Font("Segoe UI", 17);
            textBox2.Text = "";
            first = 0;
            second = 0;
            oper = "";
        }
        private void buttonSeparator_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(','))
            {
                textBox1.Text += ",";
            }
            else if (textBox1.Text[textBox1.Text.Length - 1] == ',')
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                string num = textBox1.Text;
                if (textBox1.Text[num.Length - 2] == '-')
                {
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = num.Substring(0, num.Length - 1 - (num[num.Length - 2] == ',' ? 1 : 0));
                }
            }
            else
            {
                textBox1.Text = "0";
            }
        }
        private void buttonSimbol_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else if (Regex.IsMatch(textBox1.Text, "[1-9]"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var number = (sender as Button)?.Text;
            var firstSimbol = textBox1.Text[0] == '-' ? 1 : 0;
            var separator = textBox1.Text.Contains(',') ? 1 : 0;
            if (textBox1.Text.Length < (28 + firstSimbol + separator))
            {
                //textBox1.Font = new Font("Segoe UI", 34);
                if (textBox1.Text == "0")
                {
                    textBox1.Text = number;
                }
                else
                {
                    textBox1.Text += number;
                }
            }
        }




        private void buttonRoot_Click(object sender, EventArgs e)
        {
            double root = 0;
            if (Double.TryParse(textBox1.Text, out root))
            {
                if (root >= 0)
                {
                    decimal x = Convert.ToDecimal(Math.Sqrt(root));
                    textBox1Format(x);
                }
                else
                {
                    errorProvider1.SetError(textBox2, "Can`t calculate square root of negative number!");
                }
            }
        }
        private void buttonOperator_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == ',')
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }


            if (oper == "")
            {
                decimal.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out first);
                textBox1.Text = "0";
            }
            oper = (sender as Button).Text;


            if (first.ToString().Length > 16)
            {
                if ((first.ToString()[11] == '0' && first.ToString()[1] == ',') || first.ToString("0.################").Length > 21)
                {
                    textBox2.Text = first.ToString("0#.####E+0") + " " + oper;
                }
                else
                {
                    textBox2.Text = first.ToString("0.################") + " " + oper;
                }
            }
            else
            {
                textBox2.Text = first.ToString("0.################") + " " + oper;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (oper != "")
            {
                if (Decimal.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out second))
                {
                    first = calc(first, second, oper);
                    textBox2.Text = oper = "";
                }
            }
            else
            {
                Decimal.TryParse(textBox1.Text, out first);
            }
            textBox1Format(first);
        }




        private decimal calc(decimal x, decimal y, string o)
        {
            try
            {
                if (o == "*")
                {
                    return x * y;
                }
                else if (o == "/")
                {
                    if (y != 0)
                    {
                        return x / y;
                    }
                    else
                    {
                        errorProvider1.SetError(textBox2, "Can`t divide by 0");
                        return first;
                    }
                }
                else if (o == "+")
                {
                    return x + y;
                }
                else if (o == "-")
                {
                    return x - y;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                errorProvider1.SetError(textBox2, "Number is too big!");
                return first;
            }
        }
        private void textBox1Format(decimal number)
        {
            /*var separator = textBox1.Text.Contains(',') ? 1 : 0;
            if (number.ToString().Length > 8 - separator)
            {
                textBox1.Font = new Font("Segoe UI", 34);
                if ((number.ToString()[6] == '0' && number.ToString()[1] == ',') || number.ToString("0.################").Length > 17)
                {
                    textBox1.Text = number.ToString("0#.##E+0");
                }
                else
                {
                    textBox1.Text = number.ToString("0.################");
                    textBox1.Font = new Font("Segoe UI", 17);
                }
            }
            else
            {
                textBox1.Text = number.ToString("0.########");
            }*/
            textBox1.Text = number.ToString("0.############################");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}