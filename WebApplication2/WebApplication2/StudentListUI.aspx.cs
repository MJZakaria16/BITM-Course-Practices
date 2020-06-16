using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Model;

namespace WebApplication2
{
    public partial class StudentListUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            List<Student> studentList = new List<Student>();
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);
            if (ViewState["StudentList"] != null)
            {
                studentList = (List<Student>)ViewState["StudentList"];
            }
            studentList.Add(aStudent);
            ViewState["StudentList"] = studentList;

            messageLabel.Text = string.Empty;
            messageLabel.Text = "Student Saved Successfull";
            messageLabel.ForeColor = Color.Green;
            ClearTextBox();

        }

        private void ClearTextBox()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            regNoTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            List<Student> studentList=new List<Student>();
            studentList = (List<Student>) ViewState["StudentList"];

            foreach (var aStudent in studentList)
            {
                studentListBox.Items.Add("First Name: " + aStudent.FirstName);
                studentListBox.Items.Add("Last Name: " + aStudent.LastName);
                studentListBox.Items.Add("User Name: " + aStudent.UserName);
                studentListBox.Items.Add("Reg No: " + aStudent.RegNo);
                studentListBox.Items.Add("Email: " + aStudent.Email);
                studentListBox.Items.Add("Age: " + aStudent.Age);
            }

        }
    }
}