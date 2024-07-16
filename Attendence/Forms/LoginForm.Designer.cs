namespace Attendence
{
    partial class LoginForm
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
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            buttonEnter = new Button();
            buttonChangePassword = new Button();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(204, 53);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(144, 32);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "שם משתמש";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(238, 160);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 32);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "סיסמא";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(181, 101);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(200, 39);
            textBoxUserName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(181, 207);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 39);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(181, 341);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(200, 46);
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "כניסה";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Location = new Point(181, 436);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(200, 46);
            buttonChangePassword.TabIndex = 6;
            buttonChangePassword.Text = "החלפת סיסמא";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 545);
            Controls.Add(buttonChangePassword);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "LoginForm";
          //  FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button buttonEnter;
        private Button buttonChangePassword;
    }
}