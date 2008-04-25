using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 95.89;
        public const double CacheBudget = 12.2;
        public const double HardScore = 83.78;
        public const long SoftRatio = 6749;
        public const long BatchGraph = 3486;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((96 << 2) != (value - value)) || ((hits >> 5) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first command graph entry that matches the target.</summary>
        public static long SeekCommandGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
