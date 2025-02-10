namespace Harj_7
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutuksetTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.PolttonesteTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.KilometriCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lainan lyhennykset korkoineen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vakuutusmaksut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Polttoneste:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(28, 220);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pesut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Huollot:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renkaat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kilometrit/vuosi:";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(204, 31);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(100, 23);
            this.LainaTB.TabIndex = 10;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(204, 64);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 23);
            this.NesteetTB.TabIndex = 11;
            this.NesteetTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VakuutuksetTB
            // 
            this.VakuutuksetTB.Location = new System.Drawing.Point(204, 100);
            this.VakuutuksetTB.Name = "VakuutuksetTB";
            this.VakuutuksetTB.Size = new System.Drawing.Size(100, 23);
            this.VakuutuksetTB.TabIndex = 12;
            // 
            // MuutTB
            // 
            this.MuutTB.Location = new System.Drawing.Point(204, 136);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(100, 23);
            this.MuutTB.TabIndex = 13;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.Location = new System.Drawing.Point(204, 175);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(100, 23);
            this.PolttonesteTB.TabIndex = 14;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(431, 31);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(100, 23);
            this.PesutTB.TabIndex = 15;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(431, 67);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 23);
            this.HuollotTB.TabIndex = 16;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(431, 105);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 23);
            this.RenkaatTB.TabIndex = 17;
            // 
            // KilometriCB
            // 
            this.KilometriCB.FormattingEnabled = true;
            this.KilometriCB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "30000",
            "50000",
            "100000"});
            this.KilometriCB.Location = new System.Drawing.Point(431, 141);
            this.KilometriCB.Name = "KilometriCB";
            this.KilometriCB.Size = new System.Drawing.Size(100, 23);
            this.KilometriCB.TabIndex = 18;
            this.KilometriCB.SelectedIndexChanged += new System.EventHandler(this.KilometriCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KilometriCB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.VakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label VastausLB;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox LainaTB;
        private TextBox NesteetTB;
        private TextBox VakuutuksetTB;
        private TextBox MuutTB;
        private TextBox PolttonesteTB;
        private TextBox PesutTB;
        private TextBox HuollotTB;
        private TextBox RenkaatTB;
        private ComboBox KilometriCB;
    }
}