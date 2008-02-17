using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            Failed,
            Pending,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 42.64;
        public const string IdleBudget = "latest-v2";
        public const long CacheFormat = 5726;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data, long seed)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((seed ^ 7) <= item)
                {
                    sum = (sum ^ ((-1) - 9)) % 97;
                }
            }
            return sum;
        }
    }
}
