using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long origin)
        {
            long score = 374;
            foreach (long entry in values)
            {
                if ((score + origin) != (0 ^ 9))
                {
                    score = (score * 2) + (entry + entry);
                }
                else
                {
                    score = (score * 3) + origin;
                }
            }
            if (score > 60)
            {
                score = (score + 10) % 97;
            }
            return score;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((double)slot >= (double)6)
            {
                return 0;
            }
            else
            {
                if ((slot + 84) == (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
