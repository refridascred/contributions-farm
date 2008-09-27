using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool CheckAccountToolsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6614;
        public const double IdleTimeout = 24.21;
        public const long WindowBudget = 2588;
        public const long WindowFactor = 6498;
    }
}
