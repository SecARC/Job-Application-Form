using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week07_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtBirthDate.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            var year = dtBirthDate.Value.Year;
            var todayYear = DateTime.Today.Year;
            var age = todayYear - year;
            txtAge.Text = age.ToString();
        }

        private void txtEducationGPA_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double value;
                if (!double.TryParse(txtEducationGPA.Text.Trim(), out value))
                    throw new Exception("Please enter a numeric GPA.");

                if(value < 0 | value > 4)
                    throw new Exception("Please enter a valid GPA. It must be between 0.00 and 4.00");

                txtEducationGPA.BackColor = Color.LimeGreen;
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                txtEducationGPA.BackColor = Color.PaleVioletRed;
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rdCertificationNA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCertificationNA.Checked)
            {
                chkDrivingLicenseA.Checked = chkDrivingLicenseB.Checked = chkDrivingLicenseE.Checked = chkDrivingLicenseH.Checked = false;
            }
        }

        private void chkDrivingLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDrivingLicenseA.Checked || chkDrivingLicenseB.Checked || chkDrivingLicenseE.Checked || chkDrivingLicenseH.Checked)
                rdCertificationNA.Checked = false;
            else
                rdCertificationNA.Checked = true;
        }

        private void btnSendForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbInterest.CheckedItems.Count == 0)
                    throw new Exception("Please select at least one interest.");

                if (string.IsNullOrEmpty(txtFullName.Text))
                    throw new Exception("Please enter your fullname.");

                JobApplication applicant = new JobApplication();
                applicant.fullName = txtFullName.Text.Trim();
                applicant.birthDate = dtBirthDate.Value;
                applicant.birthPlace = cboBirthPlace.Text;

                applicant.jobTitles = " ";
                if (chkJobMobile.Checked)
                    applicant.jobTitles += chkJobMobile.Text + "\n";
                if (chkJobAnalyst.Checked)
                    applicant.jobTitles += chkJobAnalyst.Text + "\n";
                if (chkJobTesting.Checked)
                    applicant.jobTitles += chkJobTesting.Text + "\n";

                applicant.drivingLicenseA = chkDrivingLicenseA.Checked;
                applicant.drivingLicenseB = chkDrivingLicenseB.Checked;
                applicant.drivingLicenseE = chkDrivingLicenseE.Checked;
                applicant.drivingLicenseH = chkDrivingLicenseH.Checked;

                applicant.educationLevel = cboEducationLevel.Text;
                applicant.educationGraduationFrom = txtEducationGraduateFrom.Text.Trim();
                double temp;
                if (double.TryParse(txtEducationGPA.Text, out temp))
                    applicant.educationGPA = temp;

                applicant.interests = "";
                foreach (var item in lbInterest.CheckedItems)
                {
                    applicant.interests += item.ToString() + "\n";
                }

                Form2 form = new Form2(applicant);
                form.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
