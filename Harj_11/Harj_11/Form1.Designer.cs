namespace Harj_11
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
            this.HeitaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeitaBT.Location = new System.Drawing.Point(239, 221);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(259, 46);
            this.HeitaBT.TabIndex = 0;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nopan heitto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::Harj_11.Properties.Resources.rollingDice__1_;
            this.Noppa01PB.Location = new System.Drawing.Point(239, 101);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(119, 113);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 2;
            this.Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Harj_11.Properties.Resources.rollingDice__1_;
            this.Noppa02PB.Location = new System.Drawing.Point(388, 101);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(110, 114);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 3;
            this.Noppa02PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeitaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HeitaBT;
        private Label label1;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
    }
}