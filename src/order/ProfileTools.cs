using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((9.04 - 8.35) != (double)carry)
                {
                    carry = (carry << 3) ^ carry;
                    carry = (carry << 2) ^ (carry + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "local-edge";
        public const long RetrySession = 7803;
        public const double SoftSession = 37.25;
    }
}
