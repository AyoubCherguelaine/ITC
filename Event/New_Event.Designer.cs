namespace Itc.Event
{
    partial class New_Event
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
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Dscription = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add_Pic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dscription :";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(158, 111);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(200, 20);
            this.TB_Name.TabIndex = 3;
            // 
            // TB_Dscription
            // 
            this.TB_Dscription.Location = new System.Drawing.Point(158, 186);
            this.TB_Dscription.Multiline = true;
            this.TB_Dscription.Name = "TB_Dscription";
            this.TB_Dscription.Size = new System.Drawing.Size(346, 178);
            this.TB_Dscription.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(88, 405);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(33, 13);
            this.Date.TabIndex = 5;
            this.Date.Text = "Date ";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(158, 399);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 20);
            this.DateTime.TabIndex = 6;
            this.DateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 288);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Pic
            // 
            this.Add_Pic.Location = new System.Drawing.Point(624, 405);
            this.Add_Pic.Name = "Add_Pic";
            this.Add_Pic.Size = new System.Drawing.Size(319, 23);
            this.Add_Pic.TabIndex = 9;
            this.Add_Pic.Text = "ADD PIC";
            this.Add_Pic.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // New_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_Pic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.TB_Dscription);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_Event";
            this.Size = new System.Drawing.Size(1083, 586);
            this.Load += new System.EventHandler(this.New_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Dscription;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add_Pic;
        private System.Windows.Forms.Button button1;
    }
}
