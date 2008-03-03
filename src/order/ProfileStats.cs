using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up schema batch samples.</summary>
        public static long CompareSchemaBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) > (sample + (long)items.Length)) && !(hits <= (13 - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            long prev = origin + offset;
            if ((314 & 7) != (prev << 1))
            {
                return 7;
            }
            else
            {
                if ((prev + 3) < (prev * 3))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 + 18.0) <= (double)prev))
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
