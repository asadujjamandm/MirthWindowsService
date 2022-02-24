using CusWinAPISvcWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CusWinAPISvcWindow
{
    public partial class DatabaseForm : Form
    {
        public WinAPIConfigProperties _winAPIConfigProp;

        public DatabaseForm()
        {
            InitializeComponent();
        }

        public DatabaseForm(ref WinAPIConfigProperties winAPIConfigProp)
        {
            _winAPIConfigProp = winAPIConfigProp;
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //WinAPIConfigProperties winAPIConfigProperties = new WinAPIConfigProperties();

            _winAPIConfigProp.ServerName = serverTxt.Text.Trim();
            _winAPIConfigProp.DataSource = dataSource.Text.Trim();
            _winAPIConfigProp.LoginName = loginNameTxt.Text.Trim();
            _winAPIConfigProp.Password = passwordTxt.Text.Trim();


            this.Close();
            AppSettings appSettings = new AppSettings(ref _winAPIConfigProp);
            appSettings.ShowDialog();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsDbConnect())
                {
                    nextButton.Enabled = true;
                    MessageLabel.ForeColor = Color.Green;
                    MessageLabel.Text = "Connected to server !!";
                }
            }
            catch (Exception ex)
            {
                nextButton.Enabled = false;
                MessageLabel.ForeColor = Color.Red;
                MessageLabel.Text = "Unable to connect !!";
            }

        }

        private bool IsDbConnect()
        {
            string sqlConnection;
            if (WinAuthRadio.Checked)
            {
                sqlConnection = "Data Source=" + serverTxt.Text.Trim() + ";Initial Catalog=" + dataSource.Text.Trim() + ";Integrated Security=True";
            }
            else
            {
                sqlConnection = "Data Source=" + serverTxt.Text.Trim() + ";Database=" + dataSource.Text.Trim() + ";User Id=" + loginNameTxt.Text.Trim() + "; Password=" + passwordTxt.Text.Trim() + ";MultipleActiveResultSets=true;";
            }
            SqlConnection connect = new SqlConnection(sqlConnection);
            {
                if (connect.State == System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
            return true;
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            nextButton.Enabled = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ErrorProvider errorProvider = new ErrorProvider();
        private void serverTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(serverTxt.Text))
            {
                e.Cancel = true;
                serverTxt.Focus();
                errorProvider.SetError(serverTxt, "Please enter Server Info!");
                ConnectButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(serverTxt, null);
                ConnectButton.Enabled = true;
            }

        }

        private void dataSource_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dataSource.Text))
            {
                e.Cancel = true;
                dataSource.Focus();
                errorProvider.SetError(dataSource, "Please enter Data Source!s");
                ConnectButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dataSource, null);
                ConnectButton.Enabled = true;
            }
        }

        private void loginName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(loginNameTxt.Text))
            {
                e.Cancel = true;
                loginNameTxt.Focus();
                errorProvider.SetError(loginNameTxt, "Please enter Login Name!");
                ConnectButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(loginNameTxt, null);
                ConnectButton.Enabled = true;
            }
        }

        private void passwordTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                e.Cancel = true;
                passwordTxt.Focus();
                errorProvider.SetError(passwordTxt, "Please enter Password!");
                ConnectButton.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(passwordTxt, null);
                ConnectButton.Enabled = true;
            }
        }

        private void WinAuthRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (WinAuthRadio.Checked)
            {
                loginlbl.Enabled = false;
                loginNameTxt.Enabled = false;
                passlbl.Enabled = false;
                passwordTxt.Enabled = false;
            }
            else
            {
                loginlbl.Enabled = true;
                loginNameTxt.Enabled = true;
                passlbl.Enabled = true;
                passwordTxt.Enabled = true;
            }
        }
    }
}
