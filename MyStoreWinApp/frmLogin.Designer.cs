namespace MyStoreWinApp
{
    partial class frmLogin
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
            lbEmail = new Label();
            tbMail = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            lbRes = new Label();
            lbPass = new Label();
            tbPass = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(62, 30);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 15);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email: ";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(148, 25);
            tbMail.Margin = new Padding(3, 2, 3, 2);
            tbMail.Name = "tbMail";
            tbMail.PlaceholderText = "admin";
            tbMail.Size = new Size(176, 23);
            tbMail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 73);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 68);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 1;
            // 
            // lbRes
            // 
            lbRes.AutoSize = true;
            lbRes.Location = new Point(125, 114);
            lbRes.Name = "lbRes";
            lbRes.Size = new Size(0, 15);
            lbRes.TabIndex = 4;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(62, 73);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(63, 15);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password: ";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(148, 68);
            tbPass.Margin = new Padding(3, 2, 3, 2);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(176, 23);
            tbPass.TabIndex = 3;
            tbPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(89, 154);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(223, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 44);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 212);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(lbRes);
            Controls.Add(tbPass);
            Controls.Add(lbPass);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(tbMail);
            Controls.Add(lbEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEmail;
        private TextBox tbMail;
        private Label label2;
        private TextBox textBox2;
        private Label lbRes;
        private Label lbPass;
        private TextBox tbPass;
        private Button btnLogin;
        private Button btnClear;
    }
}
