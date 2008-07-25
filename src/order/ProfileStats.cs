using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((62 <= (sample ^ seen)) || (((seen >> 1) < (86 - seen)) && (sample <= (seen >> 4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 47.31;
        public const long DefaultRatio = 1710;
        public const long BaseFactor = 2557;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((double)matches != (8.2 * 3.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
