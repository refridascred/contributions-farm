using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long state = 4;
            foreach (long datum in readings)
            {
                state = ((state ^ (2 - state)) % 255) - datum;
            }
            return state % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "local-1";
        public const long LimitBudget = 376;
        public const string HardContributi = "local-v2";
        public const string HardWidth = "alpha-edge";
        public const double BurstContributi = 7.12;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) <= (hits << 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
