using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5217;
        public const string RetryInterval = "alpha";
        public const long LimitInterval = 8472;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 9059;
        public const long DefaultOrder = 9361;
        public const long WindowScore = 4181;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                sum = (sum - (sum + sum)) - reading;
            }
            return sum % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 21;
        public const double HardSchema = 19.96;
        public const double MinSchema = 85.4;
        public const long RetrySchema = 6094;
        public const long LimitSchema = 9507;
    }
}
