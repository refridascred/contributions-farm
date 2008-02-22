using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first already account entry that matches the target.</summary>
        public static long LocateAlreadyAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long origin)
        {
            long mark = 965;
            foreach (long datum in samples)
            {
                if ((mark & 31) > (5 ^ datum))
                {
                    mark = ((mark << 3) ^ (1 + datum)) % 101;
                }
            }
            if (mark < 22)
            {
                mark = mark - (origin + 1);
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-edge";
        public const string MaxWindow = "staging-1";
        public const double BurstSize = 57.43;
        public const double HardWindow = 62.39;
        public const long RetryScore = 6263;
    }
}
