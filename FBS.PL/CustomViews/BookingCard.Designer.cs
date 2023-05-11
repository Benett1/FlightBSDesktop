namespace WindowsFormsApp1.CustomViews
{
    partial class BookingCard
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
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.depAirportTxt = new System.Windows.Forms.Label();
            this.arrivalAirportTxt = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.Label();
            this.bagTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departure Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Airport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(280, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(280, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(280, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(475, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(280, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Baggage";
            // 
            // depAirportTxt
            // 
            this.depAirportTxt.AutoSize = true;
            this.depAirportTxt.Location = new System.Drawing.Point(110, 19);
            this.depAirportTxt.Name = "depAirportTxt";
            this.depAirportTxt.Size = new System.Drawing.Size(35, 13);
            this.depAirportTxt.TabIndex = 8;
            this.depAirportTxt.Text = "label8";
            // 
            // arrivalAirportTxt
            // 
            this.arrivalAirportTxt.AutoSize = true;
            this.arrivalAirportTxt.Location = new System.Drawing.Point(89, 63);
            this.arrivalAirportTxt.Name = "arrivalAirportTxt";
            this.arrivalAirportTxt.Size = new System.Drawing.Size(35, 13);
            this.arrivalAirportTxt.TabIndex = 9;
            this.arrivalAirportTxt.Text = "label9";
            // 
            // dateTxt
            // 
            this.dateTxt.AutoSize = true;
            this.dateTxt.Location = new System.Drawing.Point(72, 105);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(41, 13);
            this.dateTxt.TabIndex = 10;
            this.dateTxt.Text = "label10";
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Location = new System.Drawing.Point(312, 20);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(41, 13);
            this.nameTxt.TabIndex = 11;
            this.nameTxt.Text = "label11";
            // 
            // surnameTxt
            // 
            this.surnameTxt.AutoSize = true;
            this.surnameTxt.Location = new System.Drawing.Point(326, 63);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(41, 13);
            this.surnameTxt.TabIndex = 12;
            this.surnameTxt.Text = "label12";
            // 
            // ageTxt
            // 
            this.ageTxt.AutoSize = true;
            this.ageTxt.Location = new System.Drawing.Point(300, 104);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(41, 13);
            this.ageTxt.TabIndex = 13;
            this.ageTxt.Text = "label13";
            // 
            // bagTxt
            // 
            this.bagTxt.AutoSize = true;
            this.bagTxt.Location = new System.Drawing.Point(330, 140);
            this.bagTxt.Name = "bagTxt";
            this.bagTxt.Size = new System.Drawing.Size(41, 13);
            this.bagTxt.TabIndex = 14;
            this.bagTxt.Text = "label14";
            // 
            // BookingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.bagTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.arrivalAirportTxt);
            this.Controls.Add(this.depAirportTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingCard";
            this.Size = new System.Drawing.Size(593, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label depAirportTxt;
        private System.Windows.Forms.Label arrivalAirportTxt;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label surnameTxt;
        private System.Windows.Forms.Label ageTxt;
        private System.Windows.Forms.Label bagTxt;
    }
}
