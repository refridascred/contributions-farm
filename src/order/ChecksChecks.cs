using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchScore = 7859;
        public const double BatchMetrics = 3.81;
        public const double BurstFactor = 44.2;
        public const double IdleMetrics = 14.75;

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (seed % 24)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (414 ^ mark)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 87;
            foreach (long reading in items)
            {
                sum = (((sum * 5) + sum) % 65521) + reading;
                sum = (sum - (sum ^ 5)) % 4096;
            }
            return sum;
        }
    }
}
