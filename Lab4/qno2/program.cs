namespace qno2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findFactorsButton_Click(object sender, EventArgs e)
        {
            // Parse the input number
            if (int.TryParse(numberTextBox.Text, out int number))
            {
                List<int> factors = FindFactors(number);
                DisplayFactors(factors);
            }
            else
            {
                factorsListBox.Items.Clear();
                MessageBox.Show("Invalid input. Please enter a valid integer number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<int> FindFactors(int number)
        {
            List<int> factors = new List<int>();

            // Find factors
            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                    if (i != number / i)
                    {
                        factors.Add(number / i);
                    }
                }
            }

            factors.Sort();
            return factors;
        }

        private void DisplayFactors(List<int> factors)
        {
            factorsListBox.Items.Clear();

            // Display factors
            if (factors.Count > 0)
            {
                foreach (int factor in factors)
                {
                    factorsListBox.Items.Add(factor);
                }
            }
            else
            {
                factorsListBox.Items.Add("No factors found.");
            }
        }
    }
}






