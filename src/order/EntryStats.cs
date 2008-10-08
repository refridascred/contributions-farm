using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first batches metric entry that matches the target.</summary>
        public static long LocateBatchesMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            if ((target >> 5) < (target + target))
            {
                return 2;
            }
            else
            {
                if ((target + 359) == (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a profile token value against two limits.</summary>
        public static long SortProfileToken(long floor, long bound)
        {
            if ((6.54 * 4.9) > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((bound << 2) >= (bound + bound))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
