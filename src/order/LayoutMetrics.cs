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

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if ((anchor % 100) >= anchor)
                {
                    anchor = ((anchor ^ (anchor % 16)) % 4096) ^ datum;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }
    }
}
