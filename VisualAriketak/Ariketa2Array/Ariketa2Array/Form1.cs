namespace Ariketa2Array
{
    public partial class Form1 : Form
    {
        ZenbakiaArray zenbakia = new ZenbakiaArray();
        float[] zenbakiak = new float[4];
        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    label1.Text = "Zenbakia 2";
                    zenbakiak[0] = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    i = 1;
                    break;
                case 1:
                    label1.Text = "Zenbakia 3";
                    zenbakiak[1] = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    i = 2;
                    break;
                case 2:
                    label1.Text = "Zenbakia 4";
                    zenbakiak[2] = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    i = 3;
                    break;
                case 3:
                    label1.Text = "Emaitza";
                    zenbakiak[3] = float.Parse(textBox1.Text);
                    zenbakia.eragiketaluzea();
                    textBox1.Text = "(" + zenbakiak[0] + " + (" + zenbakiak[1] + "x2)" + " + (" + zenbakiak[2] + "x3)" + " + (" + zenbakiak[3] + "x4)/4 = " + zenbakia.eragiketa.ToString();
                    i++;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Zenbakia 1";
            textBox1.Clear();
            i = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}