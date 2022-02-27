
namespace CusWinAPISvcWindow
{
    partial class AppSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.txtCvsApiUrl = new System.Windows.Forms.TextBox();
            this.lblCvsApiUrl = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.lbtFrequency = new System.Windows.Forms.Label();
            this.GrpBoxAppSettings = new System.Windows.Forms.GroupBox();
            this.GrpBoxAppSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(137, 46);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(241, 20);
            this.txtFrequency.TabIndex = 1;
            this.txtFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrequency_KeyPress);
            this.txtFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.txtFrequency_Validating);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(137, 76);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(241, 20);
            this.txtSourcePath.TabIndex = 3;
            this.txtSourcePath.Validating += new System.ComponentModel.CancelEventHandler(this.txtSourcePath_Validating);
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Location = new System.Drawing.Point(35, 76);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(66, 13);
            this.lblSourcePath.TabIndex = 2;
            this.lblSourcePath.Text = "Source Path";
            // 
            // txtCvsApiUrl
            // 
            this.txtCvsApiUrl.Location = new System.Drawing.Point(137, 136);
            this.txtCvsApiUrl.Name = "txtCvsApiUrl";
            this.txtCvsApiUrl.Size = new System.Drawing.Size(241, 20);
            this.txtCvsApiUrl.TabIndex = 7;
            this.txtCvsApiUrl.Validating += new System.ComponentModel.CancelEventHandler(this.txtCvsApiUrl_Validating);
            // 
            // lblCvsApiUrl
            // 
            this.lblCvsApiUrl.AutoSize = true;
            this.lblCvsApiUrl.Location = new System.Drawing.Point(35, 136);
            this.lblCvsApiUrl.Name = "lblCvsApiUrl";
            this.lblCvsApiUrl.Size = new System.Drawing.Size(73, 13);
            this.lblCvsApiUrl.TabIndex = 6;
            this.lblCvsApiUrl.Text = "CVS API URL";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(137, 106);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(241, 20);
            this.txtDestination.TabIndex = 5;
            this.txtDestination.Validating += new System.ComponentModel.CancelEventHandler(this.txtDestination_Validating);
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Location = new System.Drawing.Point(35, 106);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(85, 13);
            this.lblDestinationPath.TabIndex = 4;
            this.lblDestinationPath.Text = "Destination Path";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(285, 329);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 9;
            this.previousButton.Text = "< Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(376, 329);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 3);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-1, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 3);
            this.label2.TabIndex = 16;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(20, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(386, 20);
            this.labelWelcome.TabIndex = 17;
            this.labelWelcome.Text = "Welcone to the Mirth Windows Service Installer Setup";
            // 
            // lbtFrequency
            // 
            this.lbtFrequency.AutoSize = true;
            this.lbtFrequency.Location = new System.Drawing.Point(35, 46);
            this.lbtFrequency.Name = "lbtFrequency";
            this.lbtFrequency.Size = new System.Drawing.Size(57, 13);
            this.lbtFrequency.TabIndex = 0;
            this.lbtFrequency.Text = "Frequency";
            // 
            // GrpBoxAppSettings
            // 
            this.GrpBoxAppSettings.Controls.Add(this.lbtFrequency);
            this.GrpBoxAppSettings.Controls.Add(this.txtFrequency);
            this.GrpBoxAppSettings.Controls.Add(this.lblSourcePath);
            this.GrpBoxAppSettings.Controls.Add(this.txtSourcePath);
            this.GrpBoxAppSettings.Controls.Add(this.lblDestinationPath);
            this.GrpBoxAppSettings.Controls.Add(this.txtDestination);
            this.GrpBoxAppSettings.Controls.Add(this.txtCvsApiUrl);
            this.GrpBoxAppSettings.Controls.Add(this.lblCvsApiUrl);
            this.GrpBoxAppSettings.Location = new System.Drawing.Point(20, 66);
            this.GrpBoxAppSettings.Name = "GrpBoxAppSettings";
            this.GrpBoxAppSettings.Size = new System.Drawing.Size(446, 217);
            this.GrpBoxAppSettings.TabIndex = 18;
            this.GrpBoxAppSettings.TabStop = false;
            this.GrpBoxAppSettings.Text = "App Settings";
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 371);
            this.Controls.Add(this.GrpBoxAppSettings);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Settings";
            this.GrpBoxAppSettings.ResumeLayout(false);
            this.GrpBoxAppSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TextBox txtCvsApiUrl;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        protected System.Windows.Forms.Label lblSourcePath;
        protected System.Windows.Forms.Label lblCvsApiUrl;
        protected System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWelcome;
        protected System.Windows.Forms.Label lbtFrequency;
        private System.Windows.Forms.GroupBox GrpBoxAppSettings;
    }
}