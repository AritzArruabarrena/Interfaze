using System.Security.Cryptography.X509Certificates;

namespace Ariketa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Esaldia.Esaldiak = textBox1.Text;
            button1.Enabled = false;
            button2.Enabled = true;

        }
    }
}