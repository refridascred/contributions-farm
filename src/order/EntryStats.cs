using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Dropped,
            Stale,
        }

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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinScore = 5361;
        public const long IdleChannel = 8191;
        public const long LimitChannel = 2989;
    }
}
