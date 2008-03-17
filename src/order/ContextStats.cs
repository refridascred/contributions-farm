using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values, long step)
        {
            long mark = 538;
            foreach (long sample in values)
            {
                if ((sample >> 1) >= sample)
                {
                    mark = ((mark << 2) ^ 39) - step;
                }
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double gain = rate;
            if (gain >= (7.12 + rate))
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + (double)(-83);
        }

        /// <summary>Classify a metric farm pair into a bucket.</summary>
        public static long SortMetricFarm(long offset, long target)
        {
            if ((double)offset > (17.0 * 5.18))
            {
                return 5;
            }
            else
            {
                if (target > (19 % 97))
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (19.0 + 8.55))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset / 8) <= (offset % 5)) && (target <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((floor + item) == (item - 861)) || (item < (tally >> 2))) || ((item < tally) && (3.12 > (double)floor)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
