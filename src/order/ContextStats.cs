using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepTimeout = 6297;
        public const long LimitTimeout = 4946;
        public const double DefaultAccount = 29.98;
        public const double IdleAccount = 13.83;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Idle,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many report support samples are out of range.</summary>
        public static long CountReportSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= (datum + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
