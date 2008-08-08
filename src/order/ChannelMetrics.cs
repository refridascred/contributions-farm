using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardBudget = 942;
        public const string MinProfile = "staging-edge";
        public const double RetryProfile = 35.15;
        public const long StepBudget = 7053;
    }
}
