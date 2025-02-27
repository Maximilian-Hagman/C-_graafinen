namespace Harj_14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\maximilian.hagman\\source\\repos\\Harj_14\\demoteksti.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\maximilian.hagman\\source\\repos\\Harj_14\\demoteksti.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();
        }
    }
}