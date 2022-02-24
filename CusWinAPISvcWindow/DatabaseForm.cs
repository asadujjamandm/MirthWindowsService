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

            //_winAPIConfigProp.ServerName = serverTxt.Text.Trim();
            //_winAPIConfigProp.DataSource = dataSource.Text.Trim();
            //_winAPIConfigProp.LoginName = loginName.Text.Trim();
            //_winAPIConfigProp.Password = passwordTxt.Text.Trim();


            //this.Close();
            //AppSettings appSettings = new AppSettings(ref _winAPIConfigProp);
            //appSettings.ShowDialog();
            //if (IsDbConnect())
            //{
            //    MessageBox.Show("Database Connected");
            //}


            //string connectionString = "metadata = res://*/Repository.BacktalkDB.csdl|res://*/Repository.BacktalkDB.ssdl|res://*/Repository.BacktalkDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=" + serverTxt.Text.Trim() + ";initial catalog=" + dataSource.Text.Trim() + ";user id=" + loginName.Text.Trim() + ";password=" + passwordTxt.Text.Trim() + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";

            //var p = connectionString + "prvoder name =\"System.Data.EntityClient\"";
            //var entityConnectionStringBuilder = new EntityConnectionStringBuilder(connectionString);
            //var sqlConnection = entityConnectionStringBuilder.ProviderConnectionString;


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
            string sqlConnection = "Data Source=" + serverTxt.Text.Trim() + ";Database=" + dataSource.Text.Trim() + ";User Id=" + loginName.Text.Trim() + "; Password=" + passwordTxt.Text.Trim() + ";MultipleActiveResultSets=true;";

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
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(serverTxt, null);

            }

        }

        private void dataSource_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dataSource.Text))
            {
                e.Cancel = true;
                dataSource.Focus();
                errorProvider.SetError(dataSource, "Please enter Data Source!s");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dataSource, null);
            }
        }

        private void loginName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(loginName.Text))
            {
                e.Cancel = true;
                loginName.Focus();
                errorProvider.SetError(loginName, "Please enter Login Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(loginName, null);
            }
        }

        private void passwordTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                e.Cancel = true;
                passwordTxt.Focus();
                errorProvider.SetError(passwordTxt, "Please enter Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(passwordTxt, null);
            }
        }
    }
}
