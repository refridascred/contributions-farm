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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (carry - (long)i)) % 97) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    carry = ((carry + (carry + carry)) % 1000) - (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

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
