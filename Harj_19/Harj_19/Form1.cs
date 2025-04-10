namespace Harj_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Meistapanel.Visible = true;
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            Meistapanel.Visible = true;
            Ruoatpanel.Visible = false;
            Juomatpanel.Visible = false;
            Herkutpanel.Visible = false;
            Koripanel.Visible = false;
        }

        private void RuoatBt_Click(object sender, EventArgs e)
        {
            Meistapanel.Visible = false;
            Ruoatpanel.Visible = true;
            Juomatpanel.Visible = false;
            Herkutpanel.Visible = false;
            Koripanel.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            Meistapanel.Visible = false;
            Ruoatpanel.Visible = false;
            Juomatpanel.Visible = true;
            Herkutpanel.Visible = false;
            Koripanel.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            Meistapanel.Visible = false;
            Ruoatpanel.Visible = false;
            Juomatpanel.Visible = false;
            Herkutpanel.Visible = true;
            Koripanel.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            Meistapanel.Visible = false;
            Ruoatpanel.Visible = false;
            Juomatpanel.Visible = false;
            Herkutpanel.Visible = false;
            Koripanel.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}