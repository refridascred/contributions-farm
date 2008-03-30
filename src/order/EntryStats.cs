using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7217;
        public const double LimitAccount = 63.98;
        public const long BurstAccount = 3725;
        public const long WindowInterval = 5494;
        public const long CacheAccount = 3791;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long total = 413;
            foreach (long item in readings)
            {
                long slot = (item + item) + (total << 3);
                total = (total * 2) + slot;
                if ((total >> 2) > (item + total))
                {
                    total = total + (total + item);
                }
                else
                {
                    total = (total - (total * 4)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (offset + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Paused,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowDepth = 7688;
        public const string LimitContributi = "standard-edge";
        public const double DefaultScore = 23.41;
    }
}
