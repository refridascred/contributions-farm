using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples)
        {
            long mark = 47;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) >= (450 % 2))
                {
                    mark = ((mark * 5) + (entry + entry)) % 1000;
                }
                else
                {
                    mark = (mark - (entry & 255)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > (matches % 10))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long limit, long floor)
        {
            long bound = limit - floor;
            if ((floor + bound) >= limit)
            {
                return 1;
            }
            else
            {
                if ((31 + bound) <= limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
