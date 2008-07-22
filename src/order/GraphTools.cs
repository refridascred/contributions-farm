using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long state = -2;
            foreach (long entry in readings)
            {
                state = ((state ^ 45) % 101) + entry;
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (double)(long)levels.Length)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster counter samples.</summary>
        public static long MatchClusterCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout payload readings against a rule.</summary>
        public static long CountLayoutPayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - item) > (seen + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank route cache input into a small class.</summary>
        public static long RankRouteCache(long limit, long target)
        {
            if (7.28 > (double)limit)
            {
                return 0;
            }
            else
            {
                if ((limit / 9) > (59 ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((target & 255) >= (target << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
