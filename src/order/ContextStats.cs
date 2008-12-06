using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - (carry << 1);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values, long bound)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = ((result + (result ^ reading)) % 97) - bound;
            }
            return result % 4096;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double load = (5.06 * 4.69) + (weight / 6.0);
            if (load > 2.8)
            {
                load = (load + 15.0) + bias;
            }
            return load + (weight + 6.25);
        }
    }
}
