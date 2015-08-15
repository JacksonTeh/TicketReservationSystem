namespace TicketReservationSystem
{
    partial class SelectTrip
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxOrigin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(251, 247);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(107, 20);
            this.txtCode.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label8.Location = new System.Drawing.Point(100, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Flight Code";
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Items.AddRange(new object[] {
            "Kuala Lumpur",
            "Kota Kinabalu",
            "Kuching",
            "Sibu"});
            this.cbxDestination.Location = new System.Drawing.Point(251, 96);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(177, 21);
            this.cbxDestination.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(100, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Destination";
            // 
            // cbxOrigin
            // 
            this.cbxOrigin.FormattingEnabled = true;
            this.cbxOrigin.Items.AddRange(new object[] {
            "Kuala Lumpur",
            "Kota Kinabalu",
            "Kuching",
            "Sibu"});
            this.cbxOrigin.Location = new System.Drawing.Point(251, 49);
            this.cbxOrigin.Name = "cbxOrigin";
            this.cbxOrigin.Size = new System.Drawing.Size(177, 21);
            this.cbxOrigin.TabIndex = 16;
            this.cbxOrigin.SelectedIndexChanged += new System.EventHandler(this.cbxOrigin_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(100, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Origin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(100, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Depart Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label7.Location = new System.Drawing.Point(100, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Arrive Time";
            // 
            // txtDepart
            // 
            this.txtDepart.Enabled = false;
            this.txtDepart.Location = new System.Drawing.Point(251, 152);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(177, 20);
            this.txtDepart.TabIndex = 21;
            // 
            // txtArrive
            // 
            this.txtArrive.Enabled = false;
            this.txtArrive.Location = new System.Drawing.Point(251, 200);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.Size = new System.Drawing.Size(177, 20);
            this.txtArrive.TabIndex = 22;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnInfo.Location = new System.Drawing.Point(454, 233);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(142, 34);
            this.btnInfo.TabIndex = 25;
            this.btnInfo.Text = "Show Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnBack.Location = new System.Drawing.Point(454, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 34);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnConfirm.Location = new System.Drawing.Point(251, 305);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(142, 34);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SelectTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 398);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInfo);
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
            this.Name = "SelectTrip";
            this.Text = "SelectTrip";
            this.Load += new System.EventHandler(this.SelectTrip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxOrigin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtArrive;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
    }
}