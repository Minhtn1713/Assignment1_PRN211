namespace MyStoreWinApp
{
    partial class frmProfile
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
            tbName = new TextBox();
            lbName = new Label();
            tbPass = new TextBox();
            label5 = new Label();
            tbMail = new TextBox();
            label4 = new Label();
            tbId = new TextBox();
            lbID = new Label();
            btnSave = new Button();
            btnExit = new Button();
            cbCity = new ComboBox();
            cbCountry = new ComboBox();
            lbCity = new Label();
            lbCountry = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(164, 115);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(176, 23);
            tbName.TabIndex = 9;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(73, 120);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(467, 115);
            tbPass.Margin = new Padding(3, 2, 3, 2);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(176, 23);
            tbPass.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 120);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(467, 69);
            tbMail.Margin = new Padding(3, 2, 3, 2);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(176, 23);
            tbMail.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 74);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // tbId
            // 
            tbId.Location = new Point(164, 69);
            tbId.Margin = new Padding(3, 2, 3, 2);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(176, 23);
            tbId.TabIndex = 13;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(73, 74);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 7;
            lbID.Text = "ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(164, 230);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 61);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(417, 230);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 61);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnReturn_Click;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(467, 184);
            cbCity.Margin = new Padding(3, 2, 3, 2);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(176, 23);
            cbCity.TabIndex = 17;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(164, 184);
            cbCountry.Margin = new Padding(3, 2, 3, 2);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(176, 23);
            cbCountry.TabIndex = 18;
            cbCountry.SelectedIndexChanged += cbCountry_SelectedIndexChanged;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(376, 186);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 15;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(73, 186);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 16;
            lbCountry.Text = "Country";
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 338);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Controls.Add(tbPass);
            Controls.Add(label5);
            Controls.Add(tbMail);
            Controls.Add(label4);
            Controls.Add(tbId);
            Controls.Add(lbID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProfile";
            Text = "frmUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbName;
        private Label lbName;
        private TextBox tbPass;
        private Label label5;
        private TextBox tbMail;
        private Label label4;
        private TextBox tbId;
        private Label lbID;
        private Button btnSave;
        private Button btnExit;
        private ComboBox cbCity;
        private ComboBox cbCountry;
        private Label lbCity;
        private Label lbCountry;
    }
}