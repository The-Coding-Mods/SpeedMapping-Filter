namespace GbxTest
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.chkIgnoreTemplate = new System.Windows.Forms.CheckBox();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblCheckpoint = new System.Windows.Forms.Label();
            this.lblMultilap = new System.Windows.Forms.Label();
            this.numMultilap = new System.Windows.Forms.NumericUpDown();
            this.cmbEqMultilap = new System.Windows.Forms.ComboBox();
            this.lblCheckpoints = new System.Windows.Forms.Label();
            this.lblFinishes = new System.Windows.Forms.Label();
            this.btnAddCp = new System.Windows.Forms.Button();
            this.chkCheckpoint = new System.Windows.Forms.CheckBox();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.cmbStartDirection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMultilap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartCoords = new System.Windows.Forms.TextBox();
            this.txtAuthorTime = new System.Windows.Forms.TextBox();
            this.cmbEqAuthor = new System.Windows.Forms.ComboBox();
            this.chkAuthorTime = new System.Windows.Forms.CheckBox();
            this.chkCheckpointCount = new System.Windows.Forms.CheckBox();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.numCheckpoint = new System.Windows.Forms.NumericUpDown();
            this.chkFinish = new System.Windows.Forms.CheckBox();
            this.cmbEqCheckpoint = new System.Windows.Forms.ComboBox();
            this.grpBlock = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBobsleigh = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPlatformPlastic = new System.Windows.Forms.CheckBox();
            this.chkPlatformIce = new System.Windows.Forms.CheckBox();
            this.chkPlatformDirt = new System.Windows.Forms.CheckBox();
            this.chkDirtTech = new System.Windows.Forms.CheckBox();
            this.chkRoadTech = new System.Windows.Forms.CheckBox();
            this.chkPlatformTech = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultilap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckpoint)).BeginInit();
            this.grpBlock.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpFilter);
            this.groupBox1.Controls.Add(this.chkIgnoreTemplate);
            this.groupBox1.Controls.Add(this.btnTemplate);
            this.groupBox1.Controls.Add(this.grpGeneral);
            this.groupBox1.Controls.Add(this.grpBlock);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruleset";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.checkBox15);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.btnVerify);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.cmbFiles);
            this.grpFilter.Enabled = false;
            this.grpFilter.Location = new System.Drawing.Point(26, 505);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(443, 121);
            this.grpFilter.TabIndex = 15;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(94, 76);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(229, 19);
            this.checkBox15.TabIndex = 5;
            this.checkBox15.Text = "Move filtered maps instead of deleting";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Map folder:";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(332, 25);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(97, 28);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(332, 70);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(97, 28);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFiles
            // 
            this.cmbFiles.FormattingEnabled = true;
            this.cmbFiles.Location = new System.Drawing.Point(94, 29);
            this.cmbFiles.Name = "cmbFiles";
            this.cmbFiles.Size = new System.Drawing.Size(229, 23);
            this.cmbFiles.TabIndex = 3;
            this.cmbFiles.SelectedIndexChanged += new System.EventHandler(this.cmbFiles_SelectedIndexChanged);
            this.cmbFiles.Click += new System.EventHandler(this.cmbFiles_Click);
            // 
            // chkIgnoreTemplate
            // 
            this.chkIgnoreTemplate.AutoSize = true;
            this.chkIgnoreTemplate.Location = new System.Drawing.Point(358, 37);
            this.chkIgnoreTemplate.Name = "chkIgnoreTemplate";
            this.chkIgnoreTemplate.Size = new System.Drawing.Size(110, 19);
            this.chkIgnoreTemplate.TabIndex = 14;
            this.chkIgnoreTemplate.Text = "Ignore template";
            this.chkIgnoreTemplate.UseVisualStyleBackColor = true;
            this.chkIgnoreTemplate.CheckedChanged += new System.EventHandler(this.chkIgnoreTemplate_CheckedChanged);
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(26, 31);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(135, 28);
            this.btnTemplate.TabIndex = 13;
            this.btnTemplate.Text = "Import from template";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblCheckpoint);
            this.grpGeneral.Controls.Add(this.lblMultilap);
            this.grpGeneral.Controls.Add(this.numMultilap);
            this.grpGeneral.Controls.Add(this.cmbEqMultilap);
            this.grpGeneral.Controls.Add(this.lblCheckpoints);
            this.grpGeneral.Controls.Add(this.lblFinishes);
            this.grpGeneral.Controls.Add(this.btnAddCp);
            this.grpGeneral.Controls.Add(this.chkCheckpoint);
            this.grpGeneral.Controls.Add(this.btnAddFinish);
            this.grpGeneral.Controls.Add(this.cmbStartDirection);
            this.grpGeneral.Controls.Add(this.label3);
            this.grpGeneral.Controls.Add(this.chkMultilap);
            this.grpGeneral.Controls.Add(this.label1);
            this.grpGeneral.Controls.Add(this.txtStartCoords);
            this.grpGeneral.Controls.Add(this.txtAuthorTime);
            this.grpGeneral.Controls.Add(this.cmbEqAuthor);
            this.grpGeneral.Controls.Add(this.chkAuthorTime);
            this.grpGeneral.Controls.Add(this.chkCheckpointCount);
            this.grpGeneral.Controls.Add(this.chkStart);
            this.grpGeneral.Controls.Add(this.numCheckpoint);
            this.grpGeneral.Controls.Add(this.chkFinish);
            this.grpGeneral.Controls.Add(this.cmbEqCheckpoint);
            this.grpGeneral.Location = new System.Drawing.Point(25, 70);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(444, 249);
            this.grpGeneral.TabIndex = 7;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // lblCheckpoint
            // 
            this.lblCheckpoint.AutoSize = true;
            this.lblCheckpoint.Location = new System.Drawing.Point(351, 36);
            this.lblCheckpoint.Name = "lblCheckpoint";
            this.lblCheckpoint.Size = new System.Drawing.Size(66, 15);
            this.lblCheckpoint.TabIndex = 24;
            this.lblCheckpoint.Text = "checkpoint";
            // 
            // lblMultilap
            // 
            this.lblMultilap.AutoSize = true;
            this.lblMultilap.Location = new System.Drawing.Point(357, 216);
            this.lblMultilap.Name = "lblMultilap";
            this.lblMultilap.Size = new System.Drawing.Size(23, 15);
            this.lblMultilap.TabIndex = 23;
            this.lblMultilap.Text = "lap";
            // 
            // numMultilap
            // 
            this.numMultilap.Location = new System.Drawing.Point(300, 214);
            this.numMultilap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMultilap.Name = "numMultilap";
            this.numMultilap.Size = new System.Drawing.Size(46, 23);
            this.numMultilap.TabIndex = 22;
            this.numMultilap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMultilap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMultilap.ValueChanged += new System.EventHandler(this.numMultilap_ValueChanged);
            // 
            // cmbEqMultilap
            // 
            this.cmbEqMultilap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEqMultilap.FormattingEnabled = true;
            this.cmbEqMultilap.Location = new System.Drawing.Point(151, 212);
            this.cmbEqMultilap.Name = "cmbEqMultilap";
            this.cmbEqMultilap.Size = new System.Drawing.Size(128, 23);
            this.cmbEqMultilap.TabIndex = 21;
            // 
            // lblCheckpoints
            // 
            this.lblCheckpoints.AutoSize = true;
            this.lblCheckpoints.Location = new System.Drawing.Point(300, 181);
            this.lblCheckpoints.Name = "lblCheckpoints";
            this.lblCheckpoints.Size = new System.Drawing.Size(88, 15);
            this.lblCheckpoints.TabIndex = 20;
            this.lblCheckpoints.Text = "0 checkpoint(s)";
            // 
            // lblFinishes
            // 
            this.lblFinishes.AutoSize = true;
            this.lblFinishes.Location = new System.Drawing.Point(300, 143);
            this.lblFinishes.Name = "lblFinishes";
            this.lblFinishes.Size = new System.Drawing.Size(56, 15);
            this.lblFinishes.TabIndex = 19;
            this.lblFinishes.Text = "0 finishes";
            // 
            // btnAddCp
            // 
            this.btnAddCp.Location = new System.Drawing.Point(151, 176);
            this.btnAddCp.Name = "btnAddCp";
            this.btnAddCp.Size = new System.Drawing.Size(128, 23);
            this.btnAddCp.TabIndex = 18;
            this.btnAddCp.Text = "Checkpoints";
            this.btnAddCp.UseVisualStyleBackColor = true;
            this.btnAddCp.Click += new System.EventHandler(this.btnAddCp_Click);
            // 
            // chkCheckpoint
            // 
            this.chkCheckpoint.AutoSize = true;
            this.chkCheckpoint.Location = new System.Drawing.Point(15, 180);
            this.chkCheckpoint.Name = "chkCheckpoint";
            this.chkCheckpoint.Size = new System.Drawing.Size(138, 19);
            this.chkCheckpoint.TabIndex = 17;
            this.chkCheckpoint.Text = "Identical checkpoints";
            this.chkCheckpoint.UseVisualStyleBackColor = true;
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(151, 136);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(128, 23);
            this.btnAddFinish.TabIndex = 16;
            this.btnAddFinish.Text = "Finishes";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // cmbStartDirection
            // 
            this.cmbStartDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartDirection.FormattingEnabled = true;
            this.cmbStartDirection.Location = new System.Drawing.Point(151, 101);
            this.cmbStartDirection.Name = "cmbStartDirection";
            this.cmbStartDirection.Size = new System.Drawing.Size(128, 23);
            this.cmbStartDirection.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "milliseconds";
            // 
            // chkMultilap
            // 
            this.chkMultilap.AutoSize = true;
            this.chkMultilap.Location = new System.Drawing.Point(15, 214);
            this.chkMultilap.Name = "chkMultilap";
            this.chkMultilap.Size = new System.Drawing.Size(70, 19);
            this.chkMultilap.TabIndex = 13;
            this.chkMultilap.Text = "Multilap";
            this.chkMultilap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Coords";
            // 
            // txtStartCoords
            // 
            this.txtStartCoords.Location = new System.Drawing.Point(351, 101);
            this.txtStartCoords.Name = "txtStartCoords";
            this.txtStartCoords.Size = new System.Drawing.Size(68, 23);
            this.txtStartCoords.TabIndex = 9;
            this.txtStartCoords.Text = "0,0,0";
            this.txtStartCoords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthorTime
            // 
            this.txtAuthorTime.Location = new System.Drawing.Point(300, 69);
            this.txtAuthorTime.Name = "txtAuthorTime";
            this.txtAuthorTime.Size = new System.Drawing.Size(46, 23);
            this.txtAuthorTime.TabIndex = 8;
            this.txtAuthorTime.Text = "15000";
            this.txtAuthorTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbEqAuthor
            // 
            this.cmbEqAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEqAuthor.FormattingEnabled = true;
            this.cmbEqAuthor.Location = new System.Drawing.Point(151, 64);
            this.cmbEqAuthor.Name = "cmbEqAuthor";
            this.cmbEqAuthor.Size = new System.Drawing.Size(128, 23);
            this.cmbEqAuthor.TabIndex = 7;
            // 
            // chkAuthorTime
            // 
            this.chkAuthorTime.AutoSize = true;
            this.chkAuthorTime.Location = new System.Drawing.Point(15, 68);
            this.chkAuthorTime.Name = "chkAuthorTime";
            this.chkAuthorTime.Size = new System.Drawing.Size(90, 19);
            this.chkAuthorTime.TabIndex = 6;
            this.chkAuthorTime.Text = "Author time";
            this.chkAuthorTime.UseVisualStyleBackColor = true;
            // 
            // chkCheckpointCount
            // 
            this.chkCheckpointCount.AutoSize = true;
            this.chkCheckpointCount.Location = new System.Drawing.Point(15, 32);
            this.chkCheckpointCount.Name = "chkCheckpointCount";
            this.chkCheckpointCount.Size = new System.Drawing.Size(121, 19);
            this.chkCheckpointCount.TabIndex = 3;
            this.chkCheckpointCount.Text = "Checkpoint count";
            this.chkCheckpointCount.UseVisualStyleBackColor = true;
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Location = new System.Drawing.Point(15, 103);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(97, 19);
            this.chkStart.TabIndex = 1;
            this.chkStart.Text = "Identical start";
            this.chkStart.UseVisualStyleBackColor = true;
            // 
            // numCheckpoint
            // 
            this.numCheckpoint.Location = new System.Drawing.Point(300, 33);
            this.numCheckpoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCheckpoint.Name = "numCheckpoint";
            this.numCheckpoint.Size = new System.Drawing.Size(46, 23);
            this.numCheckpoint.TabIndex = 5;
            this.numCheckpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCheckpoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCheckpoint.ValueChanged += new System.EventHandler(this.numCheckpoint_ValueChanged);
            // 
            // chkFinish
            // 
            this.chkFinish.AutoSize = true;
            this.chkFinish.Location = new System.Drawing.Point(15, 139);
            this.chkFinish.Name = "chkFinish";
            this.chkFinish.Size = new System.Drawing.Size(103, 19);
            this.chkFinish.TabIndex = 2;
            this.chkFinish.Text = "Identical finish";
            this.chkFinish.UseVisualStyleBackColor = true;
            // 
            // cmbEqCheckpoint
            // 
            this.cmbEqCheckpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEqCheckpoint.FormattingEnabled = true;
            this.cmbEqCheckpoint.Location = new System.Drawing.Point(151, 33);
            this.cmbEqCheckpoint.Name = "cmbEqCheckpoint";
            this.cmbEqCheckpoint.Size = new System.Drawing.Size(128, 23);
            this.cmbEqCheckpoint.TabIndex = 4;
            // 
            // grpBlock
            // 
            this.grpBlock.Controls.Add(this.label2);
            this.grpBlock.Controls.Add(this.chkBobsleigh);
            this.grpBlock.Controls.Add(this.checkBox12);
            this.grpBlock.Controls.Add(this.chkSausage);
            this.grpBlock.Controls.Add(this.chkPlatformPlastic);
            this.grpBlock.Controls.Add(this.chkPlatformIce);
            this.grpBlock.Controls.Add(this.chkPlatformDirt);
            this.grpBlock.Controls.Add(this.chkDirtTech);
            this.grpBlock.Controls.Add(this.chkRoadTech);
            this.grpBlock.Controls.Add(this.chkPlatformTech);
            this.grpBlock.Location = new System.Drawing.Point(24, 325);
            this.grpBlock.Name = "grpBlock";
            this.grpBlock.Size = new System.Drawing.Size(444, 164);
            this.grpBlock.TabIndex = 6;
            this.grpBlock.TabStop = false;
            this.grpBlock.Text = "Disallowed block styles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Warning: scenery will be affected";
            // 
            // chkBobsleigh
            // 
            this.chkBobsleigh.AutoSize = true;
            this.chkBobsleigh.Location = new System.Drawing.Point(15, 80);
            this.chkBobsleigh.Name = "chkBobsleigh";
            this.chkBobsleigh.Size = new System.Drawing.Size(78, 19);
            this.chkBobsleigh.TabIndex = 8;
            this.chkBobsleigh.Tag = "RoadIce";
            this.chkBobsleigh.Text = "Bobsleigh";
            this.chkBobsleigh.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(15, 128);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(57, 19);
            this.checkBox12.TabIndex = 7;
            this.checkBox12.Tag = "Water";
            this.checkBox12.Text = "Water";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(334, 80);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(69, 19);
            this.chkSausage.TabIndex = 6;
            this.chkSausage.Tag = "RoadBump";
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPlatformPlastic
            // 
            this.chkPlatformPlastic.AutoSize = true;
            this.chkPlatformPlastic.Location = new System.Drawing.Point(213, 80);
            this.chkPlatformPlastic.Name = "chkPlatformPlastic";
            this.chkPlatformPlastic.Size = new System.Drawing.Size(60, 19);
            this.chkPlatformPlastic.TabIndex = 5;
            this.chkPlatformPlastic.Tag = "PlatformPlastic";
            this.chkPlatformPlastic.Text = "Plastic";
            this.chkPlatformPlastic.UseVisualStyleBackColor = true;
            // 
            // chkPlatformIce
            // 
            this.chkPlatformIce.AutoSize = true;
            this.chkPlatformIce.Location = new System.Drawing.Point(122, 80);
            this.chkPlatformIce.Name = "chkPlatformIce";
            this.chkPlatformIce.Size = new System.Drawing.Size(41, 19);
            this.chkPlatformIce.TabIndex = 4;
            this.chkPlatformIce.Tag = "PlatformIce";
            this.chkPlatformIce.Text = "Ice";
            this.chkPlatformIce.UseVisualStyleBackColor = true;
            // 
            // chkPlatformDirt
            // 
            this.chkPlatformDirt.AutoSize = true;
            this.chkPlatformDirt.Location = new System.Drawing.Point(122, 32);
            this.chkPlatformDirt.Name = "chkPlatformDirt";
            this.chkPlatformDirt.Size = new System.Drawing.Size(45, 19);
            this.chkPlatformDirt.TabIndex = 3;
            this.chkPlatformDirt.Tag = "PlatformDirt";
            this.chkPlatformDirt.Text = "Dirt";
            this.chkPlatformDirt.UseVisualStyleBackColor = true;
            // 
            // chkDirtTech
            // 
            this.chkDirtTech.AutoSize = true;
            this.chkDirtTech.Location = new System.Drawing.Point(334, 32);
            this.chkDirtTech.Name = "chkDirtTech";
            this.chkDirtTech.Size = new System.Drawing.Size(72, 19);
            this.chkDirtTech.TabIndex = 2;
            this.chkDirtTech.Tag = "RoadDirt";
            this.chkDirtTech.Text = "Dirt Tech";
            this.chkDirtTech.UseVisualStyleBackColor = true;
            // 
            // chkRoadTech
            // 
            this.chkRoadTech.AutoSize = true;
            this.chkRoadTech.Location = new System.Drawing.Point(213, 32);
            this.chkRoadTech.Name = "chkRoadTech";
            this.chkRoadTech.Size = new System.Drawing.Size(80, 19);
            this.chkRoadTech.TabIndex = 1;
            this.chkRoadTech.Tag = "RoadTech";
            this.chkRoadTech.Text = "Road Tech";
            this.chkRoadTech.UseVisualStyleBackColor = true;
            // 
            // chkPlatformTech
            // 
            this.chkPlatformTech.AutoSize = true;
            this.chkPlatformTech.Location = new System.Drawing.Point(15, 32);
            this.chkPlatformTech.Name = "chkPlatformTech";
            this.chkPlatformTech.Size = new System.Drawing.Size(72, 19);
            this.chkPlatformTech.TabIndex = 0;
            this.chkPlatformTech.Tag = "PlatformTech";
            this.chkPlatformTech.Text = "Platform";
            this.chkPlatformTech.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Exit ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Mapping Contest Filter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultilap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckpoint)).EndInit();
            this.grpBlock.ResumeLayout(false);
            this.grpBlock.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnFilter;
        private NumericUpDown numCheckpoint;
        private ComboBox cmbEqCheckpoint;
        private CheckBox chkCheckpointCount;
        private CheckBox chkFinish;
        private CheckBox chkStart;
        private GroupBox grpGeneral;
        private Button btnTemplate;
        private Label label1;
        private TextBox txtStartCoords;
        private TextBox txtAuthorTime;
        private ComboBox cmbEqAuthor;
        private CheckBox chkAuthorTime;
        private GroupBox grpBlock;
        private CheckBox chkBobsleigh;
        private CheckBox checkBox12;
        private CheckBox chkSausage;
        private CheckBox chkPlatformPlastic;
        private CheckBox chkPlatformIce;
        private CheckBox chkPlatformDirt;
        private CheckBox chkDirtTech;
        private CheckBox chkRoadTech;
        private CheckBox chkPlatformTech;
        private Label label4;
        private ComboBox cmbFiles;
        private Button btnVerify;
        private ToolStripMenuItem helpToolStripMenuItem;
        private CheckBox checkBox15;
        private CheckBox chkIgnoreTemplate;
        private GroupBox grpFilter;
        private CheckBox chkMultilap;
        private Label label3;
        private ComboBox cmbStartDirection;
        private Button btnAddFinish;
        private Button btnAddCp;
        private CheckBox chkCheckpoint;
        private Label lblCheckpoints;
        private Label lblFinishes;
        private Label label2;
        private Label lblCheckpoint;
        private Label lblMultilap;
        private NumericUpDown numMultilap;
        private ComboBox cmbEqMultilap;
    }
}