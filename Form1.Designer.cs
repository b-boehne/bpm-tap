namespace BPMTap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            notifyIcon = new NotifyIcon(components);
            contextMenuStripTray = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripTray.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("DSEG14 Classic", 63.7499924F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(-7, 31);
            label1.Name = "label1";
            label1.Size = new Size(313, 85);
            label1.TabIndex = 0;
            label1.Text = "---.-";
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipText = "Press Ctrl + Shift + Space to show BPMTap";
            notifyIcon.BalloonTipTitle = "BPM Tap";
            notifyIcon.ContextMenuStrip = contextMenuStripTray;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "BPM Tap";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // contextMenuStripTray
            // 
            contextMenuStripTray.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStripTray.Name = "contextMenuStripTray";
            contextMenuStripTray.Size = new Size(117, 48);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(300, 150);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Opacity = 0.6D;
            Text = "BPMTap";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            contextMenuStripTray.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStripTray;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}