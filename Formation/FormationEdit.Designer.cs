namespace Itc.Formation
{
    partial class FormationEdit
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
            this.Name = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ast = new System.Windows.Forms.Label();
            this.Formateur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Name.Location = new System.Drawing.Point(40, 16);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(81, 29);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 205);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 394);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.ast);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(528, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 456);
            this.panel1.TabIndex = 3;
            // 
            // ast
            // 
            this.ast.AutoSize = true;
            this.ast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ast.Location = new System.Drawing.Point(69, 12);
            this.ast.Name = "ast";
            this.ast.Size = new System.Drawing.Size(81, 17);
            this.ast.TabIndex = 3;
            this.ast.Text = "participants";
            // 
            // Formateur
            // 
            this.Formateur.AutoSize = true;
            this.Formateur.Location = new System.Drawing.Point(127, 28);
            this.Formateur.Name = "Formateur";
            this.Formateur.Size = new System.Drawing.Size(54, 13);
            this.Formateur.TabIndex = 4;
            this.Formateur.Text = "Formateur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Participant";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Name);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Formateur);
            this.panel2.Location = new System.Drawing.Point(44, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 456);
            this.panel2.TabIndex = 4;
            // 
            // FormationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormationEdit";
            this.Size = new System.Drawing.Size(983, 535);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ast;
        private System.Windows.Forms.Label Formateur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}
