namespace QuestionNo1
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
                int input1, input2;
                if (!int.TryParse(textBox1.Text, out input1))
                {
                    MessageBox.Show("Please enter a valid integer for Input 1.");
                    return;
                }
                if (!int.TryParse(textBox2.Text, out input2))
                {
                    MessageBox.Show("Please enter a valid integer for Input 2.");
                    return;
                }

                int largest = Math.Max(input1, input2); 
                MessageBox.Show("Largest number: " + largest);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                
            }

        }
    }
}
