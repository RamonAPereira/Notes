using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class NoteTaker : Form
    {
        DataSet notesData  = new DataSet();
        DataTable notes = new DataTable();
        bool IsEditing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Id", typeof(int));
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            notesData.Tables.Add(notes);
            pastNotes.DataSource = notesData.Tables[0];
        }

        private void newNote_Click(object sender, EventArgs e)
        {    
        }

        private void saveNote_Click(object sender, EventArgs e)
        {

        }

        private void editNote_Click(object sender, EventArgs e)
        {

        }

        private void deleteNote_Click(object sender, EventArgs e)
        {

        }
    }
}
