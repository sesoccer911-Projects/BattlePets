namespace BattlePets
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnE = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.petJournalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.combatLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combatLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerHeal = new System.Windows.Forms.Timer(this.components);
            this.lblHealPetsLabel = new System.Windows.Forms.Label();
            this.lblBattleLabel = new System.Windows.Forms.Label();
            this.pbHealTimer = new System.Windows.Forms.ProgressBar();
            this.timerSpawn = new System.Windows.Forms.Timer(this.components);
            this.lblhealtime = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblwildPet2 = new System.Windows.Forms.Label();
            this.lblwildPet1 = new System.Windows.Forms.Label();
            this.lblwildPet3 = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.petTeamButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnE.Location = new System.Drawing.Point(63, 279);
            this.btnE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(24, 23);
            this.btnE.TabIndex = 31;
            this.btnE.Text = "⯈";
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnW.Location = new System.Drawing.Point(15, 279);
            this.btnW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(24, 23);
            this.btnW.TabIndex = 33;
            this.btnW.Text = "⯇";
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnS.Location = new System.Drawing.Point(39, 304);
            this.btnS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(24, 23);
            this.btnS.TabIndex = 32;
            this.btnS.Text = "⯆";
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(165, 375);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 24);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(39, 255);
            this.btnN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(24, 23);
            this.btnN.TabIndex = 30;
            this.btnN.Text = "⯅";
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(237, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.openRecentToolStripMenuItem,
            this.toolStripSeparator1,
            this.toggleMusicToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            this.openRecentToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // toggleMusicToolStripMenuItem
            // 
            this.toggleMusicToolStripMenuItem.Checked = true;
            this.toggleMusicToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleMusicToolStripMenuItem.Name = "toggleMusicToolStripMenuItem";
            this.toggleMusicToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toggleMusicToolStripMenuItem.Text = "Toggle Music";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petJournalToolStripMenuItem1,
            this.toolStripSeparator2,
            this.combatLogToolStripMenuItem1});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // petJournalToolStripMenuItem1
            // 
            this.petJournalToolStripMenuItem1.Name = "petJournalToolStripMenuItem1";
            this.petJournalToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.petJournalToolStripMenuItem1.Text = "Pet Journal";
            this.petJournalToolStripMenuItem1.Click += new System.EventHandler(this.petJournalToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // combatLogToolStripMenuItem1
            // 
            this.combatLogToolStripMenuItem1.Name = "combatLogToolStripMenuItem1";
            this.combatLogToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.combatLogToolStripMenuItem1.Text = "Combat Log";
            this.combatLogToolStripMenuItem1.Click += new System.EventHandler(this.combatLogToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 22);
            this.menuFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petJournalToolStripMenuItem,
            this.combatLogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // petJournalToolStripMenuItem
            // 
            this.petJournalToolStripMenuItem.Name = "petJournalToolStripMenuItem";
            this.petJournalToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.petJournalToolStripMenuItem.Text = "Pet Journal";
            // 
            // combatLogToolStripMenuItem
            // 
            this.combatLogToolStripMenuItem.Name = "combatLogToolStripMenuItem";
            this.combatLogToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.combatLogToolStripMenuItem.Text = "Combat Log";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // timerHeal
            // 
            this.timerHeal.Interval = 1000;
            this.timerHeal.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHealPetsLabel
            // 
            this.lblHealPetsLabel.AutoSize = true;
            this.lblHealPetsLabel.Location = new System.Drawing.Point(114, 283);
            this.lblHealPetsLabel.Name = "lblHealPetsLabel";
            this.lblHealPetsLabel.Size = new System.Drawing.Size(53, 13);
            this.lblHealPetsLabel.TabIndex = 50;
            this.lblHealPetsLabel.Text = "Heal Pets";
            // 
            // lblBattleLabel
            // 
            this.lblBattleLabel.AutoSize = true;
            this.lblBattleLabel.Location = new System.Drawing.Point(185, 284);
            this.lblBattleLabel.Name = "lblBattleLabel";
            this.lblBattleLabel.Size = new System.Drawing.Size(37, 13);
            this.lblBattleLabel.TabIndex = 51;
            this.lblBattleLabel.Text = "Battle!";
            // 
            // pbHealTimer
            // 
            this.pbHealTimer.Location = new System.Drawing.Point(117, 263);
            this.pbHealTimer.Maximum = 300;
            this.pbHealTimer.Name = "pbHealTimer";
            this.pbHealTimer.Size = new System.Drawing.Size(110, 15);
            this.pbHealTimer.TabIndex = 52;
            this.pbHealTimer.Click += new System.EventHandler(this.pbHealTimer_Click);
            // 
            // timerSpawn
            // 
            this.timerSpawn.Enabled = true;
            this.timerSpawn.Interval = 1000;
            this.timerSpawn.Tick += new System.EventHandler(this.timerSpawn_Tick);
            // 
            // lblhealtime
            // 
            this.lblhealtime.AutoSize = true;
            this.lblhealtime.Location = new System.Drawing.Point(114, 247);
            this.lblhealtime.Name = "lblhealtime";
            this.lblhealtime.Size = new System.Drawing.Size(0, 13);
            this.lblhealtime.TabIndex = 53;
            // 
            // btnHeal
            // 
            this.btnHeal.BackgroundImage = global::BattlePets.Properties.Resources.revive_battle_pets;
            this.btnHeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHeal.Location = new System.Drawing.Point(117, 299);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(45, 45);
            this.btnHeal.TabIndex = 48;
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.EnabledChanged += new System.EventHandler(this.btnHeal_EnabledChanged);
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnBattle
            // 
            this.btnBattle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBattle.BackgroundImage = global::BattlePets.Properties.Resources.inv_pet_battlepettraining_greyscale;
            this.btnBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBattle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBattle.Enabled = false;
            this.btnBattle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(182, 299);
            this.btnBattle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(45, 45);
            this.btnBattle.TabIndex = 47;
            this.btnBattle.EnabledChanged += new System.EventHandler(this.btnBattle_EnabledChanged);
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BattlePets.Properties.Resources.GrassTile;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblwildPet2);
            this.panel1.Controls.Add(this.lblwildPet1);
            this.panel1.Controls.Add(this.lblwildPet3);
            this.panel1.Controls.Add(this.lblPet);
            this.panel1.Location = new System.Drawing.Point(10, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 216);
            this.panel1.TabIndex = 43;
            // 
            // lblwildPet2
            // 
            this.lblwildPet2.BackColor = System.Drawing.Color.Transparent;
            this.lblwildPet2.Font = new System.Drawing.Font("Wingdings", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblwildPet2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblwildPet2.Image = global::BattlePets.Properties.Resources.squirtle_grass_sprite;
            this.lblwildPet2.Location = new System.Drawing.Point(27, -2);
            this.lblwildPet2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwildPet2.Name = "lblwildPet2";
            this.lblwildPet2.Size = new System.Drawing.Size(20, 20);
            this.lblwildPet2.TabIndex = 53;
            this.lblwildPet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblwildPet2.Visible = false;
            // 
            // lblwildPet1
            // 
            this.lblwildPet1.BackColor = System.Drawing.Color.Transparent;
            this.lblwildPet1.Font = new System.Drawing.Font("Wingdings", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblwildPet1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblwildPet1.Image = global::BattlePets.Properties.Resources.squirtle_grass_sprite;
            this.lblwildPet1.Location = new System.Drawing.Point(55, -2);
            this.lblwildPet1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwildPet1.Name = "lblwildPet1";
            this.lblwildPet1.Size = new System.Drawing.Size(20, 20);
            this.lblwildPet1.TabIndex = 52;
            this.lblwildPet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblwildPet1.Visible = false;
            // 
            // lblwildPet3
            // 
            this.lblwildPet3.BackColor = System.Drawing.Color.Transparent;
            this.lblwildPet3.Font = new System.Drawing.Font("Wingdings", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblwildPet3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblwildPet3.Image = global::BattlePets.Properties.Resources.squirtle_grass_sprite;
            this.lblwildPet3.Location = new System.Drawing.Point(0, -2);
            this.lblwildPet3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwildPet3.Name = "lblwildPet3";
            this.lblwildPet3.Size = new System.Drawing.Size(20, 20);
            this.lblwildPet3.TabIndex = 51;
            this.lblwildPet3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblwildPet3.Visible = false;
            // 
            // lblPet
            // 
            this.lblPet.BackColor = System.Drawing.Color.Transparent;
            this.lblPet.Font = new System.Drawing.Font("Wingdings", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPet.Image = global::BattlePets.Properties.Resources.trainerSouth;
            this.lblPet.Location = new System.Drawing.Point(100, 100);
            this.lblPet.Margin = new System.Windows.Forms.Padding(5);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(20, 20);
            this.lblPet.TabIndex = 0;
            this.lblPet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTeamButton
            // 
            this.petTeamButton.Location = new System.Drawing.Point(98, 375);
            this.petTeamButton.Name = "petTeamButton";
            this.petTeamButton.Size = new System.Drawing.Size(64, 24);
            this.petTeamButton.TabIndex = 54;
            this.petTeamButton.Text = "Pet Team";
            this.petTeamButton.UseVisualStyleBackColor = true;
            this.petTeamButton.Click += new System.EventHandler(this.petTeamButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(237, 409);
            this.Controls.Add(this.petTeamButton);
            this.Controls.Add(this.lblhealtime);
            this.Controls.Add(this.pbHealTimer);
            this.Controls.Add(this.lblBattleLabel);
            this.Controls.Add(this.lblHealPetsLabel);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Pets";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combatLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toggleMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem petJournalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem combatLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.Timer timerHeal;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Label lblwildPet3;
        private System.Windows.Forms.Label lblHealPetsLabel;
        private System.Windows.Forms.Label lblBattleLabel;
        private System.Windows.Forms.ProgressBar pbHealTimer;
        private System.Windows.Forms.Timer timerSpawn;
        private System.Windows.Forms.Label lblwildPet2;
        private System.Windows.Forms.Label lblwildPet1;
        private System.Windows.Forms.Label lblhealtime;
        private System.Windows.Forms.Button petTeamButton;
    }
}

