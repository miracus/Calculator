namespace git_cbs_lesson03_ex06_calculator
{
    public partial class Main : Form
    {
        private string currentNumber;
        public Main()
        {
            InitializeComponent();
            labelField1.Text = "";
            labelField2.Text = "0";
            currentNumber = "";
        }


        private void bPercent_Click(object sender, MouseEventArgs e)
        {

        }

        private void bCE_Click(object sender, MouseEventArgs e)
        {
            labelField1.Text = "";
            labelField2.Text = "0";
        }

        private void bC_Click(object sender, MouseEventArgs e)
        {
            labelField1.Text = "";
            labelField2.Text = "0";
        }

        private void cBackSpace_Click(object sender, MouseEventArgs e)
        {

        }

        private void bOneDivX_Click(object sender, MouseEventArgs e)
        {

        }

        private void bPow2_Click(object sender, MouseEventArgs e)
        {

        }

        private void bSqrt2_Click(object sender, MouseEventArgs e)
        {

        }

        private void bDiv_Click(object sender, MouseEventArgs e)
        {

        }





        private void bMul_Click(object sender, MouseEventArgs e)
        {

        }

        private void bSub_Click(object sender, MouseEventArgs e)
        {

        }

        private void bNumber_Click(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            string numberButton = b.Text;

            if (labelField2.Text != "0")
            {
                labelField2.Text += numberButton;
                return;
            }
            else
            {
                if (numberButton != "0") labelField2.Text = numberButton;
            }
        }

        private void Number_KeyDown(object sender, KeyEventArgs e)
        {
            int keyValue = (int)e.KeyCode;
            if (keyValue >= 48 && keyValue <= 57)
            {
                int number = keyValue - 48;
                HandleNumberPress(number);
            }
        }

        private void HandleNumberPress(int number)
        {
            if (labelField2.Text != "0")
            {
                labelField2.Text += number.ToString();
            }
            else
            {
                if (number != 0)
                {
                    labelField2.Text = number.ToString();
                }
            }
        }




        private void bAdd_Click(object sender, MouseEventArgs e)
        {

        }

        private void bSighInverse_Click(object sender, MouseEventArgs e)
        {

        }



        private void bComma_Click(object sender, MouseEventArgs e)
        {

        }

        private void bResult_Click(object sender, MouseEventArgs e)
        {

        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("x1");
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("x2");
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("x3");
        }
    }
}