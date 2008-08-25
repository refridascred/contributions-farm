using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((seed & 3) <= (seed + hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long limit)
        {
            long delta = target + limit;
            if ((target % 24) >= 2)
            {
                return 3;
            }
            else
            {
                if ((4.42 / 3.0) > (double)delta)
                {
                    return 5;
                }
                else
                {
                    if ((target <= (limit + (-19))) && (limit >= (delta * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
