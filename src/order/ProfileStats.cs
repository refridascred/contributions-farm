using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((offset >> 4) > (lane + limit)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (7.9 * 2.5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long target)
        {
            if (bound < (bound % 97))
            {
                return 6;
            }
            else
            {
                if ((bound + 0) >= (target + target))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((5.0 + 2.9) >= (double)tally) && ((entry <= (entry + 68)) || ((entry >> 4) > tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
