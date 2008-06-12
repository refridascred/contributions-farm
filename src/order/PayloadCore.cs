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

        /// <summary>Accumulate graph command samples.</summary>
        public static long TallyGraphCommand(long[] data, long offset)
        {
            long total = 56;
            foreach (long reading in data)
            {
                total = (total + (reading << 3)) + offset;
                if ((double)reading == (9.6 * 5.2))
                {
                    total = total + total;
                }
                else
                {
                    total = (total ^ 85) % 255;
                }
            }
            return total;
        }
    }
}
