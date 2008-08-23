using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long MeasureFormatBatchHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-405) <= (matches - 9)) || (((offset - 81) > matches) && ((item % 10) > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools cache entries.</summary>
        public static long TotalToolsCache(long[] data, long limit)
        {
            long mark = 71;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length >= (7.2 + 2.4))
                {
                    mark = ((mark + (19 - cell)) % 65521) - limit;
                }
            }
            if (mark < 482)
            {
                mark = (mark - ((long)data.Length / 5)) % 255;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardCount = 8.22;
        public const long BurstBatch = 2338;
        public const long RetrySize = 8430;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
