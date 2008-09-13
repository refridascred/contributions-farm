using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSpan = "primary";
        public const string HardTimeout = "local-v2";
        public const long HardFactor = 4010;
        public const double MinFilter = 9.76;
        public const long StepFilter = 9399;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - ((long)i * 2);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long floor)
        {
            if (offset >= (6 + offset))
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (7.0 * 6.1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
