using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    internal class Note
    {
        public string Title { get; set; }
        public string NoteBody { get; set; }

        public Note(string title, string noteBody)
        {
            Title = title;
            NoteBody = noteBody;
        }
    }
}
