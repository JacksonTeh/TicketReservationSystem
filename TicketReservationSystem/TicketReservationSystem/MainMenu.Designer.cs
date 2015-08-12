namespace TicketReservationSystem
{
    partial class MainMenu
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnProfile.Location = new System.Drawing.Point(364, 183);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(7);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(245, 51);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Update Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnReserve.Location = new System.Drawing.Point(88, 183);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(7);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(222, 51);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reservation";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click_1);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCustomerID.Location = new System.Drawing.Point(84, 65);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 24);
            this.lblCustomerID.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 326);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblCustomerID;
    }
}