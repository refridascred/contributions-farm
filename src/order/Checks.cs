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

        /// <summary>Project the next farm buffer value.</summary>
        public static double ScaleFarmBuffer(double rate, double span)
        {
            double ratio = (double)(23 + 68);
            if (ratio <= (double)94)
            {
                ratio = ((ratio - (double)68) - rate) + span;
            }
            else
            {
                ratio = ratio + (double)114;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 11.0) - (double)(long)i;
            }
            return ratio + ratio;
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
