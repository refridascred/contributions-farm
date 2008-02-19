using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metrics order samples.</summary>
        public static long MatchMetricsOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long limit, long target)
        {
            if (((double)target == (17.0 + 16.0)) && ((limit * 2) < 781))
            {
                return 4;
            }
            else
            {
                if (limit > (limit + target))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long bound)
        {
            long prev = limit + bound;
            if (((double)prev >= (0.93 / 5.0)) || ((bound + prev) <= limit))
            {
                return 0;
            }
            else
            {
                if (prev <= (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound > (1.09 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Synced,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
