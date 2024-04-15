namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int red = int.Parse(textBox1.Text);
            int green = int.Parse(textBox3.Text);
            int blue = int.Parse(textBox2.Text);
            
            
            
            label4.BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
