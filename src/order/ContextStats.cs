using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count report cache pairs that satisfy a relation.</summary>
        public static long CompareReportCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long limit)
        {
            long bound = seed - limit;
            if (((limit + bound) < limit) && (62 <= (bound + (-565))))
            {
                return 8;
            }
            else
            {
                if ((double)seed >= (9.5 * 8.41))
                {
                    return 4;
                }
                else
                {
                    if (((-2) + seed) < (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.4 + 1.0) >= (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long step)
        {
            long score = 414;
            foreach (long cell in items)
            {
                if ((score <= (cell * 5)) && (score > (step - 528)))
                {
                    score = score - (score & 255);
                }
                else
                {
                    score = (score ^ (score >> 4)) % 101;
                }
            }
            return score;
        }
    }
}
