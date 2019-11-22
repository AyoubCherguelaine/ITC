namespace Itc.Event
{
    partial class EventUI
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Event_Name = new System.Windows.Forms.Label();
            this.Text_desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(630, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(351, 48);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 20);
            this.DTP.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Team And Function";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Event_Name
            // 
            this.Event_Name.AutoSize = true;
            this.Event_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Event_Name.Location = new System.Drawing.Point(43, 39);
            this.Event_Name.Name = "Event_Name";
            this.Event_Name.Size = new System.Drawing.Size(153, 29);
            this.Event_Name.TabIndex = 5;
            this.Event_Name.Text = "Event Name";
            this.Event_Name.Click += new System.EventHandler(this.Event_Name_Click);
            // 
            // Text_desc
            // 
            this.Text_desc.Location = new System.Drawing.Point(46, 131);
            this.Text_desc.Name = "Text_desc";
            this.Text_desc.Size = new System.Drawing.Size(505, 283);
            this.Text_desc.TabIndex = 6;
            this.Text_desc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // EventUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_desc);
            this.Controls.Add(this.Event_Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EventUI";
            this.Size = new System.Drawing.Size(1005, 503);
            this.Load += new System.EventHandler(this.EventUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Event_Name;
        private System.Windows.Forms.RichTextBox Text_desc;
        private System.Windows.Forms.Label label1;
    }
}
