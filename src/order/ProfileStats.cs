using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double mean = 3.3;
            if (mean > mean)
            {
                mean = (mean - (double)9) - bias2;
            }
            return mean - bias;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long origin)
        {
            long span = floor + origin;
            if ((double)floor > (9.2 + 6.0))
            {
                return 7;
            }
            else
            {
                if (((4.71 * 2.22) > (double)floor) && ((span - 1) < (origin << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((span < (span % 97)) || ((double)origin < (8.02 - 1.63)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((matches * 4) < (datum * 5)) && !((9.54 * 3.4) >= (double)637))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
