using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepRatio = 7650;
        public const double BurstDepth = 45.16;
        public const long MinWindow = 8721;
        public const long SoftFactor = 2873;
        public const double RetryScore = 14.31;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long score = 438;
            foreach (long sample in series)
            {
                score = ((score * 4) + (0 - sample)) % 65521;
            }
            if (score < 767)
            {
                score = (score + (score & 31)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
