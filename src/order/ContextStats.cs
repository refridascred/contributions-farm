using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6509;
        public const double BatchContext = 75.38;
        public const string BatchBudget = "staging-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data)
        {
            long carry = 31;
            foreach (long entry in data)
            {
                carry = (carry ^ (carry - carry)) % 4096;
                if (((90 >> 2) < (43 + entry)) || ((17.0 + 4.0) >= (double)entry))
                {
                    carry = carry + (6 % 10);
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 101;
                }
            }
            if (carry > 6)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardTimeout = "strict-edge";
        public const string LimitChecks = "standard";
        public const double WindowSize = 51.48;
        public const long MaxFactor = 828;
        public const long DefaultInterval = 4307;
    }
}
