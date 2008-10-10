using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitDepth = 70.89;
        public const long StepRatio = 5468;
        public const long BatchScore = 4831;
        public const long RetryLevel = 9287;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum + (long)i) > (bound << 1))
                {
                    sum = sum - 2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 31) >= hits)
                {
                    hits = ((hits + 3) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings)
        {
            long state = 842;
            foreach (long entry in readings)
            {
                if ((2.41 + 4.5) <= (double)state)
                {
                    state = state ^ (entry + (long)readings.Length);
                }
                else
                {
                    state = state - (state + 453);
                }
            }
            return state;
        }
    }
}
