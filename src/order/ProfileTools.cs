using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 57;
            foreach (long reading in data)
            {
                mark = mark + (mark >> 4);
                mark = (mark ^ (mark - 0)) % 97;
                if ((reading / 8) != (mark % 24))
                {
                    mark = mark + (915 % 100);
                }
                if ((double)mark != (0.08 + 2.02))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark + (64 + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
