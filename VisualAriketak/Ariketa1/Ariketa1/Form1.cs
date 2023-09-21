using System.Security.Cryptography.X509Certificates;

namespace Ariketa1
{

    public partial class Form1 : Form
    {
        Esaldia Esaldia = new Esaldia();
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("MESEDEZ SARTU HITZ BAT");
            }
            else
            {
                Esaldia.Esaldiak = textBox1.Text;
                Esaldia.Batu();
                textBox1.Clear();
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("MESEDEZ SARTU HITZ BAT");
            }
            else
            {
                Esaldia.Esaldiak = textBox1.Text;
                Esaldia.Batu();
                textBox1.Clear();
                button2.Enabled = false;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("MESEDEZ SARTU HITZ BAT");
            }
            else
            {
                Esaldia.Esaldiak = textBox1.Text;
                Esaldia.Batu();
                textBox1.Clear();
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("MESEDEZ SARTU HITZ BAT :)");
            }
            else
            {
                Esaldia.Esaldiak = textBox1.Text;
                Esaldia.Batu();
                textBox1.Clear();
                button4.Enabled = false;
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("MESEDEZ SARTU HITZ BAT!!!!!");
            }
            else
            {
                Esaldia.Esaldiak = textBox1.Text;
                Esaldia.Batu();
                textBox1.Clear();
                button5.Enabled = false;
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Esaldia.EsaldiakLotuta);
            button6.Enabled = false;
            
        }
    }
}