namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            teamRoleAndChampBtn = new Button();
            teamBtn = new Button();
            teamAndRoleBtn = new Button();
            textBox1 = new TextBox();
            blueTeamTextbox = new TextBox();
            redTeamTextbox = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            mirrorMatchupCheckBox = new CheckBox();
            roleSelectionBox = new ComboBox();
            textBox4 = new TextBox();
            championBtn = new Button();
            randomChampionResultTextbox = new TextBox();
            noOfParticipantsTextbox = new TextBox();
            textBox5 = new TextBox();
            rndRoleTextbox = new TextBox();
            generateRoleBtn = new Button();
            randomTeamAndChapmionBtn = new Button();
            SuspendLayout();
            // 
            // teamRoleAndChampBtn
            // 
            teamRoleAndChampBtn.BackColor = Color.Transparent;
            teamRoleAndChampBtn.Location = new Point(612, 526);
            teamRoleAndChampBtn.Name = "teamRoleAndChampBtn";
            teamRoleAndChampBtn.Size = new Size(126, 49);
            teamRoleAndChampBtn.TabIndex = 2;
            teamRoleAndChampBtn.Text = "Team + Role + Champion";
            teamRoleAndChampBtn.UseVisualStyleBackColor = false;
            teamRoleAndChampBtn.Click += teamRoleAndChampBtn_Click;
            // 
            // teamBtn
            // 
            teamBtn.Location = new Point(216, 526);
            teamBtn.Name = "teamBtn";
            teamBtn.Size = new Size(126, 49);
            teamBtn.TabIndex = 3;
            teamBtn.Text = "Team";
            teamBtn.UseVisualStyleBackColor = true;
            teamBtn.Click += teamBtn_Click;
            // 
            // teamAndRoleBtn
            // 
            teamAndRoleBtn.BackColor = Color.Transparent;
            teamAndRoleBtn.Location = new Point(348, 526);
            teamAndRoleBtn.Name = "teamAndRoleBtn";
            teamAndRoleBtn.Size = new Size(126, 49);
            teamAndRoleBtn.TabIndex = 4;
            teamAndRoleBtn.Text = "Team + Role";
            teamAndRoleBtn.UseVisualStyleBackColor = false;
            teamAndRoleBtn.Click += teamAndRoleBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
            textBox1.Location = new Point(12, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 354);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // blueTeamTextbox
            // 
            blueTeamTextbox.BackColor = SystemColors.MenuHighlight;
            blueTeamTextbox.BorderStyle = BorderStyle.FixedSingle;
            blueTeamTextbox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            blueTeamTextbox.Location = new Point(188, 48);
            blueTeamTextbox.Multiline = true;
            blueTeamTextbox.Name = "blueTeamTextbox";
            blueTeamTextbox.ReadOnly = true;
            blueTeamTextbox.Size = new Size(279, 354);
            blueTeamTextbox.TabIndex = 8;
            // 
            // redTeamTextbox
            // 
            redTeamTextbox.BackColor = Color.Red;
            redTeamTextbox.BorderStyle = BorderStyle.FixedSingle;
            redTeamTextbox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            redTeamTextbox.Location = new Point(500, 48);
            redTeamTextbox.Multiline = true;
            redTeamTextbox.Name = "redTeamTextbox";
            redTeamTextbox.ReadOnly = true;
            redTeamTextbox.Size = new Size(279, 354);
            redTeamTextbox.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            textBox2.Location = new Point(12, 18);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 11;
            textBox2.Text = "Input";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuHighlight;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            textBox3.Location = new Point(188, 15);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(279, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "Blue Team";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Red;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            textBox6.Location = new Point(500, 15);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(279, 23);
            textBox6.TabIndex = 13;
            textBox6.Text = "Red Team";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // mirrorMatchupCheckBox
            // 
            mirrorMatchupCheckBox.AutoSize = true;
            mirrorMatchupCheckBox.BackColor = Color.Transparent;
            mirrorMatchupCheckBox.ForeColor = SystemColors.ButtonFace;
            mirrorMatchupCheckBox.Location = new Point(551, 581);
            mirrorMatchupCheckBox.Name = "mirrorMatchupCheckBox";
            mirrorMatchupCheckBox.Size = new Size(115, 19);
            mirrorMatchupCheckBox.TabIndex = 14;
            mirrorMatchupCheckBox.Text = "Mirror Matchup?";
            mirrorMatchupCheckBox.UseVisualStyleBackColor = false;
            mirrorMatchupCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // roleSelectionBox
            // 
            roleSelectionBox.BackColor = Color.FromArgb(  128,   255,   128);
            roleSelectionBox.FlatStyle = FlatStyle.Flat;
            roleSelectionBox.FormattingEnabled = true;
            roleSelectionBox.Location = new Point(809, 89);
            roleSelectionBox.Name = "roleSelectionBox";
            roleSelectionBox.Size = new Size(145, 23);
            roleSelectionBox.TabIndex = 17;
            roleSelectionBox.Text = "Select Role";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(  128,   255,   128);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            textBox4.Location = new Point(809, 60);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 18;
            textBox4.Text = "Champion by Role";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // championBtn
            // 
            championBtn.BackColor = Color.FromArgb(  128,   255,   128);
            championBtn.FlatStyle = FlatStyle.Popup;
            championBtn.Location = new Point(809, 167);
            championBtn.Name = "championBtn";
            championBtn.RightToLeft = RightToLeft.No;
            championBtn.Size = new Size(145, 31);
            championBtn.TabIndex = 19;
            championBtn.Text = "Generate Champion";
            championBtn.UseVisualStyleBackColor = false;
            championBtn.Click += championBtn_Click;
            // 
            // randomChampionResultTextbox
            // 
            randomChampionResultTextbox.BackColor = Color.FromArgb(  128,   255,   128);
            randomChampionResultTextbox.BorderStyle = BorderStyle.FixedSingle;
            randomChampionResultTextbox.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point,  0);
            randomChampionResultTextbox.Location = new Point(809, 118);
            randomChampionResultTextbox.Multiline = true;
            randomChampionResultTextbox.Name = "randomChampionResultTextbox";
            randomChampionResultTextbox.Size = new Size(145, 43);
            randomChampionResultTextbox.TabIndex = 20;
            randomChampionResultTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // noOfParticipantsTextbox
            // 
            noOfParticipantsTextbox.Location = new Point(33, 407);
            noOfParticipantsTextbox.Name = "noOfParticipantsTextbox";
            noOfParticipantsTextbox.Size = new Size(100, 23);
            noOfParticipantsTextbox.TabIndex = 21;
            noOfParticipantsTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(  255,   255,   128);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            textBox5.Location = new Point(809, 255);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(145, 23);
            textBox5.TabIndex = 22;
            textBox5.Text = "Random Role\r\n";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // rndRoleTextbox
            // 
            rndRoleTextbox.BackColor = Color.FromArgb(  255,   255,   128);
            rndRoleTextbox.BorderStyle = BorderStyle.FixedSingle;
            rndRoleTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            rndRoleTextbox.Location = new Point(809, 284);
            rndRoleTextbox.Multiline = true;
            rndRoleTextbox.Name = "rndRoleTextbox";
            rndRoleTextbox.ReadOnly = true;
            rndRoleTextbox.Size = new Size(145, 43);
            rndRoleTextbox.TabIndex = 24;
            rndRoleTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // generateRoleBtn
            // 
            generateRoleBtn.BackColor = Color.FromArgb(  255,   255,   128);
            generateRoleBtn.FlatStyle = FlatStyle.Popup;
            generateRoleBtn.Location = new Point(809, 333);
            generateRoleBtn.Name = "generateRoleBtn";
            generateRoleBtn.RightToLeft = RightToLeft.No;
            generateRoleBtn.Size = new Size(145, 31);
            generateRoleBtn.TabIndex = 25;
            generateRoleBtn.Text = "Generate Role";
            generateRoleBtn.UseVisualStyleBackColor = false;
            generateRoleBtn.Click += generateRoleBtn_Click;
            // 
            // randomTeamAndChapmionBtn
            // 
            randomTeamAndChapmionBtn.BackColor = Color.Transparent;
            randomTeamAndChapmionBtn.Location = new Point(480, 526);
            randomTeamAndChapmionBtn.Name = "randomTeamAndChapmionBtn";
            randomTeamAndChapmionBtn.Size = new Size(126, 49);
            randomTeamAndChapmionBtn.TabIndex = 26;
            randomTeamAndChapmionBtn.Text = "Team + Champion";
            randomTeamAndChapmionBtn.UseVisualStyleBackColor = false;
            randomTeamAndChapmionBtn.Click += teamAndChampionBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.League_map;
            ClientSize = new Size(966, 655);
            Controls.Add(randomTeamAndChapmionBtn);
            Controls.Add(generateRoleBtn);
            Controls.Add(rndRoleTextbox);
            Controls.Add(textBox5);
            Controls.Add(noOfParticipantsTextbox);
            Controls.Add(randomChampionResultTextbox);
            Controls.Add(championBtn);
            Controls.Add(textBox4);
            Controls.Add(roleSelectionBox);
            Controls.Add(mirrorMatchupCheckBox);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(redTeamTextbox);
            Controls.Add(blueTeamTextbox);
            Controls.Add(textBox1);
            Controls.Add(teamAndRoleBtn);
            Controls.Add(teamBtn);
            Controls.Add(teamRoleAndChampBtn);
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "League Custom Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button teamRoleAndChampBtn;
        private Button teamBtn;
        private Button teamAndRoleBtn;
        private TextBox textBox1;
        private TextBox blueTeamTextbox;
        private TextBox redTeamTextbox;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private CheckBox mirrorMatchupCheckBox;
        private ComboBox roleSelectionBox;
        private TextBox textBox4;
        private Button championBtn;
        private TextBox randomChampionResultTextbox;
        private TextBox noOfParticipantsTextbox;
        private TextBox textBox5;
        private TextBox rndRoleTextbox;
        private Button generateRoleBtn;
        private Button randomTeamAndChapmionBtn;
    }
}
