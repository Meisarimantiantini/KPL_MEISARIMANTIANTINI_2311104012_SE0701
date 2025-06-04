using System;
using System.Windows.Forms;

namespace tpmodul12_2311104012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int input))
            {
                label1.Text = CariTandaBilangan(input);
            }
            else
            {
                label1.Text = "Input tidak valid";
            }
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            if (a > 0) return "Positif";
            return "Nol";
        }
    }
}
