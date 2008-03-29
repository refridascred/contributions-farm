using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long sum = 777;
            foreach (long sample in items)
            {
                if (!((sum + sum) >= (target - sample)))
                {
                    sum = ((sum * 2) + (sample - sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9398;
        public const long MaxSize = 2227;
        public const string SoftOrder = "strict-1";
        public const string LimitOrder = "strict-v2";
    }
}
