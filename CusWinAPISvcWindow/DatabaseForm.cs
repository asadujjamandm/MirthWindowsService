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
            _winAPIConfigProp.LoginName = loginName.Text.Trim();
            _winAPIConfigProp.Password = passwordTxt.Text.Trim();


            this.Close();
            AppSettings appSettings = new AppSettings(ref _winAPIConfigProp);
            appSettings.ShowDialog();
        }       
    }
}
