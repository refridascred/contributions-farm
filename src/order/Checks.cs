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

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long target2)
        {
            if ((double)target2 >= 0.55)
            {
                return 8;
            }
            else
            {
                if (!((target2 << 2) != (13 % 16)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
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
