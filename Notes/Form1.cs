using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes.Entities;

namespace Notes
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool IsEditing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            pastNotes.DataSource = notes;
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            titleBox.Clear();
            noteBox.Clear();
        }

        private void saveNote_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(titleBox.Text, noteBox.Text);
            notes.Rows.Add(newNote.Title,newNote.NoteBody);

            titleBox.Clear();
            noteBox.Clear();
        }

        private void editNote_Click(object sender, EventArgs e)
        {
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[pastNotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception exception) 
            {
                Console.WriteLine("Invalid note");
            }
        }
    }
}
