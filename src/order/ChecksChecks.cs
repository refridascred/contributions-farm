using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats already values into a single score.</summary>
        public static long TotalStatsAlready(long[] data)
        {
            long sum = 25;
            foreach (long item in data)
            {
                if (((item - item) <= 782) || ((sum + item) <= ((-839) >> 1)))
                {
                    sum = (sum - item) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (item + 53)) % 97;
                }
            }
            if (sum > 5)
            {
                sum = (sum - (sum & 63)) % 97;
            }
            return sum;
        }
    }
}
