namespace tpmodul12_2311104012
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(30, 30);
            this.textBox1.Size = new System.Drawing.Size(200, 23);

            // button1
            this.button1.Location = new System.Drawing.Point(30, 70);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Text = "Cek";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 110);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Text = "Cek Bilangan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
