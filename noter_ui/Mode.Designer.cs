namespace noter_ui
{
    partial class Mode
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenNote = new System.Windows.Forms.Button();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noter by seikkailija007";
            // 
            // btnOpenNote
            // 
            this.btnOpenNote.Location = new System.Drawing.Point(12, 54);
            this.btnOpenNote.Name = "btnOpenNote";
            this.btnOpenNote.Size = new System.Drawing.Size(124, 23);
            this.btnOpenNote.TabIndex = 2;
            this.btnOpenNote.Text = "Avaa muistiinpano";
            this.btnOpenNote.UseVisualStyleBackColor = true;
            this.btnOpenNote.Click += new System.EventHandler(this.btnOpenNote_Click);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(160, 54);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(109, 23);
            this.btnCreateNote.TabIndex = 3;
            this.btnCreateNote.Text = "Luo muistiinpano";
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnCreateNote);
            this.Controls.Add(this.btnOpenNote);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnOpenNote;
        private Button btnCreateNote;
    }
}