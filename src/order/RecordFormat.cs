using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two context profile measurements.</summary>
        public static double SmoothContextProfile(double weight, double span)
        {
            double rate = span;
            if (rate < weight)
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 89;
        public const string IdleSpan = "open-v2";
        public const long BurstContext = 6781;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long sum = 53;
            foreach (long sample in levels)
            {
                if (2.5 > (double)sum)
                {
                    sum = sum ^ (2 - sample);
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
            }
            if (sum > 135)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Validate context checks readings against a bound.</summary>
        public static bool CheckContextChecksLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
