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
    public partial class PersonForm : Form
    {
        private Person person = new Person();
        public PersonForm()
        {
            InitializeComponent();
        }

        public PersonForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            textBoxName.Text = person.Name;
            textBoxLastname.Text = person.LastName;
            textBoxAge.Text = person.Age.ToString();
            comboBoxCity.Text = person.City;
        }        

        public Person GetPerson()
        {
            return person;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.person.Name = textBoxName.Text;
            this.person.LastName = textBoxLastname.Text;
            this.person.Age = Int32.Parse(textBoxAge.Text);
            this.person.City = comboBoxCity.Text;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }

        }

        private void textBoxLastname_TextChanged(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }

        }

        private void comboBoxCity_TextChanged(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }

        }

        private bool IsFormValid()
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) 
                && !string.IsNullOrEmpty(textBoxLastname.Text) 
                && !string.IsNullOrEmpty(comboBoxCity.Text) 
                && !string.IsNullOrEmpty(textBoxAge.Text) 
                && int.TryParse(textBoxAge.Text, out int temp))
            {
                return true;
            }
            return false;

        }

    }
}
