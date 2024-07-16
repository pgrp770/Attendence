namespace Attendence
{
    partial class ClockForm
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
            labelIdentetyHeader = new Label();
            labelEnteryDate = new Label();
            labelExitDate = new Label();
            labelExitDateHeader = new Label();
            labelEntryDateHeader = new Label();
            labelIdentetyNumber = new Label();
            linkLabelCancel = new LinkLabel();
            buttonEnter = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelIdentetyHeader
            // 
            labelIdentetyHeader.AutoSize = true;
            labelIdentetyHeader.Location = new Point(319, 102);
            labelIdentetyHeader.Name = "labelIdentetyHeader";
            labelIdentetyHeader.Size = new Size(115, 32);
            labelIdentetyHeader.TabIndex = 0;
            labelIdentetyHeader.Text = "זהות עובד";
            // 
            // labelEnteryDate
            // 
            labelEnteryDate.AutoSize = true;
            labelEnteryDate.ForeColor = Color.FromArgb(0, 192, 0);
            labelEnteryDate.Location = new Point(399, 238);
            labelEnteryDate.Name = "labelEnteryDate";
            labelEnteryDate.Size = new Size(78, 32);
            labelEnteryDate.TabIndex = 1;
            labelEnteryDate.Text = "label2";
            // 
            // labelExitDate
            // 
            labelExitDate.AutoSize = true;
            labelExitDate.ForeColor = Color.FromArgb(255, 128, 128);
            labelExitDate.Location = new Point(399, 354);
            labelExitDate.Name = "labelExitDate";
            labelExitDate.Size = new Size(78, 32);
            labelExitDate.TabIndex = 2;
            labelExitDate.Text = "label3";
            // 
            // labelExitDateHeader
            // 
            labelExitDateHeader.AutoSize = true;
            labelExitDateHeader.Location = new Point(337, 295);
            labelExitDateHeader.Name = "labelExitDateHeader";
            labelExitDateHeader.Size = new Size(205, 32);
            labelExitDateHeader.TabIndex = 3;
            labelExitDateHeader.Text = "תאריך יציאה אחרון";
            // 
            // labelEntryDateHeader
            // 
            labelEntryDateHeader.AutoSize = true;
            labelEntryDateHeader.Location = new Point(337, 186);
            labelEntryDateHeader.Name = "labelEntryDateHeader";
            labelEntryDateHeader.Size = new Size(209, 32);
            labelEntryDateHeader.TabIndex = 4;
            labelEntryDateHeader.Text = "תאריך כניסה אחרון";
            // 
            // labelIdentetyNumber
            // 
            labelIdentetyNumber.AutoSize = true;
            labelIdentetyNumber.ForeColor = Color.FromArgb(0, 192, 0);
            labelIdentetyNumber.Location = new Point(468, 102);
            labelIdentetyNumber.Name = "labelIdentetyNumber";
            labelIdentetyNumber.Size = new Size(78, 32);
            labelIdentetyNumber.TabIndex = 5;
            labelIdentetyNumber.Text = "label6";
            // 
            // linkLabelCancel
            // 
            linkLabelCancel.AutoSize = true;
            linkLabelCancel.Location = new Point(406, 441);
            linkLabelCancel.Name = "linkLabelCancel";
            linkLabelCancel.Size = new Size(71, 32);
            linkLabelCancel.TabIndex = 6;
            linkLabelCancel.TabStop = true;
            linkLabelCancel.Text = "יציאה";
            linkLabelCancel.LinkClicked += linkLabelCancel_LinkClicked;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(128, 255, 128);
            buttonEnter.Location = new Point(281, 505);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(113, 100);
            buttonEnter.TabIndex = 7;
            buttonEnter.Text = "כניסה";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(255, 128, 128);
            buttonExit.Location = new Point(468, 505);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(113, 100);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "יציאה";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 731);
            Controls.Add(buttonExit);
            Controls.Add(buttonEnter);
            Controls.Add(linkLabelCancel);
            Controls.Add(labelIdentetyNumber);
            Controls.Add(labelEntryDateHeader);
            Controls.Add(labelExitDateHeader);
            Controls.Add(labelExitDate);
            Controls.Add(labelEnteryDate);
            Controls.Add(labelIdentetyHeader);
            Name = "ClockForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ClockForm";
            FormClosed += ClockForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdentetyHeader;
        private Label labelEnteryDate;
        private Label labelExitDate;
        private Label labelExitDateHeader;
        private Label labelEntryDateHeader;
        private Label labelIdentetyNumber;
        private LinkLabel linkLabelCancel;
        private Button buttonEnter;
        private Button buttonExit;
    }
}