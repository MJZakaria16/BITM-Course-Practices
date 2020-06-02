using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string firstName;
        private string lastName;
        private string name;
        private string fathersName;
        private string mothersName;
        private string address;


        private void saveButton_Click(object sender, EventArgs e)
        {

            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            name = firstName + lastName;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;
            MessageBox.Show("Information saved successfully!!!");

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(fathersName);
            item.SubItems.Add(mothersName);
            item.SubItems.Add(address);

            infoListView.Items.Add(item);
            Cleartextbox();
        }

        private void Cleartextbox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            mothersNameTextBox.Clear();
            fathersNameTextBox.Clear();
            addressTextBox.Clear();
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            Cleartextbox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;
            addressTextBox.Text = address;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            Cleartextbox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            Cleartextbox();
            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            Cleartextbox();
            addressTextBox.Text = address;
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            infoListView.Items.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = infoListView.SelectedItems[0];
            item.Remove();
        }

        private void infoListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = infoListView.SelectedItems[0];
            string name = item.Text;
            string fathersName = item.SubItems[1].Text;
            string mothersName = item.SubItems[2].Text;
            string address = item.SubItems[3].Text;

            MessageBox.Show("Hello " + name + ", Son of Mr." + fathersName + " and Mrs." + mothersName +
                            " And you address is " + address);
        }
    }
}
