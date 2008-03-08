using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count << 1) <= count)
                {
                    count = ((count + 2) ^ datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
