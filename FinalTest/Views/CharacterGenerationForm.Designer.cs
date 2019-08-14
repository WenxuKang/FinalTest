﻿namespace FinalTest
{
    partial class CharacterGenerationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGenerationForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.identityTab = new System.Windows.Forms.TabPage();
            this.abilitiesTab = new System.Windows.Forms.TabPage();
            this.CharacterSheet = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameLastLabel = new System.Windows.Forms.Label();
            this.DisplayFirstName = new System.Windows.Forms.Label();
            this.DisplayLastName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.SocialLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.LastLabel = new System.Windows.Forms.Label();
            this.abilities = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.identityTab.SuspendLayout();
            this.abilitiesTab.SuspendLayout();
            this.CharacterSheet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.identityTab);
            this.MainTabControl.Controls.Add(this.abilitiesTab);
            this.MainTabControl.Controls.Add(this.CharacterSheet);
            this.MainTabControl.Location = new System.Drawing.Point(20, 14);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(690, 506);
            this.MainTabControl.TabIndex = 0;
            // 
            // identityTab
            // 
            this.identityTab.Controls.Add(this.tableLayoutPanel1);
            this.identityTab.Location = new System.Drawing.Point(4, 29);
            this.identityTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.identityTab.Name = "identityTab";
            this.identityTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.identityTab.Size = new System.Drawing.Size(682, 473);
            this.identityTab.TabIndex = 0;
            this.identityTab.Text = "Identity";
            this.identityTab.UseVisualStyleBackColor = true;
            // 
            // abilitiesTab
            // 
            this.abilitiesTab.Controls.Add(this.tableLayoutPanel2);
            this.abilitiesTab.Location = new System.Drawing.Point(4, 29);
            this.abilitiesTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abilitiesTab.Name = "abilitiesTab";
            this.abilitiesTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abilitiesTab.Size = new System.Drawing.Size(682, 473);
            this.abilitiesTab.TabIndex = 1;
            this.abilitiesTab.Text = "Abilities";
            this.abilitiesTab.UseVisualStyleBackColor = true;
            // 
            // CharacterSheet
            // 
            this.CharacterSheet.Controls.Add(this.tableLayoutPanel3);
            this.CharacterSheet.Controls.Add(this.menuStrip1);
            this.CharacterSheet.Location = new System.Drawing.Point(4, 29);
            this.CharacterSheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CharacterSheet.Name = "CharacterSheet";
            this.CharacterSheet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CharacterSheet.Size = new System.Drawing.Size(682, 473);
            this.CharacterSheet.TabIndex = 2;
            this.CharacterSheet.Text = "Character Sheet";
            this.CharacterSheet.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DisplayLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DisplayFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameDataLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastNameLastLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GenerateNameButton, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameDataLabel.Location = new System.Drawing.Point(4, 1);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(153, 86);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.Text = "FirstName";
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLastLabel
            // 
            this.LastNameLastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLastLabel.Location = new System.Drawing.Point(4, 88);
            this.LastNameLastLabel.Name = "LastNameLastLabel";
            this.LastNameLastLabel.Size = new System.Drawing.Size(153, 86);
            this.LastNameLastLabel.TabIndex = 1;
            this.LastNameLastLabel.Text = "LastName";
            this.LastNameLastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayFirstName
            // 
            this.DisplayFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayFirstName.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayFirstName, 3);
            this.DisplayFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFirstName.Location = new System.Drawing.Point(164, 1);
            this.DisplayFirstName.Name = "DisplayFirstName";
            this.DisplayFirstName.Size = new System.Drawing.Size(476, 86);
            this.DisplayFirstName.TabIndex = 2;
            this.DisplayFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayLastName
            // 
            this.DisplayLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayLastName.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayLastName, 3);
            this.DisplayLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLastName.Location = new System.Drawing.Point(164, 88);
            this.DisplayLastName.Name = "DisplayLastName";
            this.DisplayLastName.Size = new System.Drawing.Size(476, 86);
            this.DisplayLastName.TabIndex = 5;
            this.DisplayLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DexterityLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.StrengthLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EnduranceLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.IntellectLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.EducationLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.SocialLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(42, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(614, 363);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(324, 265);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(316, 83);
            this.GenerateNameButton.TabIndex = 6;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(309, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate Abilities";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(208, 45);
            this.StrengthLabel.TabIndex = 8;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.AutoSize = true;
            this.EnduranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 90);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(208, 45);
            this.EnduranceLabel.TabIndex = 9;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.AutoSize = true;
            this.EducationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationLabel.Location = new System.Drawing.Point(3, 180);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(208, 45);
            this.EducationLabel.TabIndex = 10;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocialLabel
            // 
            this.SocialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialLabel.AutoSize = true;
            this.SocialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocialLabel.Location = new System.Drawing.Point(3, 225);
            this.SocialLabel.Name = "SocialLabel";
            this.SocialLabel.Size = new System.Drawing.Size(208, 45);
            this.SocialLabel.TabIndex = 11;
            this.SocialLabel.Text = "Social  Standing";
            this.SocialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityLabel.Location = new System.Drawing.Point(3, 45);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(208, 45);
            this.DexterityLabel.TabIndex = 12;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.AutoSize = true;
            this.IntellectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntellectLabel.Location = new System.Drawing.Point(3, 135);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(208, 45);
            this.IntellectLabel.TabIndex = 13;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(217, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 45);
            this.label1.TabIndex = 14;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(217, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 45);
            this.label2.TabIndex = 15;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(217, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 45);
            this.label3.TabIndex = 16;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(217, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 45);
            this.label4.TabIndex = 17;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(217, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 45);
            this.label5.TabIndex = 18;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(217, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 45);
            this.label6.TabIndex = 19;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.FirstLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LastLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.abilities, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(24, 32);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(618, 325);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // FirstLabel
            // 
            this.FirstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(148, 81);
            this.FirstLabel.TabIndex = 7;
            this.FirstLabel.Text = "FirstName";
            this.FirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastLabel
            // 
            this.LastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLabel.Location = new System.Drawing.Point(3, 81);
            this.LastLabel.Name = "LastLabel";
            this.LastLabel.Size = new System.Drawing.Size(148, 81);
            this.LastLabel.TabIndex = 8;
            this.LastLabel.Text = "LastName";
            this.LastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abilities
            // 
            this.abilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilities.Location = new System.Drawing.Point(3, 162);
            this.abilities.Name = "abilities";
            this.abilities.Size = new System.Drawing.Size(148, 81);
            this.abilities.TabIndex = 9;
            this.abilities.Text = "Abilities";
            this.abilities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 82);
            this.label7.TabIndex = 10;
            this.label7.Text = "Skills";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CharacterGenerationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterGenerationForm";
            this.MainTabControl.ResumeLayout(false);
            this.identityTab.ResumeLayout(false);
            this.abilitiesTab.ResumeLayout(false);
            this.CharacterSheet.ResumeLayout(false);
            this.CharacterSheet.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage identityTab;
        private System.Windows.Forms.TabPage abilitiesTab;
        private System.Windows.Forms.TabPage CharacterSheet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DisplayLastName;
        private System.Windows.Forms.Label DisplayFirstName;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameLastLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label LastLabel;
        private System.Windows.Forms.Label abilities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}