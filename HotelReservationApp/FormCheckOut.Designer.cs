namespace HotelReservationApp
{
    partial class FormCheckOut
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRoomReservation = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.dataGridViewPendingReservations = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelReservationID = new System.Windows.Forms.Label();
            this.textBoxReservationId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderReservationID = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingReservations)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReservationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelRoomReservation);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonCheckout);
            this.panel1.Controls.Add(this.dataGridViewPendingReservations);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.labelReservationID);
            this.panel1.Controls.Add(this.textBoxReservationId);
            this.panel1.Location = new System.Drawing.Point(47, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 603);
            this.panel1.TabIndex = 26;
            // 
            // labelRoomReservation
            // 
            this.labelRoomReservation.AutoSize = true;
            this.labelRoomReservation.BackColor = System.Drawing.Color.Gray;
            this.labelRoomReservation.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic);
            this.labelRoomReservation.ForeColor = System.Drawing.Color.Black;
            this.labelRoomReservation.Location = new System.Drawing.Point(445, 0);
            this.labelRoomReservation.Name = "labelRoomReservation";
            this.labelRoomReservation.Size = new System.Drawing.Size(430, 97);
            this.labelRoomReservation.TabIndex = 28;
            this.labelRoomReservation.Text = "CHECKOUT";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClear.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(763, 532);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(205, 52);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelReservationApp.Properties.Resources.istockphoto_1335061100_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 597);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCheckout.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.Location = new System.Drawing.Point(742, 180);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(185, 40);
            this.buttonCheckout.TabIndex = 4;
            this.buttonCheckout.Text = "Check Out";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click_1);
            // 
            // dataGridViewPendingReservations
            // 
            this.dataGridViewPendingReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingReservations.Location = new System.Drawing.Point(332, 276);
            this.dataGridViewPendingReservations.Name = "dataGridViewPendingReservations";
            this.dataGridViewPendingReservations.RowHeadersWidth = 51;
            this.dataGridViewPendingReservations.RowTemplate.Height = 24;
            this.dataGridViewPendingReservations.Size = new System.Drawing.Size(670, 250);
            this.dataGridViewPendingReservations.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSearch.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(526, 180);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(164, 40);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // labelReservationID
            // 
            this.labelReservationID.AutoSize = true;
            this.labelReservationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelReservationID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationID.Location = new System.Drawing.Point(337, 132);
            this.labelReservationID.Name = "labelReservationID";
            this.labelReservationID.Size = new System.Drawing.Size(196, 31);
            this.labelReservationID.TabIndex = 3;
            this.labelReservationID.Text = "Reservation ID";
            // 
            // textBoxReservationId
            // 
            this.textBoxReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservationId.Location = new System.Drawing.Point(648, 132);
            this.textBoxReservationId.Name = "textBoxReservationId";
            this.textBoxReservationId.Size = new System.Drawing.Size(279, 30);
            this.textBoxReservationId.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationHistoryToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationHistoryToolStripMenuItem
            // 
            this.reservationHistoryToolStripMenuItem.Name = "reservationHistoryToolStripMenuItem";
            this.reservationHistoryToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.reservationHistoryToolStripMenuItem.Text = "Reservation History";
            this.reservationHistoryToolStripMenuItem.Click += new System.EventHandler(this.reservationHistoryToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F);
            this.label1.Location = new System.Drawing.Point(411, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 105);
            this.label1.TabIndex = 28;
            this.label1.Text = "CheckOut";
            // 
            // errorProviderReservationID
            // 
            this.errorProviderReservationID.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservationApp.Properties.Resources.istockphoto_1335061100_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(2, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1120, 709);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.Load += new System.EventHandler(this.FormCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingReservations)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReservationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.DataGridView dataGridViewPendingReservations;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelReservationID;
        private System.Windows.Forms.TextBox textBoxReservationId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderReservationID;
        private System.Windows.Forms.Label labelRoomReservation;
    }
}