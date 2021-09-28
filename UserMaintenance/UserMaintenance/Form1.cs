using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            labelFullName.Text = Resource1.FullName;
            buttonAddName.Text = Resource1.Add;
            buttonWriteToFile.Text = Resource1.toFile;

            listUserNames.DataSource = users;
            listUserNames.ValueMember = "ID";
            listUserNames.DisplayMember = "FullName";
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            var u = new User()
            { 
                FullName = textFullName.Text
            };
            users.Add(u);
        }

        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (User person in users)
                    {
                        sw.WriteLine(person.ID + " " + person.FullName);
                    }
                }
            }
        }
    }
}
