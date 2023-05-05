using System.Globalization;

namespace BPMTap
{
    public partial class Form1 : Form
    {
        private const string DEFAULT_LABEL = "---.-";

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private decimal? Bpm;
        private BPMCalculator BPMCalculator;
        private System.Windows.Forms.Timer timeOutTimer;

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                ((Screen.PrimaryScreen.Bounds.Size.Width - this.Width) / 2),
                5
            );
            this.InitBPMTap();

            RegisterHotKey(this.Handle, 0, (int)KeyModifier.Shift | (int)KeyModifier.Control, Keys.Space.GetHashCode());

            System.Windows.Forms.Timer timeOutTimer = new();
            timeOutTimer.Interval = Properties.Settings.Default.TimeoutSeconds * 1000;
            timeOutTimer.Tick += new EventHandler(OnTimeoutTimer);
            this.timeOutTimer = timeOutTimer;
            this.HideAfterTimeout();

            this.notifyIcon.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.HideAfterTimeout();
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Hide();
                    break;
                case Keys.Space:
                    this.Bpm = this.BPMCalculator.addTapGetBpm();
                    this.updateBpmDisplay();
                    break;
            }
        }

        private void updateBpmDisplay()
        {
            this.label1.Text = (this.Bpm == null)
              ? DEFAULT_LABEL
              : String.Format(new CultureInfo("en_US"), "{0:000.0}", this.Bpm);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                this.Show();
                this.HideAfterTimeout();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }

        private void InitBPMTap()
        {
            this.BPMCalculator = new BPMCalculator();
        }

        private void HideAfterTimeout()
        {
            this.timeOutTimer.Stop();
            this.timeOutTimer.Interval = Properties.Settings.Default.TimeoutSeconds * 1000;
            this.timeOutTimer.Start();
        }

        private void OnTimeoutTimer(object? sender, EventArgs e)
        {
            this.HideAndResetForm();
        }

        private void HideAndResetForm()
        {
            this.Hide();
            this.timeOutTimer.Stop();
            this.InitBPMTap();
            this.Bpm = null;
            this.updateBpmDisplay();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new SettingsForm();

            settingsForm.ShowDialog();
        }
    }
}