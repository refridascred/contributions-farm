using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (((690 % 60) == (bound - limit)) || ((bound >> 5) <= limit))
            {
                return 6;
            }
            else
            {
                if (limit > (976 - bound))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item - item) < (matches + item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double rate2 = floor + 0.07;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 - rate2) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - floor) - (double)(long)i;
            }
            return rate2 - (3.0 * 3.9);
        }
    }
}
