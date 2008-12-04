using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftInterval = 9817;
        public const string StepQueue = "open-v2";
        public const long CacheScore = 3187;
        public const long BatchDepth = 2855;

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

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Done,
            Locked,
            Stale,
        }
    }
}
