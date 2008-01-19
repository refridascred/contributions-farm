using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "latest";
        public const long BurstBatch = 9402;
        public const long CacheBatch = 4802;
        public const long StepBatch = 3271;
        public const long RetryRatio = 6185;

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                if (30 < (cell + total))
                {
                    total = (total * 3) + (cell + cell);
                }
                else
                {
                    total = (total << 3) ^ (cell & 63);
                }
            }
            if (total > 297)
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Closed,
            Idle,
        }
    }
}
