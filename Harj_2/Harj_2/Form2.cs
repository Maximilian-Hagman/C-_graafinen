namespace Harj_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiLB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;
        }
    }
}