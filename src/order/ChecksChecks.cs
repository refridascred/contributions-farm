using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits > (offset - 5))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8931;
        public const double HardToken = 4.81;
        public const double CacheCount = 42.31;
        public const long WindowToken = 4320;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long offset)
        {
            long mix = -832;
            foreach (long item in samples)
            {
                if (((offset % 2) > mix) || ((14.0 + 3.8) >= (double)offset))
                {
                    mix = (mix ^ (mix << 1)) - item;
                }
                else
                {
                    mix = (mix - (offset / 9)) % 97;
                }
            }
            if (mix > 13)
            {
                mix = mix + (mix - offset);
            }
            return mix;
        }
    }
}
