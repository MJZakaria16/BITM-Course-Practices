using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp4
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadEquationComboBox();
            LoadYearComboBox();

            equationComboBox.Text = "Pricipal(P)";
            equationLabel.Text = "P=I/rt";
            firstLabel.Text = "Interest(I):$";
            firstTextBox.Text = "amount";
            secondLabel.Text = "Rate(R):%";
            secondTextBox.Text = "rate";
            perYearLabel.Text = "per year";
            thirdLabel.Text = "Time(t):";
            thirdTextBox.Text = "#";
            perYearLabel2.Text = " ";
            yearComboBox.Text = "years";
            answerTextBox.Text = "Answer:           P=?     ";
        }

        private void LoadYearComboBox()
        {
            yearComboBox.Items.Add("days(360/yr)");
            yearComboBox.Items.Add("days(365/yr)");
            yearComboBox.Items.Add("weeks");
            yearComboBox.Items.Add("months");
            yearComboBox.Items.Add("quarters");
            yearComboBox.Items.Add("years");
        }

        private void LoadEquationComboBox()
        {
            equationComboBox.Items.Add("Interest(I)");
            equationComboBox.Items.Add("Pricipal(P)");
            equationComboBox.Items.Add("Rate(R)");
            equationComboBox.Items.Add("Time Period(t)");
        }
        private void equationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equationComboBox.Text == "Pricipal(P)")
            {
                equationLabel.Text = "P=I/rt";
                firstLabel.Text = "Interest(I):$";
                firstTextBox.Text = "";
                secondLabel.Text = "Rate(R):%";
                secondTextBox.Text = "";
                perYearLabel.Text = "per year";
                thirdLabel.Text = "Time(t):";
                thirdTextBox.Text = "";
                perYearLabel2.Text = " ";
                yearComboBox.Text = "years";
                answerTextBox.Text = "Answer:           P=?     ";
            }

            else if (equationComboBox.Text == "Interest(I)")
            {
                equationLabel.Text = "I=Prt";
                firstLabel.Text = "Principal(P):$";
                firstTextBox.Text = "";
                secondLabel.Text = "Rate(R):%";
                secondTextBox.Text = "";
                perYearLabel.Text = "per year";
                thirdLabel.Text = "Time(t):";
                thirdTextBox.Text = "";
                perYearLabel2.Text = " ";
                yearComboBox.Text = "years";
                answerTextBox.Text = "Answer:           I=?     ";
            }

            else if (equationComboBox.Text == "Rate(R)")
            {
                equationLabel.Text = "r=I/pt";
                firstLabel.Text = "Principal(P):$";
                firstTextBox.Text = "";
                secondLabel.Text = "Interest(I):$";
                secondTextBox.Text = "";
                perYearLabel.Text = " ";
                thirdLabel.Text = "Time(t):";
                thirdTextBox.Text = "";
                perYearLabel2.Text = " ";
                yearComboBox.Text = "years";
                answerTextBox.Text = "Answer:           R=?     ";
            }

            else if (equationComboBox.Text == "Time Period(t)")
            {
                equationLabel.Text = "t=I/Pr";
                firstLabel.Text = "Principal(P):$";
                firstTextBox.Text = "";
                secondLabel.Text = "Interest(I):$";
                secondTextBox.Text = "";
                perYearLabel.Text = " ";
                thirdLabel.Text = "Rate(R):%";
                thirdTextBox.Text = "";
                perYearLabel2.Text = "per year";
                yearComboBox.Text = " ";
                yearComboBox.Hide();
                answerTextBox.Text = "Answer:           t=?     ";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstTextBox.Clear();
            secondTextBox.Clear();
            thirdTextBox.Clear();
            answerTextBox.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (equationComboBox.Text == "Pricipal(P)")
            {
                double i = Convert.ToDouble(firstTextBox.Text);
                double r = (Convert.ToDouble(secondTextBox.Text) / 100);
                double t = Convert.ToDouble(thirdTextBox.Text);
                if (yearComboBox.Text == "days(360/yr)")
                {
                    t = t / 360;
                }

                else if (yearComboBox.Text == "days(365/yr)")
                {
                    t = t / 365;
                }

                else if (yearComboBox.Text == "weeks")
                {
                    t = t / 52;
                }

                else if (yearComboBox.Text == "months")
                {
                    t = t / 12;
                }

                else if (yearComboBox.Text == "quarters")
                {
                    t = t / 4;
                }

                else if (yearComboBox.Text == "years")
                {
                    t = t / 1;
                }

                double answer = i /(r * t) ;

                answerTextBox.Clear();
                answerTextBox.Text = "                  P=$ " + answer.ToString();
            }

            else if (equationComboBox.Text == "Interest(I)")
            {
                double p = Convert.ToDouble(firstTextBox.Text);
                double r = (Convert.ToDouble(secondTextBox.Text) / 100);
                double t = Convert.ToDouble(thirdTextBox.Text);
                if (yearComboBox.Text == "days(360/yr)")
                {
                    t = t / 360;
                }

                else if (yearComboBox.Text == "days(365/yr)")
                {
                    t = t / 365;
                }

                else if (yearComboBox.Text == "weeks")
                {
                    t = t / 52;
                }

                else if (yearComboBox.Text == "months")
                {
                    t = t / 12;
                }

                else if (yearComboBox.Text == "quarters")
                {
                    t = t / 4;
                }

                else if (yearComboBox.Text == "years")
                {
                    t = t/1;
                }

                double answer = p * r * t;
                
                answerTextBox.Clear();
                answerTextBox.Text = "                  I=$ "+answer.ToString();
            }

            else if (equationComboBox.Text == "Rate(R)")
            {
                double p = Convert.ToDouble(firstTextBox.Text);
                double i = Convert.ToDouble(secondTextBox.Text);
                double t = Convert.ToDouble(thirdTextBox.Text);
                if (yearComboBox.Text == "days(360/yr)")
                {
                    t = t / 360;
                }

                else if (yearComboBox.Text == "days(365/yr)")
                {
                    t = t / 365;
                }

                else if (yearComboBox.Text == "weeks")
                {
                    t = t / 52;
                }

                else if (yearComboBox.Text == "months")
                {
                    t = t / 12;
                }

                else if (yearComboBox.Text == "quarters")
                {
                    t = t / 4;
                }

                else if (yearComboBox.Text == "years")
                {
                    t = t / 1;
                }

                double answer = i/(p*t);
                answer = answer * 100;
                answerTextBox.Clear();
                answerTextBox.Text = "                  R= " + answer.ToString()+"%/year";
            }

            else if (equationComboBox.Text == "Time Period(t)")
            {
                double p = Convert.ToDouble(firstTextBox.Text);
                double r = (Convert.ToDouble(thirdTextBox.Text) / 100);
                double i = Convert.ToDouble(secondTextBox.Text);

                double answer = i / (p * r);

                answerTextBox.Clear();
                answerTextBox.Text = "                  t= " + answer.ToString()+" years";
            }
        }
        
    }
}
