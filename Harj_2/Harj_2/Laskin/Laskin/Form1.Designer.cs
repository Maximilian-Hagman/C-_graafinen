namespace Laskin
{
    partial class yksinkertainen_nelilaskin
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
            this.LukuKaksiTB = new System.Windows.Forms.TextBox();
            this.LukutYksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.merkki = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuKaksiTB
            // 
            this.LukuKaksiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuKaksiTB.Location = new System.Drawing.Point(199, 50);
            this.LukuKaksiTB.Name = "LukuKaksiTB";
            this.LukuKaksiTB.Size = new System.Drawing.Size(100, 36);
            this.LukuKaksiTB.TabIndex = 0;
            // 
            // LukutYksiTB
            // 
            this.LukutYksiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukutYksiTB.Location = new System.Drawing.Point(49, 50);
            this.LukutYksiTB.Name = "LukutYksiTB";
            this.LukutYksiTB.Size = new System.Drawing.Size(100, 36);
            this.LukutYksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(155, 50);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(38, 38);
            this.LaskutoimitusCB.TabIndex = 2;
            // 
            // merkki
            // 
            this.merkki.AutoSize = true;
            this.merkki.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.merkki.Location = new System.Drawing.Point(305, 53);
            this.merkki.Name = "merkki";
            this.merkki.Size = new System.Drawing.Size(28, 30);
            this.merkki.TabIndex = 3;
            this.merkki.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(339, 56);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(26, 30);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "X";
            // 
            // LaskeTB
            // 
            this.LaskeTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeTB.Location = new System.Drawing.Point(371, 53);
            this.LaskeTB.Name = "LaskeTB";
            this.LaskeTB.Size = new System.Drawing.Size(97, 37);
            this.LaskeTB.TabIndex = 5;
            this.LaskeTB.Text = "Laske";
            this.LaskeTB.UseVisualStyleBackColor = true;
            this.LaskeTB.Click += new System.EventHandler(this.LaskeTB_Click);
            // 
            // yksinkertainen_nelilaskin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskeTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.merkki);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.LukutYksiTB);
            this.Controls.Add(this.LukuKaksiTB);
            this.Name = "yksinkertainen_nelilaskin";
            this.Text = "laskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LukuKaksiTB;
        private TextBox LukutYksiTB;
        private ComboBox LaskutoimitusCB;
        private Label merkki;
        private Label VastausLB;
        private Button LaskeTB;
    }
}