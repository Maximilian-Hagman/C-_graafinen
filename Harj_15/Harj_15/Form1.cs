using System.Diagnostics;

namespace Harj_15
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }
    }
}