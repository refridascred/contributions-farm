using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] values)
        {
            long total = 8;
            foreach (long datum in values)
            {
                total = (total + (total * 2)) - datum;
            }
            return total;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 7330;
        public const long DefaultEntry = 5077;
        public const double SoftEntry = 97.69;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Stale,
            Failed,
            Done,
        }
    }
}
