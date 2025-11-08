namespace WattenForms
{
    partial class FrmModeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeSelection));
            this.btnPvP = new System.Windows.Forms.Button();
            this.btnBotMedium = new System.Windows.Forms.Button();
            this.btnBotEasy = new System.Windows.Forms.Button();
            this.btnBotHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPvP
            // 
            this.btnPvP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPvP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPvP.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPvP.ForeColor = System.Drawing.Color.White;
            this.btnPvP.Location = new System.Drawing.Point(277, 110);
            this.btnPvP.Name = "btnPvP";
            this.btnPvP.Size = new System.Drawing.Size(238, 68);
            this.btnPvP.TabIndex = 0;
            this.btnPvP.Text = "PvP";
            this.btnPvP.UseVisualStyleBackColor = false;
            this.btnPvP.Click += new System.EventHandler(this.btnPvP_Click);
            // 
            // btnBotMedium
            // 
            this.btnBotMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(13)))));
            this.btnBotMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotMedium.ForeColor = System.Drawing.Color.White;
            this.btnBotMedium.Location = new System.Drawing.Point(281, 242);
            this.btnBotMedium.Name = "btnBotMedium";
            this.btnBotMedium.Size = new System.Drawing.Size(238, 68);
            this.btnBotMedium.TabIndex = 1;
            this.btnBotMedium.Text = "Medium";
            this.btnBotMedium.UseVisualStyleBackColor = false;
            this.btnBotMedium.Click += new System.EventHandler(this.btnBotMedium_Click);
            // 
            // btnBotEasy
            // 
            this.btnBotEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(11)))));
            this.btnBotEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotEasy.ForeColor = System.Drawing.Color.White;
            this.btnBotEasy.Location = new System.Drawing.Point(12, 242);
            this.btnBotEasy.Name = "btnBotEasy";
            this.btnBotEasy.Size = new System.Drawing.Size(238, 68);
            this.btnBotEasy.TabIndex = 2;
            this.btnBotEasy.Text = "Easy\r\n";
            this.btnBotEasy.UseVisualStyleBackColor = false;
            this.btnBotEasy.Click += new System.EventHandler(this.btnBotEasy_Click);
            // 
            // btnBotHard
            // 
            this.btnBotHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(40)))));
            this.btnBotHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotHard.ForeColor = System.Drawing.Color.White;
            this.btnBotHard.Location = new System.Drawing.Point(550, 242);
            this.btnBotHard.Name = "btnBotHard";
            this.btnBotHard.Size = new System.Drawing.Size(238, 68);
            this.btnBotHard.TabIndex = 3;
            this.btnBotHard.Text = "Hard";
            this.btnBotHard.UseVisualStyleBackColor = false;
            this.btnBotHard.Click += new System.EventHandler(this.btnBotHard_Click);
            // 
            // frmModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBotHard);
            this.Controls.Add(this.btnBotEasy);
            this.Controls.Add(this.btnBotMedium);
            this.Controls.Add(this.btnPvP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmModeSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModeSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPvP;
        private System.Windows.Forms.Button btnBotMedium;
        private System.Windows.Forms.Button btnBotEasy;
        private System.Windows.Forms.Button btnBotHard;
    }
}