namespace QuestionNo3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            orderToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem1 = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            processingToolStripMenuItem = new ToolStripMenuItem();
            completedToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foodToolStripMenuItem, orderToolStripMenuItem1, processingToolStripMenuItem, completedToolStripMenuItem, exitToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(50, 20);
            orderToolStripMenuItem.Text = "Menu";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem1
            // 
            orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            orderToolStripMenuItem1.Size = new Size(133, 22);
            orderToolStripMenuItem1.Text = "Order";
            orderToolStripMenuItem1.Click += orderToolStripMenuItem1_Click;
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(133, 22);
            foodToolStripMenuItem.Text = "Food";
            foodToolStripMenuItem.Click += foodToolStripMenuItem_Click;
            // 
            // processingToolStripMenuItem
            // 
            processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            processingToolStripMenuItem.Size = new Size(133, 22);
            processingToolStripMenuItem.Text = "Processing";
            processingToolStripMenuItem.Click += processingToolStripMenuItem_Click;
            // 
            // completedToolStripMenuItem
            // 
            completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            completedToolStripMenuItem.Size = new Size(133, 22);
            completedToolStripMenuItem.Text = "Completed";
            completedToolStripMenuItem.Click += completedToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(133, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem1;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem processingToolStripMenuItem;
        private ToolStripMenuItem completedToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
