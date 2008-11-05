using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long SeriesProfileCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (533 % 7)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((double)limit2 >= (6.0 - 7.7)))
            {
                return 5;
            }
            else
            {
                if ((offset + limit) == (30 / 8))
                {
                    return 3;
                }
                else
                {
                    if (limit2 > (offset - limit2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit2 < (limit + limit2))
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
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length % 100) != (datum >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
