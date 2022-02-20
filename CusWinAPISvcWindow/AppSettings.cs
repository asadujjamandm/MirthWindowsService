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
            _winAPIConfigProp.Frequency = Convert.ToInt32(frequencytxtBox.Text.Trim());
            _winAPIConfigProp.SourcePath = sourcePathTxtBox.Text.Trim();
            _winAPIConfigProp.DestinationPath = destinationtxtBox.Text.Trim();
            _winAPIConfigProp.CVSAPIUrl = cvsAPIURLlbl.Text.Trim();

            this.Close();

        }
    }
}
