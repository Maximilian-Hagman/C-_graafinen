namespace Harj_9
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
            this.VastausLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(12, 85);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 0;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(90, 30);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(100, 23);
            this.AsteetTB.TabIndex = 2;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(312, 30);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(75, 23);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(6, 45);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(62, 19);
            this.CelsiusRB.TabIndex = 4;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            this.CelsiusRB.CheckedChanged += new System.EventHandler(this.CelsiusRB_CheckedChanged);
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(6, 22);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(81, 19);
            this.FahrenheitRB.TabIndex = 5;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CelsiusRB);
            this.groupBox1.Controls.Add(this.FahrenheitRB);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 72);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miten muunnat?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 112);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VastausLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label VastausLB;
        private Label label2;
        private TextBox AsteetTB;
        private Button MuunnaBT;
        private RadioButton CelsiusRB;
        private RadioButton FahrenheitRB;
        private GroupBox groupBox1;
    }
}