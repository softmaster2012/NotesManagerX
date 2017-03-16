namespace PersonalNotesManager
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
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.ThemesLB = new System.Windows.Forms.ListBox();
            this.NotesLB = new System.Windows.Forms.ListBox();
            this.Themes = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.Label();
            this.NotesList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(71, 66);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(718, 21);
            this.CategoriesCB.TabIndex = 0;
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // ThemesLB
            // 
            this.ThemesLB.FormattingEnabled = true;
            this.ThemesLB.Location = new System.Drawing.Point(71, 112);
            this.ThemesLB.Name = "ThemesLB";
            this.ThemesLB.Size = new System.Drawing.Size(161, 160);
            this.ThemesLB.TabIndex = 3;
            this.ThemesLB.SelectedIndexChanged += new System.EventHandler(this.ThemesLB_SelectedIndexChanged);
            // 
            // NotesLB
            // 
            this.NotesLB.FormattingEnabled = true;
            this.NotesLB.Location = new System.Drawing.Point(71, 391);
            this.NotesLB.Name = "NotesLB";
            this.NotesLB.Size = new System.Drawing.Size(161, 160);
            this.NotesLB.TabIndex = 4;
            this.NotesLB.SelectedIndexChanged += new System.EventHandler(this.NotesLB_SelectedIndexChanged);
            // 
            // Themes
            // 
            this.Themes.AutoSize = true;
            this.Themes.Location = new System.Drawing.Point(71, 93);
            this.Themes.Name = "Themes";
            this.Themes.Size = new System.Drawing.Size(45, 13);
            this.Themes.TabIndex = 6;
            this.Themes.Text = "Themes";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(71, 375);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(35, 13);
            this.Notes.TabIndex = 7;
            this.Notes.Text = "Notes";
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Location = new System.Drawing.Point(8, 69);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(57, 13);
            this.Categories.TabIndex = 8;
            this.Categories.Text = "Categories";
            // 
            // NotesList
            // 
            this.NotesList.Location = new System.Drawing.Point(262, 93);
            this.NotesList.Name = "NotesList";
            this.NotesList.Size = new System.Drawing.Size(527, 537);
            this.NotesList.TabIndex = 9;
            this.NotesList.Text = "";
            this.NotesList.TextChanged += new System.EventHandler(this.NotesList_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 722);
            this.Controls.Add(this.NotesList);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Themes);
            this.Controls.Add(this.NotesLB);
            this.Controls.Add(this.ThemesLB);
            this.Controls.Add(this.CategoriesCB);
            this.Name = "Form2";
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.ListBox ThemesLB;
        private System.Windows.Forms.ListBox NotesLB;
        private System.Windows.Forms.Label Themes;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.RichTextBox NotesList;
    }
}