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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= (11 + 60))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
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
