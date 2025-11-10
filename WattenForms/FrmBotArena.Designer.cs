namespace WattenForms
{
    partial class FrmBotArena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBot1WinCount = new System.Windows.Forms.Label();
            this.lblBot2WinCount = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.comboBoxBot1 = new System.Windows.Forms.ComboBox();
            this.comboBoxBot2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAmountOfRounds = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBot1WinCount
            // 
            this.lblBot1WinCount.AutoSize = true;
            this.lblBot1WinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBot1WinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBot1WinCount.Location = new System.Drawing.Point(254, 468);
            this.lblBot1WinCount.Name = "lblBot1WinCount";
            this.lblBot1WinCount.Size = new System.Drawing.Size(87, 95);
            this.lblBot1WinCount.TabIndex = 2;
            this.lblBot1WinCount.Text = "0";
            this.lblBot1WinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBot2WinCount
            // 
            this.lblBot2WinCount.AutoSize = true;
            this.lblBot2WinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBot2WinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBot2WinCount.Location = new System.Drawing.Point(1499, 468);
            this.lblBot2WinCount.Name = "lblBot2WinCount";
            this.lblBot2WinCount.Size = new System.Drawing.Size(87, 95);
            this.lblBot2WinCount.TabIndex = 3;
            this.lblBot2WinCount.Text = "0";
            this.lblBot2WinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.BackColor = System.Drawing.Color.Transparent;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 250F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(632, 190);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(753, 472);
            this.lblVS.TabIndex = 4;
            this.lblVS.Text = "VS";
            // 
            // comboBoxBot1
            // 
            this.comboBoxBot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBot1.FormattingEnabled = true;
            this.comboBoxBot1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "ChatGpt"});
            this.comboBoxBot1.Location = new System.Drawing.Point(163, 190);
            this.comboBoxBot1.Name = "comboBoxBot1";
            this.comboBoxBot1.Size = new System.Drawing.Size(429, 103);
            this.comboBoxBot1.TabIndex = 5;
            // 
            // comboBoxBot2
            // 
            this.comboBoxBot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBot2.FormattingEnabled = true;
            this.comboBoxBot2.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "ChatGpt"});
            this.comboBoxBot2.Location = new System.Drawing.Point(1386, 190);
            this.comboBoxBot2.Name = "comboBoxBot2";
            this.comboBoxBot2.Size = new System.Drawing.Size(429, 103);
            this.comboBoxBot2.TabIndex = 6;
            // 
            // comboBoxAmountOfRounds
            // 
            this.comboBoxAmountOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAmountOfRounds.FormattingEnabled = true;
            this.comboBoxAmountOfRounds.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000",
            "100000",
            "1000000",
            "10000000",
            "100000000",
            "1000000000",
            "10000000000",
            "100000000000"});
            this.comboBoxAmountOfRounds.Location = new System.Drawing.Point(653, 80);
            this.comboBoxAmountOfRounds.Name = "comboBoxAmountOfRounds";
            this.comboBoxAmountOfRounds.Size = new System.Drawing.Size(630, 66);
            this.comboBoxAmountOfRounds.TabIndex = 7;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(807, 676);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(365, 163);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // FrmBotArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2011, 874);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.comboBoxAmountOfRounds);
            this.Controls.Add(this.comboBoxBot2);
            this.Controls.Add(this.comboBoxBot1);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblBot2WinCount);
            this.Controls.Add(this.lblBot1WinCount);
            this.Name = "FrmBotArena";
            this.Text = "FrmBotArena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBot1WinCount;
        private System.Windows.Forms.Label lblBot2WinCount;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.ComboBox comboBoxBot1;
        private System.Windows.Forms.ComboBox comboBoxBot2;
        private System.Windows.Forms.ComboBox comboBoxAmountOfRounds;
        private System.Windows.Forms.Button btnGo;
    }
}