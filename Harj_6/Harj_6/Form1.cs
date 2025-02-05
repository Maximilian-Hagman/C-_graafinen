namespace Harj_6
{
    public partial class SalasanaForm : System.Windows.Forms.Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TarkistaLB_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Pekka" && SalasanaTB.Text == "Pekk@Ko1r@")
            {

                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheLB.Visible = true;
            }
        }

        private void VirheLB_Click(object sender, EventArgs e)
        {

        }
    }
}