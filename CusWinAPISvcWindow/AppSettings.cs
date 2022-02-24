using CusWinAPISvcWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CusWinAPISvcWindow
{
    public partial class AppSettings : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public WinAPIConfigProperties _winAPIConfigProp;
        public AppSettings()
        {
            InitializeComponent();
        }

        public AppSettings(ref WinAPIConfigProperties winAPIConfigProp)
        {
            InitializeComponent();

            _winAPIConfigProp = winAPIConfigProp;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DatabaseForm databaseForm = new DatabaseForm();
            databaseForm.ShowDialog();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{
            //    MessageBox.Show(txtSourcePath.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //string res = txtFrequency.Text.Trim();
            //bool res1 = res.All(char.IsDigit);
            _winAPIConfigProp.Frequency = Convert.ToInt32(txtFrequency.Text.Trim());
            _winAPIConfigProp.SourcePath = txtSourcePath.Text.Trim();
            _winAPIConfigProp.DestinationPath = txtDestination.Text.Trim();
            _winAPIConfigProp.CVSAPIUrl = lblCvsApiUrl.Text.Trim();

            this.Close();

        }

        private void txtFrequency_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFrequency.Text))
            {
                e.Cancel = true;
                txtFrequency.Focus();
                errorProvider.SetError(txtFrequency, "Please enter numeric Frequency value!");
                nextButton.Enabled = false;
            }
            else
            {
                e.Cancel = false ;
                errorProvider.SetError(txtFrequency, null);
                nextButton.Enabled = true;
            }
        }

        private void txtFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtSourcePath_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtSourcePath.Text))
            {
                e.Cancel = true;
                txtSourcePath.Focus();                
                errorProvider.SetError(txtSourcePath, "Please enter Source Path!");
                nextButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSourcePath,null);
                nextButton.Enabled = true;
            }

        }

        private void txtDestination_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtDestination.Text))
            {
                e.Cancel = true;
                txtDestination.Focus();
                errorProvider.SetError(txtDestination, "Please enter Destination!");
                nextButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDestination, null);
                nextButton.Enabled = true;
            }

        }

        private void txtCvsApiUrl_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCvsApiUrl.Text))
            {
                e.Cancel = true;
                txtCvsApiUrl.Focus();
                errorProvider.SetError(txtCvsApiUrl, "Please enter Cvs API Url");
                nextButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCvsApiUrl, null);
                nextButton.Enabled = true;
            }
        }

        
    }
}
