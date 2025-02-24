namespace Harj_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\maximilian.hagman\\source\\repos\\Harj_13\\pojat.txt");
            string[] tyttöt = File.ReadAllLines("C:\\Users\\maximilian.hagman\\source\\repos\\Harj_13\\tyttöt.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poika in pojat) 
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ", suosituin poikiean nimi vuonna 2024";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tyttö in tyttöt)
            {
                if (nimi == tyttö)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ", suosituin tyttöjen nimi vuonna 2024";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false) 
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta :(";
                VastausLB.Visible = true;
            }
        }
    }
}