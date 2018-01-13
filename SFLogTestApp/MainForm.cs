using SFLog;
using SFLog.Enums;
using System;
using System.Windows.Forms;

namespace SFLogTestApp
{
    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            this.LoadLogLevels();
        }

        #endregion Constructor

        #region Set Log Level

        /// <summary>
        /// Handles the Click event of the buttonSetLogLevel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSetLogLevel_Click(object sender, EventArgs e)
        {
            Log.SetLogLevel((LogLevel)comboBoxSetLogLevel.SelectedItem);
        }

        /// <summary>
        /// Loads the log levels.
        /// </summary>
        private void LoadLogLevels()
        {
            comboBoxSetLogLevel.DataSource = Enum.GetValues(typeof(LogLevel));
        }

        #endregion Set Log Level

        #region Set Logs Folder Name

        /// <summary>
        /// Handles the Click event of the buttonSetLogsFolderName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSetLogsFolderName_Click(object sender, EventArgs e)
        {
            Log.SetLogsFolderName(textBoxSetLogsFolderName.Text);
        }

        #endregion Set Logs Folder Name

        #region Set Log File Name

        /// <summary>
        /// Handles the Click event of the buttonSetLogFileName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSetLogFileName_Click(object sender, EventArgs e)
        {
            Log.SetLogFileName(textBoxSetLogFileName.Text);
        }

        #endregion Set Log File Name

        #region Write Debug Message

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            Log.Debug(this, "buttonDebug_Click", textBoxDebug.Text);
            Log.Debug(typeof(MainForm), "buttonDebug_Click", textBoxDebug.Text);
        }

        #endregion Write Debug Message

        #region Write Info Message

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Log.Info(this, "buttonInfo_Click", textBoxInfo.Text);
            Log.Info(typeof(MainForm), "buttonInfo_Click", textBoxInfo.Text);
        }

        #endregion Write Info Message

        #region Write Warn Message

        private void buttonWarn_Click(object sender, EventArgs e)
        {
            Log.Warn(this, "buttonWarn_Click", textBoxWarn.Text);
            Log.Warn(typeof(MainForm), "buttonWarn_Click", textBoxWarn.Text);
        }

        #endregion Write Warn Message

        #region Write Error Message

        private void buttonError_Click(object sender, EventArgs e)
        {
            Log.Error(this, "buttonError_Click", new Exception(textBoxError.Text));
            Log.Error(typeof(MainForm), "buttonError_Click", new Exception(textBoxError.Text));
        }

        #endregion Write Error Message
    }
}