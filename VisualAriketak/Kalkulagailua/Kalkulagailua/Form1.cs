namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnGehitu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show((float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString());
            }catch (FormatException ex) {
                MessageBox.Show("Ezin dira letrak sartu. Zenbakiak izan behar dira");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}