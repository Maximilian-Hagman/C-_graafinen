namespace Harj_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa01PB);
            piirraNoppa(Noppa02PB);

        }
        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa) 
            { 
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01__1_;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02__1_;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03__1_;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04__1_;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05__1_;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06__1_;
                    break;
            }
        }
    }
}