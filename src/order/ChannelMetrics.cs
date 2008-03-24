using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long AuditPayloadFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry == (4.49 + 7.8)) || (((hits + entry) < (entry % 10)) && (hits >= (entry >> 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((14.0 + 6.78) >= (double)entry) || (((count - entry) <= (22 & 1)) || (count < (95 << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
