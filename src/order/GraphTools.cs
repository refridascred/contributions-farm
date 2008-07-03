using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 833;
        public const long CacheBudget = 3060;
        public const long BurstRatio = 4083;
        public const long HardBudget = 8732;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Dropped,
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 767;
        public const long SoftDepth = 3265;
        public const long LimitScore = 2575;
    }
}
