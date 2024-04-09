namespace NumberComparer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblNumber1
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(26, 26);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(62, 13);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Number 1:";

            // lblNumber2
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(26, 52);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(62, 13);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Number 2:";

            // txtNumber1
            this.txtNumber1.Location = new System.Drawing.Point(94, 23);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 2;

            // txtNumber2
            this.txtNumber2.Location = new System.Drawing.Point(94, 49);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 3;

            // btnCompare
            this.btnCompare.Location = new System.Drawing.Point(29, 89);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(165, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare Numbers";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(26, 135);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 180);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Name = "MainForm";
            this.Text = "Number Comparer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblResult;
    }
}
