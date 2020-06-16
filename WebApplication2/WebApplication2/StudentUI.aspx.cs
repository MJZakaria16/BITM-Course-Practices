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
    public partial class StudentUI : System.Web.UI.Page
    {
        List<Student> studentList=new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.UserName = userNameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);

            ViewState["Student"] = aStudent;
            ClearTextBox();

            messageLabel.Text = string.Empty;
            messageLabel.Text = "Student Saved Successfull";
            messageLabel.ForeColor = Color.Green;
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
            Student aStudent=new Student();
            aStudent =(Student) ViewState["Student"];
            if (aStudent != null)
            {
                firstNameLabel.Text = aStudent.FirstName;
                lastNameLabel.Text = aStudent.LastName;
                userNameLabel.Text = aStudent.UserName;
                regNoLabel.Text = aStudent.RegNo;
                emailLabel.Text = aStudent.Email;
                ageLabel.Text = aStudent.Age.ToString();
            }
            else
            {
                messageLabel.Text = string.Empty;
                messageLabel.Text = "No information found";
                messageLabel.ForeColor = Color.Red;
            }
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentListUI.aspx");
        }
    }
}