namespace Lab4
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            

        }
        
        private void Btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text += Btn0.Text;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn1.Text;

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn2.Text;

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

            txtValue.Text = Btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtValue.Text = Btn9.Text;
        }
    }
}
