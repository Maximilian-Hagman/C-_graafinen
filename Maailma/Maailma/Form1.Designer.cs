namespace Maailma
{
    partial class Maailma
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
            this.TextLB = new System.Windows.Forms.Label();
            this.VaihtoLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLB
            // 
            this.TextLB.AutoSize = true;
            this.TextLB.Location = new System.Drawing.Point(377, 88);
            this.TextLB.Name = "TextLB";
            this.TextLB.Size = new System.Drawing.Size(74, 15);
            this.TextLB.TabIndex = 0;
            this.TextLB.Text = "Hei maailma";
            // 
            // VaihtoLB
            // 
            this.VaihtoLB.Location = new System.Drawing.Point(376, 109);
            this.VaihtoLB.Name = "VaihtoLB";
            this.VaihtoLB.Size = new System.Drawing.Size(75, 23);
            this.VaihtoLB.TabIndex = 1;
            this.VaihtoLB.Text = "Vaihto";
            this.VaihtoLB.UseVisualStyleBackColor = true;
            this.VaihtoLB.Click += new System.EventHandler(this.VaihtoLB_Click);
            // 
            // Maailma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VaihtoLB);
            this.Controls.Add(this.TextLB);
            this.Name = "Maailma";
            this.Text = "Maailma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TextLB;
        private Button VaihtoLB;
    }
}