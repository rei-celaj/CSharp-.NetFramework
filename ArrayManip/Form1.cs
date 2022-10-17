using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class frmSport : Form
    {
        private string[] sports = new string[]{"Squash", "Table Tennis",
                                    "Football"};
        private int[] numParticipants = new int[] { 25, 30, 105 };

        public frmSport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sports.Length; i++)
            {
                txtSport.AppendText(sports[i] + ": " + 
                    numParticipants[i] + Environment.NewLine);
            }
        }

        private void btnHighestSport_Click(object sender, EventArgs e)
        {
            int max = 0;
            String maxSport = "";

            for (int i = 0; i < sports.Length; i++)
            {
                if (max < numParticipants[i])
                {
                    max = numParticipants[i];
                    maxSport = sports[i];
                }
            }

            txtSport.Text = "Largest sport is " + maxSport + " which has "
                + max + " participants.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index;
            string findSport = txtSportEntry.Text;
            index = Array.IndexOf(sports, findSport); 

            if (index == -1)
            {
                MessageBox.Show("Sport does not exist. Please try again.",
                        "Sport Error");
                txtSportEntry.Clear();
                txtSportEntry.Focus();
            }
            else
            {
                int[] newParticipants = new int[numParticipants.Length - 1];
                string[] newSports = new string[sports.Length - 1];

                for (int i = index + 1; i < newParticipants.GetLength(0) + index + 1; i++)
                {
                    newParticipants[(i -1) % newParticipants.GetLength(0)] = 
                        numParticipants[i % numParticipants.Length];  //Skips deleted element
                }

                for (int i = index + 1; i < newSports.GetLength(0) + index + 1; i++)
                {
                    newSports[(i - 1) % newSports.GetLength(0)] =
                        sports[i % sports.Length]; //Circular array
                }

                numParticipants = newParticipants;
                sports = newSports;
            }
        }

        private void btnNewSport_Click(object sender, EventArgs e)
        {
            int participants;
            string newSport;
            if (Int32.TryParse(txtParticipants.Text, out participants))
            {
                if (participants > 0 && txtSportEntry.Text.Length != 0)
                {
                    int[] newParticipants = new int[numParticipants.Length + 1];
                    string[] newSports = new string[sports.Length + 1];
                    newSport = txtSportEntry.Text;

                    Array.Copy(numParticipants, newParticipants, numParticipants.Length);
                    Array.Copy(sports, newSports, sports.Length);

                    newParticipants[newParticipants.Length - 1] = participants;
                    newSports[newSports.Length - 1] = newSport;

                    numParticipants = newParticipants;
                    sports = newSports;
                }
                else
                {
                    MessageBox.Show("Participants must be greater than 0" 
                        + " or sport entry is empty. Please try again.", 
                        "Participants Error");
                    txtParticipants.Clear();
                    txtParticipants.Focus();
                }
            }
            else
            {
                MessageBox.Show("Participants must be a number. " +
                    "Please try again.", "Participants Error");
                txtParticipants.Clear();
                txtParticipants.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSport.Clear();
            txtParticipants.Clear();
            txtSportEntry.Clear();
        }

        private void btnSpecific_Click(object sender, EventArgs e)
        {
            string sport = txtSportEntry.Text;
            bool found = false;

            for (int i = 0; (i < sports.Length) && !found; i++)
            {
                if (sport == sports[i])
                {
                    found = true;
                    txtSport.Text = sport + " has " + numParticipants[i]
                        + " participants";
                }
            }

            if (found == false)
            {
                MessageBox.Show("Sport was not found. " +
                    "Please enter a valid sport", "Error");
                txtSportEntry.Focus();
            }
        }
    }
}
