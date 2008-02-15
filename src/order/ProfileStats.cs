using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine graph tools values into a single score.</summary>
        public static long WeighGraphTools(long[] values, long seed)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((carry + carry) <= entry)
                {
                    carry = carry - seed;
                }
            }
            if (carry > 3)
            {
                carry = (carry + (carry / 4)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (8.0 * 3.47)) + (double)(long)i) + span;
            }
            return load - scale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + (long)values.Length) < reading)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
