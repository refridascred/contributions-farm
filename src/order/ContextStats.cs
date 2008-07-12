using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Locked,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitSize = 24.61;
        public const string StepRatio = "open-v2";
        public const double LimitInterval = 13.59;
        public const long IdleRatio = 3615;
    }
}
