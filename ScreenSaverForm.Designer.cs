namespace DavidVidmar.WindowsFader {
  partial class ScreenSaverForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();        
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.components = new System.ComponentModel.Container();
        this.timer = new System.Windows.Forms.Timer(this.components);
        this.panel1 = new System.Windows.Forms.Panel();
        this.currentUserLabel = new System.Windows.Forms.Label();
        this.fadeToLabel = new System.Windows.Forms.Label();
        this.currentTimeLabel = new System.Windows.Forms.Label();
        this.fadeTimeLabel = new System.Windows.Forms.Label();
        this.currentTransparencyLabel = new System.Windows.Forms.Label();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // timer
        // 
        this.timer.Enabled = true;
        this.timer.Interval = 1000;
        this.timer.Tick += new System.EventHandler(this.timer_Tick);
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.currentUserLabel);
        this.panel1.Controls.Add(this.fadeToLabel);
        this.panel1.Controls.Add(this.currentTimeLabel);
        this.panel1.Controls.Add(this.fadeTimeLabel);
        this.panel1.Controls.Add(this.currentTransparencyLabel);
        this.panel1.Location = new System.Drawing.Point(12, 12);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(182, 130);
        this.panel1.TabIndex = 4;
        // 
        // currentUserLabel
        // 
        this.currentUserLabel.AutoSize = true;
        this.currentUserLabel.ForeColor = System.Drawing.Color.White;
        this.currentUserLabel.Location = new System.Drawing.Point(16, 93);
        this.currentUserLabel.Name = "currentUserLabel";
        this.currentUserLabel.Size = new System.Drawing.Size(91, 13);
        this.currentUserLabel.TabIndex = 8;
        this.currentUserLabel.Text = "Current user: {0}";
        this.currentUserLabel.Visible = false;
        // 
        // fadeToLabel
        // 
        this.fadeToLabel.AutoSize = true;
        this.fadeToLabel.ForeColor = System.Drawing.Color.White;
        this.fadeToLabel.Location = new System.Drawing.Point(16, 16);
        this.fadeToLabel.Name = "fadeToLabel";
        this.fadeToLabel.Size = new System.Drawing.Size(79, 13);
        this.fadeToLabel.TabIndex = 4;
        this.fadeToLabel.Text = "Fade to %: {0}";
        this.fadeToLabel.Visible = false;
        // 
        // currentTimeLabel
        // 
        this.currentTimeLabel.AutoSize = true;
        this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
        this.currentTimeLabel.Location = new System.Drawing.Point(16, 67);
        this.currentTimeLabel.Name = "currentTimeLabel";
        this.currentTimeLabel.Size = new System.Drawing.Size(88, 13);
        this.currentTimeLabel.TabIndex = 7;
        this.currentTimeLabel.Text = "Curent time: {0}";
        this.currentTimeLabel.Visible = false;
        // 
        // fadeTimeLabel
        // 
        this.fadeTimeLabel.AutoSize = true;
        this.fadeTimeLabel.ForeColor = System.Drawing.Color.White;
        this.fadeTimeLabel.Location = new System.Drawing.Point(16, 29);
        this.fadeTimeLabel.Name = "fadeTimeLabel";
        this.fadeTimeLabel.Size = new System.Drawing.Size(78, 13);
        this.fadeTimeLabel.TabIndex = 5;
        this.fadeTimeLabel.Text = "Fade time: {0}";
        this.fadeTimeLabel.Visible = false;
        // 
        // currentTransparencyLabel
        // 
        this.currentTransparencyLabel.AutoSize = true;
        this.currentTransparencyLabel.ForeColor = System.Drawing.Color.White;
        this.currentTransparencyLabel.Location = new System.Drawing.Point(16, 54);
        this.currentTransparencyLabel.Name = "currentTransparencyLabel";
        this.currentTransparencyLabel.Size = new System.Drawing.Size(136, 13);
        this.currentTransparencyLabel.TabIndex = 6;
        this.currentTransparencyLabel.Text = "Current transparency: {0}";
        this.currentTransparencyLabel.Visible = false;
        // 
        // ScreenSaverForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Black;
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.ClientSize = new System.Drawing.Size(490, 312);
        this.Controls.Add(this.panel1);
        this.Cursor = System.Windows.Forms.Cursors.No;
        this.DoubleBuffered = true;
        this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "ScreenSaverForm";
        this.ShowInTaskbar = false;
        this.TopMost = true;
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseDown);
        this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label fadeToLabel;
    private System.Windows.Forms.Label currentTimeLabel;
    private System.Windows.Forms.Label fadeTimeLabel;
    private System.Windows.Forms.Label currentTransparencyLabel;
    private System.Windows.Forms.Label currentUserLabel;



  }
}