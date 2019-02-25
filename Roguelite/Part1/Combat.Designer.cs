namespace Part1
{
    partial class Combat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStats = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnGuard = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblEnemyDef = new System.Windows.Forms.Label();
            this.lblEnemyAtk = new System.Windows.Forms.Label();
            this.lblEnemyHp = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.lblPlayDef = new System.Windows.Forms.Label();
            this.lblPlayAtk = new System.Windows.Forms.Label();
            this.lblPlayHp = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.picPlayerHelmet = new System.Windows.Forms.PictureBox();
            this.picPlayerVest = new System.Windows.Forms.PictureBox();
            this.picPlayerWeapon = new System.Windows.Forms.PictureBox();
            this.picPlayerPotion = new System.Windows.Forms.PictureBox();
            this.picEnemyPotion = new System.Windows.Forms.PictureBox();
            this.picEnemyWeapon = new System.Windows.Forms.PictureBox();
            this.picEnemyVest = new System.Windows.Forms.PictureBox();
            this.picEnemyHelmet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerHelmet = new System.Windows.Forms.Label();
            this.lblPlayerVest = new System.Windows.Forms.Label();
            this.lblPlayerWeapon = new System.Windows.Forms.Label();
            this.lblPlayerPotion = new System.Windows.Forms.Label();
            this.lblEnemyHelmet = new System.Windows.Forms.Label();
            this.lblEnemyVest = new System.Windows.Forms.Label();
            this.lblEnemyWeapon = new System.Windows.Forms.Label();
            this.lblEnemyPotion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHelmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerVest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyVest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(44, 93);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 13);
            this.lblStats.TabIndex = 41;
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(381, 288);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(75, 33);
            this.btnHeal.TabIndex = 40;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(243, 348);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 33);
            this.btnInventory.TabIndex = 39;
            this.btnInventory.Text = "Loot";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGuard
            // 
            this.btnGuard.Location = new System.Drawing.Point(261, 286);
            this.btnGuard.Name = "btnGuard";
            this.btnGuard.Size = new System.Drawing.Size(83, 35);
            this.btnGuard.TabIndex = 38;
            this.btnGuard.Text = "Guard";
            this.btnGuard.UseVisualStyleBackColor = true;
            this.btnGuard.Click += new System.EventHandler(this.btnGuard_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(137, 282);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(76, 39);
            this.btnAttack.TabIndex = 37;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblEnemyDef
            // 
            this.lblEnemyDef.AutoSize = true;
            this.lblEnemyDef.Location = new System.Drawing.Point(417, 169);
            this.lblEnemyDef.Name = "lblEnemyDef";
            this.lblEnemyDef.Size = new System.Drawing.Size(31, 13);
            this.lblEnemyDef.TabIndex = 35;
            this.lblEnemyDef.Text = "DEF:";
            // 
            // lblEnemyAtk
            // 
            this.lblEnemyAtk.AutoSize = true;
            this.lblEnemyAtk.Location = new System.Drawing.Point(417, 156);
            this.lblEnemyAtk.Name = "lblEnemyAtk";
            this.lblEnemyAtk.Size = new System.Drawing.Size(31, 13);
            this.lblEnemyAtk.TabIndex = 34;
            this.lblEnemyAtk.Text = "ATK:";
            // 
            // lblEnemyHp
            // 
            this.lblEnemyHp.AutoSize = true;
            this.lblEnemyHp.Location = new System.Drawing.Point(417, 143);
            this.lblEnemyHp.Name = "lblEnemyHp";
            this.lblEnemyHp.Size = new System.Drawing.Size(25, 13);
            this.lblEnemyHp.TabIndex = 33;
            this.lblEnemyHp.Text = "HP:";
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(417, 110);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(39, 13);
            this.lblEnemy.TabIndex = 32;
            this.lblEnemy.Text = "Enemy";
            // 
            // lblPlayDef
            // 
            this.lblPlayDef.AutoSize = true;
            this.lblPlayDef.Location = new System.Drawing.Point(182, 169);
            this.lblPlayDef.Name = "lblPlayDef";
            this.lblPlayDef.Size = new System.Drawing.Size(31, 13);
            this.lblPlayDef.TabIndex = 31;
            this.lblPlayDef.Text = "DEF:";
            // 
            // lblPlayAtk
            // 
            this.lblPlayAtk.AutoSize = true;
            this.lblPlayAtk.Location = new System.Drawing.Point(182, 156);
            this.lblPlayAtk.Name = "lblPlayAtk";
            this.lblPlayAtk.Size = new System.Drawing.Size(31, 13);
            this.lblPlayAtk.TabIndex = 30;
            this.lblPlayAtk.Text = "ATK:";
            // 
            // lblPlayHp
            // 
            this.lblPlayHp.AutoSize = true;
            this.lblPlayHp.Location = new System.Drawing.Point(182, 143);
            this.lblPlayHp.Name = "lblPlayHp";
            this.lblPlayHp.Size = new System.Drawing.Size(25, 13);
            this.lblPlayHp.TabIndex = 29;
            this.lblPlayHp.Text = "HP:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(182, 110);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(26, 13);
            this.lblPlayer.TabIndex = 28;
            this.lblPlayer.Text = "You";
            // 
            // picPlayerHelmet
            // 
            this.picPlayerHelmet.Location = new System.Drawing.Point(30, 56);
            this.picPlayerHelmet.Name = "picPlayerHelmet";
            this.picPlayerHelmet.Size = new System.Drawing.Size(62, 50);
            this.picPlayerHelmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerHelmet.TabIndex = 42;
            this.picPlayerHelmet.TabStop = false;
            // 
            // picPlayerVest
            // 
            this.picPlayerVest.Location = new System.Drawing.Point(30, 132);
            this.picPlayerVest.Name = "picPlayerVest";
            this.picPlayerVest.Size = new System.Drawing.Size(62, 50);
            this.picPlayerVest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerVest.TabIndex = 43;
            this.picPlayerVest.TabStop = false;
            // 
            // picPlayerWeapon
            // 
            this.picPlayerWeapon.Location = new System.Drawing.Point(30, 203);
            this.picPlayerWeapon.Name = "picPlayerWeapon";
            this.picPlayerWeapon.Size = new System.Drawing.Size(62, 50);
            this.picPlayerWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerWeapon.TabIndex = 44;
            this.picPlayerWeapon.TabStop = false;
            // 
            // picPlayerPotion
            // 
            this.picPlayerPotion.Location = new System.Drawing.Point(30, 271);
            this.picPlayerPotion.Name = "picPlayerPotion";
            this.picPlayerPotion.Size = new System.Drawing.Size(62, 50);
            this.picPlayerPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerPotion.TabIndex = 45;
            this.picPlayerPotion.TabStop = false;
            // 
            // picEnemyPotion
            // 
            this.picEnemyPotion.Location = new System.Drawing.Point(540, 271);
            this.picEnemyPotion.Name = "picEnemyPotion";
            this.picEnemyPotion.Size = new System.Drawing.Size(62, 50);
            this.picEnemyPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyPotion.TabIndex = 50;
            this.picEnemyPotion.TabStop = false;
            // 
            // picEnemyWeapon
            // 
            this.picEnemyWeapon.Location = new System.Drawing.Point(540, 203);
            this.picEnemyWeapon.Name = "picEnemyWeapon";
            this.picEnemyWeapon.Size = new System.Drawing.Size(62, 50);
            this.picEnemyWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyWeapon.TabIndex = 49;
            this.picEnemyWeapon.TabStop = false;
            // 
            // picEnemyVest
            // 
            this.picEnemyVest.Location = new System.Drawing.Point(540, 132);
            this.picEnemyVest.Name = "picEnemyVest";
            this.picEnemyVest.Size = new System.Drawing.Size(62, 50);
            this.picEnemyVest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyVest.TabIndex = 48;
            this.picEnemyVest.TabStop = false;
            // 
            // picEnemyHelmet
            // 
            this.picEnemyHelmet.Location = new System.Drawing.Point(540, 56);
            this.picEnemyHelmet.Name = "picEnemyHelmet";
            this.picEnemyHelmet.Size = new System.Drawing.Size(62, 50);
            this.picEnemyHelmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyHelmet.TabIndex = 47;
            this.picEnemyHelmet.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 46;
            // 
            // lblPlayerHelmet
            // 
            this.lblPlayerHelmet.AutoSize = true;
            this.lblPlayerHelmet.Location = new System.Drawing.Point(27, 110);
            this.lblPlayerHelmet.Name = "lblPlayerHelmet";
            this.lblPlayerHelmet.Size = new System.Drawing.Size(40, 13);
            this.lblPlayerHelmet.TabIndex = 52;
            this.lblPlayerHelmet.Text = "Helmet";
            // 
            // lblPlayerVest
            // 
            this.lblPlayerVest.AutoSize = true;
            this.lblPlayerVest.Location = new System.Drawing.Point(27, 185);
            this.lblPlayerVest.Name = "lblPlayerVest";
            this.lblPlayerVest.Size = new System.Drawing.Size(58, 13);
            this.lblPlayerVest.TabIndex = 53;
            this.lblPlayerVest.Text = "BodyArmor";
            // 
            // lblPlayerWeapon
            // 
            this.lblPlayerWeapon.AutoSize = true;
            this.lblPlayerWeapon.Location = new System.Drawing.Point(27, 256);
            this.lblPlayerWeapon.Name = "lblPlayerWeapon";
            this.lblPlayerWeapon.Size = new System.Drawing.Size(48, 13);
            this.lblPlayerWeapon.TabIndex = 54;
            this.lblPlayerWeapon.Text = "Weapon";
            // 
            // lblPlayerPotion
            // 
            this.lblPlayerPotion.AutoSize = true;
            this.lblPlayerPotion.Location = new System.Drawing.Point(27, 324);
            this.lblPlayerPotion.Name = "lblPlayerPotion";
            this.lblPlayerPotion.Size = new System.Drawing.Size(37, 13);
            this.lblPlayerPotion.TabIndex = 55;
            this.lblPlayerPotion.Text = "Potion";
            // 
            // lblEnemyHelmet
            // 
            this.lblEnemyHelmet.AutoSize = true;
            this.lblEnemyHelmet.Location = new System.Drawing.Point(537, 109);
            this.lblEnemyHelmet.Name = "lblEnemyHelmet";
            this.lblEnemyHelmet.Size = new System.Drawing.Size(35, 13);
            this.lblEnemyHelmet.TabIndex = 56;
            this.lblEnemyHelmet.Text = "label7";
            // 
            // lblEnemyVest
            // 
            this.lblEnemyVest.AutoSize = true;
            this.lblEnemyVest.Location = new System.Drawing.Point(537, 185);
            this.lblEnemyVest.Name = "lblEnemyVest";
            this.lblEnemyVest.Size = new System.Drawing.Size(70, 13);
            this.lblEnemyVest.TabIndex = 57;
            this.lblEnemyVest.Text = "lblEnemyVest";
            // 
            // lblEnemyWeapon
            // 
            this.lblEnemyWeapon.AutoSize = true;
            this.lblEnemyWeapon.Location = new System.Drawing.Point(537, 256);
            this.lblEnemyWeapon.Name = "lblEnemyWeapon";
            this.lblEnemyWeapon.Size = new System.Drawing.Size(35, 13);
            this.lblEnemyWeapon.TabIndex = 58;
            this.lblEnemyWeapon.Text = "label9";
            // 
            // lblEnemyPotion
            // 
            this.lblEnemyPotion.AutoSize = true;
            this.lblEnemyPotion.Location = new System.Drawing.Point(537, 324);
            this.lblEnemyPotion.Name = "lblEnemyPotion";
            this.lblEnemyPotion.Size = new System.Drawing.Size(41, 13);
            this.lblEnemyPotion.TabIndex = 59;
            this.lblEnemyPotion.Text = "label10";
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEnemyPotion);
            this.Controls.Add(this.lblEnemyWeapon);
            this.Controls.Add(this.lblEnemyVest);
            this.Controls.Add(this.lblEnemyHelmet);
            this.Controls.Add(this.lblPlayerPotion);
            this.Controls.Add(this.lblPlayerWeapon);
            this.Controls.Add(this.lblPlayerVest);
            this.Controls.Add(this.lblPlayerHelmet);
            this.Controls.Add(this.picEnemyPotion);
            this.Controls.Add(this.picEnemyWeapon);
            this.Controls.Add(this.picEnemyVest);
            this.Controls.Add(this.picEnemyHelmet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPlayerPotion);
            this.Controls.Add(this.picPlayerWeapon);
            this.Controls.Add(this.picPlayerVest);
            this.Controls.Add(this.picPlayerHelmet);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnGuard);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblEnemyDef);
            this.Controls.Add(this.lblEnemyAtk);
            this.Controls.Add(this.lblEnemyHp);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblPlayDef);
            this.Controls.Add(this.lblPlayAtk);
            this.Controls.Add(this.lblPlayHp);
            this.Controls.Add(this.lblPlayer);
            this.Name = "Combat";
            this.Size = new System.Drawing.Size(656, 479);
            this.VisibleChanged += new System.EventHandler(this.Combat_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHelmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerVest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyVest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyHelmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnGuard;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblEnemyDef;
        private System.Windows.Forms.Label lblEnemyAtk;
        private System.Windows.Forms.Label lblEnemyHp;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Label lblPlayDef;
        private System.Windows.Forms.Label lblPlayAtk;
        private System.Windows.Forms.Label lblPlayHp;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox picPlayerHelmet;
        private System.Windows.Forms.PictureBox picPlayerVest;
        private System.Windows.Forms.PictureBox picPlayerWeapon;
        private System.Windows.Forms.PictureBox picPlayerPotion;
        private System.Windows.Forms.PictureBox picEnemyPotion;
        private System.Windows.Forms.PictureBox picEnemyWeapon;
        private System.Windows.Forms.PictureBox picEnemyVest;
        private System.Windows.Forms.PictureBox picEnemyHelmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerHelmet;
        private System.Windows.Forms.Label lblPlayerVest;
        private System.Windows.Forms.Label lblPlayerWeapon;
        private System.Windows.Forms.Label lblPlayerPotion;
        private System.Windows.Forms.Label lblEnemyHelmet;
        private System.Windows.Forms.Label lblEnemyVest;
        private System.Windows.Forms.Label lblEnemyWeapon;
        private System.Windows.Forms.Label lblEnemyPotion;
    }
}
