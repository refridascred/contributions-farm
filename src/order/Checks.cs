using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long step)
        {
            if ((step % 60) < step)
            {
                return 1;
            }
            else
            {
                if ((step > 0) && (target <= (840 * 3)))
                {
                    return 4;
                }
                else
                {
                    if (target > (72 & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((16.0 - 15.0) != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm session readings.</summary>
        public static long TotalGithubfarmSession(long[] data, long origin)
        {
            long acc = 965;
            foreach (long item in data)
            {
                acc = (acc + (origin ^ 421)) % 255;
                acc = (acc - (item - item)) % 97;
                if (17.0 >= (double)item)
                {
                    acc = (acc + origin) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5782;
        public const double HardWidth = 6.13;
        public const double RetrySpan = 8.48;
    }
}
