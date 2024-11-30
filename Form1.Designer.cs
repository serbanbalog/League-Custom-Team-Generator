﻿namespace WinFormsApp1
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
            SuspendLayout();
            // 
            // teamRoleAndChampBtn
            // 
            teamRoleAndChampBtn.BackColor = Color.Transparent;
            teamRoleAndChampBtn.Location = new Point(329, 390);
            teamRoleAndChampBtn.Name = "teamRoleAndChampBtn";
            teamRoleAndChampBtn.Size = new Size(126, 49);
            teamRoleAndChampBtn.TabIndex = 2;
            teamRoleAndChampBtn.Text = "Echipa + Rol + Campion";
            teamRoleAndChampBtn.UseVisualStyleBackColor = false;
            teamRoleAndChampBtn.Click += teamRoleAndChampBtn_Click;
            // 
            // teamBtn
            // 
            teamBtn.Location = new Point(65, 390);
            teamBtn.Name = "teamBtn";
            teamBtn.Size = new Size(126, 49);
            teamBtn.TabIndex = 3;
            teamBtn.Text = "Echipa";
            teamBtn.UseVisualStyleBackColor = true;
            teamBtn.Click += teamBtn_Click;
            // 
            // teamAndRoleBtn
            // 
            teamAndRoleBtn.BackColor = Color.Transparent;
            teamAndRoleBtn.Location = new Point(197, 390);
            teamAndRoleBtn.Name = "teamAndRoleBtn";
            teamAndRoleBtn.Size = new Size(126, 49);
            teamAndRoleBtn.TabIndex = 4;
            teamAndRoleBtn.Text = "Echipa + Rol";
            teamAndRoleBtn.UseVisualStyleBackColor = false;
            teamAndRoleBtn.Click += teamAndRoleBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 220);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // blueTeamTextbox
            // 
            blueTeamTextbox.BackColor = SystemColors.MenuHighlight;
            blueTeamTextbox.BorderStyle = BorderStyle.FixedSingle;
            blueTeamTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
            blueTeamTextbox.Location = new Point(284, 48);
            blueTeamTextbox.Multiline = true;
            blueTeamTextbox.Name = "blueTeamTextbox";
            blueTeamTextbox.ReadOnly = true;
            blueTeamTextbox.Size = new Size(145, 220);
            blueTeamTextbox.TabIndex = 8;
            // 
            // redTeamTextbox
            // 
            redTeamTextbox.BorderStyle = BorderStyle.FixedSingle;
            redTeamTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
            redTeamTextbox.Location = new Point(454, 48);
            redTeamTextbox.Multiline = true;
            redTeamTextbox.Name = "redTeamTextbox";
            redTeamTextbox.ReadOnly = true;
            redTeamTextbox.Size = new Size(145, 220);
            redTeamTextbox.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
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
            textBox3.Location = new Point(284, 19);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "Blue Team";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Red;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(454, 19);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(145, 23);
            textBox6.TabIndex = 13;
            textBox6.Text = "Red Team";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // mirrorMatchupCheckBox
            // 
            mirrorMatchupCheckBox.AutoSize = true;
            mirrorMatchupCheckBox.BackColor = Color.Transparent;
            mirrorMatchupCheckBox.ForeColor = SystemColors.ButtonFace;
            mirrorMatchupCheckBox.Location = new Point(461, 406);
            mirrorMatchupCheckBox.Name = "mirrorMatchupCheckBox";
            mirrorMatchupCheckBox.Size = new Size(115, 19);
            mirrorMatchupCheckBox.TabIndex = 14;
            mirrorMatchupCheckBox.Text = "Mirror Matchup?";
            mirrorMatchupCheckBox.UseVisualStyleBackColor = false;
            mirrorMatchupCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // roleSelectionBox
            // 
            roleSelectionBox.FormattingEnabled = true;
            roleSelectionBox.Location = new Point(647, 46);
            roleSelectionBox.Name = "roleSelectionBox";
            roleSelectionBox.Size = new Size(145, 23);
            roleSelectionBox.TabIndex = 17;
            roleSelectionBox.SelectionChangeCommitted += roleSelectionBox_SelectionChangeCommitted;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(  128,   255,   128);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(647, 17);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 18;
            textBox4.Text = "Role";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // championBtn
            // 
            championBtn.Location = new Point(647, 124);
            championBtn.Name = "championBtn";
            championBtn.RightToLeft = RightToLeft.No;
            championBtn.Size = new Size(145, 31);
            championBtn.TabIndex = 19;
            championBtn.Text = "Generate Champion";
            championBtn.UseVisualStyleBackColor = true;
            championBtn.Click += championBtn_Click;
            // 
            // randomChampionResultTextbox
            // 
            randomChampionResultTextbox.BorderStyle = BorderStyle.FixedSingle;
            randomChampionResultTextbox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            randomChampionResultTextbox.Location = new Point(647, 75);
            randomChampionResultTextbox.Multiline = true;
            randomChampionResultTextbox.Name = "randomChampionResultTextbox";
            randomChampionResultTextbox.Size = new Size(145, 43);
            randomChampionResultTextbox.TabIndex = 20;
            randomChampionResultTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // noOfParticipantsTextbox
            // 
            noOfParticipantsTextbox.Location = new Point(33, 273);
            noOfParticipantsTextbox.Name = "noOfParticipantsTextbox";
            noOfParticipantsTextbox.Size = new Size(100, 23);
            noOfParticipantsTextbox.TabIndex = 21;
            noOfParticipantsTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.League_map;
            ClientSize = new Size(804, 451);
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
    }
}