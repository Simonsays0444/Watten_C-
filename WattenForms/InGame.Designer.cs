namespace WattenForms
{
    partial class InGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.comboBoxCardsPlayer1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCardsPlayer2 = new System.Windows.Forms.ComboBox();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer2WinCount = new System.Windows.Forms.Label();
            this.lblPlayer1WinCount = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnPlayer1Play = new System.Windows.Forms.Button();
            this.btnPlayer2Play = new System.Windows.Forms.Button();
            this.lblRankAndSuitView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCardsPlayer1
            // 
            this.comboBoxCardsPlayer1.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxCardsPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCardsPlayer1.DisplayMember = "Name";
            this.comboBoxCardsPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCardsPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCardsPlayer1.FormattingEnabled = true;
            this.comboBoxCardsPlayer1.Location = new System.Drawing.Point(12, 183);
            this.comboBoxCardsPlayer1.Name = "comboBoxCardsPlayer1";
            this.comboBoxCardsPlayer1.Size = new System.Drawing.Size(334, 56);
            this.comboBoxCardsPlayer1.Sorted = true;
            this.comboBoxCardsPlayer1.TabIndex = 0;
            this.comboBoxCardsPlayer1.SelectedIndexChanged += new System.EventHandler(this.comboBoxCardsPlayer1_SelectedIndexChanged);
            // 
            // comboBoxCardsPlayer2
            // 
            this.comboBoxCardsPlayer2.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxCardsPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCardsPlayer2.DisplayMember = "Name";
            this.comboBoxCardsPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCardsPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCardsPlayer2.FormattingEnabled = true;
            this.comboBoxCardsPlayer2.Location = new System.Drawing.Point(660, 183);
            this.comboBoxCardsPlayer2.Name = "comboBoxCardsPlayer2";
            this.comboBoxCardsPlayer2.Size = new System.Drawing.Size(334, 56);
            this.comboBoxCardsPlayer2.Sorted = true;
            this.comboBoxCardsPlayer2.TabIndex = 1;
            this.comboBoxCardsPlayer2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCardsPlayer2_SelectedIndexChanged);
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(58, 81);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(265, 76);
            this.lblPlayer1Name.TabIndex = 2;
            this.lblPlayer1Name.Text = "Player1";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.Location = new System.Drawing.Point(670, 81);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(265, 76);
            this.lblPlayer2Name.TabIndex = 3;
            this.lblPlayer2Name.Text = "Player2";
            // 
            // lblPlayer2WinCount
            // 
            this.lblPlayer2WinCount.AutoSize = true;
            this.lblPlayer2WinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2WinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2WinCount.Location = new System.Drawing.Point(754, 244);
            this.lblPlayer2WinCount.Name = "lblPlayer2WinCount";
            this.lblPlayer2WinCount.Size = new System.Drawing.Size(148, 161);
            this.lblPlayer2WinCount.TabIndex = 5;
            this.lblPlayer2WinCount.Text = "0";
            // 
            // lblPlayer1WinCount
            // 
            this.lblPlayer1WinCount.AutoSize = true;
            this.lblPlayer1WinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1WinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1WinCount.Location = new System.Drawing.Point(100, 244);
            this.lblPlayer1WinCount.Name = "lblPlayer1WinCount";
            this.lblPlayer1WinCount.Size = new System.Drawing.Size(148, 161);
            this.lblPlayer1WinCount.TabIndex = 4;
            this.lblPlayer1WinCount.Text = "0";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Lime;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(450, 153);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(111, 108);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnPlayer1Play
            // 
            this.btnPlayer1Play.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPlayer1Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayer1Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1Play.ForeColor = System.Drawing.Color.Lime;
            this.btnPlayer1Play.Location = new System.Drawing.Point(351, 183);
            this.btnPlayer1Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayer1Play.Name = "btnPlayer1Play";
            this.btnPlayer1Play.Size = new System.Drawing.Size(92, 53);
            this.btnPlayer1Play.TabIndex = 7;
            this.btnPlayer1Play.Text = ">>>";
            this.btnPlayer1Play.UseVisualStyleBackColor = false;
            this.btnPlayer1Play.Click += new System.EventHandler(this.btnPlayer1Play_Click);
            // 
            // btnPlayer2Play
            // 
            this.btnPlayer2Play.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPlayer2Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayer2Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2Play.ForeColor = System.Drawing.Color.Lime;
            this.btnPlayer2Play.Location = new System.Drawing.Point(566, 183);
            this.btnPlayer2Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayer2Play.Name = "btnPlayer2Play";
            this.btnPlayer2Play.Size = new System.Drawing.Size(92, 53);
            this.btnPlayer2Play.TabIndex = 8;
            this.btnPlayer2Play.Text = "<<<";
            this.btnPlayer2Play.UseVisualStyleBackColor = false;
            this.btnPlayer2Play.Click += new System.EventHandler(this.btnPlayer2Play_Click);
            // 
            // lblRankAndSuitView
            // 
            this.lblRankAndSuitView.AutoSize = true;
            this.lblRankAndSuitView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lblRankAndSuitView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRankAndSuitView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRankAndSuitView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankAndSuitView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRankAndSuitView.Location = new System.Drawing.Point(373, 39);
            this.lblRankAndSuitView.Name = "lblRankAndSuitView";
            this.lblRankAndSuitView.Size = new System.Drawing.Size(243, 80);
            this.lblRankAndSuitView.TabIndex = 9;
            this.lblRankAndSuitView.Text = "Schlag: König\r\nFarbe: Herz";
            this.lblRankAndSuitView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 403);
            this.Controls.Add(this.lblRankAndSuitView);
            this.Controls.Add(this.btnPlayer2Play);
            this.Controls.Add(this.btnPlayer1Play);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblPlayer2WinCount);
            this.Controls.Add(this.lblPlayer1WinCount);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.comboBoxCardsPlayer2);
            this.Controls.Add(this.comboBoxCardsPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCardsPlayer1;
        private System.Windows.Forms.ComboBox comboBoxCardsPlayer2;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2WinCount;
        private System.Windows.Forms.Label lblPlayer1WinCount;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnPlayer1Play;
        private System.Windows.Forms.Button btnPlayer2Play;
        private System.Windows.Forms.Label lblRankAndSuitView;
    }
}