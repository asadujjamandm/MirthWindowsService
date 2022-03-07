
namespace Mirth
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WindowsAPIServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.APIServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // WindowsAPIServiceProcessInstaller
            // 
            this.WindowsAPIServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.WindowsAPIServiceProcessInstaller.Password = null;
            this.WindowsAPIServiceProcessInstaller.Username = null;
            // 
            // APIServiceInstaller
            // 
            this.APIServiceInstaller.Description = "Win API Service Covert XML to JSON, pass jSON to CVS API, Sotre Ack in BacktalkDB" +
    "";
            this.APIServiceInstaller.DisplayName = "Windows API Service";
            this.APIServiceInstaller.ServiceName = "Windows API Service";
            this.APIServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WindowsAPIServiceProcessInstaller,
            this.APIServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller WindowsAPIServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller APIServiceInstaller;
    }
}