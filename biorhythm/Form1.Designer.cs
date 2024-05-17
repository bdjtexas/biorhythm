namespace biorhythm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.exitButton = new System.Windows.Forms.Button();
            this.BirthDatelabel = new System.Windows.Forms.Label();
            this.DateToCalculatelabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBirthDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeApplicationColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateBiorhythmButton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TotalDaysAliveTextBox = new System.Windows.Forms.TextBox();
            this.TotalDaysAliveLabel = new System.Windows.Forms.Label();
            this.SeeGraphButton = new System.Windows.Forms.Button();
            this.PhysicalCycleTextBox = new System.Windows.Forms.TextBox();
            this.PhysicalCycleLabel = new System.Windows.Forms.Label();
            this.EmotionalCycleTextBox = new System.Windows.Forms.TextBox();
            this.EmotionalCycleLabel = new System.Windows.Forms.Label();
            this.IntellectualCycleTextBox = new System.Windows.Forms.TextBox();
            this.IntellectualCycleLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(267, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(330, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BirthDatelabel
            // 
            this.BirthDatelabel.AutoSize = true;
            this.BirthDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDatelabel.Location = new System.Drawing.Point(80, 29);
            this.BirthDatelabel.Name = "BirthDatelabel";
            this.BirthDatelabel.Size = new System.Drawing.Size(91, 20);
            this.BirthDatelabel.TabIndex = 3;
            this.BirthDatelabel.Text = "Birth Date";
            // 
            // DateToCalculatelabel
            // 
            this.DateToCalculatelabel.AutoSize = true;
            this.DateToCalculatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToCalculatelabel.Location = new System.Drawing.Point(293, 29);
            this.DateToCalculatelabel.Name = "DateToCalculatelabel";
            this.DateToCalculatelabel.Size = new System.Drawing.Size(149, 20);
            this.DateToCalculatelabel.TabIndex = 4;
            this.DateToCalculatelabel.Text = "Date to Calculate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBirthDateToolStripMenuItem,
            this.printToolStripMenuItem,
            this.ExitMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saveBirthDateToolStripMenuItem
            // 
            this.saveBirthDateToolStripMenuItem.Name = "saveBirthDateToolStripMenuItem";
            this.saveBirthDateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveBirthDateToolStripMenuItem.Text = "Save Birth Date";
            this.saveBirthDateToolStripMenuItem.Click += new System.EventHandler(this.saveBirthDateToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.printToolStripMenuItem.Text = "Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeApplicationColorsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeApplicationColorsToolStripMenuItem
            // 
            this.changeApplicationColorsToolStripMenuItem.Name = "changeApplicationColorsToolStripMenuItem";
            this.changeApplicationColorsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.changeApplicationColorsToolStripMenuItem.Text = "Change application colors";
            this.changeApplicationColorsToolStripMenuItem.Click += new System.EventHandler(this.changeApplicationColorsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // CalculateBiorhythmButton
            // 
            this.CalculateBiorhythmButton.Location = new System.Drawing.Point(186, 87);
            this.CalculateBiorhythmButton.Name = "CalculateBiorhythmButton";
            this.CalculateBiorhythmButton.Size = new System.Drawing.Size(125, 23);
            this.CalculateBiorhythmButton.TabIndex = 6;
            this.CalculateBiorhythmButton.Text = "Calculate Biorhythm";
            this.CalculateBiorhythmButton.UseVisualStyleBackColor = true;
            this.CalculateBiorhythmButton.Click += new System.EventHandler(this.CalculateBiorhythmButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // TotalDaysAliveTextBox
            // 
            this.TotalDaysAliveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDaysAliveTextBox.Location = new System.Drawing.Point(213, 211);
            this.TotalDaysAliveTextBox.Name = "TotalDaysAliveTextBox";
            this.TotalDaysAliveTextBox.Size = new System.Drawing.Size(71, 22);
            this.TotalDaysAliveTextBox.TabIndex = 7;
            this.TotalDaysAliveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalDaysAliveLabel
            // 
            this.TotalDaysAliveLabel.AutoSize = true;
            this.TotalDaysAliveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDaysAliveLabel.Location = new System.Drawing.Point(198, 195);
            this.TotalDaysAliveLabel.Name = "TotalDaysAliveLabel";
            this.TotalDaysAliveLabel.Size = new System.Drawing.Size(100, 13);
            this.TotalDaysAliveLabel.TabIndex = 8;
            this.TotalDaysAliveLabel.Text = "Total Days Alive";
            // 
            // SeeGraphButton
            // 
            this.SeeGraphButton.Location = new System.Drawing.Point(88, 208);
            this.SeeGraphButton.Name = "SeeGraphButton";
            this.SeeGraphButton.Size = new System.Drawing.Size(75, 23);
            this.SeeGraphButton.TabIndex = 9;
            this.SeeGraphButton.Text = "See Graph...";
            this.SeeGraphButton.UseVisualStyleBackColor = true;
            this.SeeGraphButton.Click += new System.EventHandler(this.SeeGraphButton_Click);
            // 
            // PhysicalCycleTextBox
            // 
            this.PhysicalCycleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalCycleTextBox.Location = new System.Drawing.Point(110, 157);
            this.PhysicalCycleTextBox.Name = "PhysicalCycleTextBox";
            this.PhysicalCycleTextBox.Size = new System.Drawing.Size(31, 22);
            this.PhysicalCycleTextBox.TabIndex = 10;
            this.PhysicalCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhysicalCycleLabel
            // 
            this.PhysicalCycleLabel.AutoSize = true;
            this.PhysicalCycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalCycleLabel.Location = new System.Drawing.Point(81, 128);
            this.PhysicalCycleLabel.Name = "PhysicalCycleLabel";
            this.PhysicalCycleLabel.Size = new System.Drawing.Size(89, 26);
            this.PhysicalCycleLabel.TabIndex = 11;
            this.PhysicalCycleLabel.Text = "Physical Cycle\r\n(of 23 Days)";
            this.PhysicalCycleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PhysicalCycleLabel.Click += new System.EventHandler(this.PhysicalCycleLabel_Click);
            // 
            // EmotionalCycleTextBox
            // 
            this.EmotionalCycleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmotionalCycleTextBox.Location = new System.Drawing.Point(233, 157);
            this.EmotionalCycleTextBox.Name = "EmotionalCycleTextBox";
            this.EmotionalCycleTextBox.Size = new System.Drawing.Size(31, 22);
            this.EmotionalCycleTextBox.TabIndex = 12;
            this.EmotionalCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmotionalCycleLabel
            // 
            this.EmotionalCycleLabel.AutoSize = true;
            this.EmotionalCycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmotionalCycleLabel.Location = new System.Drawing.Point(200, 128);
            this.EmotionalCycleLabel.Name = "EmotionalCycleLabel";
            this.EmotionalCycleLabel.Size = new System.Drawing.Size(97, 26);
            this.EmotionalCycleLabel.TabIndex = 13;
            this.EmotionalCycleLabel.Text = "Emotional Cycle\r\n(of 28 Days)";
            this.EmotionalCycleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IntellectualCycleTextBox
            // 
            this.IntellectualCycleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntellectualCycleTextBox.Location = new System.Drawing.Point(353, 157);
            this.IntellectualCycleTextBox.Name = "IntellectualCycleTextBox";
            this.IntellectualCycleTextBox.Size = new System.Drawing.Size(28, 22);
            this.IntellectualCycleTextBox.TabIndex = 14;
            this.IntellectualCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntellectualCycleLabel
            // 
            this.IntellectualCycleLabel.AutoSize = true;
            this.IntellectualCycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntellectualCycleLabel.Location = new System.Drawing.Point(315, 128);
            this.IntellectualCycleLabel.Name = "IntellectualCycleLabel";
            this.IntellectualCycleLabel.Size = new System.Drawing.Size(105, 26);
            this.IntellectualCycleLabel.TabIndex = 15;
            this.IntellectualCycleLabel.Text = "Intellectual Cycle\r\n(of 33 Days)";
            this.IntellectualCycleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 261);
            this.Controls.Add(this.IntellectualCycleLabel);
            this.Controls.Add(this.IntellectualCycleTextBox);
            this.Controls.Add(this.EmotionalCycleLabel);
            this.Controls.Add(this.EmotionalCycleTextBox);
            this.Controls.Add(this.PhysicalCycleLabel);
            this.Controls.Add(this.PhysicalCycleTextBox);
            this.Controls.Add(this.SeeGraphButton);
            this.Controls.Add(this.TotalDaysAliveLabel);
            this.Controls.Add(this.TotalDaysAliveTextBox);
            this.Controls.Add(this.CalculateBiorhythmButton);
            this.Controls.Add(this.DateToCalculatelabel);
            this.Controls.Add(this.BirthDatelabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Biorhythm Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label BirthDatelabel;
        private System.Windows.Forms.Label DateToCalculatelabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button CalculateBiorhythmButton;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeApplicationColorsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox TotalDaysAliveTextBox;
        private System.Windows.Forms.Label TotalDaysAliveLabel;
        private System.Windows.Forms.Button SeeGraphButton;
        private System.Windows.Forms.TextBox PhysicalCycleTextBox;
        private System.Windows.Forms.Label PhysicalCycleLabel;
        private System.Windows.Forms.TextBox EmotionalCycleTextBox;
        private System.Windows.Forms.Label EmotionalCycleLabel;
        private System.Windows.Forms.TextBox IntellectualCycleTextBox;
        private System.Windows.Forms.Label IntellectualCycleLabel;
        private System.Windows.Forms.ToolStripMenuItem saveBirthDateToolStripMenuItem;
    }
}

