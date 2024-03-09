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
            txtValue.Text = "0.";

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0.";

        }
    }
}
