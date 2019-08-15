namespace BattlePets
{
    partial class BattleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleScreen));
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.lblCapture = new System.Windows.Forms.Label();
            this.lblSwap = new System.Windows.Forms.Label();
            this.lblSkip = new System.Windows.Forms.Label();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.btnPet1 = new System.Windows.Forms.Button();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f2T5DataSet = new BattlePets.F2T5DataSet();
            this.btnPet2 = new System.Windows.Forms.Button();
            this.btnPet3 = new System.Windows.Forms.Button();
            this.btnPet4 = new System.Windows.Forms.Button();
            this.pbPet4HP = new System.Windows.Forms.ProgressBar();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.BtnRun = new System.Windows.Forms.Button();
            this.btnAbility3 = new System.Windows.Forms.Button();
            this.btnAbility2 = new System.Windows.Forms.Button();
            this.btnAbility1 = new System.Windows.Forms.Button();
            this.pbPet3HP = new System.Windows.Forms.ProgressBar();
            this.pbPet2HP = new System.Windows.Forms.ProgressBar();
            this.pbPet1HP = new System.Windows.Forms.ProgressBar();
            this.tmrBattle = new System.Windows.Forms.Timer(this.components);
            this.gpbxPet1 = new System.Windows.Forms.GroupBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.pbHealth1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPetType1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPetFamily1 = new System.Windows.Forms.Label();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxPet2 = new System.Windows.Forms.GroupBox();
            this.pbHealth2 = new System.Windows.Forms.ProgressBar();
            this.lblName2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPetType2 = new System.Windows.Forms.Label();
            this.grpbxPetText2 = new System.Windows.Forms.GroupBox();
            this.lblPetFamily2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpbxTimer = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.petTableAdapter = new BattlePets.F2T5DataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new BattlePets.F2T5DataSetTableAdapters.TableAdapterManager();
            this.typeTableAdapter = new BattlePets.F2T5DataSetTableAdapters.TypeTableAdapter();
            this.grpbxWeather = new System.Windows.Forms.GroupBox();
            this.pbPet1 = new System.Windows.Forms.PictureBox();
            this.pbPet2 = new System.Windows.Forms.PictureBox();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.gbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2T5DataSet)).BeginInit();
            this.gpbxPet1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.grpbxPet2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbxPetText2.SuspendLayout();
            this.grpbxTimer.SuspendLayout();
            this.grpbxWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.lblCapture);
            this.gbButtons.Controls.Add(this.lblSwap);
            this.gbButtons.Controls.Add(this.lblSkip);
            this.gbButtons.Controls.Add(this.lblRun);
            this.gbButtons.Controls.Add(this.lblSubmit);
            this.gbButtons.Controls.Add(this.btnPet1);
            this.gbButtons.Controls.Add(this.btnPet2);
            this.gbButtons.Controls.Add(this.btnPet3);
            this.gbButtons.Controls.Add(this.btnPet4);
            this.gbButtons.Controls.Add(this.pbPet4HP);
            this.gbButtons.Controls.Add(this.btnSwap);
            this.gbButtons.Controls.Add(this.btnPass);
            this.gbButtons.Controls.Add(this.btnSubmit);
            this.gbButtons.Controls.Add(this.btnCapture);
            this.gbButtons.Controls.Add(this.BtnRun);
            this.gbButtons.Controls.Add(this.btnAbility3);
            this.gbButtons.Controls.Add(this.btnAbility2);
            this.gbButtons.Controls.Add(this.btnAbility1);
            this.gbButtons.Controls.Add(this.pbPet3HP);
            this.gbButtons.Controls.Add(this.pbPet2HP);
            this.gbButtons.Controls.Add(this.pbPet1HP);
            this.gbButtons.Location = new System.Drawing.Point(12, 312);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(480, 120);
            this.gbButtons.TabIndex = 0;
            this.gbButtons.TabStop = false;
            // 
            // lblCapture
            // 
            this.lblCapture.AutoSize = true;
            this.lblCapture.Location = new System.Drawing.Point(425, 0);
            this.lblCapture.Name = "lblCapture";
            this.lblCapture.Size = new System.Drawing.Size(44, 13);
            this.lblCapture.TabIndex = 41;
            this.lblCapture.Text = "Capture";
            // 
            // lblSwap
            // 
            this.lblSwap.AutoSize = true;
            this.lblSwap.Location = new System.Drawing.Point(8, 0);
            this.lblSwap.Name = "lblSwap";
            this.lblSwap.Size = new System.Drawing.Size(34, 13);
            this.lblSwap.TabIndex = 40;
            this.lblSwap.Text = "Swap";
            // 
            // lblSkip
            // 
            this.lblSkip.AutoSize = true;
            this.lblSkip.Location = new System.Drawing.Point(267, 57);
            this.lblSkip.Name = "lblSkip";
            this.lblSkip.Size = new System.Drawing.Size(53, 13);
            this.lblSkip.TabIndex = 39;
            this.lblSkip.Text = "Skip Turn";
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(213, 57);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(56, 13);
            this.lblRun.TabIndex = 38;
            this.lblRun.Text = "Run Away";
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Location = new System.Drawing.Point(168, 57);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(39, 13);
            this.lblSubmit.TabIndex = 37;
            this.lblSubmit.Text = "Submit";
            // 
            // btnPet1
            // 
            this.btnPet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPet1.BackgroundImage")));
            this.btnPet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPet1.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundImage", this.petBindingSource, "PetPic", true));
            this.btnPet1.Enabled = false;
            this.btnPet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPet1.Location = new System.Drawing.Point(6, 71);
            this.btnPet1.Name = "btnPet1";
            this.btnPet1.Size = new System.Drawing.Size(45, 45);
            this.btnPet1.TabIndex = 5;
            this.btnPet1.Text = "\r\n";
            this.btnPet1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPet1.UseVisualStyleBackColor = true;
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.f2T5DataSet;
            // 
            // f2T5DataSet
            // 
            this.f2T5DataSet.DataSetName = "F2T5DataSet";
            this.f2T5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPet2
            // 
            this.btnPet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPet2.BackgroundImage")));
            this.btnPet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPet2.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundImage", this.petBindingSource, "PetPic", true));
            this.btnPet2.Enabled = false;
            this.btnPet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPet2.Location = new System.Drawing.Point(57, 71);
            this.btnPet2.Name = "btnPet2";
            this.btnPet2.Size = new System.Drawing.Size(45, 45);
            this.btnPet2.TabIndex = 4;
            this.btnPet2.Text = "\r\n";
            this.btnPet2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPet2.UseVisualStyleBackColor = true;
            // 
            // btnPet3
            // 
            this.btnPet3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPet3.BackgroundImage")));
            this.btnPet3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPet3.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundImage", this.petBindingSource, "PetPic", true));
            this.btnPet3.Enabled = false;
            this.btnPet3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPet3.Location = new System.Drawing.Point(108, 71);
            this.btnPet3.Name = "btnPet3";
            this.btnPet3.Size = new System.Drawing.Size(45, 45);
            this.btnPet3.TabIndex = 3;
            this.btnPet3.Text = "\r\n";
            this.btnPet3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPet3.UseVisualStyleBackColor = true;
            // 
            // btnPet4
            // 
            this.btnPet4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPet4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPet4.BackgroundImage")));
            this.btnPet4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPet4.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundImage", this.petBindingSource, "PetPic", true));
            this.btnPet4.Enabled = false;
            this.btnPet4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPet4.Location = new System.Drawing.Point(426, 71);
            this.btnPet4.Name = "btnPet4";
            this.btnPet4.Size = new System.Drawing.Size(45, 45);
            this.btnPet4.TabIndex = 31;
            this.btnPet4.Text = "\r\n";
            this.btnPet4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPet4.UseVisualStyleBackColor = true;
            // 
            // pbPet4HP
            // 
            this.pbPet4HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPet4HP.BackColor = System.Drawing.Color.Green;
            this.pbPet4HP.ForeColor = System.Drawing.Color.DarkGreen;
            this.pbPet4HP.Location = new System.Drawing.Point(426, 60);
            this.pbPet4HP.Name = "pbPet4HP";
            this.pbPet4HP.Size = new System.Drawing.Size(45, 13);
            this.pbPet4HP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPet4HP.TabIndex = 36;
            // 
            // btnSwap
            // 
            this.btnSwap.BackgroundImage = global::BattlePets.Properties.Resources.ability_hunter_pet_goto;
            this.btnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwap.Enabled = false;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.Location = new System.Drawing.Point(6, 13);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(45, 45);
            this.btnSwap.TabIndex = 24;
            this.btnSwap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Yellow;
            this.btnPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPass.BackgroundImage")));
            this.btnPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPass.Enabled = false;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Location = new System.Drawing.Point(270, 71);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(45, 45);
            this.btnPass.TabIndex = 22;
            this.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.BackgroundImage = global::BattlePets.Properties.Resources.killcommand_v7337;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(168, 71);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(45, 45);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapture.BackgroundImage")));
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapture.Enabled = false;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Location = new System.Drawing.Point(426, 13);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(45, 45);
            this.btnCapture.TabIndex = 23;
            this.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.BackColor = System.Drawing.Color.Firebrick;
            this.BtnRun.BackgroundImage = global::BattlePets.Properties.Resources.sprint_v7337;
            this.BtnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRun.Enabled = false;
            this.BtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRun.Location = new System.Drawing.Point(219, 71);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(45, 45);
            this.BtnRun.TabIndex = 20;
            this.BtnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRun.UseVisualStyleBackColor = false;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnAbility3
            // 
            this.btnAbility3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbility3.BackgroundImage")));
            this.btnAbility3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbility3.Enabled = false;
            this.btnAbility3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbility3.Location = new System.Drawing.Point(270, 9);
            this.btnAbility3.Name = "btnAbility3";
            this.btnAbility3.Size = new System.Drawing.Size(45, 45);
            this.btnAbility3.TabIndex = 19;
            this.btnAbility3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbility3.UseVisualStyleBackColor = true;
            this.btnAbility3.EnabledChanged += new System.EventHandler(this.btnAbility3_EnabledChanged);
            this.btnAbility3.Click += new System.EventHandler(this.btnAbility3_Click);
            // 
            // btnAbility2
            // 
            this.btnAbility2.BackgroundImage = global::BattlePets.Properties.Resources.ability_iyyokuk_sword_white;
            this.btnAbility2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbility2.Enabled = false;
            this.btnAbility2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbility2.Location = new System.Drawing.Point(219, 9);
            this.btnAbility2.Name = "btnAbility2";
            this.btnAbility2.Size = new System.Drawing.Size(45, 45);
            this.btnAbility2.TabIndex = 18;
            this.btnAbility2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbility2.UseVisualStyleBackColor = true;
            this.btnAbility2.EnabledChanged += new System.EventHandler(this.btnAbility2_EnabledChanged);
            this.btnAbility2.Click += new System.EventHandler(this.btnAbility2_Click);
            // 
            // btnAbility1
            // 
            this.btnAbility1.BackgroundImage = global::BattlePets.Properties.Resources.ability_iyyokuk_sword_white1;
            this.btnAbility1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbility1.Enabled = false;
            this.btnAbility1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbility1.Location = new System.Drawing.Point(168, 9);
            this.btnAbility1.Name = "btnAbility1";
            this.btnAbility1.Size = new System.Drawing.Size(45, 45);
            this.btnAbility1.TabIndex = 17;
            this.btnAbility1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbility1.UseVisualStyleBackColor = true;
            this.btnAbility1.EnabledChanged += new System.EventHandler(this.btnAbility1_EnabledChanged);
            this.btnAbility1.Click += new System.EventHandler(this.btnAbility1_Click);
            // 
            // pbPet3HP
            // 
            this.pbPet3HP.Location = new System.Drawing.Point(108, 60);
            this.pbPet3HP.Name = "pbPet3HP";
            this.pbPet3HP.Size = new System.Drawing.Size(45, 13);
            this.pbPet3HP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPet3HP.TabIndex = 10;
            // 
            // pbPet2HP
            // 
            this.pbPet2HP.Location = new System.Drawing.Point(57, 60);
            this.pbPet2HP.Name = "pbPet2HP";
            this.pbPet2HP.Size = new System.Drawing.Size(45, 13);
            this.pbPet2HP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPet2HP.TabIndex = 9;
            // 
            // pbPet1HP
            // 
            this.pbPet1HP.Location = new System.Drawing.Point(6, 60);
            this.pbPet1HP.Name = "pbPet1HP";
            this.pbPet1HP.Size = new System.Drawing.Size(45, 13);
            this.pbPet1HP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPet1HP.TabIndex = 8;
            // 
            // tmrBattle
            // 
            this.tmrBattle.Enabled = true;
            this.tmrBattle.Interval = 1000;
            this.tmrBattle.Tick += new System.EventHandler(this.tmrBattle_Tick);
            // 
            // gpbxPet1
            // 
            this.gpbxPet1.Controls.Add(this.lblName1);
            this.gpbxPet1.Controls.Add(this.pbHealth1);
            this.gpbxPet1.Location = new System.Drawing.Point(12, 12);
            this.gpbxPet1.Name = "gpbxPet1";
            this.gpbxPet1.Size = new System.Drawing.Size(305, 101);
            this.gpbxPet1.TabIndex = 4;
            this.gpbxPet1.TabStop = false;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.lblName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lblName1.Location = new System.Drawing.Point(6, 30);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(83, 29);
            this.lblName1.TabIndex = 22;
            this.lblName1.Text = "Name1";
            // 
            // pbHealth1
            // 
            this.pbHealth1.BackColor = System.Drawing.Color.Green;
            this.pbHealth1.ForeColor = System.Drawing.Color.DarkGreen;
            this.pbHealth1.Location = new System.Drawing.Point(3, 9);
            this.pbHealth1.MarqueeAnimationSpeed = 10;
            this.pbHealth1.Name = "pbHealth1";
            this.pbHealth1.Size = new System.Drawing.Size(175, 20);
            this.pbHealth1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbHealth1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lblPetType1);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 38);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // lblPetType1
            // 
            this.lblPetType1.AutoSize = true;
            this.lblPetType1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "TypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "ERROR TYPE"));
            this.lblPetType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPetType1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetType1.Location = new System.Drawing.Point(3, 16);
            this.lblPetType1.Name = "lblPetType1";
            this.lblPetType1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPetType1.Size = new System.Drawing.Size(0, 22);
            this.lblPetType1.TabIndex = 34;
            this.lblPetType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.lblPetFamily1);
            this.groupBox3.Location = new System.Drawing.Point(103, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 38);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // lblPetFamily1
            // 
            this.lblPetFamily1.AutoSize = true;
            this.lblPetFamily1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBindingSource, "TypeName", true));
            this.lblPetFamily1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPetFamily1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblPetFamily1.Location = new System.Drawing.Point(3, 16);
            this.lblPetFamily1.Name = "lblPetFamily1";
            this.lblPetFamily1.Size = new System.Drawing.Size(88, 22);
            this.lblPetFamily1.TabIndex = 33;
            this.lblPetFamily1.Text = "Pet Family";
            this.lblPetFamily1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.f2T5DataSet;
            // 
            // grpbxPet2
            // 
            this.grpbxPet2.Controls.Add(this.pbHealth2);
            this.grpbxPet2.Controls.Add(this.lblName2);
            this.grpbxPet2.Location = new System.Drawing.Point(311, 12);
            this.grpbxPet2.Name = "grpbxPet2";
            this.grpbxPet2.Size = new System.Drawing.Size(181, 75);
            this.grpbxPet2.TabIndex = 26;
            this.grpbxPet2.TabStop = false;
            // 
            // pbHealth2
            // 
            this.pbHealth2.BackColor = System.Drawing.Color.Green;
            this.pbHealth2.ForeColor = System.Drawing.Color.DarkGreen;
            this.pbHealth2.Location = new System.Drawing.Point(5, 9);
            this.pbHealth2.Name = "pbHealth2";
            this.pbHealth2.Size = new System.Drawing.Size(175, 20);
            this.pbHealth2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbHealth2.TabIndex = 31;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.lblName2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lblName2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName2.Location = new System.Drawing.Point(94, 30);
            this.lblName2.Name = "lblName2";
            this.lblName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName2.Size = new System.Drawing.Size(83, 29);
            this.lblName2.TabIndex = 32;
            this.lblName2.Text = "Name2";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblPetType2);
            this.groupBox1.Location = new System.Drawing.Point(311, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 38);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // lblPetType2
            // 
            this.lblPetType2.AutoSize = true;
            this.lblPetType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPetType2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetType2.Location = new System.Drawing.Point(3, 16);
            this.lblPetType2.Name = "lblPetType2";
            this.lblPetType2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPetType2.Size = new System.Drawing.Size(75, 22);
            this.lblPetType2.TabIndex = 34;
            this.lblPetType2.Text = "Pet Type";
            this.lblPetType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbxPetText2
            // 
            this.grpbxPetText2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpbxPetText2.Controls.Add(this.lblPetFamily2);
            this.grpbxPetText2.Location = new System.Drawing.Point(402, 74);
            this.grpbxPetText2.Name = "grpbxPetText2";
            this.grpbxPetText2.Size = new System.Drawing.Size(90, 38);
            this.grpbxPetText2.TabIndex = 26;
            this.grpbxPetText2.TabStop = false;
            // 
            // lblPetFamily2
            // 
            this.lblPetFamily2.AutoSize = true;
            this.lblPetFamily2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBindingSource, "TypeName", true));
            this.lblPetFamily2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPetFamily2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblPetFamily2.Location = new System.Drawing.Point(3, 16);
            this.lblPetFamily2.Name = "lblPetFamily2";
            this.lblPetFamily2.Size = new System.Drawing.Size(88, 22);
            this.lblPetFamily2.TabIndex = 33;
            this.lblPetFamily2.Text = "Pet Family";
            this.lblPetFamily2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(3, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(109, 32);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbxTimer
            // 
            this.grpbxTimer.Controls.Add(this.lblTimer);
            this.grpbxTimer.Controls.Add(this.lblTime);
            this.grpbxTimer.Location = new System.Drawing.Point(195, 12);
            this.grpbxTimer.Name = "grpbxTimer";
            this.grpbxTimer.Size = new System.Drawing.Size(115, 100);
            this.grpbxTimer.TabIndex = 35;
            this.grpbxTimer.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gold;
            this.lblTimer.Location = new System.Drawing.Point(3, 48);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(109, 49);
            this.lblTimer.TabIndex = 29;
            this.lblTimer.Text = "00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbilityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Combat_LogTableAdapter = null;
            this.tableAdapterManager.PetStorageTableAdapter = null;
            this.tableAdapterManager.PetTableAdapter = this.petTableAdapter;
            this.tableAdapterManager.PetTeamTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BattlePets.F2T5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // grpbxWeather
            // 
            this.grpbxWeather.BackColor = System.Drawing.Color.Transparent;
            this.grpbxWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpbxWeather.BackgroundImage")));
            this.grpbxWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpbxWeather.Controls.Add(this.pbPet1);
            this.grpbxWeather.Controls.Add(this.pbPet2);
            this.grpbxWeather.Controls.Add(this.pbTimer);
            this.grpbxWeather.Location = new System.Drawing.Point(12, 108);
            this.grpbxWeather.Name = "grpbxWeather";
            this.grpbxWeather.Size = new System.Drawing.Size(479, 201);
            this.grpbxWeather.TabIndex = 3;
            this.grpbxWeather.TabStop = false;
            // 
            // pbPet1
            // 
            this.pbPet1.BackColor = System.Drawing.Color.Transparent;
            this.pbPet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPet1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPet1.Image = ((System.Drawing.Image)(resources.GetObject("pbPet1.Image")));
            this.pbPet1.Location = new System.Drawing.Point(3, 16);
            this.pbPet1.Name = "pbPet1";
            this.pbPet1.Size = new System.Drawing.Size(140, 162);
            this.pbPet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPet1.TabIndex = 5;
            this.pbPet1.TabStop = false;
            // 
            // pbPet2
            // 
            this.pbPet2.BackColor = System.Drawing.Color.Transparent;
            this.pbPet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPet2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbPet2.Image = ((System.Drawing.Image)(resources.GetObject("pbPet2.Image")));
            this.pbPet2.Location = new System.Drawing.Point(336, 16);
            this.pbPet2.Name = "pbPet2";
            this.pbPet2.Size = new System.Drawing.Size(140, 162);
            this.pbPet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPet2.TabIndex = 4;
            this.pbPet2.TabStop = false;
            // 
            // pbTimer
            // 
            this.pbTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTimer.ForeColor = System.Drawing.Color.Transparent;
            this.pbTimer.Location = new System.Drawing.Point(3, 178);
            this.pbTimer.Maximum = 30;
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(473, 20);
            this.pbTimer.TabIndex = 3;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 433);
            this.Controls.Add(this.grpbxPetText2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbxTimer);
            this.Controls.Add(this.grpbxPet2);
            this.Controls.Add(this.gpbxPet1);
            this.Controls.Add(this.grpbxWeather);
            this.Controls.Add(this.gbButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(514, 476);
            this.MinimumSize = new System.Drawing.Size(514, 476);
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BattleScreen_FormClosed);
            this.Load += new System.EventHandler(this.BattleScreen_Load);
            this.Leave += new System.EventHandler(this.BattleScreen_leave);
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2T5DataSet)).EndInit();
            this.gpbxPet1.ResumeLayout(false);
            this.gpbxPet1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.grpbxPet2.ResumeLayout(false);
            this.grpbxPet2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbxPetText2.ResumeLayout(false);
            this.grpbxPetText2.PerformLayout();
            this.grpbxTimer.ResumeLayout(false);
            this.grpbxWeather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnPet3;
        private System.Windows.Forms.Button btnPet1;
        private System.Windows.Forms.Button btnPet2;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button btnAbility3;
        private System.Windows.Forms.Button btnAbility2;
        private System.Windows.Forms.Button btnAbility1;
        private System.Windows.Forms.ProgressBar pbPet3HP;
        private System.Windows.Forms.ProgressBar pbPet2HP;
        private System.Windows.Forms.ProgressBar pbPet1HP;
        private System.Windows.Forms.Timer tmrBattle;
        private System.Windows.Forms.Button btnPet4;
        private System.Windows.Forms.ProgressBar pbPet4HP;
        private System.Windows.Forms.GroupBox grpbxWeather;
        private System.Windows.Forms.GroupBox gpbxPet1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.ProgressBar pbHealth1;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.GroupBox grpbxPet2;
        private System.Windows.Forms.Label lblPetType2;
        private System.Windows.Forms.ProgressBar pbHealth2;
        private System.Windows.Forms.Label lblPetFamily2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpbxTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox grpbxPetText2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPetType1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPetFamily1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPet2;
        private System.Windows.Forms.PictureBox pbPet1;
        private System.Windows.Forms.Label lblCapture;
        private System.Windows.Forms.Label lblSwap;
        private System.Windows.Forms.Label lblSkip;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblSubmit;
        private F2T5DataSet f2T5DataSet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private F2T5DataSetTableAdapters.PetTableAdapter petTableAdapter;
        private F2T5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private F2T5DataSetTableAdapters.TypeTableAdapter typeTableAdapter;
    }
}