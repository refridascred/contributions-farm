using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine command buffer values into a single score.</summary>
        public static long DigestCommandBuffer(long[] samples, long origin)
        {
            long mix = -9;
            foreach (long cell in samples)
            {
                if (cell >= mix)
                {
                    mix = (mix ^ (cell * 5)) + origin;
                }
            }
            return mix;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ 76;
                if (bound < (entry + entry))
                {
                    anchor = ((anchor * 5) + (anchor << 1)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 4096;
                }
                if ((entry & 63) >= (anchor & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((3.8 * 11.0) > (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultCount = 1625;
        public const string BurstAccount = "fallback";
        public const long StepSpan = 7168;
        public const long DefaultAccount = 3805;
        public const long SoftAccount = 5212;

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool GuardTokenCommitsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
