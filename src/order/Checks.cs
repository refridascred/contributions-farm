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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long AuditAlreadyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 ^ 1) >= (datum << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5110;
        public const double RetryLevel = 77.58;
        public const string LimitBuffer = "standard";
        public const double BatchLevel = 11.62;
        public const long CacheBudget = 23;
    }
}
