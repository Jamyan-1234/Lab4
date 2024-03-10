namespace Lab4
{
    public partial class frmCalculator : Form
    {


        double num1;
        double num2;
        double result;
        string operation;
        double memory;
        double PLUS_memory;


        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }


        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {


        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn0.Text;

        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn1.Text;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn2.Text;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn3.Text;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn4.Text;
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn5.Text;
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn6.Text;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn7.Text;
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn8.Text;
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn9.Text;
        }








        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = double.Parse(txtValue.Text);
            txtValue.Clear();
        }
        private void btnSubtrac_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = double.Parse(txtValue.Text);
            txtValue.Clear();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = double.Parse(txtValue.Text);
            txtValue.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = double.Parse(txtValue.Text);
            txtValue.Clear();
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
            num1 = 0;
            num2 = 0;
            operation = "";
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {

            txtValue.Text = memory.ToString();
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memory = double.Parse(txtValue.Text);
            txtValue.Clear();
        }
        //rr
        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            PLUS_memory = double.Parse(txtValue.Text);
            memory += PLUS_memory;
            txtValue.Clear();
        }

        private void btnPlusMinis_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValue.Text))
            {
                if (txtValue.Text.StartsWith("-"))
                {
                    txtValue.Text = txtValue.Text.Substring(1); 
                }
                else
                {
                    txtValue.Text = "-" + txtValue.Text; 
                }
            }
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!txtValue.Text.Contains("."))
            {
                
                txtValue.Text += ".";
            }
        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {
            operation = "1/x";
            num1 = int.Parse(txtValue.Text);
            double overx = Convert.ToDouble(num1);
            double one = 1.0;
            double new_result = one / overx;
            txtValue.Text = new_result.ToString();


        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            operation = "%";
            num1 = int.Parse(txtValue.Text);
            txtValue.Clear();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            operation = "sqrt";
            num1 = int.Parse(txtValue.Text);
            result = num1 * num1;
            txtValue.Text = result.ToString();

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length > 0)
            {
                txtValue.Text = txtValue.Text.Remove(txtValue.Text.Length - 1);
            }
        }









        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(txtValue.Text);
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        result = num1 / num2;
                        break;
                    case "%":
                        double floatednum1 = Convert.ToDouble(num1);
                        double new_result = (floatednum1 / 100) * num2;
                        result = new_result;
                        break;
                }
                txtValue.Text = result.ToString();
                operation = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Zovhon too oruulna uu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Toog 0-t huvaah bolomjgui", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



    }
}
