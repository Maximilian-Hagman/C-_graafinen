namespace Harj_16
{
    partial class AjastinForm
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
            this.minuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.aikaLB = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.StopBT = new System.Windows.Forms.Button();
            this.StartBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minuutitLB.Location = new System.Drawing.Point(12, 9);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(98, 30);
            this.minuutitLB.TabIndex = 0;
            this.minuutitLB.Text = "Minuutit:";
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekunnitLB.Location = new System.Drawing.Point(116, 9);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(101, 30);
            this.SekunnitLB.TabIndex = 1;
            this.SekunnitLB.Text = "Sekunnit:";
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 51.751F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(12, 83);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(207, 93);
            this.aikaLB.TabIndex = 2;
            this.aikaLB.Text = "00:00";
            this.aikaLB.Click += new System.EventHandler(this.aikaLB_Click);
            // 
            // minuutitCB
            // 
            this.minuutitCB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minuutitCB.Location = new System.Drawing.Point(12, 42);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(98, 38);
            this.minuutitCB.TabIndex = 3;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.sekunnitCB.Location = new System.Drawing.Point(116, 42);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(101, 38);
            this.sekunnitCB.TabIndex = 4;
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBT.Location = new System.Drawing.Point(116, 179);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(101, 44);
            this.StopBT.TabIndex = 5;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBT.Location = new System.Drawing.Point(12, 179);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(98, 44);
            this.StartBT.TabIndex = 6;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // AjastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 250);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Name = "AjastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label minuutitLB;
        private Label SekunnitLB;
        private Label aikaLB;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Button StopBT;
        private Button StartBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}