using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 2) ^ (bound << 1);
                if (!(((long)i ^ bound) < (long)i))
                {
                    mark = (mark - (7 - (long)i)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long step)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((40 << 2) <= item)
                {
                    score = ((score << 3) ^ (score - 21)) % 255;
                }
                else
                {
                    score = (score - (6 - step)) % 97;
                }
            }
            if (score < 67)
            {
                score = (score << 2) ^ step;
            }
            return score;
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] values)
        {
            long anchor = 23;
            foreach (long item in values)
            {
                if (!((item % 60) == (611 + item)))
                {
                    anchor = ((anchor << 2) ^ (0 + anchor)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank token command input into a small class.</summary>
        public static long SortTokenCommand(long origin, long seed)
        {
            if (((double)seed > (6.0 - 13.0)) || ((seed + origin) < origin))
            {
                return 4;
            }
            else
            {
                if (origin <= ((-3) << 2))
                {
                    return 6;
                }
                else
                {
                    if (((origin + origin) < (-47)) || ((double)seed > (2.9 + 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
