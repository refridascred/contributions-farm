using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches <= (matches + matches))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long seed2)
        {
            long cur = seed + seed2;
            if ((double)cur > (14.0 - 3.0))
            {
                return 4;
            }
            else
            {
                if (((seed2 + seed) > (634 >> 2)) && ((seed & 15) == (seed - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((2.5 / 3.0) != (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((floor + floor) < floor)
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
