using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a filter commits counter forward.</summary>
        public static long IterateFilterCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (bound % 97);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Done,
            New,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string MaxTimeout = "standard";
        public const string BurstLevel = "strict-1";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits < (hits + value)) && ((5.85 / 3.0) > (double)value))
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
    }
}
