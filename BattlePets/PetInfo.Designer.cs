namespace BattlePets
{
    partial class PetInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetInfo));
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLevelLabel = new System.Windows.Forms.Label();
            this.grpbxAbility2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpbxAbility3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpbxAbility1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAbility1 = new System.Windows.Forms.Button();
            this.lblRarityLabel = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpbxAbilityDesc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinsLabel = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblBattlesFought = new System.Windows.Forms.Label();
            this.lblLossesLabel = new System.Windows.Forms.Label();
            this.lblBattlesFoughtLabel = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblSpeedLabel = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pgBarHealth = new System.Windows.Forms.ProgressBar();
            this.lblHealthLabel = new System.Windows.Forms.Label();
            this.pgBarExperience = new System.Windows.Forms.ProgressBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblExperienceLabel = new System.Windows.Forms.Label();
            this.lblHealthLbl = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPowerLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.grpbxPetInfo = new System.Windows.Forms.GroupBox();
            this.grpbxAbility2.SuspendLayout();
            this.grpbxAbility3.SuspendLayout();
            this.grpbxAbility1.SuspendLayout();
            this.grpbxAbilityDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grpbxPetInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(288, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(232, 329);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 30);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTypeLabel
            // 
            this.lblTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeLabel.AutoSize = true;
            this.lblTypeLabel.Location = new System.Drawing.Point(6, 197);
            this.lblTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeLabel.Name = "lblTypeLabel";
            this.lblTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.lblTypeLabel.TabIndex = 27;
            this.lblTypeLabel.Text = "Type:";
            this.lblTypeLabel.Click += new System.EventHandler(this.lblTypeLabel_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(44, 184);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(26, 13);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "[LV]";
            this.lblLevel.Click += new System.EventHandler(this.lblLevel_Click);
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(44, 197);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 28;
            this.lblType.Text = "[Type]";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblLevelLabel
            // 
            this.lblLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevelLabel.AutoSize = true;
            this.lblLevelLabel.Location = new System.Drawing.Point(6, 184);
            this.lblLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevelLabel.Name = "lblLevelLabel";
            this.lblLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLevelLabel.TabIndex = 20;
            this.lblLevelLabel.Text = "Level:";
            this.lblLevelLabel.Click += new System.EventHandler(this.lblLevelLabel_Click);
            // 
            // grpbxAbility2
            // 
            this.grpbxAbility2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxAbility2.Controls.Add(this.button5);
            this.grpbxAbility2.Controls.Add(this.button2);
            this.grpbxAbility2.Location = new System.Drawing.Point(214, 76);
            this.grpbxAbility2.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxAbility2.Name = "grpbxAbility2";
            this.grpbxAbility2.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxAbility2.Size = new System.Drawing.Size(112, 66);
            this.grpbxAbility2.TabIndex = 14;
            this.grpbxAbility2.TabStop = false;
            this.grpbxAbility2.Text = "Ability 2";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(59, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 48;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(8, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 47;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpbxAbility3
            // 
            this.grpbxAbility3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxAbility3.Controls.Add(this.button6);
            this.grpbxAbility3.Controls.Add(this.button3);
            this.grpbxAbility3.Location = new System.Drawing.Point(214, 140);
            this.grpbxAbility3.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxAbility3.Name = "grpbxAbility3";
            this.grpbxAbility3.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxAbility3.Size = new System.Drawing.Size(112, 66);
            this.grpbxAbility3.TabIndex = 15;
            this.grpbxAbility3.TabStop = false;
            this.grpbxAbility3.Text = "Ability 3";
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(58, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 49;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 48;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grpbxAbility1
            // 
            this.grpbxAbility1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxAbility1.Controls.Add(this.button4);
            this.grpbxAbility1.Controls.Add(this.btnAbility1);
            this.grpbxAbility1.Location = new System.Drawing.Point(214, 10);
            this.grpbxAbility1.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxAbility1.Name = "grpbxAbility1";
            this.grpbxAbility1.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxAbility1.Size = new System.Drawing.Size(112, 66);
            this.grpbxAbility1.TabIndex = 13;
            this.grpbxAbility1.TabStop = false;
            this.grpbxAbility1.Text = "Ability 1";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(7, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 47;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAbility1
            // 
            this.btnAbility1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbility1.BackgroundImage")));
            this.btnAbility1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbility1.Enabled = false;
            this.btnAbility1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbility1.Location = new System.Drawing.Point(58, 16);
            this.btnAbility1.Name = "btnAbility1";
            this.btnAbility1.Size = new System.Drawing.Size(45, 45);
            this.btnAbility1.TabIndex = 46;
            this.btnAbility1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbility1.UseVisualStyleBackColor = true;
            // 
            // lblRarityLabel
            // 
            this.lblRarityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRarityLabel.AutoSize = true;
            this.lblRarityLabel.Location = new System.Drawing.Point(6, 210);
            this.lblRarityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRarityLabel.Name = "lblRarityLabel";
            this.lblRarityLabel.Size = new System.Drawing.Size(37, 13);
            this.lblRarityLabel.TabIndex = 33;
            this.lblRarityLabel.Text = "Rarity:";
            this.lblRarityLabel.Click += new System.EventHandler(this.lblRarityLabel_Click);
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorite.ForeColor = System.Drawing.Color.Red;
            this.lblFavorite.Location = new System.Drawing.Point(128, 140);
            this.lblFavorite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(21, 22);
            this.lblFavorite.TabIndex = 17;
            this.lblFavorite.Text = "♥";
            this.lblFavorite.Visible = false;
            // 
            // lblRarity
            // 
            this.lblRarity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRarity.AutoSize = true;
            this.lblRarity.Location = new System.Drawing.Point(44, 210);
            this.lblRarity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(40, 13);
            this.lblRarity.TabIndex = 34;
            this.lblRarity.Text = "[Rarity]";
            this.lblRarity.Click += new System.EventHandler(this.lblRarity_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 171);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "[Battle Pet Name]";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // grpbxAbilityDesc
            // 
            this.grpbxAbilityDesc.Controls.Add(this.label1);
            this.grpbxAbilityDesc.Controls.Add(this.lblWins);
            this.grpbxAbilityDesc.Controls.Add(this.label2);
            this.grpbxAbilityDesc.Controls.Add(this.lblWinsLabel);
            this.grpbxAbilityDesc.Controls.Add(this.lblLosses);
            this.grpbxAbilityDesc.Controls.Add(this.lblBattlesFought);
            this.grpbxAbilityDesc.Controls.Add(this.lblLossesLabel);
            this.grpbxAbilityDesc.Controls.Add(this.lblBattlesFoughtLabel);
            this.grpbxAbilityDesc.Location = new System.Drawing.Point(172, 199);
            this.grpbxAbilityDesc.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxAbilityDesc.Name = "grpbxAbilityDesc";
            this.grpbxAbilityDesc.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxAbilityDesc.Size = new System.Drawing.Size(154, 75);
            this.grpbxAbilityDesc.TabIndex = 20;
            this.grpbxAbilityDesc.TabStop = false;
            this.grpbxAbilityDesc.Text = "Ability";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "[Speed]";
            // 
            // lblWins
            // 
            this.lblWins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(45, 24);
            this.lblWins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(37, 13);
            this.lblWins.TabIndex = 40;
            this.lblWins.Text = "[Wins]";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Speed:";
            // 
            // lblWinsLabel
            // 
            this.lblWinsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWinsLabel.AutoSize = true;
            this.lblWinsLabel.Location = new System.Drawing.Point(4, 24);
            this.lblWinsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinsLabel.Name = "lblWinsLabel";
            this.lblWinsLabel.Size = new System.Drawing.Size(34, 13);
            this.lblWinsLabel.TabIndex = 39;
            this.lblWinsLabel.Text = "Type:";
            // 
            // lblLosses
            // 
            this.lblLosses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(45, 37);
            this.lblLosses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(46, 13);
            this.lblLosses.TabIndex = 42;
            this.lblLosses.Text = "[Losses]";
            // 
            // lblBattlesFought
            // 
            this.lblBattlesFought.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBattlesFought.AutoSize = true;
            this.lblBattlesFought.Location = new System.Drawing.Point(87, 11);
            this.lblBattlesFought.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBattlesFought.Name = "lblBattlesFought";
            this.lblBattlesFought.Size = new System.Drawing.Size(14, 13);
            this.lblBattlesFought.TabIndex = 38;
            this.lblBattlesFought.Text = "#";
            // 
            // lblLossesLabel
            // 
            this.lblLossesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLossesLabel.AutoSize = true;
            this.lblLossesLabel.Location = new System.Drawing.Point(4, 37);
            this.lblLossesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLossesLabel.Name = "lblLossesLabel";
            this.lblLossesLabel.Size = new System.Drawing.Size(60, 13);
            this.lblLossesLabel.TabIndex = 41;
            this.lblLossesLabel.Text = "Description";
            // 
            // lblBattlesFoughtLabel
            // 
            this.lblBattlesFoughtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBattlesFoughtLabel.AutoSize = true;
            this.lblBattlesFoughtLabel.Location = new System.Drawing.Point(4, 11);
            this.lblBattlesFoughtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBattlesFoughtLabel.Name = "lblBattlesFoughtLabel";
            this.lblBattlesFoughtLabel.Size = new System.Drawing.Size(68, 13);
            this.lblBattlesFoughtLabel.TabIndex = 37;
            this.lblBattlesFoughtLabel.Text = "Ability Name:";
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(6, 171);
            this.lblNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblNameLabel.TabIndex = 0;
            this.lblNameLabel.Text = "Name:";
            this.lblNameLabel.Click += new System.EventHandler(this.lblNameLabel_Click);
            // 
            // lblSpeedLabel
            // 
            this.lblSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeedLabel.AutoSize = true;
            this.lblSpeedLabel.Location = new System.Drawing.Point(6, 223);
            this.lblSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeedLabel.Name = "lblSpeedLabel";
            this.lblSpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.lblSpeedLabel.TabIndex = 35;
            this.lblSpeedLabel.Text = "Speed:";
            this.lblSpeedLabel.Click += new System.EventHandler(this.lblSpeedLabel_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(65, 223);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 13);
            this.lblSpeed.TabIndex = 36;
            this.lblSpeed.Text = "[Speed]";
            this.lblSpeed.Click += new System.EventHandler(this.lblSpeed_Click);
            // 
            // pgBarHealth
            // 
            this.pgBarHealth.Location = new System.Drawing.Point(35, 278);
            this.pgBarHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pgBarHealth.Name = "pgBarHealth";
            this.pgBarHealth.Size = new System.Drawing.Size(291, 18);
            this.pgBarHealth.TabIndex = 29;
            // 
            // lblHealthLabel
            // 
            this.lblHealthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHealthLabel.AutoSize = true;
            this.lblHealthLabel.Location = new System.Drawing.Point(6, 278);
            this.lblHealthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHealthLabel.Name = "lblHealthLabel";
            this.lblHealthLabel.Size = new System.Drawing.Size(25, 13);
            this.lblHealthLabel.TabIndex = 30;
            this.lblHealthLabel.Text = "HP:";
            // 
            // pgBarExperience
            // 
            this.pgBarExperience.Location = new System.Drawing.Point(35, 300);
            this.pgBarExperience.Margin = new System.Windows.Forms.Padding(2);
            this.pgBarExperience.Name = "pgBarExperience";
            this.pgBarExperience.Size = new System.Drawing.Size(291, 18);
            this.pgBarExperience.TabIndex = 31;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BattlePets.Properties.Resources.pet_battle_speed_v7414;
            this.pictureBox4.Location = new System.Drawing.Point(40, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 13);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblExperienceLabel
            // 
            this.lblExperienceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExperienceLabel.AutoSize = true;
            this.lblExperienceLabel.Location = new System.Drawing.Point(6, 300);
            this.lblExperienceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExperienceLabel.Name = "lblExperienceLabel";
            this.lblExperienceLabel.Size = new System.Drawing.Size(24, 13);
            this.lblExperienceLabel.TabIndex = 32;
            this.lblExperienceLabel.Text = "XP:";
            this.lblExperienceLabel.Click += new System.EventHandler(this.lblExperienceLabel_Click);
            // 
            // lblHealthLbl
            // 
            this.lblHealthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHealthLbl.AutoSize = true;
            this.lblHealthLbl.Location = new System.Drawing.Point(6, 236);
            this.lblHealthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHealthLbl.Name = "lblHealthLbl";
            this.lblHealthLbl.Size = new System.Drawing.Size(41, 13);
            this.lblHealthLbl.TabIndex = 40;
            this.lblHealthLbl.Text = "Health:";
            this.lblHealthLbl.Click += new System.EventHandler(this.lblHealthLbl_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(65, 236);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(44, 13);
            this.lblHealth.TabIndex = 41;
            this.lblHealth.Text = "[Health]";
            this.lblHealth.Click += new System.EventHandler(this.lblHealth_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BattlePets.Properties.Resources.pet_battle_health_v7414;
            this.pictureBox5.Location = new System.Drawing.Point(40, 236);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 13);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Power:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPowerLabel
            // 
            this.lblPowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPowerLabel.AutoSize = true;
            this.lblPowerLabel.Location = new System.Drawing.Point(65, 249);
            this.lblPowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPowerLabel.Name = "lblPowerLabel";
            this.lblPowerLabel.Size = new System.Drawing.Size(43, 13);
            this.lblPowerLabel.TabIndex = 44;
            this.lblPowerLabel.Text = "[Power]";
            this.lblPowerLabel.Click += new System.EventHandler(this.lblPowerLabel_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BattlePets.Properties.Resources.pet_battle_power_v7414;
            this.pictureBox6.Location = new System.Drawing.Point(40, 249);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 13);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // grpbxPetInfo
            // 
            this.grpbxPetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxPetInfo.Controls.Add(this.pictureBox6);
            this.grpbxPetInfo.Controls.Add(this.lblPowerLabel);
            this.grpbxPetInfo.Controls.Add(this.label6);
            this.grpbxPetInfo.Controls.Add(this.pictureBox5);
            this.grpbxPetInfo.Controls.Add(this.lblHealth);
            this.grpbxPetInfo.Controls.Add(this.lblHealthLbl);
            this.grpbxPetInfo.Controls.Add(this.lblExperienceLabel);
            this.grpbxPetInfo.Controls.Add(this.pictureBox4);
            this.grpbxPetInfo.Controls.Add(this.pgBarExperience);
            this.grpbxPetInfo.Controls.Add(this.lblHealthLabel);
            this.grpbxPetInfo.Controls.Add(this.pgBarHealth);
            this.grpbxPetInfo.Controls.Add(this.lblSpeed);
            this.grpbxPetInfo.Controls.Add(this.lblSpeedLabel);
            this.grpbxPetInfo.Controls.Add(this.lblNameLabel);
            this.grpbxPetInfo.Controls.Add(this.grpbxAbilityDesc);
            this.grpbxPetInfo.Controls.Add(this.lblName);
            this.grpbxPetInfo.Controls.Add(this.lblRarity);
            this.grpbxPetInfo.Controls.Add(this.lblFavorite);
            this.grpbxPetInfo.Controls.Add(this.lblRarityLabel);
            this.grpbxPetInfo.Controls.Add(this.grpbxAbility1);
            this.grpbxPetInfo.Controls.Add(this.grpbxAbility3);
            this.grpbxPetInfo.Controls.Add(this.grpbxAbility2);
            this.grpbxPetInfo.Controls.Add(this.lblLevelLabel);
            this.grpbxPetInfo.Controls.Add(this.lblType);
            this.grpbxPetInfo.Controls.Add(this.lblLevel);
            this.grpbxPetInfo.Controls.Add(this.lblTypeLabel);
            this.grpbxPetInfo.Location = new System.Drawing.Point(11, 1);
            this.grpbxPetInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxPetInfo.Name = "grpbxPetInfo";
            this.grpbxPetInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxPetInfo.Size = new System.Drawing.Size(330, 326);
            this.grpbxPetInfo.TabIndex = 26;
            this.grpbxPetInfo.TabStop = false;
            this.grpbxPetInfo.Text = "Pet Info";
            this.grpbxPetInfo.Enter += new System.EventHandler(this.grpbxPetInfo_Enter);
            // 
            // PetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 361);
            this.Controls.Add(this.grpbxPetInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PetInfo";
            this.Text = "Battle Pet Info";
            this.grpbxAbility2.ResumeLayout(false);
            this.grpbxAbility3.ResumeLayout(false);
            this.grpbxAbility1.ResumeLayout(false);
            this.grpbxAbilityDesc.ResumeLayout(false);
            this.grpbxAbilityDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grpbxPetInfo.ResumeLayout(false);
            this.grpbxPetInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTypeLabel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLevelLabel;
        private System.Windows.Forms.GroupBox grpbxAbility2;
        private System.Windows.Forms.GroupBox grpbxAbility3;
        private System.Windows.Forms.GroupBox grpbxAbility1;
        private System.Windows.Forms.Label lblRarityLabel;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpbxAbilityDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinsLabel;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblBattlesFought;
        private System.Windows.Forms.Label lblLossesLabel;
        private System.Windows.Forms.Label lblBattlesFoughtLabel;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblSpeedLabel;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ProgressBar pgBarHealth;
        private System.Windows.Forms.Label lblHealthLabel;
        private System.Windows.Forms.ProgressBar pgBarExperience;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblExperienceLabel;
        private System.Windows.Forms.Label lblHealthLbl;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPowerLabel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAbility1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpbxPetInfo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}