namespace Attendence
{
    partial class PasswordChangeForm
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
            labelTz = new Label();
            labelNewPassword = new Label();
            labelOldPassword = new Label();
            labelAcceptNewPassword = new Label();
            textBoxTz = new TextBox();
            textBoxOldPssword = new TextBox();
            textBoxAcceptNewPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            buttonChangeNewPassword = new Button();
            linkLabelCancel = new LinkLabel();
            SuspendLayout();
            // 
            // labelTz
            // 
            labelTz.AutoSize = true;
            labelTz.Location = new Point(149, 121);
            labelTz.Name = "labelTz";
            labelTz.Size = new Size(134, 32);
            labelTz.TabIndex = 0;
            labelTz.Text = "תעודת זהות";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Location = new Point(149, 297);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(153, 32);
            labelNewPassword.TabIndex = 1;
            labelNewPassword.Text = "סיסמא חדשה";
            // 
            // labelOldPassword
            // 
            labelOldPassword.AutoSize = true;
            labelOldPassword.Location = new Point(149, 201);
            labelOldPassword.Name = "labelOldPassword";
            labelOldPassword.Size = new Size(141, 32);
            labelOldPassword.TabIndex = 2;
            labelOldPassword.Text = "סיסמא ישנה";
            // 
            // labelAcceptNewPassword
            // 
            labelAcceptNewPassword.AutoSize = true;
            labelAcceptNewPassword.Location = new Point(149, 404);
            labelAcceptNewPassword.Name = "labelAcceptNewPassword";
            labelAcceptNewPassword.Size = new Size(219, 32);
            labelAcceptNewPassword.TabIndex = 3;
            labelAcceptNewPassword.Text = "אישור סיסמא חדשה";
            // 
            // textBoxTz
            // 
            textBoxTz.Location = new Point(432, 114);
            textBoxTz.Name = "textBoxTz";
            textBoxTz.Size = new Size(294, 39);
            textBoxTz.TabIndex = 4;
            // 
            // textBoxOldPssword
            // 
            textBoxOldPssword.Location = new Point(432, 198);
            textBoxOldPssword.Name = "textBoxOldPssword";
            textBoxOldPssword.Size = new Size(294, 39);
            textBoxOldPssword.TabIndex = 5;
            // 
            // textBoxAcceptNewPassword
            // 
            textBoxAcceptNewPassword.BackColor = SystemColors.Info;
            textBoxAcceptNewPassword.Location = new Point(432, 397);
            textBoxAcceptNewPassword.Name = "textBoxAcceptNewPassword";
            textBoxAcceptNewPassword.Size = new Size(294, 39);
            textBoxAcceptNewPassword.TabIndex = 6;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BackColor = SystemColors.Info;
            textBoxNewPassword.Location = new Point(432, 290);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(294, 39);
            textBoxNewPassword.TabIndex = 7;
            // 
            // buttonChangeNewPassword
            // 
            buttonChangeNewPassword.BackColor = SystemColors.Info;
            buttonChangeNewPassword.Location = new Point(432, 493);
            buttonChangeNewPassword.Name = "buttonChangeNewPassword";
            buttonChangeNewPassword.Size = new Size(294, 46);
            buttonChangeNewPassword.TabIndex = 8;
            buttonChangeNewPassword.Text = "ביצוע החלפת סיסמא";
            buttonChangeNewPassword.UseVisualStyleBackColor = false;
            buttonChangeNewPassword.Click += buttonChangeNewPassword_Click;
            // 
            // linkLabelCancel
            // 
            linkLabelCancel.AutoSize = true;
            linkLabelCancel.Location = new Point(181, 500);
            linkLabelCancel.Name = "linkLabelCancel";
            linkLabelCancel.Size = new Size(69, 32);
            linkLabelCancel.TabIndex = 9;
            linkLabelCancel.TabStop = true;
            linkLabelCancel.Text = "ביטול";
            linkLabelCancel.LinkClicked += linkLabelCancel_LinkClicked;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(linkLabelCancel);
            Controls.Add(buttonChangeNewPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxAcceptNewPassword);
            Controls.Add(textBoxOldPssword);
            Controls.Add(textBoxTz);
            Controls.Add(labelAcceptNewPassword);
            Controls.Add(labelOldPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(labelTz);
            Name = "PasswordChangeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "PasswordChangeForm";
            FormClosed += PasswordChangeForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTz;
        private Label labelNewPassword;
        private Label labelOldPassword;
        private Label labelAcceptNewPassword;
        private TextBox textBoxTz;
        private TextBox textBoxOldPssword;
        private TextBox textBoxAcceptNewPassword;
        private TextBox textBoxNewPassword;
        private Button buttonChangeNewPassword;
        private LinkLabel linkLabelCancel;
    }
}