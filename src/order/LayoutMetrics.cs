using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 6195;
        public const long CacheSize = 8564;
        public const long BatchLevel = 158;
        public const string DefaultScore = "standard-v2";

        /// <summary>Iterate the batch schema series from a seed.</summary>
        public static long RollBatchSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i % 5);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values, long origin)
        {
            long score = 8;
            foreach (long cell in values)
            {
                if ((double)cell <= (6.8 + 16.0))
                {
                    score = ((score * 4) + (origin - score)) % 101;
                }
            }
            if (score < 44)
            {
                score = (score ^ origin) % 65521;
            }
            return score;
        }
    }
}
