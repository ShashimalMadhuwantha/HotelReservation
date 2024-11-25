namespace HotelReservationApp
{
    partial class FormRoomReservation
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
            this.buttonReserve = new System.Windows.Forms.Button();
            this.dataGridViewAvailableRoom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomId = new System.Windows.Forms.TextBox();
            this.labelRoomReservation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderRoomID = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRoomID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReserve
            // 
            this.buttonReserve.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.buttonReserve.Location = new System.Drawing.Point(475, 162);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(142, 41);
            this.buttonReserve.TabIndex = 1;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click_1);
            // 
            // dataGridViewAvailableRoom
            // 
            this.dataGridViewAvailableRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableRoom.Location = new System.Drawing.Point(53, 237);
            this.dataGridViewAvailableRoom.Name = "dataGridViewAvailableRoom";
            this.dataGridViewAvailableRoom.RowHeadersWidth = 51;
            this.dataGridViewAvailableRoom.RowTemplate.Height = 24;
            this.dataGridViewAvailableRoom.Size = new System.Drawing.Size(816, 265);
            this.dataGridViewAvailableRoom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F);
            this.label1.Location = new System.Drawing.Point(56, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room ID";
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomId.Location = new System.Drawing.Point(319, 91);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.Size = new System.Drawing.Size(298, 28);
            this.textBoxRoomId.TabIndex = 2;
            // 
            // labelRoomReservation
            // 
            this.labelRoomReservation.AutoSize = true;
            this.labelRoomReservation.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelRoomReservation.Font = new System.Drawing.Font("MV Boli", 48F);
            this.labelRoomReservation.Location = new System.Drawing.Point(199, 44);
            this.labelRoomReservation.Name = "labelRoomReservation";
            this.labelRoomReservation.Size = new System.Drawing.Size(722, 105);
            this.labelRoomReservation.TabIndex = 8;
            this.labelRoomReservation.Text = "Room Reservation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.buttonReserve);
            this.panel1.Controls.Add(this.dataGridViewAvailableRoom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxRoomId);
            this.panel1.Location = new System.Drawing.Point(87, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 564);
            this.panel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.reservationHistoryToolStripMenuItem,
            this.hallReservationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // reservationHistoryToolStripMenuItem
            // 
            this.reservationHistoryToolStripMenuItem.Name = "reservationHistoryToolStripMenuItem";
            this.reservationHistoryToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.reservationHistoryToolStripMenuItem.Text = "Reservation History";
            // 
            // hallReservationToolStripMenuItem
            // 
            this.hallReservationToolStripMenuItem.Name = "hallReservationToolStripMenuItem";
            this.hallReservationToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.hallReservationToolStripMenuItem.Text = "Hall Reservation";
            // 
            // errorProviderRoomID
            // 
            this.errorProviderRoomID.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservationApp.Properties.Resources.istockphoto_1074648650_612x6121;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormRoomReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 736);
            this.Controls.Add(this.labelRoomReservation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRoomReservation";
            this.Text = "FormRoomReservation";
            this.Load += new System.EventHandler(this.FormRoomReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRoomID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.DataGridView dataGridViewAvailableRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomId;
        private System.Windows.Forms.Label labelRoomReservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallReservationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderRoomID;
    }
}