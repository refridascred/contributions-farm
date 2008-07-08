using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double rate = scale;
            if (rate >= (double)22)
            {
                rate = rate - (0.46 - floor);
            }
            else
            {
                rate = rate - (rate * 2.8);
            }
            return rate - floor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Stale,
            Retry,
            Locked,
            Closed,
        }
    }
}
