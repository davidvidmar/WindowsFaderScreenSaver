namespace DavidVidmar.WindowsFader
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.fadeOutGroupBox = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorlabel = new System.Windows.Forms.Label();
            this.endOpacityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endOpacityPercentLabel = new System.Windows.Forms.Label();
            this.endOpacityLabel = new System.Windows.Forms.Label();
            this.completeInSecondsLabel = new System.Windows.Forms.Label();
            this.completeInLabel = new System.Windows.Forms.Label();
            this.completeInTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fadeOutGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endOpacityTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(239, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.ButtonCancelClicked);
            // 
            // fadeOutGroupBox
            // 
            this.fadeOutGroupBox.Controls.Add(this.linkLabel1);
            this.fadeOutGroupBox.Controls.Add(this.colorPanel);
            this.fadeOutGroupBox.Controls.Add(this.colorlabel);
            this.fadeOutGroupBox.Controls.Add(this.endOpacityTextBox);
            this.fadeOutGroupBox.Controls.Add(this.endOpacityPercentLabel);
            this.fadeOutGroupBox.Controls.Add(this.endOpacityLabel);
            this.fadeOutGroupBox.Controls.Add(this.completeInSecondsLabel);
            this.fadeOutGroupBox.Controls.Add(this.completeInLabel);
            this.fadeOutGroupBox.Controls.Add(this.completeInTextBox);
            this.fadeOutGroupBox.Controls.Add(this.endOpacityTrackBar);
            this.fadeOutGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fadeOutGroupBox.Location = new System.Drawing.Point(3, 3);
            this.fadeOutGroupBox.Name = "fadeOutGroupBox";
            this.fadeOutGroupBox.Size = new System.Drawing.Size(318, 119);
            this.fadeOutGroupBox.TabIndex = 0;
            this.fadeOutGroupBox.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(156, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "default";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DefaultColorLinkClicked);
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPanel.Location = new System.Drawing.Point(111, 47);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(38, 22);
            this.colorPanel.TabIndex = 2;
            this.colorPanel.TabStop = true;
            this.colorPanel.Click += new System.EventHandler(this.ColorPanelClicked);
            // 
            // colorlabel
            // 
            this.colorlabel.AutoSize = true;
            this.colorlabel.Location = new System.Drawing.Point(7, 52);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(78, 13);
            this.colorlabel.TabIndex = 7;
            this.colorlabel.Text = "Fade to color:";
            // 
            // endOpacityTextBox
            // 
            this.endOpacityTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.endOpacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endOpacityTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endOpacityTextBox.Location = new System.Drawing.Point(111, 83);
            this.endOpacityTextBox.Name = "endOpacityTextBox";
            this.endOpacityTextBox.ReadOnly = true;
            this.endOpacityTextBox.Size = new System.Drawing.Size(25, 15);
            this.endOpacityTextBox.TabIndex = 4;
            this.endOpacityTextBox.TabStop = false;
            this.endOpacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // endOpacityPercentLabel
            // 
            this.endOpacityPercentLabel.AutoSize = true;
            this.endOpacityPercentLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endOpacityPercentLabel.Location = new System.Drawing.Point(134, 83);
            this.endOpacityPercentLabel.Name = "endOpacityPercentLabel";
            this.endOpacityPercentLabel.Size = new System.Drawing.Size(17, 13);
            this.endOpacityPercentLabel.TabIndex = 5;
            this.endOpacityPercentLabel.Text = "%";
            // 
            // endOpacityLabel
            // 
            this.endOpacityLabel.AutoSize = true;
            this.endOpacityLabel.Location = new System.Drawing.Point(7, 83);
            this.endOpacityLabel.Name = "endOpacityLabel";
            this.endOpacityLabel.Size = new System.Drawing.Size(70, 13);
            this.endOpacityLabel.TabIndex = 3;
            this.endOpacityLabel.Text = "End opacity:";
            // 
            // completeInSecondsLabel
            // 
            this.completeInSecondsLabel.AutoSize = true;
            this.completeInSecondsLabel.Location = new System.Drawing.Point(156, 22);
            this.completeInSecondsLabel.Name = "completeInSecondsLabel";
            this.completeInSecondsLabel.Size = new System.Drawing.Size(49, 13);
            this.completeInSecondsLabel.TabIndex = 1;
            this.completeInSecondsLabel.Text = "seconds";
            // 
            // completeInLabel
            // 
            this.completeInLabel.AutoSize = true;
            this.completeInLabel.Location = new System.Drawing.Point(7, 22);
            this.completeInLabel.Name = "completeInLabel";
            this.completeInLabel.Size = new System.Drawing.Size(98, 13);
            this.completeInLabel.TabIndex = 0;
            this.completeInLabel.Text = "Complete fade in:";
            // 
            // completeInTextBox
            // 
            this.completeInTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.completeInTextBox.Location = new System.Drawing.Point(111, 19);
            this.completeInTextBox.Name = "completeInTextBox";
            this.completeInTextBox.Size = new System.Drawing.Size(38, 22);
            this.completeInTextBox.SkipLiterals = false;
            this.completeInTextBox.TabIndex = 0;
            this.completeInTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.completeInTextBox.UseSystemPasswordChar = true;
            // 
            // endOpacityTrackBar
            // 
            this.endOpacityTrackBar.LargeChange = 10;
            this.endOpacityTrackBar.Location = new System.Drawing.Point(153, 70);
            this.endOpacityTrackBar.Maximum = 100;
            this.endOpacityTrackBar.Name = "endOpacityTrackBar";
            this.endOpacityTrackBar.Size = new System.Drawing.Size(159, 45);
            this.endOpacityTrackBar.TabIndex = 6;
            this.endOpacityTrackBar.TickFrequency = 10;
            this.endOpacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.endOpacityTrackBar.Value = 100;
            this.endOpacityTrackBar.Scroll += new System.EventHandler(this.EndOpacityTrackBarScroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.fadeOutGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 160);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 128);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(159, 3);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.ButtonOkClicked);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(342, 178);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Windows Fader Screensaver Settings";
            this.fadeOutGroupBox.ResumeLayout(false);
            this.fadeOutGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endOpacityTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox fadeOutGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar endOpacityTrackBar;
        private System.Windows.Forms.Label endOpacityPercentLabel;
        private System.Windows.Forms.Label endOpacityLabel;
        private System.Windows.Forms.Label completeInSecondsLabel;
        private System.Windows.Forms.Label completeInLabel;
        private System.Windows.Forms.MaskedTextBox completeInTextBox;
        private System.Windows.Forms.MaskedTextBox endOpacityTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label colorlabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}