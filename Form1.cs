namespace variasImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = variasImagenes.Properties.Resources.primavera;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = variasImagenes.Properties.Resources.invierno;
        }

        private void buttonVerano_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = variasImagenes.Properties.Resources.verano;
        }

        private void buttonOtono_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = variasImagenes.Properties.Resources.otoño;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
