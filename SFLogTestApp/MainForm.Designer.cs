namespace SFLogTestApp
{
    partial class MainForm
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
            this.buttonSetLogsFolderName = new System.Windows.Forms.Button();
            this.textBoxSetLogsFolderName = new System.Windows.Forms.TextBox();
            this.textBoxSetLogFileName = new System.Windows.Forms.TextBox();
            this.buttonSetLogFileName = new System.Windows.Forms.Button();
            this.comboBoxSetLogLevel = new System.Windows.Forms.ComboBox();
            this.buttonSetLogLevel = new System.Windows.Forms.Button();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonWarn = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxWarn = new System.Windows.Forms.TextBox();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSetLogsFolderName
            // 
            this.buttonSetLogsFolderName.Location = new System.Drawing.Point(218, 9);
            this.buttonSetLogsFolderName.Name = "buttonSetLogsFolderName";
            this.buttonSetLogsFolderName.Size = new System.Drawing.Size(150, 23);
            this.buttonSetLogsFolderName.TabIndex = 0;
            this.buttonSetLogsFolderName.Text = "Set Logs Folder Name";
            this.buttonSetLogsFolderName.UseVisualStyleBackColor = true;
            this.buttonSetLogsFolderName.Click += new System.EventHandler(this.buttonSetLogsFolderName_Click);
            // 
            // textBoxSetLogsFolderName
            // 
            this.textBoxSetLogsFolderName.Location = new System.Drawing.Point(12, 12);
            this.textBoxSetLogsFolderName.Name = "textBoxSetLogsFolderName";
            this.textBoxSetLogsFolderName.Size = new System.Drawing.Size(200, 20);
            this.textBoxSetLogsFolderName.TabIndex = 1;
            this.textBoxSetLogsFolderName.Text = "TestFolderName";
            // 
            // textBoxSetLogFileName
            // 
            this.textBoxSetLogFileName.Location = new System.Drawing.Point(13, 40);
            this.textBoxSetLogFileName.Name = "textBoxSetLogFileName";
            this.textBoxSetLogFileName.Size = new System.Drawing.Size(199, 20);
            this.textBoxSetLogFileName.TabIndex = 2;
            this.textBoxSetLogFileName.Text = "testLog";
            // 
            // buttonSetLogFileName
            // 
            this.buttonSetLogFileName.Location = new System.Drawing.Point(218, 38);
            this.buttonSetLogFileName.Name = "buttonSetLogFileName";
            this.buttonSetLogFileName.Size = new System.Drawing.Size(150, 23);
            this.buttonSetLogFileName.TabIndex = 3;
            this.buttonSetLogFileName.Text = "Set Log File Name";
            this.buttonSetLogFileName.UseVisualStyleBackColor = true;
            this.buttonSetLogFileName.Click += new System.EventHandler(this.buttonSetLogFileName_Click);
            // 
            // comboBoxSetLogLevel
            // 
            this.comboBoxSetLogLevel.FormattingEnabled = true;
            this.comboBoxSetLogLevel.Location = new System.Drawing.Point(13, 69);
            this.comboBoxSetLogLevel.Name = "comboBoxSetLogLevel";
            this.comboBoxSetLogLevel.Size = new System.Drawing.Size(199, 21);
            this.comboBoxSetLogLevel.TabIndex = 4;
            // 
            // buttonSetLogLevel
            // 
            this.buttonSetLogLevel.Location = new System.Drawing.Point(218, 67);
            this.buttonSetLogLevel.Name = "buttonSetLogLevel";
            this.buttonSetLogLevel.Size = new System.Drawing.Size(150, 23);
            this.buttonSetLogLevel.TabIndex = 5;
            this.buttonSetLogLevel.Text = "Set Log Level";
            this.buttonSetLogLevel.UseVisualStyleBackColor = true;
            this.buttonSetLogLevel.Click += new System.EventHandler(this.buttonSetLogLevel_Click);
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(218, 96);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(150, 23);
            this.buttonDebug.TabIndex = 6;
            this.buttonDebug.Text = "Write Debug Message";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(218, 125);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(150, 23);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Write Info Message";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonWarn
            // 
            this.buttonWarn.Location = new System.Drawing.Point(218, 154);
            this.buttonWarn.Name = "buttonWarn";
            this.buttonWarn.Size = new System.Drawing.Size(150, 23);
            this.buttonWarn.TabIndex = 8;
            this.buttonWarn.Text = "Write Warn Message";
            this.buttonWarn.UseVisualStyleBackColor = true;
            this.buttonWarn.Click += new System.EventHandler(this.buttonWarn_Click);
            // 
            // buttonError
            // 
            this.buttonError.Location = new System.Drawing.Point(218, 183);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(150, 23);
            this.buttonError.TabIndex = 9;
            this.buttonError.Text = "Write Error Message";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(13, 98);
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.Size = new System.Drawing.Size(199, 20);
            this.textBoxDebug.TabIndex = 10;
            this.textBoxDebug.Text = "This is a debug message";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(13, 127);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(199, 20);
            this.textBoxInfo.TabIndex = 11;
            this.textBoxInfo.Text = "This is a info message";
            // 
            // textBoxWarn
            // 
            this.textBoxWarn.Location = new System.Drawing.Point(13, 156);
            this.textBoxWarn.Name = "textBoxWarn";
            this.textBoxWarn.Size = new System.Drawing.Size(199, 20);
            this.textBoxWarn.TabIndex = 12;
            this.textBoxWarn.Text = "This is a warn message";
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(13, 185);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(199, 20);
            this.textBoxError.TabIndex = 13;
            this.textBoxError.Text = "This is a error message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 220);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.textBoxWarn);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxDebug);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.buttonWarn);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.buttonSetLogLevel);
            this.Controls.Add(this.comboBoxSetLogLevel);
            this.Controls.Add(this.buttonSetLogFileName);
            this.Controls.Add(this.textBoxSetLogFileName);
            this.Controls.Add(this.textBoxSetLogsFolderName);
            this.Controls.Add(this.buttonSetLogsFolderName);
            this.Name = "MainForm";
            this.Text = "SFLogTestApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetLogsFolderName;
        private System.Windows.Forms.TextBox textBoxSetLogsFolderName;
        private System.Windows.Forms.TextBox textBoxSetLogFileName;
        private System.Windows.Forms.Button buttonSetLogFileName;
        private System.Windows.Forms.ComboBox comboBoxSetLogLevel;
        private System.Windows.Forms.Button buttonSetLogLevel;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonWarn;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxWarn;
        private System.Windows.Forms.TextBox textBoxError;
    }
}