namespace Harj_17
{
    using System.IO;
    public partial class Form1 : Form
    {
        string tiedostoPolku = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Koodi txt-tiedoston avaamiseen
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true, Multiselect = false }) 
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader v1 = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = v1.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true})
                {
                    if(ttk.ShowDialog()==DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(rikasTB.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Voimme käyttää tallenna komentoa tässä
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(rikasTB.Text);
                    }
                }

            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivittysToolStripMenuItem.Checked == true) 
            {
                tekstinKorostusToolStripMenuItem.Checked = false;
                rikasTB.WordWrap = false;
            }
            else
            {
                tekstinKorostusToolStripMenuItem.Checked = true;
                rikasTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rikasTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                rikasTB.Text = "";
            }
            else
            {
                rikasTB.Text = "";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasTB.Text, rikasTB.Font, Brushes.Black, 12, 10);
        }

        private void rikasTB_TextChanged(object sender, EventArgs e)
        {
            if(rikasTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }
    }
}