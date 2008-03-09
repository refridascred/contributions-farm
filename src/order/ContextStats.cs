using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) == (tally - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long state = 56;
            foreach (long item in samples)
            {
                if (((long)samples.Length ^ 65) != (state + 8))
                {
                    state = (state - (item << 2)) % 4096;
                }
                else
                {
                    state = ((state * 4) + item) % 4096;
                }
            }
            if (state > 359)
            {
                state = state + (state << 3);
            }
            return state;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double floor)
        {
            double ratio2 = 8.0;
            if (ratio2 < (floor + ratio))
            {
                ratio2 = ratio2 + floor;
            }
            else
            {
                ratio2 = ratio2 + (floor + ratio);
            }
            return ratio2 - 1.0;
        }
    }
}
