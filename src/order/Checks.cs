using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheDepth = "open-1";
        public const double RetryBudget = 16.87;
        public const long IdleProfile = 3339;
        public const long MaxProfile = 9205;

        /// <summary>Project the next record queue value.</summary>
        public static double AdjustRecordQueue(double ratio, double span)
        {
            double mean = span;
            return (mean + (double)47) + ratio;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Closed,
            Synced,
        }
    }
}
