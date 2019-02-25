namespace Part1
{
    partial class Form1
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
            this.inventoryScreen1 = new Part1.InventoryScreen();
            this.gameOverScreen1 = new Part1.GameOverScreen();
            this.startScreen = new Part1.StartScreen();
            this.combat1 = new Part1.Combat();
            this.SuspendLayout();
            // 
            // inventoryScreen1
            // 
            this.inventoryScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryScreen1.Form = null;
            this.inventoryScreen1.Location = new System.Drawing.Point(0, 0);
            this.inventoryScreen1.Name = "inventoryScreen1";
            this.inventoryScreen1.Size = new System.Drawing.Size(635, 442);
            this.inventoryScreen1.TabIndex = 2;
            // 
            // gameOverScreen1
            // 
            this.gameOverScreen1.BackColor = System.Drawing.Color.DarkRed;
            this.gameOverScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverScreen1.Form = null;
            this.gameOverScreen1.Location = new System.Drawing.Point(0, 0);
            this.gameOverScreen1.Name = "gameOverScreen1";
            this.gameOverScreen1.Size = new System.Drawing.Size(635, 442);
            this.gameOverScreen1.TabIndex = 1;
            // 
            // startScreen
            // 
            this.startScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startScreen.Form = null;
            this.startScreen.Location = new System.Drawing.Point(0, 0);
            this.startScreen.Name = "startScreen";
            this.startScreen.Size = new System.Drawing.Size(635, 442);
            this.startScreen.TabIndex = 0;
            // 
            // combat1
            // 
            this.combat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combat1.Form = null;
            this.combat1.Location = new System.Drawing.Point(0, 0);
            this.combat1.Name = "combat1";
            this.combat1.Size = new System.Drawing.Size(635, 442);
            this.combat1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 442);
            this.Controls.Add(this.combat1);
            this.Controls.Add(this.inventoryScreen1);
            this.Controls.Add(this.gameOverScreen1);
            this.Controls.Add(this.startScreen);
            this.Name = "Form1";
            this.Text = "Roguelite P1";
            this.ResumeLayout(false);

        }

        #endregion
        private StartScreen startScreen;
        private GameOverScreen gameOverScreen1;
        private InventoryScreen inventoryScreen1;
        private Combat combat1;
    }
}

