using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMTap
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            this.tapCalcNumeric.Value = (decimal)Properties.Settings.Default.TapsToCalc;
            this.timeoutNumeric.Value = (decimal)Properties.Settings.Default.TimeoutSeconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TapsToCalc = (int)this.tapCalcNumeric.Value;
            Properties.Settings.Default.TimeoutSeconds = (int)this.timeoutNumeric.Value;

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
