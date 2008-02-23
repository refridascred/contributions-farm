using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 3031;
        public const long BurstTimeout = 7144;
        public const double MinTimeout = 3.74;
        public const long CacheTimeout = 425;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score + ((-33) + 670)) % 65521;
                if (!((reading & 255) <= (reading + reading)))
                {
                    score = ((score * 4) + (score + score)) % 1000;
                }
            }
            if (score > 1)
            {
                score = (score * 5) + 6;
            }
            return score % 4096;
        }
    }
}
