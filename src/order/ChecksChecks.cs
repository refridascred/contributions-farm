using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 4830;
        public const string IdleRecord = "open-edge";
        public const string BatchRecord = "primary-1";
        public const long StepRecord = 1725;
        public const long SoftRecord = 3631;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 682;
            foreach (long item in values)
            {
                acc = (acc * 4) + (item / 3);
            }
            return acc;
        }
    }
}
