namespace WindowsFormsApp1.CustomViews
{
    partial class FlightCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.departurelLbl = new System.Windows.Forms.Label();
            this.arrivalLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flightLbl = new System.Windows.Forms.Label();
            this.bookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(82, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Airport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(321, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival Airport:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(31, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Time:";
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Location = new System.Drawing.Point(85, 78);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(35, 13);
            this.dateTimeLbl.TabIndex = 5;
            this.dateTimeLbl.Text = "label6";
            // 
            // departurelLbl
            // 
            this.departurelLbl.AutoSize = true;
            this.departurelLbl.Location = new System.Drawing.Point(176, 49);
            this.departurelLbl.Name = "departurelLbl";
            this.departurelLbl.Size = new System.Drawing.Size(35, 13);
            this.departurelLbl.TabIndex = 6;
            this.departurelLbl.Text = "label7";
            // 
            // arrivalLbl
            // 
            this.arrivalLbl.AutoSize = true;
            this.arrivalLbl.Location = new System.Drawing.Point(395, 49);
            this.arrivalLbl.Name = "arrivalLbl";
            this.arrivalLbl.Size = new System.Drawing.Size(35, 13);
            this.arrivalLbl.TabIndex = 7;
            this.arrivalLbl.Text = "label8";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // flightLbl
            // 
            this.flightLbl.AutoSize = true;
            this.flightLbl.Location = new System.Drawing.Point(73, 21);
            this.flightLbl.Name = "flightLbl";
            this.flightLbl.Size = new System.Drawing.Size(35, 13);
            this.flightLbl.TabIndex = 8;
            this.flightLbl.Text = "label6";
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(224, 78);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 9;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // FlightCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.flightLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arrivalLbl);
            this.Controls.Add(this.departurelLbl);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlightCard";
            this.Size = new System.Drawing.Size(515, 111);
            this.Load += new System.EventHandler(this.FlightCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.Label departurelLbl;
        private System.Windows.Forms.Label arrivalLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label flightLbl;
        private System.Windows.Forms.Button bookBtn;
    }
}
