using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersonalNotesManager
{
    public partial class Form2 : Form
    {
        string path;
        XDocument file;
        Form1 X;
        public Form2(Form1 X)
        {
            InitializeComponent();
            path = @"..\..\categories.xml";
            file = XDocument.Load(path);
            this.X = X;
        }

        private void NotesList_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThemesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NotesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            X.Close();
        }
    }
}
