using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 3004;
        public const long StepReport = 8634;
        public const long MaxReport = 3315;
        public const string WindowFactor = "fallback-edge";

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
