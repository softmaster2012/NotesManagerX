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
using System.Security.Cryptography;

namespace PersonalNotesManager
{
    public partial class Form1 : Form
    {
        string Path;
        XDocument doc;
        MD5 Codder;

        public Form1()
        {
            InitializeComponent();
            Path = @"..\..\accounts.xml";
            doc = XDocument.Load(Path);
            Codder = MD5.Create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Passw = GetMd5Hash(textBox2.Text);
            var res = from x in doc.Element("root").Elements("account")
                      where x.Attribute("login").Value == Login && x.Attribute("passw").Value == Passw
                      select x;


        }

        string GetMd5Hash(string input)
        {
            byte[] data =Codder.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
