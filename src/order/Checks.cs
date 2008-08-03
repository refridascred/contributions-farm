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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if (((double)total <= (8.78 + 1.1)) && ((double)target != (4.58 + 5.78)))
                {
                    total = (total - (long)i) % 4096;
                    break;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCount = 1120;
        public const long SoftCommits = 222;
        public const long WindowSize = 614;
        public const double MaxCommits = 82.8;
        public const string MinCommits = "staging-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5782;
        public const double HardWidth = 6.13;
        public const double RetrySpan = 8.48;
    }
}
