namespace Harj_15
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
            this.components = new System.ComponentModel.Container();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.KelloLB = new System.Windows.Forms.Label();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(12, 128);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(119, 65);
            this.StartBT.TabIndex = 0;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(214, 128);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(119, 65);
            this.StopBT.TabIndex = 1;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(415, 128);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(119, 65);
            this.ResetBT.TabIndex = 2;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // KelloLB
            // 
            this.KelloLB.AutoSize = true;
            this.KelloLB.Font = new System.Drawing.Font("Segoe UI", 71F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KelloLB.Location = new System.Drawing.Point(-1, -2);
            this.KelloLB.Name = "KelloLB";
            this.KelloLB.Size = new System.Drawing.Size(576, 127);
            this.KelloLB.TabIndex = 3;
            this.KelloLB.Text = "00:00:00.000";
            // 
            // AjastinTM
            // 
            this.AjastinTM.Enabled = true;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 202);
            this.Controls.Add(this.KelloLB);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
        private Label KelloLB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}