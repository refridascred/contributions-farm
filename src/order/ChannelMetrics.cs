using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "alpha";
        public const long StepWidth = 1500;
        public const long SoftRatio = 8487;
        public const string BatchRatio = "strict-edge";
        public const double BatchNotes = 36.42;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits >= ((-4) + cell))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
