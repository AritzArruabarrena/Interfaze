namespace Ariketa2List
{
    public partial class Form1 : Form
    {
        List<Ariketa> zenbakiak = new List<Ariketa>();
        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "1.zenbakia";
            i = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    zenbakiak.Add(new Ariketa(double.Parse(textBox1.Text)));
                    label1.Text = "Zenbakia 2";
                    textBox1.Clear();
                    i = 1;  
                    break;
                    
                case 1:
                    zenbakiak.Add(new Ariketa(double.Parse(textBox1.Text)));
                    label1.Text = "Zenbakia 3";
                    textBox1.Clear();
                    i = 2;
                    break;
                case 2:
                    zenbakiak.Add(new Ariketa(double.Parse(textBox1.Text)));
                    label1.Text = "Zenbakia 4";
                    textBox1.Clear();
                    i = 3;
                    break;
                case 3:
                    zenbakiak.Add(new Ariketa(double.Parse(textBox1.Text)));
                    label1.Text = "Emaitza";
                    textBox1.Text = "(" + zenbakiak[0].Zenbakia + " + (2 x " + zenbakiak[1].Zenbakia + ") + (3 x " + zenbakiak[2].Zenbakia + ") + (4 x " + zenbakiak[3].Zenbakia + ")) / 4 = " + Ariketa.Eragiketa(zenbakiak);
                    break;
            }
        }
    }
}