namespace HotelReservationApp
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNIC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelAdminID = new System.Windows.Forms.Label();
            this.errorProviderAdminid = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPAssword = new System.Windows.Forms.TextBox();
            this.buttonunblock = new System.Windows.Forms.Button();
            this.labelAdminUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelAdminContact = new System.Windows.Forms.Label();
            this.textBoxAdminId = new System.Windows.Forms.TextBox();
            this.labelAdminNIC = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdminid)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(4, 560);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(157, 56);
            this.buttonLogOut.TabIndex = 26;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // errorProviderNIC
            // 
            this.errorProviderNIC.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // dataGridViewAdmin
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightGray;
            this.dataGridViewAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewAdmin.ColumnHeadersHeight = 40;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdmin.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(18, 464);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 40;
            this.dataGridViewAdmin.RowTemplate.Height = 30;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(921, 170);
            this.dataGridViewAdmin.TabIndex = 10;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.labelAdmin.Location = new System.Drawing.Point(1, 8);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(233, 97);
            this.labelAdmin.TabIndex = 22;
            this.labelAdmin.Text = "Admin";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(26, 650);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 39);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonBlock
            // 
            this.buttonBlock.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlock.Location = new System.Drawing.Point(566, 207);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(151, 40);
            this.buttonBlock.TabIndex = 13;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(797, 640);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(151, 47);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelAdminID
            // 
            this.labelAdminID.AutoSize = true;
            this.labelAdminID.BackColor = System.Drawing.Color.LightGray;
            this.labelAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdminID.Location = new System.Drawing.Point(524, 134);
            this.labelAdminID.Name = "labelAdminID";
            this.labelAdminID.Size = new System.Drawing.Size(101, 29);
            this.labelAdminID.TabIndex = 11;
            this.labelAdminID.Text = "AdminId";
            // 
            // errorProviderAdminid
            // 
            this.errorProviderAdminid.ContainerControl = this;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(337, 402);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 40);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.BackColor = System.Drawing.Color.LightGray;
            this.labelAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdminName.Location = new System.Drawing.Point(47, 134);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(78, 29);
            this.labelAdminName.TabIndex = 6;
            this.labelAdminName.Text = "Name";
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.BackColor = System.Drawing.Color.LightGray;
            this.labelAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdminPassword.Location = new System.Drawing.Point(47, 349);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(120, 29);
            this.labelAdminPassword.TabIndex = 10;
            this.labelAdminPassword.Text = "Password";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(228, 138);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 28);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPAssword
            // 
            this.textBoxPAssword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPAssword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPAssword.Location = new System.Drawing.Point(228, 353);
            this.textBoxPAssword.Name = "textBoxPAssword";
            this.textBoxPAssword.Size = new System.Drawing.Size(256, 28);
            this.textBoxPAssword.TabIndex = 4;
            // 
            // buttonunblock
            // 
            this.buttonunblock.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonunblock.Location = new System.Drawing.Point(788, 207);
            this.buttonunblock.Name = "buttonunblock";
            this.buttonunblock.Size = new System.Drawing.Size(151, 40);
            this.buttonunblock.TabIndex = 15;
            this.buttonunblock.Text = "UnBlock";
            this.buttonunblock.UseVisualStyleBackColor = true;
            this.buttonunblock.Click += new System.EventHandler(this.buttonunblock_Click_1);
            // 
            // labelAdminUserName
            // 
            this.labelAdminUserName.AutoSize = true;
            this.labelAdminUserName.BackColor = System.Drawing.Color.LightGray;
            this.labelAdminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdminUserName.Location = new System.Drawing.Point(47, 303);
            this.labelAdminUserName.Name = "labelAdminUserName";
            this.labelAdminUserName.Size = new System.Drawing.Size(129, 29);
            this.labelAdminUserName.TabIndex = 9;
            this.labelAdminUserName.Text = "UserName";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(228, 299);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(256, 28);
            this.textBoxUserName.TabIndex = 3;
            // 
            // labelAdminContact
            // 
            this.labelAdminContact.AutoSize = true;
            this.labelAdminContact.BackColor = System.Drawing.Color.LightGray;
            this.labelAdminContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdminContact.Location = new System.Drawing.Point(47, 247);
            this.labelAdminContact.Name = "labelAdminContact";
            this.labelAdminContact.Size = new System.Drawing.Size(94, 29);
            this.labelAdminContact.TabIndex = 8;
            this.labelAdminContact.Text = "Contact";
            // 
            // textBoxAdminId
            // 
            this.textBoxAdminId.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxAdminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdminId.Location = new System.Drawing.Point(640, 134);
            this.textBoxAdminId.Name = "textBoxAdminId";
            this.textBoxAdminId.Size = new System.Drawing.Size(256, 28);
            this.textBoxAdminId.TabIndex = 5;
            // 
            // labelAdminNIC
            // 
            this.labelAdminNIC.AutoSize = true;
            this.labelAdminNIC.BackColor = System.Drawing.Color.LightGray;
            this.labelAdminNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminNIC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdminNIC.Location = new System.Drawing.Point(47, 199);
            this.labelAdminNIC.Name = "labelAdminNIC";
            this.labelAdminNIC.Size = new System.Drawing.Size(54, 29);
            this.labelAdminNIC.TabIndex = 7;
            this.labelAdminNIC.Text = "NIC";
            // 
            // textBoxContact
            // 
            this.textBoxContact.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(228, 247);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(256, 28);
            this.textBoxContact.TabIndex = 1;
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIC.Location = new System.Drawing.Point(228, 198);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(256, 28);
            this.textBoxNIC.TabIndex = 2;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.LightGray;
            this.panelAdmin.Controls.Add(this.dataGridViewAdmin);
            this.panelAdmin.Controls.Add(this.buttonBlock);
            this.panelAdmin.Controls.Add(this.labelAdmin);
            this.panelAdmin.Controls.Add(this.buttonClear);
            this.panelAdmin.Controls.Add(this.labelAdminID);
            this.panelAdmin.Controls.Add(this.buttonAdd);
            this.panelAdmin.Controls.Add(this.labelAdminName);
            this.panelAdmin.Controls.Add(this.labelAdminPassword);
            this.panelAdmin.Controls.Add(this.textBoxName);
            this.panelAdmin.Controls.Add(this.textBoxPAssword);
            this.panelAdmin.Controls.Add(this.buttonunblock);
            this.panelAdmin.Controls.Add(this.labelAdminUserName);
            this.panelAdmin.Controls.Add(this.textBoxUserName);
            this.panelAdmin.Controls.Add(this.labelAdminContact);
            this.panelAdmin.Controls.Add(this.textBoxAdminId);
            this.panelAdmin.Controls.Add(this.labelAdminNIC);
            this.panelAdmin.Controls.Add(this.textBoxContact);
            this.panelAdmin.Controls.Add(this.textBoxNIC);
            this.panelAdmin.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAdmin.Location = new System.Drawing.Point(167, 2);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(951, 733);
            this.panelAdmin.TabIndex = 25;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1123, 736);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelAdmin);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdminid)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelAdminID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPAssword;
        private System.Windows.Forms.Button buttonunblock;
        private System.Windows.Forms.Label labelAdminUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelAdminContact;
        private System.Windows.Forms.TextBox textBoxAdminId;
        private System.Windows.Forms.Label labelAdminNIC;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
        private System.Windows.Forms.ErrorProvider errorProviderNIC;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAdminid;
    }
}