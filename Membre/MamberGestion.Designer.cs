namespace Itc.Membre
{
    partial class MamberGestion
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Name_M_Selected = new System.Windows.Forms.Label();
            this.Surname_M_Selected = new System.Windows.Forms.Label();
            this.Dscr_M_Selected = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 446);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 531);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Membre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Dscr_M_Selected);
            this.panel2.Controls.Add(this.Surname_M_Selected);
            this.panel2.Controls.Add(this.Name_M_Selected);
            this.panel2.Location = new System.Drawing.Point(715, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 531);
            this.panel2.TabIndex = 5;
            // 
            // Name_M_Selected
            // 
            this.Name_M_Selected.AutoSize = true;
            this.Name_M_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Name_M_Selected.Location = new System.Drawing.Point(38, 52);
            this.Name_M_Selected.Name = "Name_M_Selected";
            this.Name_M_Selected.Size = new System.Drawing.Size(81, 29);
            this.Name_M_Selected.TabIndex = 0;
            this.Name_M_Selected.Text = "Name";
            // 
            // Surname_M_Selected
            // 
            this.Surname_M_Selected.AutoSize = true;
            this.Surname_M_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Surname_M_Selected.Location = new System.Drawing.Point(38, 100);
            this.Surname_M_Selected.Name = "Surname_M_Selected";
            this.Surname_M_Selected.Size = new System.Drawing.Size(116, 29);
            this.Surname_M_Selected.TabIndex = 1;
            this.Surname_M_Selected.Text = "Surname";
            // 
            // Dscr_M_Selected
            // 
            this.Dscr_M_Selected.AutoSize = true;
            this.Dscr_M_Selected.Location = new System.Drawing.Point(39, 194);
            this.Dscr_M_Selected.Name = "Dscr_M_Selected";
            this.Dscr_M_Selected.Size = new System.Drawing.Size(26, 13);
            this.Dscr_M_Selected.TabIndex = 2;
            this.Dscr_M_Selected.Text = "Dsc";
            // 
            // MamberGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MamberGestion";
            this.Size = new System.Drawing.Size(1107, 537);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Dscr_M_Selected;
        private System.Windows.Forms.Label Surname_M_Selected;
        private System.Windows.Forms.Label Name_M_Selected;
    }
}
