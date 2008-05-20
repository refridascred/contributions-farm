using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout context entries.</summary>
        public static long WeighLayoutContext(long[] data, long seed)
        {
            long mark = 478;
            foreach (long entry in data)
            {
                mark = ((mark + (seed + mark)) % 65521) + entry;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 8803;
        public const long BaseRatio = 761;
        public const long BurstCount = 502;
        public const long MaxAccount = 3122;
        public const string BaseAccount = "standard-edge";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value / 3) <= (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (limit << 3)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the cache session series from a seed.</summary>
        public static long StepCacheSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result << 3) ^ origin) % 1000) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
