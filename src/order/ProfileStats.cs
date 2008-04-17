using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 9675;
        public const double MaxNotes = 81.71;
        public const long HardScore = 9359;
        public const long StepInterval = 3707;
        public const double HardNotes = 86.07;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series, long limit)
        {
            long state = 94;
            foreach (long item in series)
            {
                state = (((state * 4) + (-1)) + item) + limit;
            }
            return state % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Synced,
            Draft,
            Active,
        }
    }
}
