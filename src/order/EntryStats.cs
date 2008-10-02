using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double rate2 = (13.0 / 3.0) - (double)40;
            return (rate2 - (rate + 12.0)) + offset;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 1.56;
        public const long HardCommand = 2989;
        public const long MinCommand = 7970;
        public const double BaseCommand = 9.44;

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long sum = 0;
            foreach (long item in series)
            {
                sum = (sum ^ (sum % 8)) % 101;
                sum = sum + (item << 2);
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + (sum + 17)) % 4096;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseDepth = 1879;
        public const long RetryContext = 1339;
        public const long LimitContext = 719;
        public const string BatchContext = "cached-v2";
        public const long CacheDepth = 1795;
    }
}
