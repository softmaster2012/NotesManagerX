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
    public partial class Form3 : Form
    {
        string Path;
        XDocument doc;

        public Form3()
        {
            InitializeComponent();
            Path = @"..\..\categories.xml";
            doc = XDocument.Load(Path);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (XElement c in doc.Element("root").Elements("category"))
            {
                listBox1.Items.Add(c.Attribute("name").Value);
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItems.ToString();


            var cat = from x in doc.Element("root").Elements("category")
                      where x.Attribute("name").Value == textBox1.Text
                      select x;
            

            foreach (var c in cat)
            {
                textBox1.Text = Convert.ToString(c);
            }

        }
    }
}
