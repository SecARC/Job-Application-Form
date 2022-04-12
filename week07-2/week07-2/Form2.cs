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
    public partial class Form2 : Form
    {
        private JobApplication applicant { get; set; }
        public Form2(JobApplication applicant)
        {
            InitializeComponent();
            this.applicant = applicant;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelJobTitle.Text = this.applicant.jobTitles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
