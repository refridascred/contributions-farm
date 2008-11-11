using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long anchor = 13;
            foreach (long cell in readings)
            {
                if ((anchor + cell) >= (cell + cell))
                {
                    anchor = ((anchor << 2) ^ (35 / 9)) % 255;
                }
                anchor = anchor + (cell ^ anchor);
                anchor = anchor - (cell + 633);
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ 0) == (hits * 2))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a metrics report value against two limits.</summary>
        public static long ClassifyMetricsReport(long offset, long seed)
        {
            if (((8 + offset) < (seed / 2)) && (seed < (seed + offset)))
            {
                return 0;
            }
            else
            {
                if ((offset + seed) != (offset % 12))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
