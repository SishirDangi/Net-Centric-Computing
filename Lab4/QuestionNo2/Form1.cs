using System;
using System.Windows.Forms;

namespace QuestionNo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                string factors = FindFactors(number);
                MessageBox.Show($"Factors of {number}: {factors}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private string FindFactors(int number)
        {
            if (number <= 0)
                throw new ArgumentException("Number must be a positive integer.");

            string factors = "";
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors += i + " ";
                }
            }
            return factors;
        }
    }
}
