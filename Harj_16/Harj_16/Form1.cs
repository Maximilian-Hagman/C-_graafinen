namespace Harj_16
{
    public partial class AjastinForm : Form
    {
        public AjastinForm()
        {
            InitializeComponent();
        }

        private void aikaLB_Click(object sender, EventArgs e)
        {

        }
        private int kokonaisaika;
        private void AjastinForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // Aivan alussa poistetaan Stop-button käytöstä
            for(int i=0; i < 60; i++) 
            {
                minuutitCB.Items.Add(i.ToString()); // Lisämme minuuttehin 0-50
                sekunnitCB.Items.Add(i.ToString()); // Lisämme minuuteihin 0-59
            }
            minuutitCB.SelectedIndex = 0; // Määrittelemme, että oletus on 30
            sekunnitCB.SelectedIndex = 10; // Otetaan Stop-painike käyttöön
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // Poistetaan tämä painike käytöstä
            StopBT.Enabled = true; // Otetaan Stop-painike käyttöön 
            // Lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minuutitCB.SelectedIndex.ToString()); // Haetaan valitut minuutit
            int sekunnnit = int.Parse(sekunnitCB.SelectedIndex.ToString()); // Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; // Otetaan Start-painike käyttöön
            StopBT.Enabled = false; // Poistetaan tämä painike käytöstä
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit + ":" + sekunnit;
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}