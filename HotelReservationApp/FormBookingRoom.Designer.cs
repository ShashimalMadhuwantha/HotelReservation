namespace HotelReservationApp
{
    partial class FormBookingRoom
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
            this.labelRoomReservation = new System.Windows.Forms.Label();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelephoneNmb = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDaycount = new System.Windows.Forms.ErrorProvider(this.components);
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripRoomBooking = new System.Windows.Forms.MenuStrip();
            this.panelBillView = new System.Windows.Forms.Panel();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelDayCount = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.textBoxDayCount = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelRoomBooking = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelephoneNmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDaycount)).BeginInit();
            this.menuStripRoomBooking.SuspendLayout();
            this.panelBillView.SuspendLayout();
            this.panelRoomBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(10, 632);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(157, 56);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelRoomReservation
            // 
            this.labelRoomReservation.AutoSize = true;
            this.labelRoomReservation.BackColor = System.Drawing.Color.Gray;
            this.labelRoomReservation.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic);
            this.labelRoomReservation.ForeColor = System.Drawing.Color.Black;
            this.labelRoomReservation.Location = new System.Drawing.Point(3, 0);
            this.labelRoomReservation.Name = "labelRoomReservation";
            this.labelRoomReservation.Size = new System.Drawing.Size(539, 97);
            this.labelRoomReservation.TabIndex = 27;
            this.labelRoomReservation.Text = "RoomReservation";
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProviderTelephoneNmb
            // 
            this.errorProviderTelephoneNmb.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderDaycount
            // 
            this.errorProviderDaycount.ContainerControl = this;
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
            this.reservationHistoryToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.reservationHistoryToolStripMenuItem.Text = "Reservation History";
            this.reservationHistoryToolStripMenuItem.Click += new System.EventHandler(this.reservationHistoryToolStripMenuItem_Click);
            // 
            // menuStripRoomBooking
            // 
            this.menuStripRoomBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripRoomBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationHistoryToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStripRoomBooking.Location = new System.Drawing.Point(0, 0);
            this.menuStripRoomBooking.Name = "menuStripRoomBooking";
            this.menuStripRoomBooking.Size = new System.Drawing.Size(1123, 28);
            this.menuStripRoomBooking.TabIndex = 26;
            this.menuStripRoomBooking.Text = "menuStrip1";
            // 
            // panelBillView
            // 
            this.panelBillView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBillView.Controls.Add(this.labelTotalBill);
            this.panelBillView.Location = new System.Drawing.Point(358, 399);
            this.panelBillView.Name = "panelBillView";
            this.panelBillView.Size = new System.Drawing.Size(382, 268);
            this.panelBillView.TabIndex = 17;
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.AutoSize = true;
            this.labelTotalBill.BackColor = System.Drawing.Color.Silver;
            this.labelTotalBill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBill.ForeColor = System.Drawing.Color.Black;
            this.labelTotalBill.Location = new System.Drawing.Point(23, 20);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(99, 25);
            this.labelTotalBill.TabIndex = 12;
            this.labelTotalBill.Text = "Total Bill";
            // 
            // buttonReserve
            // 
            this.buttonReserve.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.buttonReserve.Location = new System.Drawing.Point(513, 335);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(127, 46);
            this.buttonReserve.TabIndex = 8;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click_1);
            // 
            // labelDayCount
            // 
            this.labelDayCount.AutoSize = true;
            this.labelDayCount.BackColor = System.Drawing.Color.LightGray;
            this.labelDayCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelDayCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDayCount.Location = new System.Drawing.Point(54, 271);
            this.labelDayCount.Name = "labelDayCount";
            this.labelDayCount.Size = new System.Drawing.Size(123, 29);
            this.labelDayCount.TabIndex = 3;
            this.labelDayCount.Text = "Day Count";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.LightGray;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(54, 114);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.buttonClear.Location = new System.Drawing.Point(358, 335);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(93, 46);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.LightGray;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddress.Location = new System.Drawing.Point(54, 163);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(102, 29);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.AutoSize = true;
            this.labelTelephoneNumber.BackColor = System.Drawing.Color.LightGray;
            this.labelTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.labelTelephoneNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTelephoneNumber.Location = new System.Drawing.Point(54, 215);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(224, 29);
            this.labelTelephoneNumber.TabIndex = 2;
            this.labelTelephoneNumber.Text = "Telephone Number";
            // 
            // textBoxDayCount
            // 
            this.textBoxDayCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDayCount.Location = new System.Drawing.Point(358, 273);
            this.textBoxDayCount.Name = "textBoxDayCount";
            this.textBoxDayCount.Size = new System.Drawing.Size(282, 28);
            this.textBoxDayCount.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(358, 125);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(282, 28);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(358, 217);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(282, 28);
            this.textBoxTelephoneNumber.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(358, 163);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(282, 28);
            this.textBoxAddress.TabIndex = 5;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(10, 570);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(157, 56);
            this.buttonLogOut.TabIndex = 29;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // panelRoomBooking
            // 
            this.panelRoomBooking.BackColor = System.Drawing.Color.LightGray;
            this.panelRoomBooking.Controls.Add(this.buttonReserve);
            this.panelRoomBooking.Controls.Add(this.labelRoomReservation);
            this.panelRoomBooking.Controls.Add(this.labelDayCount);
            this.panelRoomBooking.Controls.Add(this.labelName);
            this.panelRoomBooking.Controls.Add(this.buttonClear);
            this.panelRoomBooking.Controls.Add(this.panelBillView);
            this.panelRoomBooking.Controls.Add(this.labelAddress);
            this.panelRoomBooking.Controls.Add(this.labelTelephoneNumber);
            this.panelRoomBooking.Controls.Add(this.textBoxDayCount);
            this.panelRoomBooking.Controls.Add(this.textBoxName);
            this.panelRoomBooking.Controls.Add(this.textBoxTelephoneNumber);
            this.panelRoomBooking.Controls.Add(this.textBoxAddress);
            this.panelRoomBooking.Location = new System.Drawing.Point(173, 31);
            this.panelRoomBooking.Name = "panelRoomBooking";
            this.panelRoomBooking.Size = new System.Drawing.Size(951, 721);
            this.panelRoomBooking.TabIndex = 25;
            // 
            // FormBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1123, 736);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.menuStripRoomBooking);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.panelRoomBooking);
            this.Name = "FormBookingRoom";
            this.Text = "FormBookingRoom";
            this.Load += new System.EventHandler(this.FormBookingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelephoneNmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDaycount)).EndInit();
            this.menuStripRoomBooking.ResumeLayout(false);
            this.menuStripRoomBooking.PerformLayout();
            this.panelBillView.ResumeLayout(false);
            this.panelBillView.PerformLayout();
            this.panelRoomBooking.ResumeLayout(false);
            this.panelRoomBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelRoomReservation;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.MenuStrip menuStripRoomBooking;
        private System.Windows.Forms.ToolStripMenuItem reservationHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelRoomBooking;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Label labelDayCount;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelBillView;
        private System.Windows.Forms.Label labelTotalBill;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxDayCount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ErrorProvider errorProviderTelephoneNmb;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderDaycount;
    }
}