namespace Notes
{
    partial class NoteTaker
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.pastNotes = new System.Windows.Forms.DataGridView();
            this.newNote = new System.Windows.Forms.Button();
            this.saveNote = new System.Windows.Forms.Button();
            this.editNote = new System.Windows.Forms.Button();
            this.deleteNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pastNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(388, 37);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(400, 22);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(388, 89);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(400, 349);
            this.noteBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(384, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(384, 66);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(54, 20);
            this.noteLabel.TabIndex = 3;
            this.noteLabel.Text = "Note:";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pastNotes
            // 
            this.pastNotes.BackgroundColor = System.Drawing.Color.White;
            this.pastNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastNotes.Location = new System.Drawing.Point(13, 37);
            this.pastNotes.Name = "pastNotes";
            this.pastNotes.RowHeadersWidth = 51;
            this.pastNotes.RowTemplate.Height = 24;
            this.pastNotes.Size = new System.Drawing.Size(365, 263);
            this.pastNotes.TabIndex = 4;
            // 
            // newNote
            // 
            this.newNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNote.Location = new System.Drawing.Point(13, 307);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(179, 56);
            this.newNote.TabIndex = 5;
            this.newNote.Text = "New Note";
            this.newNote.UseVisualStyleBackColor = true;
            this.newNote.Click += new System.EventHandler(this.newNote_Click);
            // 
            // saveNote
            // 
            this.saveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNote.Location = new System.Drawing.Point(199, 307);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(179, 56);
            this.saveNote.TabIndex = 6;
            this.saveNote.Text = "Save Note";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // editNote
            // 
            this.editNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNote.Location = new System.Drawing.Point(12, 369);
            this.editNote.Name = "editNote";
            this.editNote.Size = new System.Drawing.Size(179, 56);
            this.editNote.TabIndex = 7;
            this.editNote.Text = "Edit Note";
            this.editNote.UseVisualStyleBackColor = true;
            this.editNote.Click += new System.EventHandler(this.editNote_Click);
            // 
            // deleteNote
            // 
            this.deleteNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNote.Location = new System.Drawing.Point(199, 369);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(179, 56);
            this.deleteNote.TabIndex = 8;
            this.deleteNote.Text = "Delete Note";
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.editNote);
            this.Controls.Add(this.saveNote);
            this.Controls.Add(this.newNote);
            this.Controls.Add(this.pastNotes);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pastNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.DataGridView pastNotes;
        private System.Windows.Forms.Button newNote;
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.Button editNote;
        private System.Windows.Forms.Button deleteNote;
    }
}

