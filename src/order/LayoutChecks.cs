using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a filter contributi reading by value.</summary>
        public static long LookupFilterContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Failed,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 270;
        public const long BurstRatio = 9745;
        public const long BaseBudget = 5673;
        public const double IdleStream = 4.42;
        public const long LimitStream = 3193;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 1715;
        public const long BurstSpan = 7075;
        public const long WindowRatio = 1532;
        public const string StepCount = "staging";
        public const long DefaultOrder = 5837;
    }
}
