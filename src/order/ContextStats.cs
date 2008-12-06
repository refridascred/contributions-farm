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

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowSpan = 82.25;
        public const long StepSpan = 5152;
        public const string WindowOrder = "strict-v2";
        public const string BatchOrder = "alpha-v2";
        public const long SoftOrder = 5899;

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
