using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Draft,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((7.34 * 19.0) <= (double)(long)i)
                {
                    score = (score - step) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
