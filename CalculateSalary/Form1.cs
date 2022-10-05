using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class frmEvaluation : Form
    {
        public frmEvaluation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double scoreA = double.Parse(txtTest1.Text),
                       scoreB = double.Parse(txtTest2.Text),
                       scoreC = double.Parse(txtTest3.Text),
                       totalScore,
                       salary; 

                int hours,
                    years = Int32.Parse(txtYears.Text);

                char grade,
                    jobType = Char.ToUpper(char.Parse(txtType.Text));

                if (!validScore(scoreA))
                {
                    clean(txtTest1);
                    MessageBox.Show("Part A must be within 0 to 100. " +
                        "Please enter the score again.", 
                        "Percentage Entry");
                }
                else if (!validScore(scoreB))
                {
                    clean(txtTest2);
                    MessageBox.Show("Part B must be within 0 to 100. " +
                        "Please enter the score again.",
                        "Percentage Entry");
                }
                else if (!validScore(scoreC))
                {
                    clean(txtTest3);
                    MessageBox.Show("Part C must be within 0 to 100. " +
                        "Please enter the score again.",
                        "Percentage Entry");
                }
                else if (!validYears(years))
                {
                    clean(txtYears);
                    MessageBox.Show("Years must be within 0 to 50. " +
                        "Please enter years again.",
                        "Years Entry");
                }
                else if (!validTime(jobType))
                {
                    clean(txtType);
                    MessageBox.Show("Jpb type must be partime or full. " +
                        "Please enter it again.",
                        "Job Entry");
                }
                else
                {
                    if (Int32.TryParse(txtHours.Text, out hours) || (jobType == 'F'))
                    {
                        if (!validHours(hours))
                        {
                            clean(txtHours);
                            MessageBox.Show("Years must be within 0 to 50. " +
                                "Please enter years again.",
                                "Hours Entry");
                        }
                        else
                        {
                            totalScore = calcTotal(scoreA, scoreB, scoreC);
                            calcGrade(totalScore, out grade);
                            salary = calcSalary(grade, jobType, hours, years, totalScore);

                            txtGrade.Text = grade.ToString();
                            txtScore.Text = (totalScore / 100).ToString("p2");
                            txtSalary.Text = salary.ToString("c");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("One of the boxes marked up " +
                    "was filled with an incorrect type. Please try again", 
                    "Incorrect Type");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() 
                    + "\n" +ex.StackTrace, "Exception");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtTest1.Clear();
            txtTest2.Clear();
            txtTest3.Clear();
            txtType.Clear();
            txtHours.Text = "0";
            txtSalary.Clear();
            txtScore.Clear();
            txtGrade.Clear();
            txtYears.Clear();
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calcGrade(double score, out char grade)
        {
            if (score >= 90)
            {
                grade = 'A';
            }
            else if ((score < 90) && (score >= 80))
            {
                grade = 'B';
            }
            else if ((score < 80) && (score >= 70))
            {
                grade = 'C';
            }
            else if ((score < 70) && (score >= 60))
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
        }

        private double calcTotal(double a, double b, double c)
        {
            return (a * .25) + (b * .35) + (c * .4);
        } 

        private double calcSalary(char grade, char jobType, int hours, 
            int years, double total)
        {
            double salary,
                percent;

            const double TWO = 0.02,
                FIVE = 0.05;

            switch(grade)
            {
                case 'A':
                    salary = (double)price.priceA;
                    break;
                case 'B':
                    salary = (double)price.priceB;
                    break;
                case 'C':
                    salary = (double)price.priceC;
                    break;
                case 'D':
                    salary = (double)price.priceD;
                    break;
                default:
                    salary = (double)price.priceF;
                    break;
            }

            if (jobType == 'P')
            {
                percent = .025 * hours;
                salary *= percent;
            }

            if ((years >= 5) && (years <= 10))
            {
                salary += salary * TWO;
            }
            if (years > 10)
            {
                salary += salary * FIVE;
            }

            return salary;
        }

        private Boolean validScore(double score)
        {
            return score <= 100 && score >= 0 ? true : false;
        }

        private Boolean validTime(char c)
        {
            return (c != 'F') ||(c != 'P') ? true : false;
        }
        private Boolean validYears(Int32 years)
        {
            return years <= 50 && years >= 0 ? true : false;
        }

        private Boolean validHours(Int32 hours)
        {
            return hours <= 40 && hours >= 0 ? true : false;
        }

        private void clean(TextBox c)
        {
            c.Clear();
            c.Focus();
        }

        private enum price
        {
            priceA = 120000,
            priceB = 110000,
            priceC = 90000,
            priceD = 75000,
            priceF = 35000
        };

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
