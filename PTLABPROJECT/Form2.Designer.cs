namespace PTLABPROJECT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelcost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham Medium", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SeatNo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Gotham Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(662, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "PICK SEAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(289, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 69);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First class",
            "Economy",
            "1 rupee"});
            this.comboBox1.Location = new System.Drawing.Point(450, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select Class";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "FROM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(368, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "TO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(309, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "CLASS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "DATE :";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Chennai",
            "Puducherry",
            "Trichy"});
            this.comboBox2.Location = new System.Drawing.Point(450, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 33);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Take off";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Mumbai",
            "Delhi",
            "Kolkata"});
            this.comboBox3.Location = new System.Drawing.Point(450, 241);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 33);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Text = "Destination";
            // 
            // labelcost
            // 
            this.labelcost.AutoSize = true;
            this.labelcost.BackColor = System.Drawing.Color.Transparent;
            this.labelcost.Font = new System.Drawing.Font("Gotham Medium", 24F);
            this.labelcost.ForeColor = System.Drawing.Color.White;
            this.labelcost.Location = new System.Drawing.Point(794, 359);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(49, 48);
            this.labelcost.TabIndex = 11;
            this.labelcost.Text = "0";
            this.labelcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(656, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cost :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(274, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "SEAT NO :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 288);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 11, 23, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 30);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.button2.Font = new System.Drawing.Font("Gotham Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(411, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "BOOK NOW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.BackColor = System.Drawing.Color.Transparent;
            this.cname.Font = new System.Drawing.Font("Gotham Medium", 18F);
            this.cname.ForeColor = System.Drawing.Color.White;
            this.cname.Location = new System.Drawing.Point(459, 114);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(182, 36);
            this.cname.TabIndex = 16;
            this.cname.Text = "Coustomer";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 605);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelcost);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cname;
    }
}