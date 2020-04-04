using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class MainForm : Form
    {
        private readonly List<Person> people = new List<Person>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var personForm = new PersonForm();
            personForm.ShowDialog(this);

            if (personForm.DialogResult == DialogResult.OK)
            {
                var savedPerson = personForm.GetPerson();
                people.Add(savedPerson);
                listView1.Items.Clear();
                foreach (var person in people)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = person.Name,
                        Tag = person
                    };
                    item.SubItems.Add(person.LastName);
                    listView1.Items.Add(item);
                }
                personForm.Dispose();
            }
            else
            {
                personForm.Dispose();
            }
        }
        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personForm = new PersonForm((Person)listView1.SelectedItems[0].Tag);
            personForm.ShowDialog(this);

            if (personForm.DialogResult == DialogResult.OK)
            {
                var savedPerson = personForm.GetPerson();
                listView1.Items.Clear();
                foreach (var person in people)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = person.Name,
                        Tag = person
                    };
                    item.SubItems.Add(person.LastName);
                    listView1.Items.Add(item);
                }
                personForm.Dispose();
            }
            else
            {
                personForm.Dispose();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
