using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long target)
        {
            long cur = limit - target;
            if (!((7.7 - 1.67) <= (double)cur))
            {
                return 7;
            }
            else
            {
                if (((cur + target) != (cur + cur)) && (13.0 <= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 * 7.8) <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count counter metrics pairs that satisfy a relation.</summary>
        public static long MatchCounterMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate profile session readings against a bound.</summary>
        public static bool CheckProfileSessionRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
