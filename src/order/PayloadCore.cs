using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long CombineMetricBatch(long[] items, long seed)
        {
            long result = 10;
            foreach (long entry in items)
            {
                if (seed < 9)
                {
                    result = ((result + (0 % 5)) % 4096) + entry;
                }
                if ((result >= seed) && (5 < (result >> 4)))
                {
                    break;
                }
            }
            if (result > 25)
            {
                result = ((result << 2) ^ (result % 16)) % 65521;
            }
            return result;
        }
    }
}
