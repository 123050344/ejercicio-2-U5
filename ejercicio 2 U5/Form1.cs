namespace ejercicio_2_U5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double[,] numbers = new double[2, 1];


            if (double.TryParse(txtnumber1.Text, out numbers[0, 0]) && double.TryParse(txtnumber2.Text, out numbers[1, 0]))
            {

                double result = numbers[0, 0] + numbers[1, 0];


                txttotal.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumber1.Clear();
            txtnumber2.Clear();
            txttotal.Clear();
        }
    }
}