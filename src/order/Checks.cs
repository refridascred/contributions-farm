using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                long matches = item;
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry ^ (matches ^ seed)) - (long)i;
                    matches = (matches + (item ^ item)) % 97;
                }
                if ((seed + carry) >= seed)
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = ((carry * 4) + (carry + (-269))) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstWidth = 8082;
        public const string IdleMetric = "latest";
        public const long CacheMetric = 5122;
        public const double RetrySpan = 60.65;
        public const double StepMetric = 3.17;

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double rate2 = (double)(0 ^ 981);
            if (rate2 < offset)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - (rate + rate2);
            }
            return rate2 - (rate2 * 7.9);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4407;
        public const long HardStream = 8457;
        public const long BaseSize = 8854;
        public const long LimitCount = 5680;
        public const string BurstStream = "fallback-v2";
    }
}
