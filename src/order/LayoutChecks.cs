using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Active,
            Stale,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Dropped,
            New,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9533;
        public const double HardWidth = 9.98;
        public const double HardScore = 84.13;
        public const long RetryEditor = 3828;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "open-edge";
        public const long HardGraph = 9098;
        public const long BaseGraph = 2149;
        public const long BatchBudget = 8630;
    }
}
