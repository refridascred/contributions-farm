using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 1) == (limit >> 2))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum + matches) > 505))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (!((offset + offset) > offset))
            {
                return 7;
            }
            else
            {
                if ((8.93 - 8.69) < (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if (!(offset > offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset2 != (double)offset) && ((double)offset != (double)39))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already account value from a seed.</summary>
        public static long RollAlreadyAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (sum > (long)i)
                {
                    sum = (sum * 2) + 8;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 243;
            foreach (long item in items)
            {
                if ((item % 5) != (item * 3))
                {
                    sum = ((sum * 5) + 46) % 255;
                }
            }
            return sum;
        }
    }
}
