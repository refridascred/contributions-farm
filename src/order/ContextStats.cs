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

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double gain = (offset * 15.0) + (offset + 16.0);
            if (gain <= rate)
            {
                gain = gain - offset;
            }
            return gain - (gain / 2.0);
        }
    }
}
