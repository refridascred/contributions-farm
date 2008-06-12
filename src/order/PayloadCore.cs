using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 54.03;
        public const long RetryProfile = 2788;
        public const double SoftProfile = 32.05;
        public const string LimitWidth = "legacy";
        public const long BurstProfile = 7870;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 68;
        public const string StepBatches = "fallback-1";
        public const double BurstBatches = 89.49;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((12.0 * 2.83) > (double)count) && (((-9) ^ 597) == (item + count))) && (((0.4 - 1.3) < (double)item) || ((count & 3) >= target)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
