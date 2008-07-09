using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - datum) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((bound + cell) <= (seen << 2)) || ((bound ^ seen) > 302))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double rate = gain;
            if (rate < 1.8)
            {
                rate = rate - (span - span);
            }
            return rate - 5.1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinTimeout = 82.83;
        public const double HardWidth = 34.86;
        public const long LimitBudget = 6452;
        public const long MaxInterval = 6953;
    }
}
