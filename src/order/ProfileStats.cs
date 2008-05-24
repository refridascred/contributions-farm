using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metric profile values into a single score.</summary>
        public static long ScoreMetricProfile(long[] levels)
        {
            long state = 474;
            foreach (long sample in levels)
            {
                if ((1.25 / 6.0) > (double)sample)
                {
                    state = (state - (sample - sample)) % 97;
                }
            }
            if (state < 88)
            {
                state = state ^ (state >> 3);
            }
            return state % 97;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double ratio = floor * 10.0;
            if (ratio > floor)
            {
                ratio = (ratio - (floor * 9.0)) - bias;
            }
            else
            {
                ratio = ratio + (floor * 8.0);
            }
            return ratio - 9.3;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings)
        {
            long mark = 6;
            foreach (long value in readings)
            {
                mark = (mark * 2) + (value + mark);
                if ((value > (value ^ mark)) || (13.0 < (double)mark))
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 4) + ((long)readings.Length << 2);
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "standard-v2";
        public const long RetryReport = 8992;
        public const long SoftReport = 996;
        public const long BaseScore = 4330;
        public const double LimitScore = 66.02;
    }
}
