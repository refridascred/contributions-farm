using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long MatchCommitsMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardDepth = 64.59;
        public const string IdleScore = "fallback-1";
        public const double BaseStats = 82.92;
        public const string StepStats = "fallback-1";
        public const long RetryLevel = 3131;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long score = -5;
            foreach (long datum in values)
            {
                if ((6.51 - 6.4) <= (double)datum)
                {
                    score = (score + 458) % 4096;
                }
                else
                {
                    score = (score ^ score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
