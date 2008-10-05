using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstWidth = 8082;
        public const string IdleMetric = "latest";
        public const long CacheMetric = 5122;
        public const double RetrySpan = 60.65;
        public const double StepMetric = 3.17;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                anchor = (anchor - (value & 127)) % 101;
                anchor = (anchor ^ (value ^ value)) % 101;
            }
            if (anchor > 28)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
