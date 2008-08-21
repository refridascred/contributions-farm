using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "cached";
        public const long WindowCount = 1336;
        public const string CacheGithubfarm = "fallback-edge";
        public const long RetryTimeout = 9525;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long anchor = 42;
            foreach (long datum in samples)
            {
                if ((1.0 / 7.0) != (double)(long)samples.Length)
                {
                    anchor = ((anchor + (anchor % 24)) % 97) + datum;
                }
                else
                {
                    anchor = ((anchor * 5) + (689 << 3)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 4) < (matches - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
