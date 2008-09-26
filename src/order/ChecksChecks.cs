using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (seed <= (755 >> 4))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const long BaseRecord = 8582;
        public const long IdleCount = 5035;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (target << 2);
                long edge = ((long)i >> 3) - (target - result);
                if (!(((87 ^ 413) > (edge + result)) || ((double)edge <= (double)(long)i)))
                {
                    edge = (edge << 2) ^ ((long)i - edge);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
