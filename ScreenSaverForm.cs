using System;
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
        private bool _active;

		/// <summary>
        /// Current mouse location.
		/// </summary>
        private Point _mouseLocation;

        /// <summary>
        /// Old mouse location.
        /// </summary>
        private Point _oldMouseLocation;

		/// <summary>
		/// Doing fade in?
		/// </summary>
		private bool _fadeIn;

        private const bool Debug = false;
        private DateTime _startTime;

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

            this._oldMouseLocation = Cursor.Position;
            Cursor.Position = new Point(Bounds.Right + 1, Bounds.Bottom + 1);

            if (Debug)
            {
                fadeToLabel.Visible = true;
                fadeTimeLabel.Visible = true;
                currentTimeLabel.Visible = true;
                currentTransparencyLabel.Visible = true;

                fadeToLabel.Text = $"Fade to: {Settings.EndOpacityPercent}";
                fadeTimeLabel.Text = $"Fade time: {Settings.CompleteFadeInSeconds*1000} ms";

                currentUserLabel.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                _startTime = DateTime.Now;
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
			    System.Diagnostics.Debug.WriteLine(screen.DeviceName + " " + screen.Bounds);
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
            this._fadeIn = true;
        }

        /// <summary>
        /// Handles the MouseMove event of the current form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Set IsActive and MouseLocation only the first time this event is called.
            if (!_active)
            {
                _mouseLocation = MousePosition;
                _active = true;
            }
            else
            {
                // If the mouse has moved significantly since first call, close.
                if ((Math.Abs(MousePosition.X - _mouseLocation.X) > 1) ||
                    (Math.Abs(MousePosition.Y - _mouseLocation.Y) > 1))
                {
                    FadeIn();
                }
                else
                {
                    _mouseLocation = MousePosition;
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
            if (!this._fadeIn)
            {
                if (Opacity < Settings.EndOpacityPercent)
                {                    
                    Opacity += 0.005;

                    if (Debug)
                    {
                        currentTransparencyLabel.Text = $"Current opacity: {Opacity:N2}";
                        currentTimeLabel.Text = $"Elapsed time: {DateTime.Now.Subtract(_startTime).TotalMilliseconds} ms";
                    }
                }
            }
            else
            {
                Cursor.Position = this._oldMouseLocation;
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
