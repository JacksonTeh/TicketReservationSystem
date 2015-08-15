namespace TicketReservationSystem
{
    partial class ViewTransaction
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origin,
            this.Destination,
            this.DepartTime,
            this.ArriveTime,
            this.FlightCode,
            this.Payment});
            this.dataGridView1.Location = new System.Drawing.Point(51, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            // 
            // DepartTime
            // 
            this.DepartTime.HeaderText = "DepartTime";
            this.DepartTime.Name = "DepartTime";
            // 
            // ArriveTime
            // 
            this.ArriveTime.HeaderText = "ArriveTime";
            this.ArriveTime.Name = "ArriveTime";
            // 
            // FlightCode
            // 
            this.FlightCode.HeaderText = "FlightCode";
            this.FlightCode.Name = "FlightCode";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnBack.Location = new System.Drawing.Point(518, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewTransaction";
            this.Text = "ConfirmBooking";
            this.Load += new System.EventHandler(this.ViewTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Button btnBack;
    }
}