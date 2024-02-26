namespace Snippets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Configurar el text del checkbox
            checkBox1.Text = "Accepto els termes i condicions";
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Comprovar estat del checkbox i obrir messagebox corresponent
            if (checkBox1.Checked)
            {
                MessageBox.Show("Si");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
    }
}
