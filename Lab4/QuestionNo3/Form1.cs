namespace QuestionNo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("Order menu clicked!");
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Food menu clicked!");
        }

        private void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Processing menu clicked!");
        }

        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Completed menu clicked!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
