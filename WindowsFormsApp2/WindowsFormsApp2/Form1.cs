using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string email;
        private char[] emailArray;
        private List<string> emailList=new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            email = emailAddTextBox.Text;
            emailArray = email.ToCharArray();
           
            if (email.Contains(".") && email.Contains("@"))
            {
                foreach (var character in emailArray)
                {
                    if (character =='@')
                    {
                        sum++;
                    }
                }

                if (sum == 1)
                {
                    addEmailListBox.Items.Add(email);
                    AddEmail(email);
                    emailAddTextBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Email must have one '@' sign");
                    emailAddTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Email Address");
                emailAddTextBox.Text = string.Empty;
            }
        }

        private void AddEmail(string email)
        {
            emailList.Add(email);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchEmailListBox.Items.Clear();
            string searchedEmail = searchTextBox.Text;

            foreach (var email in emailList)
            {
                if (email.Contains(searchedEmail))
                {
                    searchEmailListBox.Items.Add(email);
                }
            }
            
        }
    }
}
