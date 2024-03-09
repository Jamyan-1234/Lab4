namespace Lab4
{
    public partial class frmCalculator : Form
    {


        int num1;
        int num2;
        double result;
        string operation;


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
            num1 = int.Parse(txtValue.Text);
            txtValue.Clear();
        }
        private void btnSubtrac_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(txtValue.Text);
            txtValue.Clear();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(txtValue.Text);
            txtValue.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(txtValue.Text);
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

        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {

        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusMinis_Click(object sender, EventArgs e)
        {

        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {

        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {

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

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

        }









        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtValue.Text);
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
        
        
    }
}
