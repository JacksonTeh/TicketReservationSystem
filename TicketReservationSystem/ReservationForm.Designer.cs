namespace TicketReservationSystem
{
    partial class ReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Your Seat";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(41, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seat Unavailable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(84, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seat Available";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 420);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(309, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Origin";
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Items.AddRange(new object[] {
            "Kuala Lumpur",
            "Kota Kinabalu",
            "Kuching",
            "Sibu"});
            this.cbxOrigin.Location = new System.Drawing.Point(446, 52);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(177, 21);
            this.cbxOrigin.TabIndex = 6;
            this.cbxOrigin.SelectedIndexChanged += new System.EventHandler(this.cbxOrigin_SelectedIndexChanged);
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Items.AddRange(new object[] {
            "Kuala Lumpur",
            "Kota Kinabalu",
            "Kuching",
            "Sibu"});
            this.cbxDestination.Location = new System.Drawing.Point(446, 99);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(177, 21);
            this.cbxDestination.TabIndex = 8;
            this.cbxDestination.SelectedIndexChanged += new System.EventHandler(this.cbxDestination_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(309, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(309, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Depart Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label7.Location = new System.Drawing.Point(309, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Arrive Time";
            // 
            // txtDepart
            // 
            this.txtDepart.Enabled = false;
            this.txtDepart.Location = new System.Drawing.Point(446, 155);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(177, 20);
            this.txtDepart.TabIndex = 11;
            // 
            // txtArrive
            // 
            this.txtArrive.Enabled = false;
            this.txtArrive.Location = new System.Drawing.Point(446, 203);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.Size = new System.Drawing.Size(177, 20);
            this.txtArrive.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(446, 250);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(177, 20);
            this.txtCode.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label8.Location = new System.Drawing.Point(309, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Flight Code";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnConfirm.Location = new System.Drawing.Point(446, 369);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(177, 34);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnInfo.Location = new System.Drawing.Point(446, 300);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(142, 34);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Show Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 469);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArrive);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxOrigin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtArrive;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnInfo;
    }
}