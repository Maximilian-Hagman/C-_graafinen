namespace Laskin
{
    public partial class yksinkertainen_nelilaskin : Form
    {
        public yksinkertainen_nelilaskin()
        {
            InitializeComponent();
        }

        private void LaskeTB_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(LukutYksiTB.Text);
            float luku2 = float.Parse(LukuKaksiTB.Text);
            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    vastaus= luku1 + luku2;
                    break;
                    case "-":
                    vastaus= luku1 - luku2;
                    break;
                    case "*":
                    vastaus= luku1 * luku2;
                    break;
                    case "/":
                    vastaus= luku1 / luku2;
                    break;
                default:
                    Console.WriteLine("Taphtui virhe!");
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }
    }
}