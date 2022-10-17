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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.chkIgnoreTemplate = new System.Windows.Forms.CheckBox();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.txtEndCoords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartCoords = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpBlock = new System.Windows.Forms.GroupBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(493, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruleset";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.checkBox15);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.button3);
            this.grpFilter.Controls.Add(this.button1);
            this.grpFilter.Controls.Add(this.comboBox3);
            this.grpFilter.Enabled = false;
            this.grpFilter.Location = new System.Drawing.Point(25, 456);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Verify";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(94, 29);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(229, 23);
            this.comboBox3.TabIndex = 3;
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
            this.grpGeneral.Controls.Add(this.checkBox16);
            this.grpGeneral.Controls.Add(this.txtEndCoords);
            this.grpGeneral.Controls.Add(this.label2);
            this.grpGeneral.Controls.Add(this.label1);
            this.grpGeneral.Controls.Add(this.txtStartCoords);
            this.grpGeneral.Controls.Add(this.textBox1);
            this.grpGeneral.Controls.Add(this.comboBox2);
            this.grpGeneral.Controls.Add(this.checkBox4);
            this.grpGeneral.Controls.Add(this.checkBox3);
            this.grpGeneral.Controls.Add(this.checkBox1);
            this.grpGeneral.Controls.Add(this.numericUpDown1);
            this.grpGeneral.Controls.Add(this.checkBox2);
            this.grpGeneral.Controls.Add(this.comboBox1);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(25, 70);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(444, 194);
            this.grpGeneral.TabIndex = 7;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // txtEndCoords
            // 
            this.txtEndCoords.Location = new System.Drawing.Point(195, 137);
            this.txtEndCoords.Name = "txtEndCoords";
            this.txtEndCoords.Size = new System.Drawing.Size(68, 23);
            this.txtEndCoords.TabIndex = 12;
            this.txtEndCoords.Text = "0,0,0";
            this.txtEndCoords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coords";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Coords";
            // 
            // txtStartCoords
            // 
            this.txtStartCoords.Location = new System.Drawing.Point(195, 103);
            this.txtStartCoords.Name = "txtStartCoords";
            this.txtStartCoords.Size = new System.Drawing.Size(68, 23);
            this.txtStartCoords.TabIndex = 9;
            this.txtStartCoords.Text = "0,0,0";
            this.txtStartCoords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "1:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Equal to",
            "Greater than",
            "Less than"});
            this.comboBox2.Location = new System.Drawing.Point(142, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Less than";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 68);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(90, 19);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Author time";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Checkpoint count";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Identical start";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(281, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 19);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Identical end";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Equal to",
            "Greater than",
            "Less than"});
            this.comboBox1.Location = new System.Drawing.Point(142, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Equal to";
            // 
            // grpBlock
            // 
            this.grpBlock.Controls.Add(this.checkBox14);
            this.grpBlock.Controls.Add(this.checkBox13);
            this.grpBlock.Controls.Add(this.checkBox12);
            this.grpBlock.Controls.Add(this.checkBox11);
            this.grpBlock.Controls.Add(this.checkBox10);
            this.grpBlock.Controls.Add(this.checkBox9);
            this.grpBlock.Controls.Add(this.checkBox8);
            this.grpBlock.Controls.Add(this.checkBox7);
            this.grpBlock.Controls.Add(this.checkBox6);
            this.grpBlock.Controls.Add(this.checkBox5);
            this.grpBlock.Enabled = false;
            this.grpBlock.Location = new System.Drawing.Point(24, 286);
            this.grpBlock.Name = "grpBlock";
            this.grpBlock.Size = new System.Drawing.Size(444, 164);
            this.grpBlock.TabIndex = 6;
            this.grpBlock.TabStop = false;
            this.grpBlock.Text = "Disallowed block styles";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(122, 128);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(68, 19);
            this.checkBox14.TabIndex = 9;
            this.checkBox14.Text = "Custom";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(15, 80);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(78, 19);
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Text = "Bobsleigh";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(15, 128);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(57, 19);
            this.checkBox12.TabIndex = 7;
            this.checkBox12.Text = "Water";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(334, 80);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(69, 19);
            this.checkBox11.TabIndex = 6;
            this.checkBox11.Text = "Sausage";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(213, 80);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(60, 19);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Plastic";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(122, 80);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(41, 19);
            this.checkBox9.TabIndex = 4;
            this.checkBox9.Text = "Ice";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(122, 32);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(45, 19);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "Dirt";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(334, 32);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 19);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Dirt Tech";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(213, 32);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 19);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "Road Tech";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(15, 32);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 19);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Platform";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
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
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(15, 169);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(117, 19);
            this.checkBox16.TabIndex = 13;
            this.checkBox16.Text = "Disallow multilap";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 638);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox grpGeneral;
        private Button btnTemplate;
        private TextBox txtEndCoords;
        private Label label2;
        private Label label1;
        private TextBox txtStartCoords;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private CheckBox checkBox4;
        private GroupBox grpBlock;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private Label label4;
        private ComboBox comboBox3;
        private Button button3;
        private ToolStripMenuItem helpToolStripMenuItem;
        private CheckBox checkBox15;
        private CheckBox chkIgnoreTemplate;
        private GroupBox grpFilter;
        private CheckBox checkBox16;
    }
}