﻿using System;
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
        DataTable notes = new DataTable();
        bool IsEditing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
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