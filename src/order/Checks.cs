using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-v2";
        public const long HardInterval = 9008;
        public const string DefaultTools = "open-edge";
        public const string HardTools = "strict";
        public const string CacheTools = "strict-1";

        /// <summary>Match up support layout samples.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryTimeout = 9831;
        public const double StepQueue = 33.48;
        public const long MaxQueue = 5234;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
