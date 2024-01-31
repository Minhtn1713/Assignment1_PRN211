namespace MyStoreWinApp
{
    partial class frmMemberManager
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
            lbID = new Label();
            tbId = new TextBox();
            lbName = new Label();
            tbName = new TextBox();
            lbCity = new Label();
            label4 = new Label();
            tbMail = new TextBox();
            label5 = new Label();
            tbPass = new TextBox();
            lbCountry = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lbSearch = new Label();
            tbSearch = new TextBox();
            cbAscAndDesc = new ComboBox();
            dgvList = new DataGridView();
            label1 = new Label();
            btnClear = new Button();
            cbFilterTitle = new ComboBox();
            cbFilter = new ComboBox();
            label2 = new Label();
            btnSearch = new Button();
            cbNameAndId = new ComboBox();
            cbCountry = new ComboBox();
            cbCity = new ComboBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(754, 140);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            // 
            // tbId
            // 
            tbId.Location = new Point(838, 132);
            tbId.Margin = new Padding(3, 2, 3, 2);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(176, 23);
            tbId.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(754, 333);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(838, 330);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(176, 23);
            tbName.TabIndex = 1;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(754, 215);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(754, 256);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(838, 248);
            tbMail.Margin = new Padding(3, 2, 3, 2);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(176, 23);
            tbMail.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(754, 293);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 0;
            label5.Text = "Password";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(838, 290);
            tbPass.Margin = new Padding(3, 2, 3, 2);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(176, 23);
            tbPass.TabIndex = 1;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(754, 177);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 256);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(101, 26);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(159, 256);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 26);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(307, 256);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 26);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(176, 32);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 3;
            lbSearch.Text = "Search";
            lbSearch.Click += lbSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(246, 32);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(232, 23);
            tbSearch.TabIndex = 4;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cbAscAndDesc
            // 
            cbAscAndDesc.FormattingEnabled = true;
            cbAscAndDesc.Items.AddRange(new object[] { "ASC", "DESC" });
            cbAscAndDesc.Location = new Point(365, 133);
            cbAscAndDesc.Margin = new Padding(3, 2, 3, 2);
            cbAscAndDesc.Name = "cbAscAndDesc";
            cbAscAndDesc.Size = new Size(113, 23);
            cbAscAndDesc.TabIndex = 6;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 305);
            dgvList.Margin = new Padding(3, 2, 3, 2);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(688, 281);
            dgvList.TabIndex = 7;
            dgvList.CellClick += dgvList_CellClick;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(146, 83);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 8;
            label1.Text = "Filter";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(451, 256);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 26);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbFilterTitle
            // 
            cbFilterTitle.FormattingEnabled = true;
            cbFilterTitle.Location = new Point(365, 85);
            cbFilterTitle.Margin = new Padding(3, 2, 3, 2);
            cbFilterTitle.Name = "cbFilterTitle";
            cbFilterTitle.Size = new Size(113, 23);
            cbFilterTitle.TabIndex = 5;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Country", "City" });
            cbFilter.Location = new Point(224, 85);
            cbFilter.Margin = new Padding(3, 2, 3, 2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(113, 23);
            cbFilter.TabIndex = 5;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(146, 135);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 8;
            label2.Text = "Order By";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(307, 196);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbNameAndId
            // 
            cbNameAndId.FormattingEnabled = true;
            cbNameAndId.Items.AddRange(new object[] { "ID", "Name" });
            cbNameAndId.Location = new Point(224, 132);
            cbNameAndId.Margin = new Padding(3, 2, 3, 2);
            cbNameAndId.Name = "cbNameAndId";
            cbNameAndId.Size = new Size(113, 23);
            cbNameAndId.TabIndex = 6;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(838, 169);
            cbCountry.Margin = new Padding(3, 2, 3, 2);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(176, 23);
            cbCountry.TabIndex = 10;
            cbCountry.SelectedIndexChanged += cbCountry_SelectedIndexChanged;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(838, 207);
            cbCity.Margin = new Padding(3, 2, 3, 2);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(176, 23);
            cbCity.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(599, 256);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 26);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMemberManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 597);
            Controls.Add(btnExit);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvList);
            Controls.Add(cbNameAndId);
            Controls.Add(cbAscAndDesc);
            Controls.Add(cbFilterTitle);
            Controls.Add(cbFilter);
            Controls.Add(tbSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnNew);
            Controls.Add(lbCity);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Controls.Add(lbCountry);
            Controls.Add(tbPass);
            Controls.Add(label5);
            Controls.Add(tbMail);
            Controls.Add(label4);
            Controls.Add(tbId);
            Controls.Add(lbID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMemberManager";
            Text = "frmMemberManager";
            Load += frmMemberManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private TextBox tbId;
        private Label lbName;
        private TextBox tbName;
        private Label lbCity;
        private Label label4;
        private TextBox tbMail;
        private Label label5;
        private TextBox tbPass;
        private Label lbCountry;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lbSearch;
        private TextBox tbSearch;
        private ComboBox cbAscAndDesc;
        private DataGridView dgvList;
        private Label label1;
        private Button btnClear;
        private ComboBox cbFilterTitle;
        private ComboBox cbFilter;
        private Label label2;
        private Button btnSearch;
        private ComboBox cbNameAndId;
        private ComboBox cbCountry;
        private ComboBox cbCity;
        private Button btnExit;
    }
}