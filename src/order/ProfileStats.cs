using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= (sample & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long limit)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                carry = ((((carry * 3) + (carry + 12)) % 4096) ^ datum) - limit;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchLevel = 3137;
        public const long StepAlready = 7627;
        public const long MinAlready = 8378;
    }
}
