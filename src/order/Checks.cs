using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long step)
        {
            long mark = 470;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ step) ^ datum;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Dropped,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Find the first counter format entry that matches the target.</summary>
        public static long FindCounterFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 6952;
        public const long CacheWidth = 2019;
        public const long CacheEditor = 3741;
    }
}
