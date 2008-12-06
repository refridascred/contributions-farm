using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((double)601 <= (double)matches) && !(item <= (seed ^ seed)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)limit >= 14.0) || ((floor + delta) >= limit))
            {
                return 3;
            }
            else
            {
                if ((limit + delta) > (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Ready,
            Failed,
            Synced,
            Queued,
        }
    }
}
