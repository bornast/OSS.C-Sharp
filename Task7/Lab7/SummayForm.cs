using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labs
{
    public partial class SummayForm : Form
    {
        public SummayForm()
        {
            InitializeComponent();
            PersonDataModel.getDataModel().PersonModelChanged += new PersonModelChangedEventHandler(this.RefreshSummaryData);
            DisplaySummaryData();
        }

        private void DisplaySummaryData()
        {
            int splitCount = 0, zagrebCount = 0, rijekaCount = 0;

            foreach (Person p in PersonDataModel.getDataModel().getAllPersons())
            {
                if (p.City == "Split")
                    splitCount++;
                else if (p.City == "Zagreb")
                    zagrebCount++;
                else
                    rijekaCount++;
            }

            splitCounter.Text = splitCount.ToString();
            zagrebCounter.Text = zagrebCount.ToString();
            rijekaCounter.Text = rijekaCount.ToString();
        }
        private void RefreshSummaryData(object sender, PersonDataModelChangedEventArgs e)
        {
            DisplaySummaryData();
        }

    }
}
