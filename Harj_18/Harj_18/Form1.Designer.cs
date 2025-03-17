namespace Harj_18
{
    partial class AvainhenkilotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.KatuosoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.oppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TittaliLB = new System.Windows.Forms.Label();
            this.SijaintiLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse oppilaitos:";
            // 
            // KatuosoiteLB
            // 
            this.KatuosoiteLB.AutoSize = true;
            this.KatuosoiteLB.Location = new System.Drawing.Point(12, 87);
            this.KatuosoiteLB.Name = "KatuosoiteLB";
            this.KatuosoiteLB.Size = new System.Drawing.Size(13, 15);
            this.KatuosoiteLB.TabIndex = 1;
            this.KatuosoiteLB.Text = "x";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(12, 102);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(13, 15);
            this.PostinumeroLB.TabIndex = 2;
            this.PostinumeroLB.Text = "x";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(12, 117);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(13, 15);
            this.PostitoimipaikkaLB.TabIndex = 3;
            this.PostitoimipaikkaLB.Text = "x";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(12, 132);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(13, 15);
            this.PuhelinLB.TabIndex = 4;
            this.PuhelinLB.Text = "x";
            // 
            // oppilaitoksetCB
            // 
            this.oppilaitoksetCB.FormattingEnabled = true;
            this.oppilaitoksetCB.Items.AddRange(new object[] {
            "StadinAO",
            "Omnia",
            "Varia",
            "Keuda"});
            this.oppilaitoksetCB.Location = new System.Drawing.Point(12, 61);
            this.oppilaitoksetCB.Name = "oppilaitoksetCB";
            this.oppilaitoksetCB.Size = new System.Drawing.Size(121, 23);
            this.oppilaitoksetCB.TabIndex = 5;
            this.oppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitoksetCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Items.AddRange(new object[] {
            "Sirpa Lindroos",
            "Hanna Laurila",
            "Annele Ranta",
            "Eeva Sahlman",
            "Marko Aaltonen",
            "Tuula Antola",
            "Tapio Siukonen",
            "Tuukko Soini",
            "Riikka-Maria Yli-Suomu",
            "Maija Aaltola",
            "Kai Iivari",
            "Päivi Korhonen",
            "Pekka Tauriainen",
            "Anne Heinonen",
            "Tuula Kiistinen",
            "Tiina Halmevuo",
            "Anna Mari Leinonen",
            "Anne Vuorinen",
            "Hanna Nyrönen",
            "Maarit Flinck"});
            this.vastuuhloCB.Location = new System.Drawing.Point(245, 61);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(121, 23);
            this.vastuuhloCB.TabIndex = 6;
            this.vastuuhloCB.SelectedIndexChanged += new System.EventHandler(this.vastuuhloCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valitse vastuuhenkilö:";
            // 
            // TittaliLB
            // 
            this.TittaliLB.AutoSize = true;
            this.TittaliLB.Location = new System.Drawing.Point(246, 87);
            this.TittaliLB.Name = "TittaliLB";
            this.TittaliLB.Size = new System.Drawing.Size(13, 15);
            this.TittaliLB.TabIndex = 8;
            this.TittaliLB.Text = "x";
            // 
            // SijaintiLB
            // 
            this.SijaintiLB.AutoSize = true;
            this.SijaintiLB.Location = new System.Drawing.Point(245, 102);
            this.SijaintiLB.Name = "SijaintiLB";
            this.SijaintiLB.Size = new System.Drawing.Size(13, 15);
            this.SijaintiLB.TabIndex = 9;
            this.SijaintiLB.Text = "x";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(245, 117);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(13, 15);
            this.EmailLB.TabIndex = 10;
            this.EmailLB.Text = "x";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Location = new System.Drawing.Point(245, 132);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(13, 15);
            this.PhoneLB.TabIndex = 11;
            this.PhoneLB.Text = "x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 38);
            this.label11.TabIndex = 12;
            this.label11.Text = "Oppilaitosten avainhenkilöt";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SijaintiLB);
            this.Controls.Add(this.TittaliLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.oppilaitoksetCB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.KatuosoiteLB);
            this.Controls.Add(this.label1);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label KatuosoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private ComboBox oppilaitoksetCB;
        private ComboBox vastuuhloCB;
        private Label label6;
        private Label TittaliLB;
        private Label SijaintiLB;
        private Label EmailLB;
        private Label PhoneLB;
        private Label label11;
    }
}