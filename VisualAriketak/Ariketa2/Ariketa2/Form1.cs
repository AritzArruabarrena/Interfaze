namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public int i = 0;
        Zenbakiak zenbakia = new Zenbakiak();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (i)
            {
                case 0:
                    label1.Text = "2.zenbakia";
                    zenbakia.a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    i = 1;
                    break;
                case 1:
                    label1.Text = "3.zenbakia";
                    zenbakia.b = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    i = 2;
                    break;
                case 2:
                    label1.Text = "4.zenbakia";
                    zenbakia.c = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    i = 3;
                    break;
                case 3:
                    label1.Text = "Emaitza";
                    zenbakia.d = float.Parse(textBox1.Text);
                    textBox1.Text = "(" + zenbakia.a + " + (" + zenbakia.b + "x2)" + " + (" + zenbakia.c + "x3)" + " + (" + zenbakia.d + "x4)/4 = " + zenbakia.eragiketaluzea().ToString();
                    i++;
                    break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Zenbakia1";
            textBox1.Clear();
            i = 0;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}