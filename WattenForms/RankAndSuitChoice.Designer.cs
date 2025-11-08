

namespace WattenForms
{
    partial class RankAndSuitChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankAndSuitChoice));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.comboBoxSuit = new System.Windows.Forms.ComboBox();
            this.listBoxPlayer1 = new System.Windows.Forms.ListBox();
            this.btnShowCardsPlayer1 = new System.Windows.Forms.Button();
            this.btnShowCardsPlayer2 = new System.Windows.Forms.Button();
            this.listBoxPlayer2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(261, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(273, 87);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.BackColor = System.Drawing.Color.Silver;
            this.comboBoxRank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRank.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "Unter",
            "Ober",
            "König",
            "Ass"});
            this.comboBoxRank.Location = new System.Drawing.Point(261, 108);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(273, 37);
            this.comboBoxRank.TabIndex = 1;
            this.comboBoxRank.Text = "Schlag";
            // 
            // comboBoxSuit
            // 
            this.comboBoxSuit.BackColor = System.Drawing.Color.Silver;
            this.comboBoxSuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSuit.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSuit.FormattingEnabled = true;
            this.comboBoxSuit.Items.AddRange(new object[] {
            "Eichel",
            "Blatt",
            "Herz",
            "Schellen"});
            this.comboBoxSuit.Location = new System.Drawing.Point(264, 207);
            this.comboBoxSuit.Name = "comboBoxSuit";
            this.comboBoxSuit.Size = new System.Drawing.Size(273, 37);
            this.comboBoxSuit.TabIndex = 2;
            this.comboBoxSuit.Text = "Farbe";
            // 
            // listBoxPlayer1
            // 
            this.listBoxPlayer1.BackColor = System.Drawing.Color.Silver;
            this.listBoxPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayer1.FormattingEnabled = true;
            this.listBoxPlayer1.ItemHeight = 26;
            this.listBoxPlayer1.Location = new System.Drawing.Point(22, 108);
            this.listBoxPlayer1.Name = "listBoxPlayer1";
            this.listBoxPlayer1.Size = new System.Drawing.Size(200, 212);
            this.listBoxPlayer1.TabIndex = 3;
            // 
            // btnShowCardsPlayer1
            // 
            this.btnShowCardsPlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShowCardsPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCardsPlayer1.Location = new System.Drawing.Point(47, 354);
            this.btnShowCardsPlayer1.Name = "btnShowCardsPlayer1";
            this.btnShowCardsPlayer1.Size = new System.Drawing.Size(148, 51);
            this.btnShowCardsPlayer1.TabIndex = 4;
            this.btnShowCardsPlayer1.Text = "SHOW CARDS";
            this.btnShowCardsPlayer1.UseVisualStyleBackColor = false;
            this.btnShowCardsPlayer1.Click += new System.EventHandler(this.btnShowCardsPlayer1_Click);
            // 
            // btnShowCardsPlayer2
            // 
            this.btnShowCardsPlayer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShowCardsPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCardsPlayer2.Location = new System.Drawing.Point(598, 354);
            this.btnShowCardsPlayer2.Name = "btnShowCardsPlayer2";
            this.btnShowCardsPlayer2.Size = new System.Drawing.Size(148, 51);
            this.btnShowCardsPlayer2.TabIndex = 6;
            this.btnShowCardsPlayer2.Text = "SHOW CARDS";
            this.btnShowCardsPlayer2.UseVisualStyleBackColor = false;
            this.btnShowCardsPlayer2.Click += new System.EventHandler(this.btnShowCardsPlayer2_Click);
            // 
            // listBoxPlayer2
            // 
            this.listBoxPlayer2.BackColor = System.Drawing.Color.Silver;
            this.listBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayer2.FormattingEnabled = true;
            this.listBoxPlayer2.ItemHeight = 26;
            this.listBoxPlayer2.Location = new System.Drawing.Point(573, 108);
            this.listBoxPlayer2.Name = "listBoxPlayer2";
            this.listBoxPlayer2.Size = new System.Drawing.Size(200, 212);
            this.listBoxPlayer2.TabIndex = 5;
            // 
            // RankAndSuitChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowCardsPlayer2);
            this.Controls.Add(this.listBoxPlayer2);
            this.Controls.Add(this.btnShowCardsPlayer1);
            this.Controls.Add(this.listBoxPlayer1);
            this.Controls.Add(this.comboBoxSuit);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RankAndSuitChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RankAndSuitChoice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.ComboBox comboBoxSuit;
        private System.Windows.Forms.ListBox listBoxPlayer1;
        private System.Windows.Forms.Button btnShowCardsPlayer1;
        private System.Windows.Forms.Button btnShowCardsPlayer2;
        private System.Windows.Forms.ListBox listBoxPlayer2;
    }
}