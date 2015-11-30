using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DavidVidmar.WindowsFader
{
    /// <summary>
    /// The main form, which dims the screen.
    /// </summary>
    internal partial class ScreenSaverForm : Form
    {
        #region Private Fields
        
		/// <summary>
		/// Keep track of whether the screensaver has become active. 
		/// </summary>
        private bool active;

		/// <summary>
        /// Current mouse location.
		/// </summary>
        private Point mouseLocation;

        /// <summary>
        /// Old mouse location.
        /// </summary>
        private Point oldMouseLocation;

		/// <summary>
		/// Doing fade in?
		/// </summary>
        bool fadeIn;

        private const bool debug = false;
        private DateTime startTime;

        #endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="ScreenSaverForm"/> class.
		/// </summary>
        public ScreenSaverForm()
        {
            this.InitializeComponent();
            this.SetupScreenSaver();
        }

        /// <summary>
        /// Set up the main form as a full screen screensaver.
        /// </summary>
        private void SetupScreenSaver()
        {
            // Use double buffering to improve drawing performance
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Capture the mouse
            this.Capture = true;

            // Set the application to full screen mode and hide the mouse
            Cursor.Hide();

            Bounds = GetAllScreensBounds();
            ShowInTaskbar = false;
            Opacity = 0;
            DoubleBuffered = true;			
            
            // Set up timer
            timer.Interval = Convert.ToInt32(Settings.CompleteFadeInSeconds * 1000.0 / 200.0 * (1.0 / Settings.EndOpacityPercent));

            // Set the color
            if (Settings.FadeColor != 0)
                this.BackColor = Color.FromArgb(Settings.FadeColor);

            this.oldMouseLocation = Cursor.Position;
            Cursor.Position = new Point(Bounds.Right + 1, Bounds.Bottom + 1);

            if (debug)
            {
                fadeToLabel.Visible = true;
                fadeTimeLabel.Visible = true;
                currentTimeLabel.Visible = true;
                currentTransparencyLabel.Visible = true;

                fadeToLabel.Text = string.Format("Fade to: {0}", Settings.EndOpacityPercent);
                fadeTimeLabel.Text = string.Format("Fade time: {0} ms", Settings.CompleteFadeInSeconds*1000);

                currentUserLabel.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                startTime = DateTime.Now;
            }
        }

		/// <summary>
		/// Gets screens bounds and handles multi-monitor setups.
		/// </summary>
		/// <returns>Rectangle object representing the screen bounds.</returns>
		private static Rectangle GetAllScreensBounds()
		{
		    var allScreens = Rectangle.Empty;

			foreach (var screen in Screen.AllScreens)
			{
			    Debug.WriteLine(screen.DeviceName + " " + screen.Bounds);
                allScreens = Rectangle.Union(allScreens, screen.Bounds);
			}            
		    return allScreens;
		}        

        /// <summary>
        /// Fades in the screen.
        /// </summary>
        private void FadeIn()
        {
            this.timer.Interval = 10;
            this.fadeIn = true;
        }

        /// <summary>
        /// Handles the MouseMove event of the current form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Set IsActive and MouseLocation only the first time this event is called.
            if (!this.active)
            {
                this.mouseLocation = MousePosition;
                this.active = true;
            }
            else
            {
                // If the mouse has moved significantly since first call, close.
                if ((Math.Abs(MousePosition.X - mouseLocation.X) > 1) ||
                    (Math.Abs(MousePosition.Y - mouseLocation.Y) > 1))
                {
                    this.FadeIn();
                }
                else
                {
                    this.mouseLocation = MousePosition;
                }
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the current form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.FadeIn();
        }

        /// <summary>
        /// Handles the MouseDown event of the current form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void ScreenSaverForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.FadeIn();
        }

        /// <summary>
        /// Handles the Tick event of the timer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!this.fadeIn)
            {
                if (Opacity < Settings.EndOpacityPercent)
                {                    
                    Opacity += 0.005;

                    if (debug)
                    {
                        currentTransparencyLabel.Text = string.Format("Current opacity: {0:N2}", Opacity);
                        currentTimeLabel.Text = string.Format("Elapsed time: {0} ms",
                                                              DateTime.Now.Subtract(startTime).TotalMilliseconds);
                    }
                }
            }
            else
            {
                Cursor.Position = this.oldMouseLocation;
                Opacity -= 0.12;
                if (Opacity <= 0)
                {
                    Close();                    
                }
            }

            Application.DoEvents();
        }
    }
}
