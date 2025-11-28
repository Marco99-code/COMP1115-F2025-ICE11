namespace ICE11
{
    partial class FinalForm
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
            Button_Back = new Button();
            Panel_CoreAttributes = new Panel();
            label1 = new Label();
            TextBox_WIL = new TextBox();
            TextBox_INT = new TextBox();
            Label_AGL = new Label();
            TextBox_PER = new TextBox();
            Label_STR = new Label();
            TextBox_VGR = new TextBox();
            Label_VGR = new Label();
            TextBox_STR = new TextBox();
            Label_PER = new Label();
            TextBox_AGL = new TextBox();
            Label_INT = new Label();
            Label_WIL = new Label();
            Panel_SecondaryAttributes = new Panel();
            Label_SecondaryAttributes = new Label();
            TextBox_RES = new TextBox();
            TextBox_TOU = new TextBox();
            TextBox_AWA = new TextBox();
            Label_RES = new Label();
            Label_TOU = new Label();
            Label_AWA = new Label();
            TextBox_Name = new TextBox();
            Label_Name = new Label();
            TextBox_Career = new TextBox();
            Label_Career = new Label();
            Label_Species = new Label();
            TextBox_Species = new TextBox();
            FinalFormMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            BinaryToolStripMenuItem = new ToolStripMenuItem();
            JSONToolStripMenuItem = new ToolStripMenuItem();
            TextToolStripMenuItem = new ToolStripMenuItem();
            FileToolStripSeparator = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            Panel_CoreAttributes.SuspendLayout();
            Panel_SecondaryAttributes.SuspendLayout();
            FinalFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Back
            // 
            Button_Back.Font = new Font("Calibri", 12F);
            Button_Back.Location = new Point(22, 246);
            Button_Back.Margin = new Padding(2, 1, 2, 1);
            Button_Back.Name = "Button_Back";
            Button_Back.Size = new Size(92, 33);
            Button_Back.TabIndex = 3;
            Button_Back.Text = "Back";
            Button_Back.UseVisualStyleBackColor = true;
            Button_Back.Click += Button_Back_Click;
            // 
            // Panel_CoreAttributes
            // 
            Panel_CoreAttributes.BorderStyle = BorderStyle.FixedSingle;
            Panel_CoreAttributes.Controls.Add(label1);
            Panel_CoreAttributes.Controls.Add(TextBox_WIL);
            Panel_CoreAttributes.Controls.Add(TextBox_INT);
            Panel_CoreAttributes.Controls.Add(Label_AGL);
            Panel_CoreAttributes.Controls.Add(TextBox_PER);
            Panel_CoreAttributes.Controls.Add(Label_STR);
            Panel_CoreAttributes.Controls.Add(TextBox_VGR);
            Panel_CoreAttributes.Controls.Add(Label_VGR);
            Panel_CoreAttributes.Controls.Add(TextBox_STR);
            Panel_CoreAttributes.Controls.Add(Label_PER);
            Panel_CoreAttributes.Controls.Add(TextBox_AGL);
            Panel_CoreAttributes.Controls.Add(Label_INT);
            Panel_CoreAttributes.Controls.Add(Label_WIL);
            Panel_CoreAttributes.Location = new Point(23, 128);
            Panel_CoreAttributes.Margin = new Padding(2, 1, 2, 1);
            Panel_CoreAttributes.Name = "Panel_CoreAttributes";
            Panel_CoreAttributes.Size = new Size(323, 81);
            Panel_CoreAttributes.TabIndex = 45;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 32;
            label1.Text = "Core Attributes";
            // 
            // TextBox_WIL
            // 
            TextBox_WIL.BackColor = SystemColors.Window;
            TextBox_WIL.BorderStyle = BorderStyle.FixedSingle;
            TextBox_WIL.Font = new Font("Calibri", 12F);
            TextBox_WIL.Location = new Point(268, 45);
            TextBox_WIL.Margin = new Padding(2, 1, 2, 1);
            TextBox_WIL.Name = "TextBox_WIL";
            TextBox_WIL.ReadOnly = true;
            TextBox_WIL.Size = new Size(43, 27);
            TextBox_WIL.TabIndex = 23;
            TextBox_WIL.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_INT
            // 
            TextBox_INT.BackColor = SystemColors.Window;
            TextBox_INT.BorderStyle = BorderStyle.FixedSingle;
            TextBox_INT.Font = new Font("Calibri", 12F);
            TextBox_INT.Location = new Point(216, 45);
            TextBox_INT.Margin = new Padding(2, 1, 2, 1);
            TextBox_INT.Name = "TextBox_INT";
            TextBox_INT.ReadOnly = true;
            TextBox_INT.Size = new Size(43, 27);
            TextBox_INT.TabIndex = 22;
            TextBox_INT.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_AGL
            // 
            Label_AGL.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_AGL.Location = new Point(12, 26);
            Label_AGL.Margin = new Padding(2, 0, 2, 0);
            Label_AGL.Name = "Label_AGL";
            Label_AGL.Size = new Size(43, 18);
            Label_AGL.TabIndex = 12;
            Label_AGL.Text = "AGL";
            Label_AGL.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_PER
            // 
            TextBox_PER.BackColor = SystemColors.Window;
            TextBox_PER.BorderStyle = BorderStyle.FixedSingle;
            TextBox_PER.Font = new Font("Calibri", 12F);
            TextBox_PER.Location = new Point(165, 45);
            TextBox_PER.Margin = new Padding(2, 1, 2, 1);
            TextBox_PER.Name = "TextBox_PER";
            TextBox_PER.ReadOnly = true;
            TextBox_PER.Size = new Size(43, 27);
            TextBox_PER.TabIndex = 21;
            TextBox_PER.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_STR
            // 
            Label_STR.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_STR.Location = new Point(63, 26);
            Label_STR.Margin = new Padding(2, 0, 2, 0);
            Label_STR.Name = "Label_STR";
            Label_STR.Size = new Size(43, 18);
            Label_STR.TabIndex = 13;
            Label_STR.Text = "STR";
            Label_STR.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_VGR
            // 
            TextBox_VGR.BackColor = SystemColors.Window;
            TextBox_VGR.BorderStyle = BorderStyle.FixedSingle;
            TextBox_VGR.Font = new Font("Calibri", 12F);
            TextBox_VGR.Location = new Point(114, 45);
            TextBox_VGR.Margin = new Padding(2, 1, 2, 1);
            TextBox_VGR.Name = "TextBox_VGR";
            TextBox_VGR.ReadOnly = true;
            TextBox_VGR.Size = new Size(43, 27);
            TextBox_VGR.TabIndex = 20;
            TextBox_VGR.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_VGR
            // 
            Label_VGR.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_VGR.Location = new Point(114, 26);
            Label_VGR.Margin = new Padding(2, 0, 2, 0);
            Label_VGR.Name = "Label_VGR";
            Label_VGR.Size = new Size(43, 18);
            Label_VGR.TabIndex = 14;
            Label_VGR.Text = "VGR";
            Label_VGR.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_STR
            // 
            TextBox_STR.BackColor = SystemColors.Window;
            TextBox_STR.BorderStyle = BorderStyle.FixedSingle;
            TextBox_STR.Font = new Font("Calibri", 12F);
            TextBox_STR.Location = new Point(63, 45);
            TextBox_STR.Margin = new Padding(2, 1, 2, 1);
            TextBox_STR.Name = "TextBox_STR";
            TextBox_STR.ReadOnly = true;
            TextBox_STR.Size = new Size(43, 27);
            TextBox_STR.TabIndex = 19;
            TextBox_STR.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_PER
            // 
            Label_PER.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_PER.Location = new Point(165, 26);
            Label_PER.Margin = new Padding(2, 0, 2, 0);
            Label_PER.Name = "Label_PER";
            Label_PER.Size = new Size(43, 18);
            Label_PER.TabIndex = 15;
            Label_PER.Text = "PER";
            Label_PER.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_AGL
            // 
            TextBox_AGL.BackColor = SystemColors.Window;
            TextBox_AGL.BorderStyle = BorderStyle.FixedSingle;
            TextBox_AGL.Font = new Font("Calibri", 12F);
            TextBox_AGL.Location = new Point(12, 45);
            TextBox_AGL.Margin = new Padding(2, 1, 2, 1);
            TextBox_AGL.Name = "TextBox_AGL";
            TextBox_AGL.ReadOnly = true;
            TextBox_AGL.Size = new Size(43, 27);
            TextBox_AGL.TabIndex = 18;
            TextBox_AGL.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_INT
            // 
            Label_INT.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_INT.Location = new Point(216, 26);
            Label_INT.Margin = new Padding(2, 0, 2, 0);
            Label_INT.Name = "Label_INT";
            Label_INT.Size = new Size(43, 18);
            Label_INT.TabIndex = 16;
            Label_INT.Text = "INT";
            Label_INT.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_WIL
            // 
            Label_WIL.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_WIL.Location = new Point(268, 26);
            Label_WIL.Margin = new Padding(2, 0, 2, 0);
            Label_WIL.Name = "Label_WIL";
            Label_WIL.Size = new Size(43, 18);
            Label_WIL.TabIndex = 17;
            Label_WIL.Text = "WIL";
            Label_WIL.TextAlign = ContentAlignment.TopCenter;
            // 
            // Panel_SecondaryAttributes
            // 
            Panel_SecondaryAttributes.BorderStyle = BorderStyle.FixedSingle;
            Panel_SecondaryAttributes.Controls.Add(Label_SecondaryAttributes);
            Panel_SecondaryAttributes.Controls.Add(TextBox_RES);
            Panel_SecondaryAttributes.Controls.Add(TextBox_TOU);
            Panel_SecondaryAttributes.Controls.Add(TextBox_AWA);
            Panel_SecondaryAttributes.Controls.Add(Label_RES);
            Panel_SecondaryAttributes.Controls.Add(Label_TOU);
            Panel_SecondaryAttributes.Controls.Add(Label_AWA);
            Panel_SecondaryAttributes.Location = new Point(362, 128);
            Panel_SecondaryAttributes.Margin = new Padding(2, 1, 2, 1);
            Panel_SecondaryAttributes.Name = "Panel_SecondaryAttributes";
            Panel_SecondaryAttributes.Size = new Size(192, 81);
            Panel_SecondaryAttributes.TabIndex = 46;
            // 
            // Label_SecondaryAttributes
            // 
            Label_SecondaryAttributes.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_SecondaryAttributes.Location = new Point(12, 4);
            Label_SecondaryAttributes.Margin = new Padding(2, 0, 2, 0);
            Label_SecondaryAttributes.Name = "Label_SecondaryAttributes";
            Label_SecondaryAttributes.Size = new Size(164, 21);
            Label_SecondaryAttributes.TabIndex = 33;
            Label_SecondaryAttributes.Text = "Secondary Attributes";
            // 
            // TextBox_RES
            // 
            TextBox_RES.BackColor = SystemColors.Window;
            TextBox_RES.BorderStyle = BorderStyle.FixedSingle;
            TextBox_RES.Font = new Font("Calibri", 12F);
            TextBox_RES.Location = new Point(114, 50);
            TextBox_RES.Margin = new Padding(2, 1, 2, 1);
            TextBox_RES.Name = "TextBox_RES";
            TextBox_RES.ReadOnly = true;
            TextBox_RES.Size = new Size(43, 27);
            TextBox_RES.TabIndex = 29;
            TextBox_RES.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_TOU
            // 
            TextBox_TOU.BackColor = SystemColors.Window;
            TextBox_TOU.BorderStyle = BorderStyle.FixedSingle;
            TextBox_TOU.Font = new Font("Calibri", 12F);
            TextBox_TOU.Location = new Point(63, 50);
            TextBox_TOU.Margin = new Padding(2, 1, 2, 1);
            TextBox_TOU.Name = "TextBox_TOU";
            TextBox_TOU.ReadOnly = true;
            TextBox_TOU.Size = new Size(43, 27);
            TextBox_TOU.TabIndex = 28;
            TextBox_TOU.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_AWA
            // 
            TextBox_AWA.BackColor = SystemColors.Window;
            TextBox_AWA.BorderStyle = BorderStyle.FixedSingle;
            TextBox_AWA.Font = new Font("Calibri", 12F);
            TextBox_AWA.Location = new Point(12, 50);
            TextBox_AWA.Margin = new Padding(2, 1, 2, 1);
            TextBox_AWA.Name = "TextBox_AWA";
            TextBox_AWA.ReadOnly = true;
            TextBox_AWA.Size = new Size(43, 27);
            TextBox_AWA.TabIndex = 27;
            TextBox_AWA.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_RES
            // 
            Label_RES.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_RES.Location = new Point(114, 30);
            Label_RES.Margin = new Padding(2, 0, 2, 0);
            Label_RES.Name = "Label_RES";
            Label_RES.Size = new Size(43, 18);
            Label_RES.TabIndex = 26;
            Label_RES.Text = "RES";
            Label_RES.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_TOU
            // 
            Label_TOU.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_TOU.Location = new Point(63, 30);
            Label_TOU.Margin = new Padding(2, 0, 2, 0);
            Label_TOU.Name = "Label_TOU";
            Label_TOU.Size = new Size(43, 18);
            Label_TOU.TabIndex = 25;
            Label_TOU.Text = "TOU";
            Label_TOU.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_AWA
            // 
            Label_AWA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_AWA.Location = new Point(11, 30);
            Label_AWA.Margin = new Padding(2, 0, 2, 0);
            Label_AWA.Name = "Label_AWA";
            Label_AWA.Size = new Size(48, 18);
            Label_AWA.TabIndex = 24;
            Label_AWA.Text = "AWA";
            Label_AWA.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_Name
            // 
            TextBox_Name.BackColor = SystemColors.Window;
            TextBox_Name.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Name.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox_Name.Location = new Point(23, 91);
            TextBox_Name.Margin = new Padding(2, 1, 2, 1);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.ReadOnly = true;
            TextBox_Name.Size = new Size(195, 27);
            TextBox_Name.TabIndex = 51;
            // 
            // Label_Name
            // 
            Label_Name.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_Name.Location = new Point(23, 64);
            Label_Name.Margin = new Padding(2, 0, 2, 0);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(131, 21);
            Label_Name.TabIndex = 33;
            Label_Name.Text = "Character Name";
            // 
            // TextBox_Career
            // 
            TextBox_Career.BackColor = SystemColors.Window;
            TextBox_Career.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Career.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox_Career.Location = new Point(254, 91);
            TextBox_Career.Margin = new Padding(2, 1, 2, 1);
            TextBox_Career.Name = "TextBox_Career";
            TextBox_Career.ReadOnly = true;
            TextBox_Career.Size = new Size(132, 27);
            TextBox_Career.TabIndex = 52;
            // 
            // Label_Career
            // 
            Label_Career.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_Career.Location = new Point(254, 64);
            Label_Career.Margin = new Padding(2, 0, 2, 0);
            Label_Career.Name = "Label_Career";
            Label_Career.Size = new Size(131, 21);
            Label_Career.TabIndex = 53;
            Label_Career.Text = "Career";
            // 
            // Label_Species
            // 
            Label_Species.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_Species.Location = new Point(422, 64);
            Label_Species.Margin = new Padding(2, 0, 2, 0);
            Label_Species.Name = "Label_Species";
            Label_Species.Size = new Size(131, 21);
            Label_Species.TabIndex = 55;
            Label_Species.Text = "Species";
            // 
            // TextBox_Species
            // 
            TextBox_Species.BackColor = SystemColors.Window;
            TextBox_Species.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Species.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox_Species.Location = new Point(422, 91);
            TextBox_Species.Margin = new Padding(2, 1, 2, 1);
            TextBox_Species.Name = "TextBox_Species";
            TextBox_Species.ReadOnly = true;
            TextBox_Species.Size = new Size(132, 27);
            TextBox_Species.TabIndex = 54;
            // 
            // FinalFormMenuStrip
            // 
            FinalFormMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, HelpToolStripMenuItem });
            FinalFormMenuStrip.Location = new Point(0, 0);
            FinalFormMenuStrip.Name = "FinalFormMenuStrip";
            FinalFormMenuStrip.Size = new Size(578, 24);
            FinalFormMenuStrip.TabIndex = 56;
            FinalFormMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveAsToolStripMenuItem, FileToolStripSeparator, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(37, 20);
            FileToolStripMenuItem.Text = "&File";
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BinaryToolStripMenuItem, JSONToolStripMenuItem, TextToolStripMenuItem });
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(180, 22);
            SaveAsToolStripMenuItem.Text = "Save &As";
            // 
            // BinaryToolStripMenuItem
            // 
            BinaryToolStripMenuItem.Name = "BinaryToolStripMenuItem";
            BinaryToolStripMenuItem.Size = new Size(180, 22);
            BinaryToolStripMenuItem.Text = "Binary File";
            // 
            // JSONToolStripMenuItem
            // 
            JSONToolStripMenuItem.Name = "JSONToolStripMenuItem";
            JSONToolStripMenuItem.Size = new Size(180, 22);
            JSONToolStripMenuItem.Text = "JSON File";
            // 
            // TextToolStripMenuItem
            // 
            TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            TextToolStripMenuItem.Size = new Size(180, 22);
            TextToolStripMenuItem.Text = "Text File";
            // 
            // FileToolStripSeparator
            // 
            FileToolStripSeparator.Name = "FileToolStripSeparator";
            FileToolStripSeparator.Size = new Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(180, 22);
            ExitToolStripMenuItem.Text = "E&xit";
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(44, 20);
            HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(180, 22);
            AboutToolStripMenuItem.Text = "&About...";
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 295);
            Controls.Add(Label_Species);
            Controls.Add(TextBox_Species);
            Controls.Add(Label_Career);
            Controls.Add(TextBox_Career);
            Controls.Add(Label_Name);
            Controls.Add(TextBox_Name);
            Controls.Add(Panel_SecondaryAttributes);
            Controls.Add(Panel_CoreAttributes);
            Controls.Add(Button_Back);
            Controls.Add(FinalFormMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = FinalFormMenuStrip;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "FinalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalForm";
            Activated += FinalForm_Load;
            FormClosing += FinalForm_FormClosing;
            Load += FinalForm_Load;
            Panel_CoreAttributes.ResumeLayout(false);
            Panel_CoreAttributes.PerformLayout();
            Panel_SecondaryAttributes.ResumeLayout(false);
            Panel_SecondaryAttributes.PerformLayout();
            FinalFormMenuStrip.ResumeLayout(false);
            FinalFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Back;
        private Panel Panel_CoreAttributes;
        private Label label1;
        private TextBox TextBox_WIL;
        private TextBox TextBox_INT;
        private Label Label_AGL;
        private TextBox TextBox_PER;
        private Label Label_STR;
        private TextBox TextBox_VGR;
        private Label Label_VGR;
        private TextBox TextBox_STR;
        private Label Label_PER;
        private TextBox TextBox_AGL;
        private Label Label_INT;
        private Label Label_WIL;
        private Panel Panel_SecondaryAttributes;
        private Label Label_SecondaryAttributes;
        private TextBox TextBox_RES;
        private TextBox TextBox_TOU;
        private TextBox TextBox_AWA;
        private Label Label_RES;
        private Label Label_TOU;
        private Label Label_AWA;
        private TextBox TextBox_Name;
        private Label Label_Name;
        private TextBox TextBox_Career;
        private Label Label_Career;
        private Label Label_Species;
        private TextBox TextBox_Species;
        private MenuStrip FinalFormMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripSeparator FileToolStripSeparator;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem BinaryToolStripMenuItem;
        private ToolStripMenuItem JSONToolStripMenuItem;
        private ToolStripMenuItem TextToolStripMenuItem;
    }
}