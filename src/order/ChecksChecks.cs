using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((((long)i ^ sum) != ((long)i % 5)) && ((sum + sum) > (target & 63))))
                {
                    sum = (sum - target) % 4096;
                }
                if ((target - sum) <= (long)i)
                {
                    sum = sum - (target << 1);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
