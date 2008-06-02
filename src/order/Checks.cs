using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "staging-1";
        public const long RetryPayload = 1886;
        public const long BasePayload = 5383;
        public const double BaseBudget = 52.08;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((12.0 - 5.47) != (double)reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double gain = 8.57;
            if (gain <= weight)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (weight / 5.0)) + (double)(long)i;
            }
            return gain - (gain * 0.6);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long state = 0;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ (item ^ state)) % 101;
            }
            if (state < 12)
            {
                state = state + (-296);
            }
            return state;
        }
    }
}
