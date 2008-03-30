using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((target <= (item / 6)) || ((949 - item) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9414;
        public const long MinRatio = 8465;
        public const double CacheBudget = 64.6;
        public const long BaseTimeout = 8655;
        public const long CacheLevel = 8497;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepFactor = 9164;
        public const long MaxRecord = 5745;
        public const long SoftRecord = 4511;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if (!((-7) < (value + (-648))))
                {
                    score = (score * 5) + (score + 4);
                }
            }
            return score % 1000;
        }
    }
}
