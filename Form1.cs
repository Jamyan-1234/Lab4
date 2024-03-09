namespace Lab4
{
    public partial class frmCalculator : Form
    {
        double cdblCurrTotal = 0.0; bool
        cblnReplace = false; string
        cstrLastOperation = "";



        private void CreateValue(string strCurrNum)
        {
            if ((txtValue.Text == "0.") ||
            (txtValue.Text == "") || cblnReplace)
                txtValue.Text = strCurrNum + " ";
            else
                txtValue.Text = txtValue.Text.Substring(0,
                txtValue.Text.Length - 1) + strCurrNum + " ";
            cblnReplace = false;
        }
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
            CreateValue("0");
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            CreateValue("1");
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            CreateValue("2");
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            CreateValue("3");
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            CreateValue("4");
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            CreateValue("5");
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            CreateValue("6");
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            CreateValue("7");
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            CreateValue("8");
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            CreateValue("9");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "+";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (cstrLastOperation)
            {
                case "+":
                    cdblCurrTotal +=
                    Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
                case "-":
                    cdblCurrTotal -=
                    Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
                case "*":
                    cdblCurrTotal *=
                    Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
                case "/":
                    cdblCurrTotal /=
                    Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;

            }

        }




        private void btnSubtrac_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "-";

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "*";

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "/";
        }
    }
}
