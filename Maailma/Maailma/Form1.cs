namespace Maailma
{
    public partial class Maailma : Form
    {
        public Maailma()
        {
            InitializeComponent();
        }

        private void VaihtoLB_Click(object sender, EventArgs e)
        {
            if (TextLB.Text == "Heippa maailma!")
            {
                TextLB.Text = "Jotain uutta tekstiä";
            }
            else
            {
                TextLB.Text = "Heippa maailma!";
            }
        }
    }
}