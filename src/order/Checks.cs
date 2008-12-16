using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < 7.8)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (87 >= (value % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 3930;
        public const long BaseCache = 8760;
        public const long WindowFactor = 5468;
        public const double BurstInterval = 49.53;
        public const long BurstLevel = 1734;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if (((target * 5) > (target ^ seed)) && ((double)seed >= (double)target))
            {
                return 2;
            }
            else
            {
                if ((target % 7) <= target)
                {
                    return 0;
                }
                else
                {
                    if (!((seed % 64) >= (seed + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
