using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double rate = (scale + span) * 5.0;
            if (rate >= (6.1 * 7.02))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (double)9;
            }
            return rate + (double)663;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
