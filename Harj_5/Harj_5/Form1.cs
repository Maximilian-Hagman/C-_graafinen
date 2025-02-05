namespace Harj_5
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }  

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (uusiLukuTB.Text == "-999")
                    {
                        VastausLB.Text = "";
                        int[] taulukko = jono.ToArray();
                        Array.Sort(taulukko);
                        foreach (var jasen in taulukko)
                        {
                            VastausLB.Text += jasen + " ";
                        }
                        VastausLB.Visible = true;
                    }
                    else
                    {
                        jono.Add(Int32.Parse(uusiLukuTB.Text));
                        uusiLukuTB.Text = "";
                    }
                }
                if (e.KeyChar == (char)Keys.Enter)
                {
                    TyhjaaLomake();
                }
            }
            private void TyhjaaLomake()
            {
                uusiLukuTB.Text = "";
            }
        }
    }
