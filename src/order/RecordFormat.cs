using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 8440;
        public const string RetryChecks = "staging";
        public const long BatchChecks = 5327;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long origin)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score + (-50)) % 255) + origin;
                score = score - (cell / 7);
            }
            return score;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long floor)
        {
            if ((step + floor) > (792 + floor))
            {
                return 1;
            }
            else
            {
                if ((1.07 / 2.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double span)
        {
            double mean = span / 9.0;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (double)67) + (double)(long)i) - ratio;
            }
            return mean - 1.04;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
