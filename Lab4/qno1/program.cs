namespace qno1_new_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void compareButton_Click_1(object sender, EventArgs e)
        {
            // Parse the input numbers
            if (double.TryParse(number1TextBox.Text, out double number1) &&
                double.TryParse(number2TextBox.Text, out double number2))
            {
                // Compare the numbers
                if (number1 > number2)
                {
                    MessageBox.Show($"The largest number is: {number1}", "Largest Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (number2 > number1)
                {
                    MessageBox.Show($"The largest number is: {number2}", "Largest Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Both numbers are equal.", "Largest Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





