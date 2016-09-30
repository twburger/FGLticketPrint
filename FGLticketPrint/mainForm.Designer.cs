using System.Drawing.Printing;

namespace FGLticketPrint
{
    partial class MainForm
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
            this.FGLcodeTextBox = new System.Windows.Forms.TextBox();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFGLCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFGLcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPrinterToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FGLpictureBox = new System.Windows.Forms.PictureBox();
            this.UploadImgButton = new System.Windows.Forms.Button();
            this.PrintTicketsButton = new System.Windows.Forms.Button();
            this.TicketNumberStart_textBox = new System.Windows.Forms.TextBox();
            this.TicketNumberEnd_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Count1End_textBox = new System.Windows.Forms.TextBox();
            this.Count1Start_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Count2End_textBox = new System.Windows.Forms.TextBox();
            this.Count2Start_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Count3End_textBox = new System.Windows.Forms.TextBox();
            this.Count3Start_textBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FGLimageNameTextBox = new System.Windows.Forms.TextBox();
            this.FGLCodeFileNametextBox = new System.Windows.Forms.TextBox();
            this.PrinterSelectionTextBox = new System.Windows.Forms.TextBox();
            this.PrinterSelectionlabel = new System.Windows.Forms.Label();
            this.PrinterStatusLabel = new System.Windows.Forms.Label();
            this.PrinterStatusTextBox = new System.Windows.Forms.TextBox();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FGLpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FGLcodeTextBox
            // 
            this.FGLcodeTextBox.Location = new System.Drawing.Point(0, 59);
            this.FGLcodeTextBox.Multiline = true;
            this.FGLcodeTextBox.Name = "FGLcodeTextBox";
            this.FGLcodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FGLcodeTextBox.Size = new System.Drawing.Size(487, 499);
            this.FGLcodeTextBox.TabIndex = 0;
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printerToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1196, 28);
            this.MainFormMenuStrip.TabIndex = 1;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFGLCodeToolStripMenuItem,
            this.SaveFGLcodeToolStripMenuItem,
            this.selectImageToolStripMenuItem,
            this.quitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // selectFGLCodeToolStripMenuItem
            // 
            this.selectFGLCodeToolStripMenuItem.Name = "selectFGLCodeToolStripMenuItem";
            this.selectFGLCodeToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.selectFGLCodeToolStripMenuItem.Text = "Select  FGL &Code";
            this.selectFGLCodeToolStripMenuItem.Click += new System.EventHandler(this.selectFGLCodeToolStripMenuItem_Click);
            // 
            // SaveFGLcodeToolStripMenuItem
            // 
            this.SaveFGLcodeToolStripMenuItem.Name = "SaveFGLcodeToolStripMenuItem";
            this.SaveFGLcodeToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.SaveFGLcodeToolStripMenuItem.Text = "&Save FGL Code";
            this.SaveFGLcodeToolStripMenuItem.Click += new System.EventHandler(this.SaveFGLcodeToolStripMenuItem_Click);
            // 
            // selectImageToolStripMenuItem
            // 
            this.selectImageToolStripMenuItem.Name = "selectImageToolStripMenuItem";
            this.selectImageToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.selectImageToolStripMenuItem.Text = "Select &Image";
            this.selectImageToolStripMenuItem.Click += new System.EventHandler(this.selectImageToolStripMenuItem_Click);
            // 
            // quitProgramToolStripMenuItem
            // 
            this.quitProgramToolStripMenuItem.Name = "quitProgramToolStripMenuItem";
            this.quitProgramToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.quitProgramToolStripMenuItem.Text = "&Quit Program";
            this.quitProgramToolStripMenuItem.Click += new System.EventHandler(this.quitProgramToolStripMenuItem_Click);
            // 
            // printerToolStripMenuItem
            // 
            this.printerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectPrinterToolStripComboBox});
            this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
            this.printerToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.printerToolStripMenuItem.Text = "&Printer";
            // 
            // selectPrinterToolStripComboBox
            // 
            this.selectPrinterToolStripComboBox.DropDownWidth = 264;
            this.selectPrinterToolStripComboBox.Name = "selectPrinterToolStripComboBox";
            this.selectPrinterToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.selectPrinterToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.selectPrinterToolStripComboBox_SelectedIndexChanged);
            // 
            // FGLpictureBox
            // 
            this.FGLpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FGLpictureBox.Location = new System.Drawing.Point(858, 59);
            this.FGLpictureBox.Name = "FGLpictureBox";
            this.FGLpictureBox.Size = new System.Drawing.Size(331, 222);
            this.FGLpictureBox.TabIndex = 2;
            this.FGLpictureBox.TabStop = false;
            // 
            // UploadImgButton
            // 
            this.UploadImgButton.Location = new System.Drawing.Point(1071, 287);
            this.UploadImgButton.Name = "UploadImgButton";
            this.UploadImgButton.Size = new System.Drawing.Size(118, 43);
            this.UploadImgButton.TabIndex = 3;
            this.UploadImgButton.Text = "Upload Image to Printer";
            this.UploadImgButton.UseVisualStyleBackColor = true;
            // 
            // PrintTicketsButton
            // 
            this.PrintTicketsButton.Location = new System.Drawing.Point(502, 498);
            this.PrintTicketsButton.Name = "PrintTicketsButton";
            this.PrintTicketsButton.Size = new System.Drawing.Size(96, 60);
            this.PrintTicketsButton.TabIndex = 4;
            this.PrintTicketsButton.Text = "Print";
            this.PrintTicketsButton.UseVisualStyleBackColor = true;
            // 
            // TicketNumberStart_textBox
            // 
            this.TicketNumberStart_textBox.Location = new System.Drawing.Point(916, 376);
            this.TicketNumberStart_textBox.MaxLength = 5;
            this.TicketNumberStart_textBox.Name = "TicketNumberStart_textBox";
            this.TicketNumberStart_textBox.Size = new System.Drawing.Size(62, 22);
            this.TicketNumberStart_textBox.TabIndex = 0;
            this.TicketNumberStart_textBox.TabStop = false;
            this.TicketNumberStart_textBox.Text = "0";
            this.TicketNumberStart_textBox.WordWrap = false;
            this.TicketNumberStart_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // TicketNumberEnd_textBox
            // 
            this.TicketNumberEnd_textBox.Location = new System.Drawing.Point(1010, 376);
            this.TicketNumberEnd_textBox.MaxLength = 5;
            this.TicketNumberEnd_textBox.Name = "TicketNumberEnd_textBox";
            this.TicketNumberEnd_textBox.Size = new System.Drawing.Size(62, 22);
            this.TicketNumberEnd_textBox.TabIndex = 5;
            this.TicketNumberEnd_textBox.TabStop = false;
            this.TicketNumberEnd_textBox.Text = "0";
            this.TicketNumberEnd_textBox.WordWrap = false;
            this.TicketNumberEnd_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(984, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ticket Count (Replaces #####)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FGL Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Counter 1 (Replaces 1####)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nested Counter 2 (Replaces 2####)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nested Counter 3 (Replaces 3####)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(984, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "to";
            // 
            // Count1End_textBox
            // 
            this.Count1End_textBox.Location = new System.Drawing.Point(1010, 421);
            this.Count1End_textBox.MaxLength = 5;
            this.Count1End_textBox.Name = "Count1End_textBox";
            this.Count1End_textBox.Size = new System.Drawing.Size(62, 22);
            this.Count1End_textBox.TabIndex = 13;
            this.Count1End_textBox.TabStop = false;
            this.Count1End_textBox.Text = "0";
            this.Count1End_textBox.WordWrap = false;
            this.Count1End_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // Count1Start_textBox
            // 
            this.Count1Start_textBox.Location = new System.Drawing.Point(916, 421);
            this.Count1Start_textBox.MaxLength = 5;
            this.Count1Start_textBox.Name = "Count1Start_textBox";
            this.Count1Start_textBox.Size = new System.Drawing.Size(62, 22);
            this.Count1Start_textBox.TabIndex = 12;
            this.Count1Start_textBox.TabStop = false;
            this.Count1Start_textBox.Text = "0";
            this.Count1Start_textBox.WordWrap = false;
            this.Count1Start_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1009, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "to";
            // 
            // Count2End_textBox
            // 
            this.Count2End_textBox.Location = new System.Drawing.Point(1035, 466);
            this.Count2End_textBox.MaxLength = 5;
            this.Count2End_textBox.Name = "Count2End_textBox";
            this.Count2End_textBox.Size = new System.Drawing.Size(62, 22);
            this.Count2End_textBox.TabIndex = 16;
            this.Count2End_textBox.TabStop = false;
            this.Count2End_textBox.Text = "0";
            this.Count2End_textBox.WordWrap = false;
            this.Count2End_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // Count2Start_textBox
            // 
            this.Count2Start_textBox.Location = new System.Drawing.Point(941, 466);
            this.Count2Start_textBox.MaxLength = 5;
            this.Count2Start_textBox.Name = "Count2Start_textBox";
            this.Count2Start_textBox.Size = new System.Drawing.Size(62, 22);
            this.Count2Start_textBox.TabIndex = 15;
            this.Count2Start_textBox.TabStop = false;
            this.Count2Start_textBox.Text = "0";
            this.Count2Start_textBox.WordWrap = false;
            this.Count2Start_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1035, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "to";
            // 
            // Count3End_textBox
            // 
            this.Count3End_textBox.Location = new System.Drawing.Point(1061, 512);
            this.Count3End_textBox.MaxLength = 5;
            this.Count3End_textBox.Name = "Count3End_textBox";
            this.Count3End_textBox.Size = new System.Drawing.Size(62, 22);
            this.Count3End_textBox.TabIndex = 19;
            this.Count3End_textBox.TabStop = false;
            this.Count3End_textBox.Text = "0";
            this.Count3End_textBox.WordWrap = false;
            this.Count3End_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // Count3Start_textBox
            // 
            this.Count3Start_textBox.Location = new System.Drawing.Point(967, 512);
            this.Count3Start_textBox.MaxLength = 5;
            this.Count3Start_textBox.Name = "Count3Start_textBox";
            this.Count3Start_textBox.Size = new System.Drawing.Size(62, 22);
            this.Count3Start_textBox.TabIndex = 18;
            this.Count3Start_textBox.TabStop = false;
            this.Count3Start_textBox.Text = "0";
            this.Count3Start_textBox.WordWrap = false;
            this.Count3Start_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsDigit_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(493, 59);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox8.Size = new System.Drawing.Size(359, 433);
            this.textBox8.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Messages";
            // 
            // FGLimageNameTextBox
            // 
            this.FGLimageNameTextBox.Location = new System.Drawing.Point(858, 33);
            this.FGLimageNameTextBox.Name = "FGLimageNameTextBox";
            this.FGLimageNameTextBox.ReadOnly = true;
            this.FGLimageNameTextBox.Size = new System.Drawing.Size(331, 22);
            this.FGLimageNameTextBox.TabIndex = 23;
            // 
            // FGLCodeFileNametextBox
            // 
            this.FGLCodeFileNametextBox.Location = new System.Drawing.Point(92, 32);
            this.FGLCodeFileNametextBox.Name = "FGLCodeFileNametextBox";
            this.FGLCodeFileNametextBox.ReadOnly = true;
            this.FGLCodeFileNametextBox.Size = new System.Drawing.Size(395, 22);
            this.FGLCodeFileNametextBox.TabIndex = 24;
            // 
            // PrinterSelectionTextBox
            // 
            this.PrinterSelectionTextBox.Location = new System.Drawing.Point(296, 2);
            this.PrinterSelectionTextBox.Name = "PrinterSelectionTextBox";
            this.PrinterSelectionTextBox.ReadOnly = true;
            this.PrinterSelectionTextBox.Size = new System.Drawing.Size(279, 22);
            this.PrinterSelectionTextBox.TabIndex = 25;
            // 
            // PrinterSelectionlabel
            // 
            this.PrinterSelectionlabel.AutoSize = true;
            this.PrinterSelectionlabel.Location = new System.Drawing.Point(187, 5);
            this.PrinterSelectionlabel.Name = "PrinterSelectionlabel";
            this.PrinterSelectionlabel.Size = new System.Drawing.Size(109, 17);
            this.PrinterSelectionlabel.TabIndex = 26;
            this.PrinterSelectionlabel.Text = "Printer Selected";
            // 
            // PrinterStatusLabel
            // 
            this.PrinterStatusLabel.AutoSize = true;
            this.PrinterStatusLabel.Location = new System.Drawing.Point(581, 5);
            this.PrinterStatusLabel.Name = "PrinterStatusLabel";
            this.PrinterStatusLabel.Size = new System.Drawing.Size(94, 17);
            this.PrinterStatusLabel.TabIndex = 28;
            this.PrinterStatusLabel.Text = "Printer Status";
            // 
            // PrinterStatusTextBox
            // 
            this.PrinterStatusTextBox.Location = new System.Drawing.Point(675, 2);
            this.PrinterStatusTextBox.Name = "PrinterStatusTextBox";
            this.PrinterStatusTextBox.ReadOnly = true;
            this.PrinterStatusTextBox.Size = new System.Drawing.Size(514, 22);
            this.PrinterStatusTextBox.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 558);
            this.Controls.Add(this.PrinterStatusLabel);
            this.Controls.Add(this.PrinterStatusTextBox);
            this.Controls.Add(this.PrinterSelectionlabel);
            this.Controls.Add(this.PrinterSelectionTextBox);
            this.Controls.Add(this.FGLCodeFileNametextBox);
            this.Controls.Add(this.FGLimageNameTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Count3End_textBox);
            this.Controls.Add(this.Count3Start_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Count2End_textBox);
            this.Controls.Add(this.Count2Start_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Count1End_textBox);
            this.Controls.Add(this.Count1Start_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketNumberEnd_textBox);
            this.Controls.Add(this.TicketNumberStart_textBox);
            this.Controls.Add(this.PrintTicketsButton);
            this.Controls.Add(this.UploadImgButton);
            this.Controls.Add(this.FGLpictureBox);
            this.Controls.Add(this.FGLcodeTextBox);
            this.Controls.Add(this.MainFormMenuStrip);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "clubZone FGL Ticket Printer";
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FGLpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FGLcodeTextBox;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox selectPrinterToolStripComboBox;
        private System.Windows.Forms.PictureBox FGLpictureBox;
        private System.Windows.Forms.Button UploadImgButton;
        private System.Windows.Forms.Button PrintTicketsButton;
        private System.Windows.Forms.TextBox TicketNumberStart_textBox;
        private System.Windows.Forms.TextBox TicketNumberEnd_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Count1End_textBox;
        private System.Windows.Forms.TextBox Count1Start_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Count2End_textBox;
        private System.Windows.Forms.TextBox Count2Start_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Count3End_textBox;
        private System.Windows.Forms.TextBox Count3Start_textBox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FGLimageNameTextBox;
        private System.Windows.Forms.TextBox FGLCodeFileNametextBox;
        private System.Windows.Forms.ToolStripMenuItem selectFGLCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFGLcodeToolStripMenuItem;
        private System.Windows.Forms.TextBox PrinterSelectionTextBox;
        private System.Windows.Forms.Label PrinterSelectionlabel;
        private System.Windows.Forms.Label PrinterStatusLabel;
        private System.Windows.Forms.TextBox PrinterStatusTextBox;
    }
}

