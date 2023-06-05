using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace git_cbs_lesson03_ex06_calculator
{
    public partial class Main : Form
    {
        string currentOperation = "";
        bool waitSecondOperand = false;
        string firstOperand = "";
        string secondOperand = "";
        bool equal = false;

        public Main()
        {
            InitializeComponent();
            labelField1.Text = "";
            labelField2.Text = "0";
        }



        private void bPercent_Click(object sender, MouseEventArgs e)
        {
            if (double.TryParse(labelField2.Text, out double inputT))
            {
                if (inputT > 0)
                {
                    double result = inputT / 100;
                    labelField2.Text = result.ToString();
                    labelField1.Text = result.ToString();
                }
                else
                {
                    return;
                }
            }
            else
            {
                labelField2.Text = "Дані не підходять";
            }
        }

        private void bCE_Click(object sender, MouseEventArgs e)
        {
            labelField2.Text = "0";
        }

        private void bC_Click(object sender, MouseEventArgs e)
        {
            labelField1.Text = "";
            labelField2.Text = "0";
        }

        private void cBackSpace_Click(object sender, MouseEventArgs e)
        {
            string input = labelField2.Text;
            string newString = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                newString += input[i];
            }
            labelField2.Text = newString;
        }


        private void bOneDivX_Click(object sender, EventArgs e)
        {
            if (double.TryParse(labelField2.Text, out double inputT))
            {
                if (inputT != 0)
                {
                    double result = 1 / inputT;
                    labelField2.Text = result.ToString();
                    labelField1.Text = $"1/({inputT})";
                }
                else
                {
                    labelField2.Text = "Не можна ділити на нуль";
                }
            }
            else
            {
                labelField2.Text = "Дані не підходять";
            }
        }

        private void bPow2_Click(object sender, MouseEventArgs e)
        {
            if (double.TryParse(labelField2.Text, out double inputT))
            {
                double result = Math.Pow(inputT, 2);
                labelField2.Text = result.ToString();
                labelField1.Text = $"sqr({inputT})";
            }
            else
            {
                labelField2.Text = "Дані не підходять";
            }
        }

        private void bSqrt2_Click(object sender, MouseEventArgs e)
        {
            if (double.TryParse(labelField2.Text, out double inputT))
            {
                if (inputT > 0)
                {
                    double result = Math.Sqrt(inputT);
                    labelField2.Text = result.ToString();
                    labelField1.Text = $"√({inputT})";
                }
                else
                {
                    labelField2.Text = "Не можна брати кореню з нуля";
                }
            }
            else
            {
                labelField2.Text = "Дані не підходять";
            }
        }

        private void bDiv_Click(object sender, MouseEventArgs e)
        {
            string input = "";
            currentOperation = " / ";
            if (!equal)
            {
                if (!waitSecondOperand)
                {
                    input = labelField2.Text;
                    labelField1.Text = input + currentOperation;
                }
                else
                {
                    input = labelField1.Text;
                    input = input.Replace(" * ", currentOperation);
                    input = input.Replace(" + ", currentOperation);
                    input = input.Replace(" - ", currentOperation);
                    labelField1.Text = input;
                }
            }
            else
            {
                labelField1.Text = labelField2.Text + currentOperation;
                input = labelField2.Text;
            }
            equal = false;
            firstOperand = input;
            waitSecondOperand = true;
        }

        private void bMul_Click(object sender, MouseEventArgs e)
        {
            string input = "";
            currentOperation = " * ";
            if (!equal)
            {
                if (!waitSecondOperand)
                {
                    input = labelField2.Text;
                    labelField1.Text = input + currentOperation;
                }
                else
                {
                    input = labelField1.Text;
                    input = input.Replace(" / ", currentOperation);
                    input = input.Replace(" + ", currentOperation);
                    input = input.Replace(" - ", currentOperation);
                    labelField1.Text = input;
                }
            }
            else
            {
                labelField1.Text = labelField2.Text + currentOperation;
                input = labelField2.Text;
            }
            equal = false;
            firstOperand = input;
            waitSecondOperand = true;
        }

        private void bSub_Click(object sender, MouseEventArgs e)
        {
            string input = "";
            currentOperation = " - ";
            if (!equal)
            {
                if (!waitSecondOperand)
                {
                    input = labelField2.Text;
                    labelField1.Text = input + currentOperation;
                }
                else
                {
                    input = labelField1.Text;
                    input = input.Replace(" / ", currentOperation);
                    input = input.Replace(" + ", currentOperation);
                    input = input.Replace(" * ", currentOperation);
                    labelField1.Text = input;

                }
            }
            else
            {
                labelField1.Text = labelField2.Text + currentOperation;
                input = labelField2.Text;
            }
            equal = false;
            firstOperand = input;
            waitSecondOperand = true;
        }

        private void bAdd_Click(object sender, MouseEventArgs e)
        {
            string input = "";
            currentOperation = " + ";
            if (!equal)
            {
                if (!waitSecondOperand)
                {
                    input = labelField2.Text;
                    labelField1.Text = input + currentOperation;
                }
                else
                {
                    input = labelField1.Text;
                    input = input.Replace(" / ", currentOperation);
                    input = input.Replace(" - ", currentOperation);
                    input = input.Replace(" * ", currentOperation);
                    labelField1.Text = input;

                }
            }
            else
            {
                labelField1.Text = labelField2.Text + currentOperation;
                input = labelField2.Text;
            }
            equal = false;
            firstOperand = input;
            waitSecondOperand = true;
        }

        private void bComma_Click(object sender, MouseEventArgs e)
        {
            string input = labelField2.Text;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    return;
                }
            }
            labelField2.Text += ",";
        }

        private void bNumber_Click(object sender, MouseEventArgs e)
        {
            if (!waitSecondOperand)
            {
                Button b = (Button)sender;
                string numberButton = b.Text;

                if (labelField2.Text != "0")
                {
                    if (double.TryParse(labelField2.Text, out double inputT))
                    {
                        labelField2.Text += numberButton;
                    }
                    else
                    {
                        labelField2.Text = numberButton;
                    }
                    return;
                }
                else
                {
                    if (numberButton != "0") labelField2.Text = numberButton;
                }
            }
            else
            {
                labelField2.Text = "0";
                Button b = (Button)sender;
                string numberButton = b.Text;

                if (labelField2.Text != "0")
                {
                    if (double.TryParse(labelField2.Text, out double inputT))
                    {
                        labelField2.Text += numberButton;
                    }
                    else
                    {
                        labelField2.Text = numberButton;
                    }
                    return;
                }
                else
                {
                    if (numberButton != "0") labelField2.Text = numberButton;
                }
            }
            waitSecondOperand = false;
        }




        private void bSighInverse_Click(object sender, MouseEventArgs e)
        {
            if (double.TryParse(labelField2.Text, out double inputT))
            {
                if (inputT > 0)
                {
                    double result = Math.Sqrt(inputT);
                    labelField2.Text = "-" + inputT.ToString();
                    labelField1.Text = $"negate({inputT})";
                }
                if (inputT < 0)
                {
                    double result = Math.Abs(inputT);
                    labelField2.Text = result.ToString();
                    labelField1.Text = $"negate({inputT})";
                }
            }
            else
            {
                labelField2.Text = "Дані не підходять";
            }
        }

        private void bResult_Click(object sender, MouseEventArgs e)
        {
            double result = 0;

            double.TryParse(firstOperand, out double vFirstOperand);
            double.TryParse(labelField2.Text, out double vSecondOperand);

            if (currentOperation == " + ")
            {
                result = vFirstOperand + vSecondOperand;
            }
            if (currentOperation == " - ")
            {
                result = vFirstOperand - vSecondOperand;
            }
            if (currentOperation == " / ")
            {
                result = vFirstOperand / vSecondOperand;
            }
            if (currentOperation == " * ")
            {
                result = vFirstOperand * vSecondOperand;
            }
            secondOperand = vSecondOperand.ToString();
            labelField1.Text = firstOperand + currentOperation + secondOperand + " = ";
            labelField2.Text = result.ToString();
            waitSecondOperand = true;
            equal = true;
        }

    }
}