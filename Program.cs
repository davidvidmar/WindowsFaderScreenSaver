using System;
using System.Globalization;
using System.Windows.Forms;

namespace DavidVidmar.WindowsFader
{
    /// <summary>
	/// Main program.
	/// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		/// <param name="args">Command line arguments.</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                // Get the 2 character command line argument
                var arg = args[0].ToLower(CultureInfo.InvariantCulture).Trim().Substring(0, 2);
                switch (arg)
                {
                    case "/c":
                        // Show the options dialog
                        ShowOptions();
                        break;
                    case "/p":
                        // Don't do anything for preview
                        break;
                    case "/s":
                        // Show screensaver form
                        ShowScreenSaver();
                        break;
                    default:
                        MessageBox.Show($"Invalid command line argument :{arg}", "Invalid Command Line Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // If no arguments were passed in, show the screensaver
                ShowScreenSaver();
            }
        }

        /// <summary>
		/// Shows the options form.
		/// </summary>
        private static void ShowOptions()
        {
            OptionsForm optionsForm = new OptionsForm();
            Application.Run(optionsForm);
        }

        /// <summary>
		/// Shows the screen saver form.
		/// </summary>
        private static void ShowScreenSaver()
        {
            ScreenSaverForm screenSaver = new ScreenSaverForm();
            Application.Run(screenSaver);
        }
    }
}