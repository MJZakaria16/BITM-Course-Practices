using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Dictionary<long, string> bookDictionary = new Dictionary<long, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbn = isbnTextBox.Text;
            string bookName = nameTextBox.Text;
            if (string.IsNullOrEmpty(isbnTextBox.Text) || string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please insert ISBN and Name");
            }
            else
            {
                if (isbn.Length == 13)
                {
                    if (bookDictionary.ContainsKey(Convert.ToInt64(isbn)))
                    {
                        MessageBox.Show("Already saved");
                    }
                    else
                    {
                        bookDictionary.Add(Convert.ToInt64(isbn), bookName);
                        addListBox.Items.Add(isbn);
                        addListBox.Items.Add(bookName);
}
                    
                }
                else
                {
                    MessageBox.Show("ISBN should be 13 digit");
                }
            }
            isbnTextBox.Clear();
            nameTextBox.Clear();
            isbnTextBox.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchListBox.Items.Clear();
            string searchItemText = searchTextBox.Text;
            if (isbnradioButton.Checked == true)
            {

                if (bookDictionary.ContainsKey(Convert.ToInt64(searchItemText)))
                {
                    searchListBox.Items.Add(searchItemText);
                    searchListBox.Items.Add(bookDictionary[Convert.ToInt64(searchItemText)]);
                    searchTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Enter valid ISBN");
                    searchTextBox.Clear();
                }
            }
            else
            {
                
                if (bookDictionary.ContainsValue(searchItemText))
                {
                    searchListBox.Items.Add(searchItemText);
                    foreach (var key in bookDictionary.Keys)
                    {
                        if (bookDictionary[key] == searchItemText)
                        {
                            searchListBox.Items.Add(key);
                        }
                    }
                    searchTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Enter valid name");
                    searchTextBox.Clear();
                }
            }
        }

    }
}
