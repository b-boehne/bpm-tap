using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMTap
{

    internal class BPMCalculator
    {
        private int CountTapRetention;
        private decimal? currentBpm;
        private List<DateTime> Taps;

        public BPMCalculator()
        {
            this.Taps = new List<DateTime>();
            this.CountTapRetention = Properties.Settings.Default.TapsToCalc;
        }

        public decimal? addTapGetBpm()
        {
            this.addNewTapRespectRetention();
            if (!isBpmCalculable()) return null;
            this.calculateBpmSetCurrentBpm();

            return this.currentBpm;
        }

        private bool isBpmCalculable()
        {
            return this.Taps.Count >= 2;
        }

        private bool areTapsOverRetention()
        {
            return this.Taps.Count > this.CountTapRetention;
        }

        private void addNewTapRespectRetention()
        {
            this.addNewTap();

            while (areTapsOverRetention()) this.Taps.RemoveAt(0);
        }

        private void addNewTap()
        {
            DateTime tap = DateTime.Now;
            this.Taps.Add(tap);
        }

        private void calculateBpmSetCurrentBpm()
        {
            this.currentBpm = this.calculateBpm();
        }

        private decimal calculateBpm()
        {
            TimeSpan betweenAllTaps = this.Taps.Last() - this.Taps.First();
            int msBetween = (int) betweenAllTaps.TotalMilliseconds;

            return (decimal) (this.Taps.Count - 1) * (60 * 1000) / (decimal) msBetween;
        }
    }
}
