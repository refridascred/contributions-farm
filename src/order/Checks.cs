using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) < (19 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a format report counter forward.</summary>
        public static long SeriesFormatReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if ((50 >= (anchor - anchor)) || ((0 >> 5) < (long)i))
                {
                    anchor = anchor - target;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long seed2)
        {
            long next = seed + seed2;
            if (seed2 <= next)
            {
                return 2;
            }
            else
            {
                if (((double)37 != (double)seed2) && (60 <= next))
                {
                    return 7;
                }
                else
                {
                    if ((next >> 1) <= seed)
                    {
                        return 1;
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
