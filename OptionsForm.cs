using System;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace DavidVidmar.WindowsFader
{
    /// <summary>
	/// Screen saver option form.
	/// </summary>
    internal partial class OptionsForm : Form
    {
        /// <summary>
		/// Initializes a new instance of the <see cref="OptionsForm"/> class.
		/// </summary>
        public OptionsForm()
        {
            this.InitializeComponent();

            this.completeInTextBox.Text = Settings.CompleteFadeInSeconds.ToString();
            this.endOpacityTrackBar.Value = Convert.ToInt32(Settings.EndOpacityPercent * 100);
            this.endOpacityTextBox.Text = this.endOpacityTrackBar.Value.ToString();
            this.colorPanel.BackColor = Color.FromArgb(Settings.FadeColor);
        }

        /// <summary>
		/// Applies the changes.
		/// </summary>
        private void ApplyChanges()
        {
            int completeInValue;

            try
            {
                completeInValue = Convert.ToInt32(this.completeInTextBox.Text);
                if (completeInValue < 1) completeInValue = 1;
                if (completeInValue > 10000) completeInValue = 180;
            }
            catch
            {
                MessageBox.Show("Enter value in seconds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.CompleteFadeInSeconds = completeInValue;
            Settings.EndOpacityPercent = this.endOpacityTrackBar.Value / 100.0;
            Settings.FadeColor = this.colorPanel.BackColor.ToArgb();            
        }

        /// <summary>
		/// Handles the Click event of the btnOK control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonOkClicked(object sender, EventArgs e)
        {
            try
            {
                this.ApplyChanges();
            }
            catch (ConfigurationException)
            {
                MessageBox.Show("Your settings couldn't be saved. Make sure that you have a .config file in the same directory as your screensaver.", "Failed to Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        /// <summary>
		/// Handles the Click event of the btnCancel control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonCancelClicked(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
		/// Handles the Scroll event of the endOpacityTrackBar control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void EndOpacityTrackBarScroll(object sender, EventArgs e)
        {
            endOpacityTextBox.Text = endOpacityTrackBar.Value.ToString();
        }

        /// <summary>
        /// Handles the Click event of the colorPanel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ColorPanelClicked(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// Sets the default fade color to black.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void DefaultColorLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            colorPanel.BackColor = Color.Black;
        }
    }
}