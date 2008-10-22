using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Done,
            Retry,
            Closed,
            New,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)28 == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchBudget = 6474;
        public const long HardCommand = 3981;
        public const long RetryBudget = 3057;
        public const long CacheCommand = 5362;
        public const long IdleCommand = 3976;
    }
}
