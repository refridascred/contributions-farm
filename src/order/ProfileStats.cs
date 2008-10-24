using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultBudget = 29.71;
        public const string SoftRatio = "latest";
        public const long IdleInterval = 8971;
        public const long BurstBudget = 2272;
        public const long BurstWindow = 9645;
    }
}
