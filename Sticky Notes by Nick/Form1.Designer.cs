namespace Sticky_Notes_by_Nick
{
    partial class StickNotes
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
            this.btnNewNote = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.menuColorChange = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnNewNote
            // 
            this.btnNewNote.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewNote.FlatAppearance.BorderSize = 0;
            this.btnNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNote.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNote.Location = new System.Drawing.Point(13, 4);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(64, 23);
            this.btnNewNote.TabIndex = 0;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = false;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // tbNote
            // 
            this.tbNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNote.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(13, 30);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(259, 219);
            this.tbNote.TabIndex = 1;
            // 
            // menuColorChange
            // 
            this.menuColorChange.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuColorChange.FormattingEnabled = true;
            this.menuColorChange.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Random"});
            this.menuColorChange.Location = new System.Drawing.Point(222, 4);
            this.menuColorChange.MaxDropDownItems = 4;
            this.menuColorChange.Name = "menuColorChange";
            this.menuColorChange.Size = new System.Drawing.Size(50, 22);
            this.menuColorChange.TabIndex = 2;
            this.menuColorChange.Text = "Color";
            this.menuColorChange.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StickNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuColorChange);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.btnNewNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StickNotes";
            this.Text = "Sticky Notes by Nick";
            this.Load += new System.EventHandler(this.StickNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.ComboBox menuColorChange;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

