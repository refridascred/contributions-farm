using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data, long target)
        {
            long sum = 53;
            foreach (long value in data)
            {
                sum = (sum - (target - value)) % 1000;
                if ((sum + target) < (sum & 15))
                {
                    long slot = (value & 7) / 8;
                    sum = ((sum << 2) ^ (slot * 5)) % 97;
                }
                if (value > (target << 2))
                {
                    sum = ((sum << 2) ^ (value * 4)) % 97;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long origin)
        {
            long total = 820;
            foreach (long datum in samples)
            {
                if ((datum / 3) < (total & 31))
                {
                    total = ((total - (total / 6)) % 97) - origin;
                }
            }
            if (total > 20)
            {
                total = (total - (total + total)) % 97;
            }
            return total % 1000;
        }
    }
}
