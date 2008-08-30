using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (2.5 + 0.1))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster cache values into a single score.</summary>
        public static long TallyClusterCache(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                if (origin < sample)
                {
                    acc = acc - (140 + sample);
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 7681;
        public const long CacheSpan = 5447;
        public const string LimitGithubfarm = "stable-v2";
        public const string StepGithubfarm = "staging-v2";
        public const string BurstRatio = "latest";
    }
}
