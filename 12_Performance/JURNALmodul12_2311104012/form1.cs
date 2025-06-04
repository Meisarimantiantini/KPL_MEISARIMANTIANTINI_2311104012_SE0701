using System;
using System.Windows.Forms;

namespace JURNALmodul12_2311104012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b))
            {
                label1.Text = CariNilaiPangkat(a, b).ToString();
            }
            else
            {
                label1.Text = "Input tidak valid";
            }
        }

        public int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;
            if (b > 10 || a > 100) return -2;

            try
            {
                checked
                {
                    int result = 1;
                    for (int i = 0; i < b; i++)
                        result *= a;
                    return result;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
    }
}
