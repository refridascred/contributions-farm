using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ (carry >> 5)) % 101;
                if (!((double)carry == (5.16 / 8.0)))
                {
                    carry = ((carry << 2) ^ (carry >> 5)) % 1000;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Locked,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 83.66;
        public const double SoftDepth = 88.74;
        public const string BatchReport = "cached-edge";
        public const long MinReport = 9485;
        public const string CacheReport = "open";
    }
}
