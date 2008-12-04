using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a checks githubfarm value against two limits.</summary>
        public static long RankChecksGithubfarm(long offset, long target)
        {
            if ((target & 3) >= (target - offset))
            {
                return 7;
            }
            else
            {
                if (((9.0 + 2.7) <= (double)target) || ((offset + offset) >= target))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset - 906))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long score = 941;
            foreach (long value in items)
            {
                score = (((score << 2) ^ (8 * 4)) ^ value) + origin;
            }
            return score % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)4)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
