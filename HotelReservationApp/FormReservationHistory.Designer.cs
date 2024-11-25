namespace HotelReservationApp
{
    partial class FormReservationHistory
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.hallBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chekoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelReservationHistory = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1CustomerNAme = new System.Windows.Forms.TextBox();
            this.labelReservationSystem = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelReservationHistory.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(8, 519);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(157, 56);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // hallBookingToolStripMenuItem
            // 
            this.hallBookingToolStripMenuItem.Name = "hallBookingToolStripMenuItem";
            this.hallBookingToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.hallBookingToolStripMenuItem.Text = "Hall Booking";
            // 
            // roomBookingToolStripMenuItem
            // 
            this.roomBookingToolStripMenuItem.Name = "roomBookingToolStripMenuItem";
            this.roomBookingToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.roomBookingToolStripMenuItem.Text = "Room Booking";
            // 
            // chekoutToolStripMenuItem
            // 
            this.chekoutToolStripMenuItem.Name = "chekoutToolStripMenuItem";
            this.chekoutToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.chekoutToolStripMenuItem.Text = "Chekout";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 218);
            this.dataGridView1.TabIndex = 25;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(8, 606);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(157, 56);
            this.buttonLogOut.TabIndex = 29;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // panelReservationHistory
            // 
            this.panelReservationHistory.BackColor = System.Drawing.Color.LightGray;
            this.panelReservationHistory.Controls.Add(this.buttonSearch);
            this.panelReservationHistory.Controls.Add(this.labelName);
            this.panelReservationHistory.Controls.Add(this.dateTimePicker1);
            this.panelReservationHistory.Controls.Add(this.label3);
            this.panelReservationHistory.Controls.Add(this.textBox1CustomerNAme);
            this.panelReservationHistory.Controls.Add(this.labelReservationSystem);
            this.panelReservationHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelReservationHistory.Location = new System.Drawing.Point(171, 32);
            this.panelReservationHistory.Name = "panelReservationHistory";
            this.panelReservationHistory.Size = new System.Drawing.Size(951, 703);
            this.panelReservationHistory.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.buttonSearch.Location = new System.Drawing.Point(472, 274);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(183, 44);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.LightGray;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(105, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 29);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 39);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(105, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // textBox1CustomerNAme
            // 
            this.textBox1CustomerNAme.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1CustomerNAme.Location = new System.Drawing.Point(351, 117);
            this.textBox1CustomerNAme.Name = "textBox1CustomerNAme";
            this.textBox1CustomerNAme.Size = new System.Drawing.Size(304, 39);
            this.textBox1CustomerNAme.TabIndex = 2;
            // 
            // labelReservationSystem
            // 
            this.labelReservationSystem.AutoSize = true;
            this.labelReservationSystem.BackColor = System.Drawing.Color.LightGray;
            this.labelReservationSystem.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic);
            this.labelReservationSystem.ForeColor = System.Drawing.Color.DimGray;
            this.labelReservationSystem.Location = new System.Drawing.Point(-7, 0);
            this.labelReservationSystem.Name = "labelReservationSystem";
            this.labelReservationSystem.Size = new System.Drawing.Size(584, 97);
            this.labelReservationSystem.TabIndex = 0;
            this.labelReservationSystem.Text = "Resevation History";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.chekoutToolStripMenuItem,
            this.roomBookingToolStripMenuItem,
            this.hallBookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1123, 736);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.panelReservationHistory);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormReservationHistory";
            this.Text = "FormReservationHistory";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelReservationHistory.ResumeLayout(false);
            this.panelReservationHistory.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelReservationHistory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1CustomerNAme;
        private System.Windows.Forms.Label labelReservationSystem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chekoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallBookingToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}