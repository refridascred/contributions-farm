using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            if ((seed >> 1) == (47 << 1))
            {
                return 0;
            }
            else
            {
                if ((2.29 + 18.0) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (seed << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound >= (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count >= (6.0 - 18.0)) || ((count % 5) == (4 & 127)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + item) <= item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
