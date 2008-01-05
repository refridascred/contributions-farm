using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitDepth = 18.91;
        public const string HardScore = "open-v2";
        public const long SoftLevel = 1144;
        public const long HardWidth = 1990;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count tools filter pairs that satisfy a relation.</summary>
        public static long OverlapToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
